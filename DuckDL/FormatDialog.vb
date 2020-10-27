Imports System.Text.RegularExpressions

Public Class FormatDialog
    Public Shared Custom_Command As String
    Structure Format
        Dim FormatCode As String
        Dim Filetype As String
        Dim Size As String
        Dim Details As String
    End Structure

    Private ReadOnly Formats As New List(Of Format)
    Public ReadOnly Property SelectedFormat() As String
        Get
            If BestAudio_CheckBox.Checked = True Then
                Return MainForm.FORMAT_BESTAUDIO
            ElseIf BestQuality_CheckBox.Checked = True Then
                Return MainForm.FORMAT_BEST
            ElseIf Customs_TextBox.Modified = True Then
                Custom_Command = Customs_TextBox.Text
                Return MainForm.FORMAT_CUSTOM
            Else
                If FormatList.SelectedItems.Count = 0 Then
                    Return MainForm.FORMAT_UNKNOWN
                Else
                    Return Formats(FormatList.SelectedIndex).FormatCode
                End If
            End If
        End Get
    End Property
    Sub New(ByVal url As String)
        Console.WriteLine("DuckDl-FormatDialog: > Available Formats!")
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Console.WriteLine(url)
        Dim fmtOutput As String = MainForm.GetVideoInfo("--list-formats", url, "Finding available formats...")
        Dim fmtLines As String() = fmtOutput.Split(vbNewLine)
        Dim formatcode As String
        Dim regex = New Regex("(format code)\W")
        Dim details As String
        Dim fmt As Format
        For Each fmtLine As String In fmtLines
            fmtLine = Regex.Replace(fmtLine, "([[]\w.*|format code.*)", "") ' Select everything with [ in the name and delete!
            'Console.WriteLine(fmtLine)
            fmtLine = fmtLine.TrimStart
            details = fmtLine
            fmtLine = Regex.Replace(fmtLine, "([.?\s])+", "*") ' YACK! remove those spaces so we can insert our own delimiter {*}
            'Console.WriteLine(fmtLine)
            If fmtLine.Length <> 0 Then
                formatcode = Regex.Replace(fmtLine, "([\*]).*", "")
                'Console.WriteLine(formatcode)
                fmt = New Format With {
                .FormatCode = formatcode,
                .Details = details}
                Formats.Add(fmt)
            End If
            'Console.WriteLine(formatcode)
        Next
    End Sub
    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub
    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
    Private Sub FormatDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each fmt As Format In Formats
            FormatList.Items.Add($"{">"}{fmt.Details}")
        Next
    End Sub
    '08/27/2020, modifed the video downloader section to include tool tips, a custom input box for youtube-dl commands, and to be generally more user frendly.
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/ytdl-org/youtube-dl/blob/master/README.md#format-selection")
    End Sub
    Private Sub BestQuality_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BestQuality_CheckBox.CheckedChanged
        FormatList.Enabled = Not BestQuality_CheckBox.Checked
    End Sub
    Private Sub BestAudio_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BestAudio_CheckBox.CheckedChanged
        FormatList.Enabled = Not BestAudio_CheckBox.Checked
    End Sub
    Public Sub Customs_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Customs_TextBox.TextChanged
        If Customs_TextBox IsNot Customs_TextBox.Text Then
            Customs_TextBox.Modified = True
        Else
            Customs_TextBox.Modified = False
        End If
    End Sub
End Class