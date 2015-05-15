﻿Imports System.Net
Imports System.Runtime.InteropServices

Public Class MainForm
#Region "File Icons"
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

    Const YT_URL_FORMAT As String = "http://www.youtube.com/watch?v={0}"

    Public Shared ReadOnly LibraryLocation As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DuckDL"
    Public Shared ReadOnly Downloader As String = Application.StartupPath() & "\youtube-dl.exe"
    Dim VideoQueue As New Queue(Of VideoDownload)
    Dim Downloading As Boolean = False
    Dim DLingQueued As Boolean = False

    Structure VideoDownload
        Dim Url As String
        Dim Name As String
        Dim Format As Integer
    End Structure

    Private Icn_Download As Bitmap = My.Resources.icn_arrow_down
    Private Icn_Delete As Bitmap = My.Resources.icn_x
    Private Icn_Film As Bitmap = My.Resources.icn_film
    Private Icn_Sound As Bitmap = My.Resources.icn_sound

    Private Sub MainForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(LibraryLocation) Then System.IO.File.Delete(LibraryLocation)
        If Not System.IO.Directory.Exists(LibraryLocation) Then System.IO.Directory.CreateDirectory(LibraryLocation)
        Me.Text = My.Application.Info.ProductName
        QueueBox.Items.Clear()
        'CurDLProgress.Value = 0
        'CurDLProgress.Enabled = False
        CurDLNameLabel.Text = "No video downloading"
        'CurDLInfoLabel.Text = ""
        CurDLCancel.Enabled = False
        UpdateDLButton()
        GetDownloadedVideos()
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
        End If
    End Sub

    Sub UpdateDLButton()
        If VideoQueue.Count = 0 Then
            DLingQueued = False
            RemoveSelectedToolStripMenuItem.Enabled = False
        Else
            RemoveSelectedToolStripMenuItem.Enabled = True
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
                If fmt <> -1 Then AddVideoToQueue(CreateDownloadStruct(url, GetVideoName(url), fmt))
            Else
                MsgBox("Invalid video URL:" & vbNewLine & url, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Dim dldr As Process
    Dim curDL As VideoDownload
    Sub DownloadVideo(v2d As VideoDownload)
        curDL = v2d
        Downloading = True
        CurDLCancel.Enabled = True
        CurDLNameLabel.Text = "Downloading " & curDL.Name
        dldr = New Process
        dldr.StartInfo.FileName = Downloader
        dldr.StartInfo.Arguments = " -f " & curDL.Format & " -c """ & curDL.Url & """"
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
                Or vid.ToUpper.EndsWith("3GP") Then
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

    Private Sub PlaySelectedVideos(Optional sender As System.Object = Nothing, Optional e As System.EventArgs = Nothing) Handles VideoList.DoubleClick
        For Each itm As ListViewItem In VideoList.SelectedItems
            Process.Start(LibraryLocation & "\" & itm.Text)
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
                If fmt <> -1 Then
                    For Each vidID As String In vidIDs
                        vidID = vidID.Trim()
                        If vidID <> "" Then
                            u = String.Format(YT_URL_FORMAT, vidID)
                            AddVideoToQueue(CreateDownloadStruct(u, GetVideoName(u), fmt))
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

    Private Sub LibrarySidebar_Click(ItmID As Integer) Handles LibrarySidebar.ItemClicked
        Select Case ItmID
            Case 1
                PlaySelectedVideos()
            Case 2
                DeleteSelectedVideos()
            Case 3
                OpenLibraryFolder()
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
                AddVideoToQueue(CreateDownloadStruct(line, GetVideoName(line), -1))
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
            If fmt <> -1 Then AddMultipleVideos(tbd.Lines, fmt)
        End If
    End Sub

    Private Sub OpenFileOfURLsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenFileOfURLsToolStripMenuItem.Click
        If OpenURLListDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim lines As String() = IO.File.ReadAllLines(OpenURLListDialog.FileName)
            Dim fmt As Integer = PromptForFormat(lines(0))
            If fmt <> -1 Then AddMultipleVideos(lines, fmt)
        End If
    End Sub

    Sub CleanPartFiles()
        For Each file As String In IO.Directory.EnumerateFiles(LibraryLocation)
            If file.ToUpper.EndsWith("PART") Then
                IO.File.Delete(file)
            End If
        Next
    End Sub

    Public Shared Function CreateDownloadStruct(ByVal url As String, ByVal name As String, ByVal format As Integer) As VideoDownload
        Dim struct As New VideoDownload
        struct.Url = url
        struct.Name = name
        struct.Format = format
        Return struct
    End Function

    Public Shared Function PromptForFormat(ByVal url As String) As Integer
        Dim dlg As New FormatDialog(url)
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Return dlg.SelectedFormat
        Else
            Return -1
        End If
    End Function

    Private Sub LifeCheck_Tick(sender As System.Object, e As System.EventArgs) Handles LifeCheck.Tick
        If dldr.HasExited Then
            LifeCheck.Enabled = False
            MsgBox("Failed to download video: " & vbNewLine & curDL.Name & vbNewLine & curDL.Url & vbNewLine & "In format: " & curDL.Format, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error")
            DownloadDone()
        End If
    End Sub
End Class