<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddVideoFromFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadPlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadFromListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterInMultipleURLsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileOfURLsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOnGithubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportBugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainSplitter = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VideoList = New System.Windows.Forms.ListView()
        Me.VideoIconList = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Duck_Version = New System.Windows.Forms.Label()
        Me.Refresh = New System.Windows.Forms.Button()
        Me.OpenInBrowser = New System.Windows.Forms.Button()
        Me.Play = New System.Windows.Forms.Button()
        Me.Redownload = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Show_in_folder = New System.Windows.Forms.Button()
        Me.DownloadingLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.CurDLLabel = New System.Windows.Forms.Label()
        Me.QueueLabel = New System.Windows.Forms.Label()
        Me.QueueBox = New System.Windows.Forms.ListBox()
        Me.QueueMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveQueueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadQueueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurDLPanel = New System.Windows.Forms.Panel()
        Me.DLQueuedVidsBtn = New System.Windows.Forms.Button()
        Me.CurDLProgress = New System.Windows.Forms.Label()
        Me.CurDLCancel = New System.Windows.Forms.Button()
        Me.AddFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.OpenURLListDialog = New System.Windows.Forms.OpenFileDialog()
        Me.LifeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.OpenQueueDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveQueueDialog = New System.Windows.Forms.SaveFileDialog()
        Me.RefreshToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenInBroswerToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu.SuspendLayout()
        CType(Me.MainSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitter.Panel1.SuspendLayout()
        Me.MainSplitter.Panel2.SuspendLayout()
        Me.MainSplitter.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.DownloadingLayout.SuspendLayout()
        Me.QueueMenu.SuspendLayout()
        Me.CurDLPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.BackColor = System.Drawing.Color.White
        Me.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainMenu.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem1, Me.RefreshToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MainMenu.Size = New System.Drawing.Size(683, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.BackColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddVideoFromFileToolStripMenuItem, Me.OpenLibraryToolStripMenuItem, Me.toolStripSeparator, Me.PreferencesToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "&File"
        '
        'AddVideoFromFileToolStripMenuItem
        '
        Me.AddVideoFromFileToolStripMenuItem.Image = CType(resources.GetObject("AddVideoFromFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddVideoFromFileToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddVideoFromFileToolStripMenuItem.Name = "AddVideoFromFileToolStripMenuItem"
        Me.AddVideoFromFileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.AddVideoFromFileToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.AddVideoFromFileToolStripMenuItem.Text = "&Add video from file"
        '
        'OpenLibraryToolStripMenuItem
        '
        Me.OpenLibraryToolStripMenuItem.Image = CType(resources.GetObject("OpenLibraryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenLibraryToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenLibraryToolStripMenuItem.Name = "OpenLibraryToolStripMenuItem"
        Me.OpenLibraryToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenLibraryToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.OpenLibraryToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(210, 6)
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        Me.PreferencesToolStripMenuItem.Visible = False
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(210, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadVideoToolStripMenuItem, Me.DownloadPlaylistToolStripMenuItem, Me.DownloadFromListToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'DownloadVideoToolStripMenuItem
        '
        Me.DownloadVideoToolStripMenuItem.Name = "DownloadVideoToolStripMenuItem"
        Me.DownloadVideoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DownloadVideoToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.DownloadVideoToolStripMenuItem.Text = "&Download a video"
        '
        'DownloadPlaylistToolStripMenuItem
        '
        Me.DownloadPlaylistToolStripMenuItem.Name = "DownloadPlaylistToolStripMenuItem"
        Me.DownloadPlaylistToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.DownloadPlaylistToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.DownloadPlaylistToolStripMenuItem.Text = "&Download a playlist of channel"
        '
        'DownloadFromListToolStripMenuItem
        '
        Me.DownloadFromListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterInMultipleURLsToolStripMenuItem, Me.OpenFileOfURLsToolStripMenuItem})
        Me.DownloadFromListToolStripMenuItem.Name = "DownloadFromListToolStripMenuItem"
        Me.DownloadFromListToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.DownloadFromListToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.DownloadFromListToolStripMenuItem.Text = "&Download from list"
        '
        'EnterInMultipleURLsToolStripMenuItem
        '
        Me.EnterInMultipleURLsToolStripMenuItem.Name = "EnterInMultipleURLsToolStripMenuItem"
        Me.EnterInMultipleURLsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.EnterInMultipleURLsToolStripMenuItem.Text = "Enter in multiple URLs"
        '
        'OpenFileOfURLsToolStripMenuItem
        '
        Me.OpenFileOfURLsToolStripMenuItem.Name = "OpenFileOfURLsToolStripMenuItem"
        Me.OpenFileOfURLsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.OpenFileOfURLsToolStripMenuItem.Text = "Open file of URLs"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewOnGithubToolStripMenuItem, Me.ReportBugToolStripMenuItem, Me.ToolStripSeparator1, Me.CheckForUpdatesToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(43, 20)
        Me.HelpToolStripMenuItem1.Text = "&Help"
        '
        'ViewOnGithubToolStripMenuItem
        '
        Me.ViewOnGithubToolStripMenuItem.Name = "ViewOnGithubToolStripMenuItem"
        Me.ViewOnGithubToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ViewOnGithubToolStripMenuItem.Text = "&View on GitHub"
        '
        'ReportBugToolStripMenuItem
        '
        Me.ReportBugToolStripMenuItem.Name = "ReportBugToolStripMenuItem"
        Me.ReportBugToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ReportBugToolStripMenuItem.Text = "&Issues"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(175, 6)
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates..."
        Me.CheckForUpdatesToolStripMenuItem.Visible = False
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(175, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshToolStripMenuItem.ShowShortcutKeys = False
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.RefreshToolStripMenuItem.Text = "refresh"
        Me.RefreshToolStripMenuItem.Visible = False
        '
        'MainSplitter
        '
        Me.MainSplitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainSplitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitter.IsSplitterFixed = True
        Me.MainSplitter.Location = New System.Drawing.Point(0, 24)
        Me.MainSplitter.Margin = New System.Windows.Forms.Padding(0)
        Me.MainSplitter.Name = "MainSplitter"
        Me.MainSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'MainSplitter.Panel1
        '
        Me.MainSplitter.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.MainSplitter.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainSplitter.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.MainSplitter.Panel1.Margin = New System.Windows.Forms.Padding(1)
        Me.MainSplitter.Panel1MinSize = 100
        '
        'MainSplitter.Panel2
        '
        Me.MainSplitter.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.MainSplitter.Panel2.Controls.Add(Me.DownloadingLayout)
        Me.MainSplitter.Panel2MinSize = 100
        Me.MainSplitter.Size = New System.Drawing.Size(683, 661)
        Me.MainSplitter.SplitterDistance = 557
        Me.MainSplitter.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.VideoList, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.MinimumSize = New System.Drawing.Size(683, 545)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(683, 555)
        Me.TableLayoutPanel2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(563, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(116, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Video Actions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'VideoList
        '
        Me.VideoList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VideoList.HideSelection = False
        Me.VideoList.LabelWrap = False
        Me.VideoList.LargeImageList = Me.VideoIconList
        Me.VideoList.Location = New System.Drawing.Point(4, 26)
        Me.VideoList.Name = "VideoList"
        Me.VideoList.Size = New System.Drawing.Size(552, 525)
        Me.VideoList.SmallImageList = Me.VideoIconList
        Me.VideoList.TabIndex = 1
        Me.VideoList.UseCompatibleStateImageBehavior = False
        Me.VideoList.View = System.Windows.Forms.View.List
        '
        'VideoIconList
        '
        Me.VideoIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.VideoIconList.ImageSize = New System.Drawing.Size(32, 32)
        Me.VideoIconList.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Label2.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_film
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(4, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(552, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Video List"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Duck_Version)
        Me.Panel1.Controls.Add(Me.Refresh)
        Me.Panel1.Controls.Add(Me.OpenInBrowser)
        Me.Panel1.Controls.Add(Me.Play)
        Me.Panel1.Controls.Add(Me.Redownload)
        Me.Panel1.Controls.Add(Me.Delete)
        Me.Panel1.Controls.Add(Me.Show_in_folder)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(563, 26)
        Me.Panel1.MinimumSize = New System.Drawing.Size(108, 525)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(116, 525)
        Me.Panel1.TabIndex = 5
        '
        'Duck_Version
        '
        Me.Duck_Version.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Duck_Version.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Duck_Version.Location = New System.Drawing.Point(0, 504)
        Me.Duck_Version.Name = "Duck_Version"
        Me.Duck_Version.Size = New System.Drawing.Size(116, 21)
        Me.Duck_Version.TabIndex = 8
        Me.Duck_Version.Text = "Version"
        Me.Duck_Version.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Refresh
        '
        Me.Refresh.Image = CType(resources.GetObject("Refresh.Image"), System.Drawing.Image)
        Me.Refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Refresh.Location = New System.Drawing.Point(7, 149)
        Me.Refresh.Name = "Refresh"
        Me.Refresh.Size = New System.Drawing.Size(93, 23)
        Me.Refresh.TabIndex = 7
        Me.Refresh.Text = "Refresh"
        Me.RefreshToolTip.SetToolTip(Me.Refresh, "Refresh video list!")
        Me.Refresh.UseVisualStyleBackColor = True
        '
        'OpenInBrowser
        '
        Me.OpenInBrowser.AutoSize = True
        Me.OpenInBrowser.Image = CType(resources.GetObject("OpenInBrowser.Image"), System.Drawing.Image)
        Me.OpenInBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.OpenInBrowser.Location = New System.Drawing.Point(7, 120)
        Me.OpenInBrowser.Name = "OpenInBrowser"
        Me.OpenInBrowser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OpenInBrowser.Size = New System.Drawing.Size(93, 23)
        Me.OpenInBrowser.TabIndex = 6
        Me.OpenInBrowser.Text = "Open in"
        Me.OpenInBroswerToolTip.SetToolTip(Me.OpenInBrowser, "Open in browser!")
        Me.OpenInBrowser.UseVisualStyleBackColor = True
        '
        'Play
        '
        Me.Play.AutoSize = True
        Me.Play.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Play.Location = New System.Drawing.Point(7, 3)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(93, 23)
        Me.Play.TabIndex = 0
        Me.Play.Text = "Play"
        Me.Play.UseVisualStyleBackColor = True
        '
        'Redownload
        '
        Me.Redownload.AutoSize = True
        Me.Redownload.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Redownload.Location = New System.Drawing.Point(7, 90)
        Me.Redownload.Name = "Redownload"
        Me.Redownload.Size = New System.Drawing.Size(93, 23)
        Me.Redownload.TabIndex = 4
        Me.Redownload.Text = "Redownload"
        Me.Redownload.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.AutoSize = True
        Me.Delete.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Delete.Location = New System.Drawing.Point(7, 32)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(93, 23)
        Me.Delete.TabIndex = 1
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Show_in_folder
        '
        Me.Show_in_folder.AutoSize = True
        Me.Show_in_folder.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Show_in_folder.Location = New System.Drawing.Point(7, 61)
        Me.Show_in_folder.Name = "Show_in_folder"
        Me.Show_in_folder.Size = New System.Drawing.Size(93, 23)
        Me.Show_in_folder.TabIndex = 3
        Me.Show_in_folder.Text = "Show in folder"
        Me.Show_in_folder.UseVisualStyleBackColor = True
        '
        'DownloadingLayout
        '
        Me.DownloadingLayout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadingLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.DownloadingLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.DownloadingLayout.ColumnCount = 2
        Me.DownloadingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DownloadingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 428.0!))
        Me.DownloadingLayout.Controls.Add(Me.CurDLLabel, 1, 0)
        Me.DownloadingLayout.Controls.Add(Me.QueueLabel, 0, 0)
        Me.DownloadingLayout.Controls.Add(Me.QueueBox, 0, 1)
        Me.DownloadingLayout.Controls.Add(Me.CurDLPanel, 1, 1)
        Me.DownloadingLayout.Location = New System.Drawing.Point(-1, 0)
        Me.DownloadingLayout.Margin = New System.Windows.Forms.Padding(0)
        Me.DownloadingLayout.Name = "DownloadingLayout"
        Me.DownloadingLayout.RowCount = 2
        Me.DownloadingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.DownloadingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DownloadingLayout.Size = New System.Drawing.Size(683, 99)
        Me.DownloadingLayout.TabIndex = 0
        '
        'CurDLLabel
        '
        Me.CurDLLabel.AutoSize = True
        Me.CurDLLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurDLLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.CurDLLabel.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_computer_link
        Me.CurDLLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CurDLLabel.Location = New System.Drawing.Point(257, 1)
        Me.CurDLLabel.Name = "CurDLLabel"
        Me.CurDLLabel.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.CurDLLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CurDLLabel.Size = New System.Drawing.Size(422, 21)
        Me.CurDLLabel.TabIndex = 3
        Me.CurDLLabel.Text = "Current Download"
        '
        'QueueLabel
        '
        Me.QueueLabel.AutoSize = True
        Me.QueueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QueueLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.QueueLabel.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_arrow_down
        Me.QueueLabel.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.QueueLabel.Location = New System.Drawing.Point(4, 1)
        Me.QueueLabel.Name = "QueueLabel"
        Me.QueueLabel.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.QueueLabel.Size = New System.Drawing.Size(246, 21)
        Me.QueueLabel.TabIndex = 1
        Me.QueueLabel.Text = "Downloading Queue"
        '
        'QueueBox
        '
        Me.QueueBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QueueBox.BackColor = System.Drawing.SystemColors.Window
        Me.QueueBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueueBox.ContextMenuStrip = Me.QueueMenu
        Me.QueueBox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.QueueBox.FormattingEnabled = True
        Me.QueueBox.Items.AddRange(New Object() {"Video 1", "Video 2", "Another Video", "More Videos"})
        Me.QueueBox.Location = New System.Drawing.Point(4, 26)
        Me.QueueBox.Name = "QueueBox"
        Me.QueueBox.Size = New System.Drawing.Size(246, 67)
        Me.QueueBox.TabIndex = 4
        '
        'QueueMenu
        '
        Me.QueueMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveSelectedToolStripMenuItem, Me.ClearAllToolStripMenuItem, Me.SaveQueueToolStripMenuItem, Me.LoadQueueToolStripMenuItem})
        Me.QueueMenu.Name = "QueueMenu"
        Me.QueueMenu.Size = New System.Drawing.Size(165, 92)
        '
        'RemoveSelectedToolStripMenuItem
        '
        Me.RemoveSelectedToolStripMenuItem.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_x
        Me.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        Me.RemoveSelectedToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RemoveSelectedToolStripMenuItem.Text = "Remove Selected"
        '
        'ClearAllToolStripMenuItem
        '
        Me.ClearAllToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ClearAllToolStripMenuItem.Name = "ClearAllToolStripMenuItem"
        Me.ClearAllToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ClearAllToolStripMenuItem.Text = "Clear All"
        '
        'SaveQueueToolStripMenuItem
        '
        Me.SaveQueueToolStripMenuItem.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icon_disk
        Me.SaveQueueToolStripMenuItem.Name = "SaveQueueToolStripMenuItem"
        Me.SaveQueueToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.SaveQueueToolStripMenuItem.Text = "Export Queue"
        '
        'LoadQueueToolStripMenuItem
        '
        Me.LoadQueueToolStripMenuItem.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_folder_table
        Me.LoadQueueToolStripMenuItem.Name = "LoadQueueToolStripMenuItem"
        Me.LoadQueueToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.LoadQueueToolStripMenuItem.Text = "Import Queue"
        '
        'CurDLPanel
        '
        Me.CurDLPanel.Controls.Add(Me.DLQueuedVidsBtn)
        Me.CurDLPanel.Controls.Add(Me.CurDLProgress)
        Me.CurDLPanel.Controls.Add(Me.CurDLCancel)
        Me.CurDLPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurDLPanel.Location = New System.Drawing.Point(257, 26)
        Me.CurDLPanel.Name = "CurDLPanel"
        Me.CurDLPanel.Size = New System.Drawing.Size(422, 69)
        Me.CurDLPanel.TabIndex = 5
        '
        'DLQueuedVidsBtn
        '
        Me.DLQueuedVidsBtn.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DLQueuedVidsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DLQueuedVidsBtn.Location = New System.Drawing.Point(2, 39)
        Me.DLQueuedVidsBtn.Name = "DLQueuedVidsBtn"
        Me.DLQueuedVidsBtn.Size = New System.Drawing.Size(232, 23)
        Me.DLQueuedVidsBtn.TabIndex = 5
        Me.DLQueuedVidsBtn.Text = "Start Downloading Queue"
        Me.DLQueuedVidsBtn.UseVisualStyleBackColor = True
        '
        'CurDLProgress
        '
        Me.CurDLProgress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurDLProgress.BackColor = System.Drawing.SystemColors.Window
        Me.CurDLProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurDLProgress.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurDLProgress.Location = New System.Drawing.Point(2, 0)
        Me.CurDLProgress.Name = "CurDLProgress"
        Me.CurDLProgress.Size = New System.Drawing.Size(420, 36)
        Me.CurDLProgress.TabIndex = 4
        Me.CurDLProgress.Text = "No video downloading (-_-')"
        Me.CurDLProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CurDLCancel
        '
        Me.CurDLCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurDLCancel.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CurDLCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CurDLCancel.Location = New System.Drawing.Point(347, 39)
        Me.CurDLCancel.Name = "CurDLCancel"
        Me.CurDLCancel.Size = New System.Drawing.Size(75, 23)
        Me.CurDLCancel.TabIndex = 3
        Me.CurDLCancel.Text = "Cancel"
        Me.CurDLCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CurDLCancel.UseVisualStyleBackColor = True
        '
        'AddFileDialog
        '
        Me.AddFileDialog.Filter = "Media files|*.mp4;*.flv;*.webm;*.3gp;*.avi;*.m4a"
        Me.AddFileDialog.Title = "Add video to Library"
        '
        'OpenURLListDialog
        '
        Me.OpenURLListDialog.Filter = "Text files|*.txt|All files|*.*"
        Me.OpenURLListDialog.Title = "Open URL List"
        '
        'LifeCheck
        '
        '
        'OpenQueueDialog
        '
        Me.OpenQueueDialog.FileName = "OpenFileDialog1"
        Me.OpenQueueDialog.Filter = "DuckDL queue files|*.ddq|All files|*.*"
        Me.OpenQueueDialog.Title = "Open Queue List File"
        '
        'SaveQueueDialog
        '
        Me.SaveQueueDialog.DefaultExt = "*.ddq"
        Me.SaveQueueDialog.Filter = "DuckDL Video Queue|*.ddq"
        Me.SaveQueueDialog.Title = "Save video queue"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(683, 685)
        Me.Controls.Add(Me.MainSplitter)
        Me.Controls.Add(Me.MainMenu)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.MinimumSize = New System.Drawing.Size(699, 724)
        Me.Name = "MainForm"
        Me.Text = "DuckDL"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.MainSplitter.Panel1.ResumeLayout(False)
        Me.MainSplitter.Panel2.ResumeLayout(False)
        CType(Me.MainSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitter.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.DownloadingLayout.ResumeLayout(False)
        Me.DownloadingLayout.PerformLayout()
        Me.QueueMenu.ResumeLayout(False)
        Me.CurDLPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents MainSplitter As System.Windows.Forms.SplitContainer
    Friend WithEvents DownloadingLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CurDLLabel As System.Windows.Forms.Label
    Friend WithEvents QueueLabel As System.Windows.Forms.Label
    Friend WithEvents QueueBox As System.Windows.Forms.ListBox
    Friend WithEvents CurDLPanel As System.Windows.Forms.Panel
    Friend WithEvents CurDLCancel As System.Windows.Forms.Button
    Friend WithEvents VideoIconList As System.Windows.Forms.ImageList
    Friend WithEvents CurDLProgress As System.Windows.Forms.Label
    Friend WithEvents QueueMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DLQueuedVidsBtn As System.Windows.Forms.Button
    Friend WithEvents AddFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenURLListDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LifeCheck As System.Windows.Forms.Timer
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveQueueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadQueueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenQueueDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveQueueDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Show_in_folder As Button
    Friend WithEvents VideoList As ListView
    Friend WithEvents Play As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Redownload As Button
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddVideoFromFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenLibraryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents PreferencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloadVideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloadPlaylistToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewOnGithubToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportBugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DownloadFromListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnterInMultipleURLsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileOfURLsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenInBrowser As Button
    Friend WithEvents Refresh As Button
    Friend WithEvents RefreshToolTip As ToolTip
    Friend WithEvents OpenInBroswerToolTip As ToolTip
    Friend WithEvents Duck_Version As Label
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
End Class
