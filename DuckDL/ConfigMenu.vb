Public Class ConfigMenu

    Private Sub ConfigMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Build a JSON Editor like this
        ' http://www.codeproject.com/Articles/282865/A-simple-JSON-Editor
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()
    End Sub
End Class