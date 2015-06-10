Imports System.Net
Imports System.Runtime.InteropServices

Public Class MainForm
#Region "File Icons (DEFUNCT)"
    'Private Structure SHFILEINFO
    '    Public hIcon As IntPtr ' : icon
    '    Public iIcon As Integer ' : icondex
    '    Public dwAttributes As Integer ' : SFGAO_ flags
    '    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=260)> _
    '    Public szDisplayName As String
    '    <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=80)> _
    '    Public szTypeName As String
    'End Structure

    'Private Declare Ansi Function SHGetFileInfo Lib "shell32.dll" (ByVal pszPath As String, _
    'ByVal dwFileAttributes As Integer, ByRef psfi As SHFILEINFO, ByVal cbFileInfo As Integer, _
    'ByVal uFlags As Integer) As IntPtr

    'Private Const SHGFI_ICON = &H100
    'Private Const SHGFI_SMALLICON = &H1
    'Private Const SHGFI_LARGEICON = &H0         ' Large icon
    'Private nIndex = 0

#End Region

    Public Const YT_URL_FORMAT As String = "http://www.youtube.com/watch?v={0}"
    Public Const FORMAT_UNKNOWN As Integer = -1
    Public Const FORMAT_BEST As Integer = -2

    Public Shared ReadOnly LibraryLocation As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DuckDL"
    Public Shared ReadOnly QueueLocation As String = LibraryLocation & "\_q.ddq"
    Public Shared ReadOnly Downloader As String = Application.StartupPath() & "\youtube-dl.exe"
    Dim VideoQueue As New Queue(Of VideoDownload)
    Dim Downloading As Boolean = False
    Dim DLingQueued As Boolean = False

    Class VideoDownload
        Private _url As String
        Public Property Url As String
            Get
                Return _url
            End Get
            Set(value As String)
                _url = value.Replace(";"c, "_"c).Trim
            End Set
        End Property

        Private _name As String
        Public Property Name As String
            Get
                Return _name
            End Get
            Set(value As String)
                _name = value.Replace(";"c, "_"c).Trim
            End Set
        End Property

        Public Format As Integer

        Public Overrides Function ToString() As String
            Return Url & ";" & Name & ";" & CStr(Format)
        End Function

        Public Sub New()
            _url = ""
            _name = ""
            Format = 0
        End Sub

        Public Sub New(ByVal __url As String, ByVal __name As String, ByVal __format As Integer)
            Url = __url
            Name = __name
            Format = __format
        End Sub

        Public Sub New(ByVal fName As String)
            Dim fPieces() As String = fName.Split("."c)
            If fPieces.Count < 4 Then
                Throw New ArgumentOutOfRangeException("fName.split('.').count", fPieces.Count, "Not a redownloadable filename (not enough pieces).")
            End If
            Url = String.Format(YT_URL_FORMAT, fPieces(fPieces.Count - 2))
            Dim _format As String = fPieces(fPieces.Count - 3)
            If Not IsNumeric(_format) Then
                Throw New ArgumentOutOfRangeException("fName.split('.')[count-3]", _format, "Filename format piece is invalid (not a number).")
            End If
            Format = CInt(_format)
            Name = ""
            For i As Integer = 0 To fPieces.Count - 4
                Name &= fPieces(i) & "."
            Next
            If Name.Length > 1 Then Name = Name.Remove(Name.Length - 1)
        End Sub

        Public Shared Function FromString(ByVal s As String) As VideoDownload
            Dim sPcs() As String = s.Split(";"c)
            Dim vd As New VideoDownload
            If sPcs.Count <> 3 Then
                Throw New ArgumentException("Input string is not a download entry (semicolon ct. =/= 2).", s)
            End If
            If Not IsNumeric(sPcs(2)) Then
                Throw New ArgumentOutOfRangeException("s.split(';')[2]", sPcs(2), "Format part of download entry is not a number.")
            End If
            vd.Url = sPcs(0)
            vd.Name = sPcs(1)
            vd.Format = CInt(sPcs(2))
            Return vd
        End Function
    End Class

    Private Icn_Download As Bitmap = My.Resources.icn_arrow_down
    Private Icn_Delete As Bitmap = My.Resources.icn_x
    Private Icn_Film As Bitmap = My.Resources.icn_film
    Private Icn_Sound As Bitmap = My.Resources.icn_sound

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ' If there is a FILE (not a dir) which occupies the library location, delete it
        If System.IO.File.Exists(LibraryLocation) Then System.IO.File.Delete(LibraryLocation)
        ' Create library dir
        If Not System.IO.Directory.Exists(LibraryLocation) Then System.IO.Directory.CreateDirectory(LibraryLocation)
        Me.Text = My.Application.Info.ProductName
        QueueBox.Items.Clear()
        ' Load queue from last session
        If IO.File.Exists(QueueLocation) Then
            LoadQueue(QueueLocation)
        End If
        'CurDLProgress.Value = 0
        'CurDLProgress.Enabled = False
        CurDLNameLabel.Text = "No video downloading"
        'CurDLInfoLabel.Text = ""
        CurDLCancel.Enabled = False
        UpdateDLButton()
        GetDownloadedVideos()
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        SaveQueue(QueueLocation)
    End Sub

    Function GetVideoName(url As String) As String
        Return GetVideoInfo("--get-title", url, "Getting name of " & url.Split("=").Last)
    End Function

    Function GetVideoThumbnail(url As String) As Bitmap
        Dim p As New Process
        p.StartInfo.FileName = Application.StartupPath() & "\youtube-dl.exe"
        p.StartInfo.Arguments = " --get-title " & url
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.Start()
        Dim imgUrl As String
        Using oStreamReader As System.IO.StreamReader = p.StandardOutput
            imgUrl = oStreamReader.ReadToEnd()
        End Using
        Dim tmp As String = My.Computer.FileSystem.GetTempFileName
        My.Computer.Network.DownloadFile(imgUrl, tmp)
        Return New Bitmap(tmp)
    End Function

    Sub AddVideoToQueue(v2d As VideoDownload)
        VideoQueue.Enqueue(v2d)
        QueueBox.Items.Add(v2d.Name)
        QueueBox.Update()
        UpdateDLButton()
    End Sub

    Sub DownloadNext()
        If (Not Downloading) And (VideoQueue.Count > 0) And DLingQueued Then
            DownloadVideo(VideoQueue.Dequeue())
            QueueBox.Items.RemoveAt(0)
            QueueBox.Update()
            UpdateDLButton()
        End If
    End Sub

    Sub RemoveVideoFromQueue(id As Integer)
        If QueueBox.SelectedItems.Count > 0 Then
            Dim tmp As List(Of VideoDownload) = VideoQueue.ToList
            tmp.RemoveAt(id)
            VideoQueue.Clear()
            For Each st As VideoDownload In tmp
                VideoQueue.Enqueue(st)
            Next
            QueueBox.Items.RemoveAt(id)
            QueueBox.Update()
        Else
            RemoveSelectedToolStripMenuItem.Enabled = False
            ClearAllToolStripMenuItem.Enabled = False
        End If
    End Sub

    Sub UpdateDLButton()
        If VideoQueue.Count = 0 Then
            DLingQueued = False
            RemoveSelectedToolStripMenuItem.Enabled = False
            ClearAllToolStripMenuItem.Enabled = False
            SaveQueueToolStripMenuItem.Enabled = False
        Else
            RemoveSelectedToolStripMenuItem.Enabled = True
            ClearAllToolStripMenuItem.Enabled = True
            SaveQueueToolStripMenuItem.Enabled = True
        End If
        If DLingQueued Then
            DLQueuedVidsBtn.Enabled = True
            DLQueuedVidsBtn.Image = Icn_Delete
            DLQueuedVidsBtn.Text = "Stop downloading from Queue"
        Else
            If VideoQueue.Count > 0 Then
                DLQueuedVidsBtn.Enabled = True
                DLQueuedVidsBtn.Image = Icn_Download
                DLQueuedVidsBtn.Text = "Start downloading Queue"
            Else
                DLQueuedVidsBtn.Enabled = False
                DLQueuedVidsBtn.Image = Nothing
                DLQueuedVidsBtn.Text = "Add some videos to your Queue!"
            End If
        End If
    End Sub

    Private Sub DownloadVideoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DownloadVideoToolStripMenuItem.Click
        Dim url As String = InputBox("Enter the URL of the video you want to download:", "Download Video")
        If url <> "" Then
            If UrlIsValid(url) And url.Contains("?v=") Then
                url = url.Split("&")(0) ' Prevents downloading of entire playlist when video is in a playlist
                Dim fmt As Integer = PromptForFormat(url)
                If fmt <> FORMAT_UNKNOWN Then AddVideoToQueue(New VideoDownload(url, GetVideoName(url), fmt))
            Else
                MsgBox("Invalid video URL:" & vbNewLine & url, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Dim dldr As Process
    Dim curDL As VideoDownload
    Sub DownloadVideo(v2d As VideoDownload)
        curDL = v2d
        Dim formatString As String = "DEADBEEF"
        If curDL.Format = FORMAT_UNKNOWN Then
            If MsgBox("No format was specified for this video: " & vbNewLine & curDL.Name & "Download anyway?", _
                   MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Warning!") = MsgBoxResult.Yes Then
                formatString = ""
            Else
                Return
            End If
        End If
        If curDL.Format = FORMAT_BEST Then
            formatString = " -f best "
        End If
        If formatString = "DEADBEEF" Then
            formatString = " -f " & CStr(curDL.Format) & " "
        End If
        Downloading = True
        CurDLCancel.Enabled = True
        CurDLNameLabel.Text = "Downloading " & curDL.Name
        dldr = New Process
        dldr.StartInfo.FileName = Downloader
        dldr.StartInfo.Arguments = formatString & "-c """ & curDL.Url & """ -o ""%(title)s.%(format_id)s.%(id)s.%(ext)s"""
        dldr.StartInfo.UseShellExecute = False
        dldr.StartInfo.RedirectStandardOutput = True
        dldr.StartInfo.WorkingDirectory = LibraryLocation
        dldr.StartInfo.CreateNoWindow = True
        AddHandler dldr.OutputDataReceived, AddressOf DLProgressUpdate
        'AddHandler dldr.Exited, AddressOf DownloadDone         DOESN'T WORK no fking idea
        dldr.Start()
        dldr.BeginOutputReadLine()
        LifeCheck.Enabled = True
    End Sub

    Dim DownloadLog As String = ""
    Private Sub DLProgressUpdate(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        _DLProgressUpdate(e.Data)
    End Sub
    Private Delegate Sub __DLProgressUpdate(ByVal text As String)
    Private Sub _DLProgressUpdate(ByVal txt As String)
        If Me.InvokeRequired Then
            Dim del As New __DLProgressUpdate(AddressOf _DLProgressUpdate)
            Dim args As Object() = {txt}
            Me.Invoke(del, args)
        Else
            DownloadLog &= txt & vbNewLine
            If txt <> "" Then CurDLProgress.Text = txt
            If txt IsNot Nothing Then
                If txt.Contains("100%") Then
                    DownloadDone()
                End If
            End If
        End If
    End Sub

    Private Function UrlIsValid(ByVal url As String) As Boolean
        Dim is_valid As Boolean = False
        If url.ToLower().StartsWith("www.") Then url = "http://" & url

        Dim web_response As HttpWebResponse = Nothing
        Try
            Dim web_request As HttpWebRequest = HttpWebRequest.Create(url)
            web_response = DirectCast(web_request.GetResponse(), HttpWebResponse)
            Return True
        Catch ex As Exception
            Return False
        Finally
            If Not (web_response Is Nothing) Then web_response.Close()
        End Try
    End Function

    Private Sub RemoveSelectedToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RemoveSelectedToolStripMenuItem.Click
        RemoveVideoFromQueue(QueueBox.SelectedIndex)
    End Sub

    Private Sub DownloadDone(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing)
        '    _DownloadDone()
        'End Sub
        'Private Delegate Sub __DownloadDone()
        'Private Sub _DownloadDone()
        '    If Me.InvokeRequired Then
        '        Dim done As New __DownloadDone(AddressOf _DownloadDone)
        '        Dim args As Object() = {}
        '        Me.Invoke(done, args)
        '    Else
        Downloading = False
        LifeCheck.Enabled = False
        CurDLNameLabel.Text = "No video downloading"
        CurDLCancel.Enabled = False
        CurDLProgress.Text = "####"
        GetDownloadedVideos()
        DownloadNext()
        'End If
    End Sub

    Private Sub CurDLCancel_Click(sender As System.Object, e As System.EventArgs) Handles CurDLCancel.Click
        dldr.Kill()
        CleanPartFiles()
        DownloadDone()
    End Sub

    Private Sub DLQueuedVidsBtn_Click(sender As System.Object, e As System.EventArgs) Handles DLQueuedVidsBtn.Click
        If VideoQueue.Count > 0 Then
            If DLingQueued Then
                DLingQueued = False
            Else
                DLingQueued = True
                DownloadNext()
            End If
            UpdateDLButton()
        End If
    End Sub

    Sub GetDownloadedVideos()
        'Dim shinfo As SHFILEINFO
        'shinfo = New SHFILEINFO()
        'shinfo.szDisplayName = New String(Chr(0), 260)
        'shinfo.szTypeName = New String(Chr(0), 80)
        'Dim hImgLarge As IntPtr
        Dim vids As IEnumerable(Of String) = IO.Directory.EnumerateFiles(LibraryLocation)
        Dim idx As Integer = 0
        Dim url As String
        VideoList.Clear()
        VideoIconList.Images.Clear()
        For Each vid As String In vids
            If vid.ToUpper.EndsWith("MP4") Or vid.ToUpper.EndsWith("FLV") Or vid.ToUpper.EndsWith("WEBM") _
                Or vid.ToUpper.EndsWith("3GP") Or vid.ToUpper.EndsWith("AVI") Then
                VideoList.Items.Add(FileNameFromPath(vid), idx)
                VideoIconList.Images.Add(Icn_Film)
                url = String.Format(YT_URL_FORMAT, vid.Split("-").Last.Split(".")(0))
                idx += 1
            ElseIf vid.ToUpper.EndsWith("M4A") Then
                VideoList.Items.Add(FileNameFromPath(vid), idx)
                VideoIconList.Images.Add(Icn_Sound)
                idx += 1
            End If
        Next
    End Sub

    Function FileNameFromPath(ByVal path As String) As String
        Return path.Split("\").Last
    End Function

    Function RemoveExtension(ByVal fname As String) As String
        Dim ret As String = ""
        Dim fpieces() As String = fname.Split("."c)
        For Each fpiece As String In fpieces
            ret &= fpiece & "."
        Next
        ret = ret.Remove(ret.Length - 1)
        Return ret
    End Function

    Private Sub PlaySelectedVideos(Optional sender As System.Object = Nothing, Optional e As System.EventArgs = Nothing) Handles VideoList.DoubleClick
        For Each itm As ListViewItem In VideoList.SelectedItems
            PlayVideo(LibraryLocation & "\" & itm.Text)
        Next
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddVideoFromFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddVideoFromFileToolStripMenuItem.Click
        If AddFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            IO.File.Copy(AddFileDialog.FileName, LibraryLocation & "\" & FileNameFromPath(AddFileDialog.FileName))
            GetDownloadedVideos()
        End If
    End Sub

    Private Sub OpenLibraryFolder(Optional sender As System.Object = Nothing, Optional e As System.EventArgs = Nothing) Handles OpenLibraryToolStripMenuItem.Click
        Process.Start(LibraryLocation)
    End Sub

    Private Sub DownloadPlaylistToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DownloadPlaylistToolStripMenuItem.Click
        Dim url As String = InputBox("Enter the URL of the playlist you want to download:", "Download Playlist")
        If url <> "" Then
            If UrlIsValid(url) Then
                Dim vidIDs As String() = GetVideoInfo("--get-id", url, "Enumerating playlist...").Split(vbNewLine)
                Dim u As String = ""
                Dim fmt As Integer = PromptForFormat(String.Format(YT_URL_FORMAT, vidIDs(0).Trim))
                If fmt <> FORMAT_UNKNOWN Then
                    For Each vidID As String In vidIDs
                        vidID = vidID.Trim()
                        If vidID <> "" Then
                            u = String.Format(YT_URL_FORMAT, vidID)
                            AddVideoToQueue(New VideoDownload(u, GetVideoName(u), fmt))
                        End If
                    Next
                End If
            Else
                MsgBox("Invalid playlist URL:" & vbNewLine & url, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Shared InfOut As System.Text.StringBuilder = Nothing
    Public Function GetVideoInfo(ByVal args As String, ByVal url As String, Optional ByVal progressTxt As String = "Downloading information...") As String
        InfOut = New System.Text.StringBuilder()
        Dim NewProcess As New System.Diagnostics.Process()
        Dim WaitDlg As New Electroduck.Controls.WaitDialog(progressTxt, True)
        WaitDlg.Show()
        With NewProcess.StartInfo
            .FileName = Downloader
            .Arguments = args & " """ & url & """"
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .RedirectStandardInput = True
            .UseShellExecute = False
            .WindowStyle = ProcessWindowStyle.Normal
            .CreateNoWindow = True
        End With

        ' Set our event handler to asynchronously read the sort output.
        AddHandler NewProcess.OutputDataReceived, AddressOf GetVideoInfo_OutputHandler
        NewProcess.Start()
        NewProcess.BeginOutputReadLine()
        NewProcess.WaitForExit()
        WaitDlg.Close()
        Return InfOut.ToString
    End Function

    Private Shared Sub GetVideoInfo_OutputHandler(sendingProcess As Object, outLine As DataReceivedEventArgs)
        ' Collect the sort command output.
        If Not String.IsNullOrEmpty(outLine.Data) Then
            ' Add the text to the collected output.
            InfOut.AppendLine(outLine.Data)
        End If
    End Sub

    Sub DeleteSelectedVideos()
        Do Until VideoList.SelectedItems.Count = 0
            IO.File.Delete(LibraryLocation & "\" & VideoList.SelectedItems(0).Text)
            VideoList.SelectedItems(0).Remove()
        Loop
    End Sub

    Sub RedownloadSelectedVideo()
        If VideoList.SelectedItems.Count > 0 Then
            Dim fname As String = VideoList.SelectedItems(0).Text
            Dim fpieces() As String = fname.Split("."c)
            If fpieces.Count > 3 Then
                If IsNumeric(fpieces(fpieces.Count - 3)) Then
                    Try
                        Dim dl As New VideoDownload(VideoList.SelectedItems(0).Text)
                        dl.Format = PromptForFormat(dl.Url)
                        If dl.Format <> FORMAT_UNKNOWN Then AddVideoToQueue(dl)
                    Catch ex As Exception
                        GoTo cannot
                    End Try
                Else
                    GoTo cannot
                End If
            Else
                GoTo cannot
            End If
        End If
        Return
cannot:
        MsgBox("This video cannot be redownloaded.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Sorry")
    End Sub

    Private Sub LibrarySidebar_Click(ItmID As Integer) Handles LibrarySidebar.ItemClicked
        Select Case ItmID
            Case 1
                PlaySelectedVideos()
            Case 2
                DeleteSelectedVideos()
            Case 3
                OpenLibraryFolder()
            Case 4
                RedownloadSelectedVideo()
        End Select
    End Sub

    Private Sub DownloadChannelToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        MsgBox("Sorry, this is no longer supported by YouTube.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
    End Sub

    Enum ContinueOrCancel
        Unknown = 0
        _Continue = 1
        Cancel = 2
    End Enum

    Sub AddMultipleVideos(ByVal lines As String(), ByVal format As Integer)
        For Each line As String In lines
            If UrlIsValid(line) Then
                AddVideoToQueue(New VideoDownload(line, GetVideoName(line), format))
            Else
ShowDlg:
                Dim dlg As New Electroduck.Controls.CustomDialog
                dlg.dialogTitle = "Error"
                dlg.dialogMessage = "This URL is not valid:" & vbNewLine & line
                dlg.buttonEText = "Continue"
                dlg.buttonEResult = ContinueOrCancel._Continue
                dlg.buttonDText = "Cancel"
                dlg.buttonDResult = ContinueOrCancel.Cancel
                dlg.ShowDialog()
                Select Case dlg.choice
                    Case ContinueOrCancel._Continue
                        GoTo NextLine
                    Case ContinueOrCancel.Cancel
                        Return
                    Case ContinueOrCancel.Unknown
                        GoTo ShowDlg
                End Select
            End If
NextLine:
        Next
    End Sub

    Private Sub EnterInMultipleURLsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EnterInMultipleURLsToolStripMenuItem.Click
        Dim tbd As New TextBoxDialog
        tbd.Title = "Download Multiple"
        tbd.Prompt = "Enter multiple video URLs, one per line:"
        If tbd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim fmt As Integer = PromptForFormat(tbd.Lines(0))
            If fmt <> FORMAT_UNKNOWN Then AddMultipleVideos(tbd.Lines, fmt)
        End If
    End Sub

    Private Sub OpenFileOfURLsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenFileOfURLsToolStripMenuItem.Click
        If OpenURLListDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim lines As String() = IO.File.ReadAllLines(OpenURLListDialog.FileName)
            Dim fmt As Integer = PromptForFormat(lines(0))
            If fmt <> FORMAT_UNKNOWN Then AddMultipleVideos(lines, fmt)
        End If
    End Sub

    Sub CleanPartFiles()
        For Each file As String In IO.Directory.EnumerateFiles(LibraryLocation)
            If file.ToUpper.EndsWith("PART") Then
                IO.File.Delete(file)
            End If
        Next
    End Sub


    Public Shared Function PromptForFormat(ByVal url As String) As Integer
        Dim dlg As New FormatDialog(url)
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return dlg.SelectedFormat
        Else
            Return FORMAT_UNKNOWN
        End If
    End Function

    Private Sub LifeCheck_Tick(sender As System.Object, e As System.EventArgs) Handles LifeCheck.Tick
        If dldr.HasExited Then
            LifeCheck.Enabled = False
            MsgBox("Failed to download video: " & vbNewLine & curDL.Name & vbNewLine & curDL.Url & vbNewLine & "In format: " & curDL.Format, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error")
            DownloadDone()
        End If
    End Sub

    Sub PlayVideo(ByVal path As String)
        Dim player As String = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Electroduck\DuckDL", "PLAYER", "")
        If player = "" And IO.File.Exists(player) Then
            Process.Start(path)
        Else
            Process.Start(player, """" & path & """")
        End If
    End Sub

    Private Sub ClearAllToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClearAllToolStripMenuItem.Click
        QueueBox.Items.Clear()
        QueueBox.Update()
    End Sub

    Sub SaveQueue(ByVal savepath As String)
        Dim f As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(savepath, False)
        For Each dl As VideoDownload In VideoQueue
            f.WriteLine(dl.ToString)
        Next
        f.Close()
    End Sub

    Sub LoadQueue(ByVal loadpath As String)
        Dim f As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader(loadpath)
        Dim line As String = f.ReadLine
        While line IsNot Nothing
attempt_line:
            Try
                AddVideoToQueue(VideoDownload.FromString(line))
            Catch ex As Exception
                Dim action As MsgBoxResult = MsgBox("Error reading queue file:" & vbNewLine & ex.ToString, _
                          MsgBoxStyle.Exclamation + MsgBoxStyle.AbortRetryIgnore, "Error reading queue")
                If action = MsgBoxResult.Abort Then
                    Return
                ElseIf action = MsgBoxResult.Retry Then
                    GoTo attempt_line
                Else
                    ' Next line
                End If
            End Try
            line = f.ReadLine
        End While
    End Sub

    Private Sub LoadQueueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LoadQueueToolStripMenuItem.Click
        If OpenQueueDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            LoadQueue(OpenQueueDialog.FileName)
        End If
    End Sub

    Private Sub SaveQueueToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveQueueToolStripMenuItem.Click
        If SaveQueueDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            SaveQueue(SaveQueueDialog.FileName)
        End If
    End Sub
End Class
