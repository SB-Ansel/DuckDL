<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextBoxDialog
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.InputTxtBox = New System.Windows.Forms.TextBox()
        Me.PromptLabel = New System.Windows.Forms.Label()
        Me.OKBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OKBtn, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CancelBtn, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(277, 274)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'InputTxtBox
        '
        Me.InputTxtBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputTxtBox.Location = New System.Drawing.Point(12, 29)
        Me.InputTxtBox.Multiline = True
        Me.InputTxtBox.Name = "InputTxtBox"
        Me.InputTxtBox.Size = New System.Drawing.Size(411, 239)
        Me.InputTxtBox.TabIndex = 0
        '
        'PromptLabel
        '
        Me.PromptLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PromptLabel.Location = New System.Drawing.Point(12, 9)
        Me.PromptLabel.Name = "PromptLabel"
        Me.PromptLabel.Size = New System.Drawing.Size(411, 17)
        Me.PromptLabel.TabIndex = 2
        Me.PromptLabel.Text = "Enter in one video URL per line:"
        '
        'OKBtn
        '
        Me.OKBtn.Location = New System.Drawing.Point(3, 3)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(67, 23)
        Me.OKBtn.TabIndex = 0
        Me.OKBtn.Text = "OK"
        Me.OKBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(76, 3)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(67, 23)
        Me.CancelBtn.TabIndex = 1
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'TextBoxDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 315)
        Me.Controls.Add(Me.PromptLabel)
        Me.Controls.Add(Me.InputTxtBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TextBoxDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Multiple Videos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents InputTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents PromptLabel As System.Windows.Forms.Label
    Friend WithEvents OKBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button

End Class
