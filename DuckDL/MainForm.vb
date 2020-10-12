Imports System.IO
Imports System.Net
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class MainForm
    Public Const YT_URL_FORMAT As String = "http://www.youtube.com/watch?v={0}"
    Public Const Twitter_URL_FORMAT As String = "https://twitter.com/i/status/{0}"
    Public Const Instagram_URL_FORMAT As String = "https://www.instagram.com/p/{0}"
    Public Const Facebook_URL_FORMAT As String = "https://www.facebook.com/watch/?v={0}"
    Public Const Reddit_URL_FORMAT As String = "https://www.reddit.com/comments/{0}"

    Public Const FORMAT_UNKNOWN As String = "FORMAT_UNKNOWN"
    Public Const FORMAT_BEST As String = "FORMAT_BEST"
    Public Const FORMAT_BESTAUDIO As String = "FORMAT_BESTAUDIO"
    Public Const FORMAT_CUSTOM As String = "FORMAT_CUSTOM"

    Public Shared ReadOnly LibraryLocation As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\DuckDL"
    Public Shared ReadOnly QueueLocation As String = LibraryLocation & "\_q.ddq"
    Public Shared ReadOnly Downloader As String = Application.StartupPath() & "\youtube-dl.exe"

    Dim VideoQueue As New Queue(Of VideoDownload)
    Dim Downloading As Boolean = False
    Dim DLingQueued As Boolean = False
    Dim IsProcessRunning As Boolean = False

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

        Public Format As String

        Public Overrides Function ToString() As String
            Return Url & ";" & Name & ";" & Format
        End Function

        Public Sub New()
            _url = ""
            _name = ""
            Format = ""

        End Sub

        Public Sub New(ByVal __url As String, ByVal __name As String, ByVal __format As String)
            Url = __url
            Name = __name
            Format = __format
        End Sub

        'SB-Ansel - takes the pieces and formats them into a workable URL
        Public Sub New(ByVal fName As String)
            Console.WriteLine("Workable URL section activated!!!")
            Dim fPieces() As String = fName.Split("."c)
            Console.WriteLine(String.Join(Environment.NewLine, fPieces))


            'If fPieces.Count < 4 Then
            '    Throw New ArgumentOutOfRangeException("fName.split('.').count", fPieces.Count, "Not a redownloadable filename (not enough pieces).")
            'End If

            For Each pieces As String In fPieces
                Console.WriteLine(pieces)
                If pieces = "youtube" Then
                    Url = String.Format(YT_URL_FORMAT, fPieces(fPieces.Count - 2))
                    Console.WriteLine("Youtube Ping!")
                End If
                If pieces = "twitter" Then
                    Url = String.Format(Twitter_URL_FORMAT, fPieces(fPieces.Count - 2))
                    Console.WriteLine("Twitter Ping!")
                End If
                If pieces = "instagram" Then
                    Url = String.Format(Instagram_URL_FORMAT, fPieces(fPieces.Count - 2))
                    Console.WriteLine("Instagram Ping!")
                End If
                If pieces = "facebook" Then
                    Url = String.Format(Facebook_URL_FORMAT, fPieces(fPieces.Count - 2))
                    Console.WriteLine("Facebook Ping!")
                End If
                If pieces = "reddit" Then
                    Url = String.Format(Reddit_URL_FORMAT, fPieces(fPieces.Count - 2))
                    Console.WriteLine("Reddit Ping!")
                End If
            Next
            'Dim _format As String = fPieces(fPieces.Count - 3)

            'If Not IsNumeric(_format) Then
            '    Throw New ArgumentOutOfRangeException("fName.split('.')[count-3]", _format, "Filename format piece is invalid (not a number).")
            'End If

            'Format = CInt(_format)
            'Name = ""

            'For i As Integer = 0 To fPieces.Count - 4
            '    Name &= fPieces(i) & "."
            'Next
            'If Name.Length > 1 Then Name = Name.Remove(Name.Length - 1)
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

    'SB-Ansel - 'Registry check to see if the users machine has Microsoft Visual C++ 2010 redistributable package (x86)'
    REM look into changing this so duckdl doesn't require admin priv
    Private Sub Microsoft_VC2010_Check() Handles MyBase.Load
        Dim regKey As Object = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\VisualStudio\10.0\VC\VCRedist\x86", "Version", Nothing)
        If regKey Is Nothing Then
            VC2010_MSGBOX()
            Process.Start(Application.StartupPath() & "vcredist_x86.exe")
        Else
            'Continue with application load to main screen etc
            Shell("youtube-dl.exe --update") '-SB-Ansel - This is shit but it's an easy way of automatically updating youtube-dl in the background for now.
        End If
    End Sub
    'SB-Ansel - Popbox to prompt the user to install C++ Redist package.
    Private Sub VC2010_MSGBOX()
        REM TODO: Simplify this statement to be inline with Microsoft_VC2010_Check()
        Dim result = MessageBox.Show("DuckDL requires Microsoft Visual C++ 2010 redistributable package (x86) in order to work properly, by pressing ok DuckDL will close and will automatically install Microsoft Visuall C++ 2010 for you.", "Microsoft Visual C++ 2010 required!", MessageBoxButtons.OK)
        Close()
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' If there is a FILE (not a dir) which occupies the library location, delete it
        If IO.File.Exists(LibraryLocation) Then IO.File.Delete(LibraryLocation)
        ' Create library dir
        If Not IO.Directory.Exists(LibraryLocation) Then IO.Directory.CreateDirectory(LibraryLocation)
        Text = My.Application.Info.ProductName
        QueueBox.Items.Clear()
        ' Load queue from last session
        If IO.File.Exists(QueueLocation) Then
            LoadQueue(QueueLocation)
        End If
        CurDLCancel.Enabled = False
        UpdateDLButton()
        GetDownloadedVideos()
    End Sub
    Private Sub MainForm_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveQueue(QueueLocation)
    End Sub

    Function GetVideoName(url As String) As String
        'Return GetVideoInfo("--get-title", url, "Getting name of " & url.Split("=").Last)
        Return GetVideoInfo("--get-title", url)
    End Function

    Function GetVideoThumbnail(url As String) As Bitmap
        Dim p As New Process
        With p
            .StartInfo.FileName = Application.StartupPath() & "\youtube-dl.exe"
            .StartInfo.Arguments = " --get-title " & url
            .StartInfo.UseShellExecute = False
            .StartInfo.RedirectStandardOutput = True
            .Start()
        End With
        Dim imgUrl As String
        Using oStreamReader As IO.StreamReader = p.StandardOutput
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
                DLQueuedVidsBtn.Text = "Add videos to your Queue!"
            End If
        End If
    End Sub

    Dim dldr As Process
    Dim curDL As VideoDownload
    Sub DownloadVideo(v2d As VideoDownload)
        curDL = v2d
        Dim formatString As String = "DEADBEEF"
        If curDL.Format = FORMAT_UNKNOWN Then
            If MsgBox("No format was specified for this video: " & vbNewLine & curDL.Name & "Download anyway?",
                   MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "Warning!") = MsgBoxResult.Yes Then
                formatString = ""
            Else
                Return
            End If
        End If
        If curDL.Format = FORMAT_BEST Then
            Console.WriteLine("Logging best")
            formatString = " -f best "
        End If
        If curDL.Format = FORMAT_BESTAUDIO Then
            formatString = " -f bestaudio "
        End If
        If curDL.Format = FORMAT_CUSTOM Then
            Console.WriteLine("FORMAT_CUSTOM")
            Console.WriteLine(FormatDialog.Custom_Command)
            formatString = " -f " + FormatDialog.Custom_Command + " "
        End If
        If formatString = "DEADBEEF" Then
            Console.WriteLine("DownloadVideo_DEADBEEF")
            formatString = " -f " & curDL.Format & " "
            Console.WriteLine(formatString)
        End If
        Console.WriteLine("############################")
        Console.WriteLine(curDL.Url)
        If DomainName(curDL.Url) = "reddit" Then
            Downloading = True
            CurDLCancel.Enabled = True
            dldr = New Process
            dldr.StartInfo.FileName = Downloader
            'Debugger.Break()
            dldr.StartInfo.Arguments = $"{formatString}-c {curDL.Url} -o {DomainName(curDL.Url)}.%(title)s.%(format_id)s.{RedditURL(curDL.Url)}.%(ext)s"
            'Console.WriteLine(dldr.StartInfo.Arguments)
            'Debugger.Break()
            dldr.StartInfo.UseShellExecute = False
            dldr.StartInfo.RedirectStandardOutput = True
            dldr.StartInfo.WorkingDirectory = LibraryLocation
            dldr.StartInfo.CreateNoWindow = True
            AddHandler dldr.OutputDataReceived, AddressOf DLProgressUpdate
            'AddHandler dldr.Exited, AddressOf DownloadDone DOESN'T WORK no fucking idea
            dldr.Start()
            dldr.BeginOutputReadLine()
            LifeCheck.Enabled = True
        Else
            Downloading = True
            CurDLCancel.Enabled = True
            dldr = New Process
            dldr.StartInfo.FileName = Downloader
            dldr.StartInfo.Arguments = $"{formatString}-c {curDL.Url} -o {DomainName(curDL.Url)}.%(title)s.%(format_id)s.%(id)s.%(ext)s"
            'Console.WriteLine(dldr.StartInfo.Arguments)
            'Debugger.Break()
            dldr.StartInfo.UseShellExecute = False
            dldr.StartInfo.RedirectStandardOutput = True
            dldr.StartInfo.WorkingDirectory = LibraryLocation
            dldr.StartInfo.CreateNoWindow = True
            AddHandler dldr.OutputDataReceived, AddressOf DLProgressUpdate
            'AddHandler dldr.Exited, AddressOf DownloadDone DOESN'T WORK no fucking idea
            dldr.Start()
            dldr.BeginOutputReadLine()
            LifeCheck.Enabled = True
        End If

    End Sub
    Dim DownloadLog As String = ""
    Private Sub DLProgressUpdate(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        _DLProgressUpdate(e.Data)
    End Sub
    Private Delegate Sub __DLProgressUpdate(ByVal text As String)
    Private Sub _DLProgressUpdate(ByVal txt As String)
        If InvokeRequired Then
            Dim del As New __DLProgressUpdate(AddressOf _DLProgressUpdate)
            Dim args As Object() = {txt}
            Invoke(del, args)
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
    ' SB-Ansel - Check to see if the suppiled URL is a real URL.
    Private Function UrlIsValid(ByVal url As String) As Boolean
        If url.ToLower().StartsWith("www.") Then url = "http://" & url
        Dim web_response As HttpWebResponse = Nothing
        Try
            Dim web_request As HttpWebRequest = WebRequest.Create(url)
            web_response = DirectCast(web_request.GetResponse(), HttpWebResponse)
            Return True
        Catch ex As Exception
            Return False
        Finally
            If Not (web_response Is Nothing) Then web_response.Close()
        End Try
    End Function

    Private Sub RemoveSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedToolStripMenuItem.Click
        RemoveVideoFromQueue(QueueBox.SelectedIndex)
    End Sub

    Private Sub DownloadDone(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing)
        Downloading = False
        LifeCheck.Enabled = False
        CurDLCancel.Enabled = False
        CurDLProgress.Text = "Download complete."
        GetDownloadedVideos()
        DownloadNext()
    End Sub
    'SB-Ansel - Helped me solve the unhandled exception when CurDLCancel is called by the user pressing the cancel button.
    'Dim p() As Process
    'Private Sub CheckForRunningProcess()
    '    p = Process.GetProcessesByName("dldr")
    '    If p.Count > 0 Then
    '        ' Process is running
    '        Console.WriteLine("DlDR still running!")
    '    Else
    '        ' Process is not running
    '        Console.WriteLine("DlDR not running!")
    '    End If
    'End Sub
    Private Sub CurDLCancel_Click(sender As Object, e As EventArgs) Handles CurDLCancel.Click
        dldr.Kill()
        'CheckForRunningProcess()
        'DownloadDone() SB-Ansel - This isn't supposed to be here, this causes an unhandled exception in DuckDL version qc_fix.
        CleanPartFiles()
    End Sub
    Sub CleanPartFiles()
        For Each file As String In IO.Directory.EnumerateFiles(LibraryLocation)
            If file.ToUpper.EndsWith("PART") Then
                IO.File.Delete(file)
            End If
        Next
    End Sub

    Private Sub DLQueuedVidsBtn_Click(sender As Object, e As EventArgs) Handles DLQueuedVidsBtn.Click
        If VideoQueue.Count > 0 Then 'This controls updating the download button if queue entry is availble'
            If DLingQueued Then
                DLingQueued = False
            Else
                DLingQueued = True
                DownloadNext()
            End If
            UpdateDLButton()
        End If
    End Sub
    'SB-Ansel - Populate main window with icons in relation to file type.
    Sub GetDownloadedVideos()
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

    Private Sub PlaySelectedVideos(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing) Handles VideoList.DoubleClick
        For Each itm As ListViewItem In VideoList.SelectedItems
            PlayVideo(LibraryLocation & "\" & itm.Text)
        Next
    End Sub

    'SB-Ansel - Function GetVideoInfo, retrieves video info from youtube-dl to populate the avalable file formats window.
    Private Shared InfOut As Text.StringBuilder = Nothing
    Public Function GetVideoInfo(ByVal args As String, ByVal url As String, Optional ByVal progressTxt As String = "Downloading information...") As String
        InfOut = New Text.StringBuilder()
        Dim NewProcess As New Process()
        'SB-Ansel - Disabled Electroducks control.dll here, in favor of using the cursor to indict progress, looks less clunky.
        'Dim WaitDlg As New Electroduck.Controls.WaitDialog(progressTxt, True)
        'WaitDlg.Show()
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
        'Console.WriteLine("GetVideoInfo Activated!")
        'Console.WriteLine(NewProcess.StartInfo.Arguments)
        ' Set our event handler to asynchronously read the sort output.
        AddHandler NewProcess.OutputDataReceived, AddressOf GetVideoInfo_OutputHandler
        Cursor = Cursors.WaitCursor
        NewProcess.Start()
        NewProcess.BeginOutputReadLine()
        NewProcess.WaitForExit()
        Cursor = Cursors.Default
        'WaitDlg.Close()
        Return InfOut.ToString
    End Function

    Private Shared Sub GetVideoInfo_OutputHandler(sendingProcess As Object, outLine As DataReceivedEventArgs)
        ' Collect the sort command output.
        If Not String.IsNullOrEmpty(outLine.Data) Then
            ' Add the text to the collected output.
            InfOut.AppendLine(outLine.Data)
            'Console.WriteLine(InfOut)
        End If
    End Sub

    Sub DeleteSelectedVideos()
        Do Until VideoList.SelectedItems.Count = 0
            IO.File.Delete(LibraryLocation & "\" & VideoList.SelectedItems(0).Text)
            VideoList.SelectedItems(0).Remove()
        Loop
    End Sub

    REM SB-Ansel - This sections needs to check whether the original source still has the video available, check for error on youtube-dl stdrout.
    ' this section is supposed to take the filename, split it up to retrieve the video ID.
    Sub RedownloadSelectedVideo()
        If VideoList.SelectedItems.Count > 0 Then
            Dim fname As String = VideoList.SelectedItems(0).Text
            Dim fpieces() As String = fname.Split("."c)
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
        Return
cannot:
        MsgBox("This video cannot be redownloaded.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Whoopsie!")
    End Sub

    'Sub RedownloadSelectedVideo()
    '    Dim dl As New VideoDownload(VideoList.SelectedItems(0).Text)
    '    Dim fname As String = VideoList.SelectedItems(0).Text
    '    Dim fpieces() As String = fname.Split("."c)
    '    Console.WriteLine(String.Join(Environment.NewLine, fpieces))
    '    Console.WriteLine(dl.Url)
    '    dl.Format = PromptForFormat(dl.Url)
    '    Console.WriteLine("JAKEJAKEJAKEJAKEJAKE!!!!!")
    '    Console.WriteLine(dl.Format)
    '    If dl.Format <> FORMAT_UNKNOWN Then AddVideoToQueue(dl)
    'End Sub

    'SB-Ansel - Open selected item in browser!
    Sub OpenInWebBrowser() ' New feature.
        Dim dl As New VideoDownload(VideoList.SelectedItems(0).Text)
        Dim fname As String = VideoList.SelectedItems(0).Text
        Dim fpieces() As String = fname.Split("."c)
        Process.Start(dl.Url)
        'Console.WriteLine(dl.Url)
    End Sub

    Enum ContinueOrCancel
        Unknown = 0
        _Continue = 1
        Cancel = 2
    End Enum

    Sub AddMultipleVideos(ByVal lines As String(), ByVal format As String)
        For Each line As String In lines
            If UrlIsValid(line) Then
                AddVideoToQueue(New VideoDownload(line, GetVideoName(line), format))
            Else
ShowDlg:
                Dim dlg As New Controls.CustomDialog With {
                    .dialogTitle = "Error",
                    .dialogMessage = "This URL is not valid:" & vbNewLine & line,
                    .buttonEText = "Continue",
                    .buttonEResult = ContinueOrCancel._Continue,
                    .buttonDText = "Cancel",
                    .buttonDResult = ContinueOrCancel.Cancel
                }
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

    'SB-Ansel - Format Dialog box, select format to which to download the video in.
    Public Shared Function PromptForFormat(ByVal url As String) As String
        DomainName(url) ' Activate DomainName
        If DomainName(url) = "reddit" Then
            Dim web_request As HttpWebRequest = WebRequest.Create(url + "/file.json")
            Dim web_response As WebResponse = web_request.GetResponse()
            web_request.ContentType = "application/json; charset=utf-8"
            web_request.MaximumAutomaticRedirections = 2
            web_request.UserAgent = "Nothing"
            web_request.AllowAutoRedirect = True

            Dim s = web_request.GetResponse().GetResponseStream()
            Dim sr = New StreamReader(s)
            Dim contributorsAsJson = sr.ReadToEnd()
            Dim contributors = JsonConvert.DeserializeObject(contributorsAsJson).ToString
            Dim parse = JArray.Parse(contributors)

            Dim urlPART = parse.SelectToken("$.[0].data.children[0].data.permalink").ToString
            Console.WriteLine("https://www.reddit.com" + urlPART)
            'Console.WriteLine(parse.SelectToken("$.[0].data.children[0].data.permalink"))
            web_response.Dispose()
            web_response.Close()
            url = "https://www.reddit.com" + urlPART
        End If

        Console.WriteLine("PromptForFormat Activated!")
        Dim dlg As New FormatDialog(url)
        Console.WriteLine(String.Join(Environment.NewLine, dlg))
        If dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Console.WriteLine(dlg.SelectedFormat)
            Return dlg.SelectedFormat
        Else
            Return FORMAT_UNKNOWN
        End If
    End Function

    Public Shared Function DomainName(ByVal curDL As String) As String
        Console.WriteLine("DomainName Activated!")
        ' Santisie the URL and retrieve the domain name for use in the file name later
        Dim sanitiseURL As String
        sanitiseURL = Regex.Replace(curDL, "(http:\/\/|https:\/\/)(www.)?|(.com)\/.*", "")
        Console.WriteLine(sanitiseURL)
        'Return sanitiseURL
        Return sanitiseURL
    End Function

    'SB-Ansel - Cause Reddit is special <3!
    Public Shared Function RedditURL(ByVal curDL As String) As String
        Console.WriteLine("RedditID Activated!")
        Dim redditID As String
        redditID = Regex.Replace(curDL, ".*(\/comments\/=?)|(\/=?.*)", "")
        Console.WriteLine(redditID)
        Return redditID
    End Function

    Private Sub LifeCheck_Tick(sender As Object, e As EventArgs) Handles LifeCheck.Tick
        If dldr.HasExited Then
            LifeCheck.Enabled = False
            MsgBox("Failed to download video: " & vbNewLine & curDL.Name & vbNewLine & curDL.Url & vbNewLine & "In format: " & curDL.Format, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "DuckDL - Error!")
            DownloadDone()
        End If
    End Sub

    ' SB-Ansel - Play video using system assocations.
    Sub PlayVideo(ByVal path As String)
        Process.Start(path)
    End Sub

    ' SB-Ansel - this works though..., appears to be unused.
    'Private Sub DownloadChannelToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    MsgBox("Sorry, this is no longer supported by YouTube.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation)
    'End Sub
    Private Sub ClearAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearAllToolStripMenuItem.Click
        VideoQueue.Clear()
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
                Dim action As MsgBoxResult = MsgBox("Error reading queue file:" & vbNewLine & ex.ToString,
                          MsgBoxStyle.Exclamation + MsgBoxStyle.AbortRetryIgnore, "Error reading queue")
                If action = MsgBoxResult.Abort Then
                    Return
                ElseIf action = MsgBoxResult.Retry Then
                    GoTo attempt_line
                Else
                    'Next line
                End If
            End Try
            line = f.ReadLine
        End While
    End Sub

    Private Sub LoadQueueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadQueueToolStripMenuItem.Click
        If OpenQueueDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            LoadQueue(OpenQueueDialog.FileName)
        End If
    End Sub

    Private Sub SaveQueueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveQueueToolStripMenuItem.Click
        If SaveQueueDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            SaveQueue(SaveQueueDialog.FileName)
        End If
    End Sub

    ' Side tool menu
    Private Sub Play_Click_1(sender As Object, e As EventArgs) Handles Play.Click
        PlaySelectedVideos()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        DeleteSelectedVideos()
    End Sub

    Private Sub Show_in_folder_Click(sender As Object, e As EventArgs) Handles Show_in_folder.Click
        Process.Start(LibraryLocation)
    End Sub

    Private Sub Redownload_Click(sender As Object, e As EventArgs) Handles Redownload.Click
        RedownloadSelectedVideo()
    End Sub
    Private Sub OpenInBrowser_Click(sender As Object, e As EventArgs) Handles OpenInBrowser.Click
        OpenInWebBrowser()
    End Sub

    'Private Sub Microsoft_VC2010_Check(sender As Object, e As EventArgs) Handles MyBase.Load
    'End Sub

    'Top tool menu
    ' File button
    Private Sub PreferencesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PreferencesToolStripMenuItem.Click
        config1.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub OpenLibraryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenLibraryToolStripMenuItem.Click
        Process.Start(LibraryLocation)
    End Sub

    Private Sub AddVideoFromFileToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AddVideoFromFileToolStripMenuItem.Click
        If AddFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            IO.File.Copy(AddFileDialog.FileName, LibraryLocation & "\" & FileNameFromPath(AddFileDialog.FileName))
            GetDownloadedVideos()
        End If
    End Sub

    '[Tools] - Downloads button
    Private Sub DownloadVideoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DownloadVideoToolStripMenuItem.Click
        Dim url As String = InputBox("Enter the URL of the video you want to download:", "Download a Video")
        If url <> "" Then
            If UrlIsValid(url) Then
                url = url.Split("&")(0) ' Prevents downloading of entire playlist when video is in a playlist
                Dim fmt As String = PromptForFormat(url)
                If fmt <> FORMAT_UNKNOWN Then AddVideoToQueue(New VideoDownload(url, GetVideoName(url), fmt))
                Console.WriteLine(fmt)
            Else
                MsgBox("Invalid video URL:" & vbNewLine & url, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub DownloadPlaylistToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DownloadPlaylistToolStripMenuItem.Click
        Dim url As String = InputBox("Enter the URL of the playlist you want to download:", "Download Playlist")
        If url <> "" Then
            If UrlIsValid(url) Then
                Dim vidIDs As String() = GetVideoInfo("--get-id", url, "Enumerating playlist...").Split(vbNewLine)
                Dim u As String = ""
                Dim fmt As String = PromptForFormat(String.Format(YT_URL_FORMAT, vidIDs(0).Trim))
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
                MsgBox("Invalid playlist URL: " & vbNewLine & url, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub EnterInMultipleURLsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnterInMultipleURLsToolStripMenuItem.Click
        Dim tbd As New TextBoxDialog With {
            .Title = "Download Multiple",
            .Prompt = "Enter multiple video URLs, one per line: "
        }
        If tbd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim fmt As String = PromptForFormat(tbd.Lines(0))
            If fmt <> FORMAT_UNKNOWN Then AddMultipleVideos(tbd.Lines, fmt)
        End If
    End Sub
    Private Sub OpenFileOfURLsToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles OpenFileOfURLsToolStripMenuItem.Click
        If OpenURLListDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim lines As String() = IO.File.ReadAllLines(OpenURLListDialog.FileName)
            Dim fmt As String = PromptForFormat(lines(0))
            If fmt <> FORMAT_UNKNOWN Then AddMultipleVideos(lines, fmt)
        End If
    End Sub

    'Help button
    Private Sub ViewOnGithubToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ViewOnGithubToolStripMenuItem.Click
        Process.Start("https://github.com/SB-Ansel/DuckDL")
    End Sub

    Private Sub ReportBugToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ReportBugToolStripMenuItem.Click
        Process.Start("https://github.com/SB-Ansel/DuckDL/issues")
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        MsgBox("Manual update check [WIP] - gilnicki", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "DuckDL update check!")
    End Sub
End Class