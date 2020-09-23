<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormatDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormatDialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.PromptLabel = New System.Windows.Forms.Label()
        Me.FormatList = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Customs_TextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BestQuality_CheckBox = New System.Windows.Forms.CheckBox()
        Me.BestAudio_CheckBox = New System.Windows.Forms.CheckBox()
        Me.BestAudio_ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BestQuality_ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(406, 378)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(188, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Cancel_Button.Location = New System.Drawing.Point(97, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(88, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'OK_Button
        '
        Me.OK_Button.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(88, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'PromptLabel
        '
        Me.PromptLabel.AutoSize = True
        Me.PromptLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromptLabel.Location = New System.Drawing.Point(15, 130)
        Me.PromptLabel.Name = "PromptLabel"
        Me.PromptLabel.Size = New System.Drawing.Size(104, 15)
        Me.PromptLabel.TabIndex = 1
        Me.PromptLabel.Text = "Available Formats:"
        '
        'FormatList
        '
        Me.FormatList.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormatList.FormattingEnabled = True
        Me.FormatList.HorizontalScrollbar = True
        Me.FormatList.Location = New System.Drawing.Point(15, 148)
        Me.FormatList.Name = "FormatList"
        Me.FormatList.Size = New System.Drawing.Size(576, 212)
        Me.FormatList.Sorted = True
        Me.FormatList.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Custom YouTube-dl commands:"
        '
        'Customs_TextBox
        '
        Me.Customs_TextBox.Location = New System.Drawing.Point(12, 99)
        Me.Customs_TextBox.Name = "Customs_TextBox"
        Me.Customs_TextBox.Size = New System.Drawing.Size(288, 20)
        Me.Customs_TextBox.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(306, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "e.g. bestaudio[ext=m4a]"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(448, 101)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(124, 15)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "See Youtube-dl docs..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(15, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Quick shortcut menu"
        '
        'BestQuality_CheckBox
        '
        Me.BestQuality_CheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.BestQuality_CheckBox.AutoSize = True
        Me.BestQuality_CheckBox.Location = New System.Drawing.Point(14, 36)
        Me.BestQuality_CheckBox.Name = "BestQuality_CheckBox"
        Me.BestQuality_CheckBox.Size = New System.Drawing.Size(73, 23)
        Me.BestQuality_CheckBox.TabIndex = 9
        Me.BestQuality_CheckBox.Text = "Best Quality"
        Me.BestQuality_ToolTip.SetToolTip(Me.BestQuality_CheckBox, "Select the best quality format represented by a single file with video and audio." &
        "")
        Me.BestQuality_CheckBox.UseVisualStyleBackColor = True
        '
        'BestAudio_CheckBox
        '
        Me.BestAudio_CheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.BestAudio_CheckBox.AutoSize = True
        Me.BestAudio_CheckBox.Location = New System.Drawing.Point(94, 36)
        Me.BestAudio_CheckBox.Name = "BestAudio_CheckBox"
        Me.BestAudio_CheckBox.Size = New System.Drawing.Size(68, 23)
        Me.BestAudio_CheckBox.TabIndex = 10
        Me.BestAudio_CheckBox.Text = "Best Audio"
        Me.BestAudio_ToolTip.SetToolTip(Me.BestAudio_CheckBox, "Select the best quality audio only-format. May not be available.")
        Me.BestAudio_CheckBox.UseVisualStyleBackColor = True
        '
        'FormatDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(606, 419)
        Me.Controls.Add(Me.BestAudio_CheckBox)
        Me.Controls.Add(Me.BestQuality_CheckBox)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Customs_TextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FormatList)
        Me.Controls.Add(Me.PromptLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormatDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Video Format - Format Selection"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents PromptLabel As System.Windows.Forms.Label
    Friend WithEvents FormatList As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Customs_TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents BestQuality_CheckBox As CheckBox
    Friend WithEvents BestQuality_ToolTip As ToolTip
    Friend WithEvents BestAudio_CheckBox As CheckBox
    Friend WithEvents BestAudio_ToolTip As ToolTip
End Class
