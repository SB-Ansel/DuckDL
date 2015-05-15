Imports System.Windows.Forms

Public Class FormatDialog

    Structure Format
        Dim Id As Integer
        Dim Filetype As String
        Dim Size As String
        Dim Note As String
    End Structure

    Private Formats As New List(Of Format)

    Public ReadOnly Property SelectedFormat() As Integer
        Get
            If BestButton.Checked = True Then
                Return MainForm.FORMAT_BEST
            Else
                If FormatList.SelectedItems.Count = 0 Then
                    Return MainForm.FORMAT_UNKNOWN
                Else
                    Return Formats(FormatList.SelectedIndex).Id
                End If
            End If
        End Get
    End Property


    Sub New(ByVal url As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        REM Get formats
        Dim fmtOutput As String = MainForm.GetVideoInfo("--list-formats", url, "Finding possible formats...")
        Dim fmtLines As String() = fmtOutput.Split(vbNewLine)
        Dim colID As String
        Dim colFiletype As String
        Dim colSize As String
        Dim colNote As String
        Dim fmt As Format
        For Each fmtLine As String In fmtLines
            fmtLine = fmtLine.TrimStart
            If fmtLine.Length >= 35 Then
                colID = fmtLine.Substring(0, 13).Trim
                colFiletype = fmtLine.Substring(13, 11).Trim
                colSize = fmtLine.Substring(24, 11).Trim
                colNote = fmtLine.Substring(35).Trim
                If IsNumeric(colID) Then
                    fmt = New Format
                    fmt.Id = colID
                    fmt.Filetype = colFiletype
                    fmt.Size = colSize
                    fmt.Note = colNote
                    Formats.Add(fmt)
                End If
            End If
        Next
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub FormatDialog_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For Each fmt As Format In Formats
            FormatList.Items.Add(fmt.Filetype.PadRight(5) & fmt.Size.PadRight(10) & fmt.Note)
        Next
    End Sub

    Private Sub BestButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles BestButton.CheckedChanged
        FormatList.Enabled = Not BestButton.Checked
    End Sub
End Class
