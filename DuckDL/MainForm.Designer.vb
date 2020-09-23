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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddVideoFromFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenLibraryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadPlaylistToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadFromListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnterInMultipleURLsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileOfURLsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportBugToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainSplitter = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Play = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Show_in_folder = New System.Windows.Forms.Button()
        Me.Redownload = New System.Windows.Forms.Button()
        Me.LabelActions = New System.Windows.Forms.Label()
        Me.VideoListLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.VideoListLabel = New System.Windows.Forms.Label()
        Me.VideoList = New System.Windows.Forms.ListView()
        Me.VideoIconList = New System.Windows.Forms.ImageList(Me.components)
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
        Me.ViewOnGithubToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainMenu.SuspendLayout()
        CType(Me.MainSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitter.Panel1.SuspendLayout()
        Me.MainSplitter.Panel2.SuspendLayout()
        Me.MainSplitter.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.VideoListLayout.SuspendLayout()
        Me.DownloadingLayout.SuspendLayout()
        Me.QueueMenu.SuspendLayout()
        Me.CurDLPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainMenu.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DownloadingToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MainMenu.Size = New System.Drawing.Size(683, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.AddVideoFromFileToolStripMenuItem, Me.OpenLibraryToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AddVideoFromFileToolStripMenuItem
        '
        Me.AddVideoFromFileToolStripMenuItem.Name = "AddVideoFromFileToolStripMenuItem"
        Me.AddVideoFromFileToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.AddVideoFromFileToolStripMenuItem.Text = "Add Video from File"
        '
        'OpenLibraryToolStripMenuItem
        '
        Me.OpenLibraryToolStripMenuItem.Name = "OpenLibraryToolStripMenuItem"
        Me.OpenLibraryToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.OpenLibraryToolStripMenuItem.Text = "Open Library Location"
        '
        'DownloadingToolStripMenuItem
        '
        Me.DownloadingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadVideoToolStripMenuItem, Me.DownloadPlaylistToolStripMenuItem, Me.DownloadFromListToolStripMenuItem})
        Me.DownloadingToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DownloadingToolStripMenuItem.Name = "DownloadingToolStripMenuItem"
        Me.DownloadingToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.DownloadingToolStripMenuItem.Text = "Downloading"
        '
        'DownloadVideoToolStripMenuItem
        '
        Me.DownloadVideoToolStripMenuItem.Name = "DownloadVideoToolStripMenuItem"
        Me.DownloadVideoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DownloadVideoToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.DownloadVideoToolStripMenuItem.Text = "Download Video"
        '
        'DownloadPlaylistToolStripMenuItem
        '
        Me.DownloadPlaylistToolStripMenuItem.Name = "DownloadPlaylistToolStripMenuItem"
        Me.DownloadPlaylistToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.DownloadPlaylistToolStripMenuItem.Text = "Download Playlist or Channel"
        '
        'DownloadFromListToolStripMenuItem
        '
        Me.DownloadFromListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterInMultipleURLsToolStripMenuItem, Me.OpenFileOfURLsToolStripMenuItem})
        Me.DownloadFromListToolStripMenuItem.Name = "DownloadFromListToolStripMenuItem"
        Me.DownloadFromListToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.DownloadFromListToolStripMenuItem.Text = "Download from List"
        '
        'EnterInMultipleURLsToolStripMenuItem
        '
        Me.EnterInMultipleURLsToolStripMenuItem.Name = "EnterInMultipleURLsToolStripMenuItem"
        Me.EnterInMultipleURLsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.EnterInMultipleURLsToolStripMenuItem.Text = "Enter in multiple URLs"
        '
        'OpenFileOfURLsToolStripMenuItem
        '
        Me.OpenFileOfURLsToolStripMenuItem.Name = "OpenFileOfURLsToolStripMenuItem"
        Me.OpenFileOfURLsToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.OpenFileOfURLsToolStripMenuItem.Text = "Open file of URLs"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewOnGithubToolStripMenuItem, Me.ReportBugToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ReportBugToolStripMenuItem
        '
        Me.ReportBugToolStripMenuItem.Name = "ReportBugToolStripMenuItem"
        Me.ReportBugToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReportBugToolStripMenuItem.Text = "Report a bug"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'MainSplitter
        '
        Me.MainSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MainSplitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitter.IsSplitterFixed = True
        Me.MainSplitter.Location = New System.Drawing.Point(0, 24)
        Me.MainSplitter.Name = "MainSplitter"
        Me.MainSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'MainSplitter.Panel1
        '
        Me.MainSplitter.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainSplitter.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.MainSplitter.Panel1.Controls.Add(Me.VideoListLayout)
        Me.MainSplitter.Panel1MinSize = 100
        '
        'MainSplitter.Panel2
        '
        Me.MainSplitter.Panel2.Controls.Add(Me.DownloadingLayout)
        Me.MainSplitter.Panel2MinSize = 100
        Me.MainSplitter.Size = New System.Drawing.Size(683, 661)
        Me.MainSplitter.SplitterDistance = 546
        Me.MainSplitter.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.Play, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Delete, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Show_in_folder, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Redownload, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.LabelActions, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(580, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.73214!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 223.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(99, 542)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Play
        '
        Me.Play.AutoSize = True
        Me.Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Play.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Play.Location = New System.Drawing.Point(3, 46)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(93, 24)
        Me.Play.TabIndex = 0
        Me.Play.Text = "Play"
        Me.Play.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.AutoSize = True
        Me.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Delete.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Delete.Location = New System.Drawing.Point(3, 77)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(93, 22)
        Me.Delete.TabIndex = 1
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Show_in_folder
        '
        Me.Show_in_folder.AutoSize = True
        Me.Show_in_folder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Show_in_folder.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Show_in_folder.Location = New System.Drawing.Point(3, 105)
        Me.Show_in_folder.Name = "Show_in_folder"
        Me.Show_in_folder.Size = New System.Drawing.Size(93, 22)
        Me.Show_in_folder.TabIndex = 3
        Me.Show_in_folder.Text = "Show in folder"
        Me.Show_in_folder.UseVisualStyleBackColor = True
        '
        'Redownload
        '
        Me.Redownload.AutoSize = True
        Me.Redownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Redownload.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Redownload.Location = New System.Drawing.Point(3, 133)
        Me.Redownload.Name = "Redownload"
        Me.Redownload.Size = New System.Drawing.Size(93, 24)
        Me.Redownload.TabIndex = 4
        Me.Redownload.Text = "Redownload"
        Me.Redownload.UseVisualStyleBackColor = True
        '
        'LabelActions
        '
        Me.LabelActions.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LabelActions.AutoSize = True
        Me.LabelActions.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.LabelActions.Location = New System.Drawing.Point(10, 11)
        Me.LabelActions.Name = "LabelActions"
        Me.LabelActions.Size = New System.Drawing.Size(78, 13)
        Me.LabelActions.TabIndex = 5
        Me.LabelActions.Text = "Video Actions"
        Me.LabelActions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VideoListLayout
        '
        Me.VideoListLayout.ColumnCount = 1
        Me.VideoListLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.VideoListLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.VideoListLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73.0!))
        Me.VideoListLayout.Controls.Add(Me.VideoListLabel, 0, 0)
        Me.VideoListLayout.Controls.Add(Me.VideoList, 0, 1)
        Me.VideoListLayout.Location = New System.Drawing.Point(-2, -2)
        Me.VideoListLayout.Name = "VideoListLayout"
        Me.VideoListLayout.RowCount = 2
        Me.VideoListLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33.0!))
        Me.VideoListLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.VideoListLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.VideoListLayout.Size = New System.Drawing.Size(588, 544)
        Me.VideoListLayout.TabIndex = 0
        '
        'VideoListLabel
        '
        Me.VideoListLabel.AutoSize = True
        Me.VideoListLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoListLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.VideoListLabel.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_film
        Me.VideoListLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VideoListLabel.Location = New System.Drawing.Point(3, 0)
        Me.VideoListLabel.Name = "VideoListLabel"
        Me.VideoListLabel.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.VideoListLabel.Size = New System.Drawing.Size(582, 33)
        Me.VideoListLabel.TabIndex = 0
        Me.VideoListLabel.Text = "Video List"
        Me.VideoListLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VideoList
        '
        Me.VideoList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VideoList.HideSelection = False
        Me.VideoList.LabelWrap = False
        Me.VideoList.LargeImageList = Me.VideoIconList
        Me.VideoList.Location = New System.Drawing.Point(3, 36)
        Me.VideoList.Name = "VideoList"
        Me.VideoList.Size = New System.Drawing.Size(582, 505)
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
        'DownloadingLayout
        '
        Me.DownloadingLayout.ColumnCount = 2
        Me.DownloadingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.DownloadingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.DownloadingLayout.Controls.Add(Me.CurDLLabel, 1, 0)
        Me.DownloadingLayout.Controls.Add(Me.QueueLabel, 0, 0)
        Me.DownloadingLayout.Controls.Add(Me.QueueBox, 0, 1)
        Me.DownloadingLayout.Controls.Add(Me.CurDLPanel, 1, 1)
        Me.DownloadingLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DownloadingLayout.Location = New System.Drawing.Point(0, 0)
        Me.DownloadingLayout.Name = "DownloadingLayout"
        Me.DownloadingLayout.RowCount = 2
        Me.DownloadingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.DownloadingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DownloadingLayout.Size = New System.Drawing.Size(679, 107)
        Me.DownloadingLayout.TabIndex = 0
        '
        'CurDLLabel
        '
        Me.CurDLLabel.AutoSize = True
        Me.CurDLLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurDLLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.CurDLLabel.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_computer_link
        Me.CurDLLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CurDLLabel.Location = New System.Drawing.Point(342, 0)
        Me.CurDLLabel.Name = "CurDLLabel"
        Me.CurDLLabel.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.CurDLLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CurDLLabel.Size = New System.Drawing.Size(334, 21)
        Me.CurDLLabel.TabIndex = 3
        Me.CurDLLabel.Text = "Current Download"
        '
        'QueueLabel
        '
        Me.QueueLabel.AutoSize = True
        Me.QueueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QueueLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.QueueLabel.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_arrow_down
        Me.QueueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QueueLabel.Location = New System.Drawing.Point(3, 0)
        Me.QueueLabel.Name = "QueueLabel"
        Me.QueueLabel.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.QueueLabel.Size = New System.Drawing.Size(333, 21)
        Me.QueueLabel.TabIndex = 1
        Me.QueueLabel.Text = "Downloading Queue"
        '
        'QueueBox
        '
        Me.QueueBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QueueBox.ContextMenuStrip = Me.QueueMenu
        Me.QueueBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QueueBox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.QueueBox.FormattingEnabled = True
        Me.QueueBox.Items.AddRange(New Object() {"Video 1", "Video 2", "Another Video", "More Videos"})
        Me.QueueBox.Location = New System.Drawing.Point(3, 24)
        Me.QueueBox.Name = "QueueBox"
        Me.QueueBox.Size = New System.Drawing.Size(333, 80)
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
        Me.CurDLPanel.Location = New System.Drawing.Point(342, 24)
        Me.CurDLPanel.Name = "CurDLPanel"
        Me.CurDLPanel.Size = New System.Drawing.Size(334, 80)
        Me.CurDLPanel.TabIndex = 5
        '
        'DLQueuedVidsBtn
        '
        Me.DLQueuedVidsBtn.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.DLQueuedVidsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DLQueuedVidsBtn.Location = New System.Drawing.Point(3, 39)
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
        Me.CurDLProgress.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurDLProgress.Location = New System.Drawing.Point(2, 0)
        Me.CurDLProgress.Name = "CurDLProgress"
        Me.CurDLProgress.Size = New System.Drawing.Size(329, 36)
        Me.CurDLProgress.TabIndex = 4
        Me.CurDLProgress.Text = "No video downloading (-_-')"
        Me.CurDLProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CurDLCancel
        '
        Me.CurDLCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurDLCancel.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CurDLCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CurDLCancel.Location = New System.Drawing.Point(256, 39)
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
        'ViewOnGithubToolStripMenuItem
        '
        Me.ViewOnGithubToolStripMenuItem.Name = "ViewOnGithubToolStripMenuItem"
        Me.ViewOnGithubToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewOnGithubToolStripMenuItem.Text = "View on GitHub"
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 500)
        Me.Name = "MainForm"
        Me.Text = "DuckDL"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.MainSplitter.Panel1.ResumeLayout(False)
        Me.MainSplitter.Panel1.PerformLayout()
        Me.MainSplitter.Panel2.ResumeLayout(False)
        CType(Me.MainSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitter.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.VideoListLayout.ResumeLayout(False)
        Me.VideoListLayout.PerformLayout()
        Me.DownloadingLayout.ResumeLayout(False)
        Me.DownloadingLayout.PerformLayout()
        Me.QueueMenu.ResumeLayout(False)
        Me.CurDLPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MainMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainSplitter As System.Windows.Forms.SplitContainer
    Friend WithEvents VideoListLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents AddVideoFromFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadVideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadPlaylistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadingLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CurDLLabel As System.Windows.Forms.Label
    Friend WithEvents QueueLabel As System.Windows.Forms.Label
    Friend WithEvents QueueBox As System.Windows.Forms.ListBox
    Friend WithEvents CurDLPanel As System.Windows.Forms.Panel
    Friend WithEvents DownloadFromListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurDLCancel As System.Windows.Forms.Button
    Friend WithEvents VideoIconList As System.Windows.Forms.ImageList
    Friend WithEvents OpenLibraryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CurDLProgress As System.Windows.Forms.Label
    Friend WithEvents QueueMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DLQueuedVidsBtn As System.Windows.Forms.Button
    Friend WithEvents AddFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents EnterInMultipleURLsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileOfURLsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenURLListDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LifeCheck As System.Windows.Forms.Timer
    Friend WithEvents ClearAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveQueueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadQueueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenQueueDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveQueueDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportBugToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Play As Button
    Friend WithEvents Delete As Button
    Friend WithEvents Show_in_folder As Button
    Friend WithEvents Redownload As Button
    Friend WithEvents VideoListLabel As Label
    Friend WithEvents VideoList As ListView
    Friend WithEvents LabelActions As Label
    Friend WithEvents ViewOnGithubToolStripMenuItem As ToolStripMenuItem
End Class
