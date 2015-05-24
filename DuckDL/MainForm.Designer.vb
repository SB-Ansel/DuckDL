<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Me.MainSplitter = New System.Windows.Forms.SplitContainer()
        Me.VideoListLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.VideoActionsLabel = New System.Windows.Forms.Label()
        Me.VideoListLabel = New System.Windows.Forms.Label()
        Me.VideoList = New System.Windows.Forms.ListView()
        Me.VideoIconList = New System.Windows.Forms.ImageList(Me.components)
        Me.LibrarySidebar = New Electroduck.Controls.Sidebar(Me.components)
        Me.DownloadingLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.CurDLLabel = New System.Windows.Forms.Label()
        Me.QueueLabel = New System.Windows.Forms.Label()
        Me.QueueBox = New System.Windows.Forms.ListBox()
        Me.QueueMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CurDLPanel = New System.Windows.Forms.Panel()
        Me.DLQueuedVidsBtn = New System.Windows.Forms.Button()
        Me.CurDLProgress = New System.Windows.Forms.Label()
        Me.CurDLCancel = New System.Windows.Forms.Button()
        Me.CurDLNameLabel = New System.Windows.Forms.Label()
        Me.AddFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.OpenURLListDialog = New System.Windows.Forms.OpenFileDialog()
        Me.LifeCheck = New System.Windows.Forms.Timer(Me.components)
        Me.MainMenu.SuspendLayout()
        CType(Me.MainSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainSplitter.Panel1.SuspendLayout()
        Me.MainSplitter.Panel2.SuspendLayout()
        Me.MainSplitter.SuspendLayout()
        Me.VideoListLayout.SuspendLayout()
        Me.DownloadingLayout.SuspendLayout()
        Me.QueueMenu.SuspendLayout()
        Me.CurDLPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DownloadingToolStripMenuItem})
        Me.MainMenu.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MainMenu.Size = New System.Drawing.Size(624, 24)
        Me.MainMenu.TabIndex = 0
        Me.MainMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.AddVideoFromFileToolStripMenuItem, Me.OpenLibraryToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_x
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AddVideoFromFileToolStripMenuItem
        '
        Me.AddVideoFromFileToolStripMenuItem.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_folder
        Me.AddVideoFromFileToolStripMenuItem.Name = "AddVideoFromFileToolStripMenuItem"
        Me.AddVideoFromFileToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AddVideoFromFileToolStripMenuItem.Text = "Add Video from File"
        '
        'OpenLibraryToolStripMenuItem
        '
        Me.OpenLibraryToolStripMenuItem.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_folder_explore
        Me.OpenLibraryToolStripMenuItem.Name = "OpenLibraryToolStripMenuItem"
        Me.OpenLibraryToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.OpenLibraryToolStripMenuItem.Text = "Open Library Location"
        '
        'DownloadingToolStripMenuItem
        '
        Me.DownloadingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadVideoToolStripMenuItem, Me.DownloadPlaylistToolStripMenuItem, Me.DownloadFromListToolStripMenuItem})
        Me.DownloadingToolStripMenuItem.Name = "DownloadingToolStripMenuItem"
        Me.DownloadingToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.DownloadingToolStripMenuItem.Text = "Downloading"
        '
        'DownloadVideoToolStripMenuItem
        '
        Me.DownloadVideoToolStripMenuItem.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_arrow_down
        Me.DownloadVideoToolStripMenuItem.Name = "DownloadVideoToolStripMenuItem"
        Me.DownloadVideoToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.DownloadVideoToolStripMenuItem.Text = "Download Video"
        '
        'DownloadPlaylistToolStripMenuItem
        '
        Me.DownloadPlaylistToolStripMenuItem.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_film
        Me.DownloadPlaylistToolStripMenuItem.Name = "DownloadPlaylistToolStripMenuItem"
        Me.DownloadPlaylistToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.DownloadPlaylistToolStripMenuItem.Text = "Download Playlist"
        '
        'DownloadFromListToolStripMenuItem
        '
        Me.DownloadFromListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterInMultipleURLsToolStripMenuItem, Me.OpenFileOfURLsToolStripMenuItem})
        Me.DownloadFromListToolStripMenuItem.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_page_white
        Me.DownloadFromListToolStripMenuItem.Name = "DownloadFromListToolStripMenuItem"
        Me.DownloadFromListToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.DownloadFromListToolStripMenuItem.Text = "Download from List"
        '
        'EnterInMultipleURLsToolStripMenuItem
        '
        Me.EnterInMultipleURLsToolStripMenuItem.Name = "EnterInMultipleURLsToolStripMenuItem"
        Me.EnterInMultipleURLsToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.EnterInMultipleURLsToolStripMenuItem.Text = "Enter in multiple URLs"
        '
        'OpenFileOfURLsToolStripMenuItem
        '
        Me.OpenFileOfURLsToolStripMenuItem.Name = "OpenFileOfURLsToolStripMenuItem"
        Me.OpenFileOfURLsToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.OpenFileOfURLsToolStripMenuItem.Text = "Open file of URLs"
        '
        'MainSplitter
        '
        Me.MainSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MainSplitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitter.Location = New System.Drawing.Point(0, 24)
        Me.MainSplitter.Name = "MainSplitter"
        Me.MainSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'MainSplitter.Panel1
        '
        Me.MainSplitter.Panel1.Controls.Add(Me.VideoListLayout)
        Me.MainSplitter.Panel1MinSize = 100
        '
        'MainSplitter.Panel2
        '
        Me.MainSplitter.Panel2.Controls.Add(Me.DownloadingLayout)
        Me.MainSplitter.Panel2MinSize = 100
        Me.MainSplitter.Size = New System.Drawing.Size(624, 441)
        Me.MainSplitter.SplitterDistance = 316
        Me.MainSplitter.TabIndex = 1
        '
        'VideoListLayout
        '
        Me.VideoListLayout.ColumnCount = 2
        Me.VideoListLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.VideoListLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.VideoListLayout.Controls.Add(Me.VideoActionsLabel, 1, 0)
        Me.VideoListLayout.Controls.Add(Me.VideoListLabel, 0, 0)
        Me.VideoListLayout.Controls.Add(Me.VideoList, 0, 1)
        Me.VideoListLayout.Controls.Add(Me.LibrarySidebar, 1, 1)
        Me.VideoListLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoListLayout.Location = New System.Drawing.Point(0, 0)
        Me.VideoListLayout.Name = "VideoListLayout"
        Me.VideoListLayout.RowCount = 2
        Me.VideoListLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.VideoListLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.VideoListLayout.Size = New System.Drawing.Size(620, 312)
        Me.VideoListLayout.TabIndex = 0
        '
        'VideoActionsLabel
        '
        Me.VideoActionsLabel.AutoSize = True
        Me.VideoActionsLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoActionsLabel.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_pencil
        Me.VideoActionsLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VideoActionsLabel.Location = New System.Drawing.Point(448, 0)
        Me.VideoActionsLabel.Name = "VideoActionsLabel"
        Me.VideoActionsLabel.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.VideoActionsLabel.Size = New System.Drawing.Size(169, 20)
        Me.VideoActionsLabel.TabIndex = 2
        Me.VideoActionsLabel.Text = "Video Actions"
        '
        'VideoListLabel
        '
        Me.VideoListLabel.AutoSize = True
        Me.VideoListLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoListLabel.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_film
        Me.VideoListLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VideoListLabel.Location = New System.Drawing.Point(3, 0)
        Me.VideoListLabel.Name = "VideoListLabel"
        Me.VideoListLabel.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.VideoListLabel.Size = New System.Drawing.Size(439, 20)
        Me.VideoListLabel.TabIndex = 0
        Me.VideoListLabel.Text = "Video List"
        '
        'VideoList
        '
        Me.VideoList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VideoList.LabelWrap = False
        Me.VideoList.LargeImageList = Me.VideoIconList
        Me.VideoList.Location = New System.Drawing.Point(3, 23)
        Me.VideoList.Name = "VideoList"
        Me.VideoList.Size = New System.Drawing.Size(439, 286)
        Me.VideoList.TabIndex = 1
        Me.VideoList.UseCompatibleStateImageBehavior = False
        Me.VideoList.View = System.Windows.Forms.View.Tile
        '
        'VideoIconList
        '
        Me.VideoIconList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.VideoIconList.ImageSize = New System.Drawing.Size(32, 32)
        Me.VideoIconList.TransparentColor = System.Drawing.Color.Transparent
        '
        'LibrarySidebar
        '
        Me.LibrarySidebar.AddDividers = True
        Me.LibrarySidebar.Antialiasing = True
        Me.LibrarySidebar.DividerColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LibrarySidebar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LibrarySidebar.Items = CType(resources.GetObject("LibrarySidebar.Items"), System.Collections.Generic.List(Of Electroduck.Controls.SidebarItem))
        Me.LibrarySidebar.Location = New System.Drawing.Point(448, 23)
        Me.LibrarySidebar.Name = "LibrarySidebar"
        Me.LibrarySidebar.ShadowHighlightAmount = 128
        Me.LibrarySidebar.Size = New System.Drawing.Size(169, 286)
        Me.LibrarySidebar.Spacing = 13
        Me.LibrarySidebar.TabIndex = 3
        Me.LibrarySidebar.Text = "Sidebar1"
        '
        'DownloadingLayout
        '
        Me.DownloadingLayout.ColumnCount = 2
        Me.DownloadingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.DownloadingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DownloadingLayout.Controls.Add(Me.CurDLLabel, 1, 0)
        Me.DownloadingLayout.Controls.Add(Me.QueueLabel, 0, 0)
        Me.DownloadingLayout.Controls.Add(Me.QueueBox, 0, 1)
        Me.DownloadingLayout.Controls.Add(Me.CurDLPanel, 1, 1)
        Me.DownloadingLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DownloadingLayout.Location = New System.Drawing.Point(0, 0)
        Me.DownloadingLayout.Name = "DownloadingLayout"
        Me.DownloadingLayout.RowCount = 2
        Me.DownloadingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DownloadingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.DownloadingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DownloadingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.DownloadingLayout.Size = New System.Drawing.Size(620, 117)
        Me.DownloadingLayout.TabIndex = 0
        '
        'CurDLLabel
        '
        Me.CurDLLabel.AutoSize = True
        Me.CurDLLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurDLLabel.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_computer_link
        Me.CurDLLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CurDLLabel.Location = New System.Drawing.Point(203, 0)
        Me.CurDLLabel.Name = "CurDLLabel"
        Me.CurDLLabel.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.CurDLLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CurDLLabel.Size = New System.Drawing.Size(414, 20)
        Me.CurDLLabel.TabIndex = 3
        Me.CurDLLabel.Text = "Current Download"
        '
        'QueueLabel
        '
        Me.QueueLabel.AutoSize = True
        Me.QueueLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QueueLabel.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_arrow_down
        Me.QueueLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.QueueLabel.Location = New System.Drawing.Point(3, 0)
        Me.QueueLabel.Name = "QueueLabel"
        Me.QueueLabel.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.QueueLabel.Size = New System.Drawing.Size(194, 20)
        Me.QueueLabel.TabIndex = 1
        Me.QueueLabel.Text = "Downloading Queue"
        '
        'QueueBox
        '
        Me.QueueBox.ContextMenuStrip = Me.QueueMenu
        Me.QueueBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QueueBox.FormattingEnabled = True
        Me.QueueBox.Items.AddRange(New Object() {"Video 1", "Video 2", "Another Video", "More Videos"})
        Me.QueueBox.Location = New System.Drawing.Point(3, 23)
        Me.QueueBox.Name = "QueueBox"
        Me.QueueBox.Size = New System.Drawing.Size(194, 91)
        Me.QueueBox.TabIndex = 4
        '
        'QueueMenu
        '
        Me.QueueMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveSelectedToolStripMenuItem})
        Me.QueueMenu.Name = "QueueMenu"
        Me.QueueMenu.Size = New System.Drawing.Size(165, 26)
        '
        'RemoveSelectedToolStripMenuItem
        '
        Me.RemoveSelectedToolStripMenuItem.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_x
        Me.RemoveSelectedToolStripMenuItem.Name = "RemoveSelectedToolStripMenuItem"
        Me.RemoveSelectedToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.RemoveSelectedToolStripMenuItem.Text = "Remove Selected"
        '
        'CurDLPanel
        '
        Me.CurDLPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurDLPanel.Controls.Add(Me.DLQueuedVidsBtn)
        Me.CurDLPanel.Controls.Add(Me.CurDLProgress)
        Me.CurDLPanel.Controls.Add(Me.CurDLCancel)
        Me.CurDLPanel.Controls.Add(Me.CurDLNameLabel)
        Me.CurDLPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CurDLPanel.Location = New System.Drawing.Point(203, 23)
        Me.CurDLPanel.Name = "CurDLPanel"
        Me.CurDLPanel.Size = New System.Drawing.Size(414, 91)
        Me.CurDLPanel.TabIndex = 5
        '
        'DLQueuedVidsBtn
        '
        Me.DLQueuedVidsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DLQueuedVidsBtn.Location = New System.Drawing.Point(6, 53)
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
        Me.CurDLProgress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CurDLProgress.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurDLProgress.Location = New System.Drawing.Point(3, 20)
        Me.CurDLProgress.Name = "CurDLProgress"
        Me.CurDLProgress.Size = New System.Drawing.Size(325, 23)
        Me.CurDLProgress.TabIndex = 4
        Me.CurDLProgress.Text = "####"
        Me.CurDLProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CurDLCancel
        '
        Me.CurDLCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurDLCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CurDLCancel.Image = Global.Electroduck.DuckDL.My.Resources.Resources.icn_x
        Me.CurDLCancel.Location = New System.Drawing.Point(334, 20)
        Me.CurDLCancel.Name = "CurDLCancel"
        Me.CurDLCancel.Size = New System.Drawing.Size(75, 24)
        Me.CurDLCancel.TabIndex = 3
        Me.CurDLCancel.Text = "Cancel"
        Me.CurDLCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CurDLCancel.UseVisualStyleBackColor = True
        '
        'CurDLNameLabel
        '
        Me.CurDLNameLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurDLNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurDLNameLabel.Location = New System.Drawing.Point(3, 1)
        Me.CurDLNameLabel.Name = "CurDLNameLabel"
        Me.CurDLNameLabel.Size = New System.Drawing.Size(406, 16)
        Me.CurDLNameLabel.TabIndex = 0
        Me.CurDLNameLabel.Text = "My Video"
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
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 465)
        Me.Controls.Add(Me.MainSplitter)
        Me.Controls.Add(Me.MainMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MainMenu
        Me.MinimumSize = New System.Drawing.Size(550, 500)
        Me.Name = "MainForm"
        Me.Text = "DuckDL"
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.MainSplitter.Panel1.ResumeLayout(False)
        Me.MainSplitter.Panel2.ResumeLayout(False)
        CType(Me.MainSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainSplitter.ResumeLayout(False)
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
    Friend WithEvents VideoActionsLabel As System.Windows.Forms.Label
    Friend WithEvents VideoListLabel As System.Windows.Forms.Label
    Friend WithEvents VideoList As System.Windows.Forms.ListView
    Friend WithEvents LibrarySidebar As Electroduck.Controls.Sidebar
    Friend WithEvents AddVideoFromFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadVideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadPlaylistToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadingLayout As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents CurDLLabel As System.Windows.Forms.Label
    Friend WithEvents QueueLabel As System.Windows.Forms.Label
    Friend WithEvents QueueBox As System.Windows.Forms.ListBox
    Friend WithEvents CurDLPanel As System.Windows.Forms.Panel
    Friend WithEvents CurDLNameLabel As System.Windows.Forms.Label
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

End Class
