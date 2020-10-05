Public NotInheritable Class Splash
    Private Sub Splash_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ApplicationTitle.Text = My.Application.Info.Title
        Version.Text = String.Format(Version.Text, My.Application.Info.Version)
        Copyright.Text = String.Format(Copyright.Text, My.Application.Info.Copyright)
    End Sub
    'Public Sub UpdateProgress()
    '    If InvokeRequired Then
    '        Invoke(New MethodInvoker(AddressOf UpdateProgress))
    '    Else
    '        ProgressBar1.PerformStep()
    '    End If
    'End Sub
End Class
