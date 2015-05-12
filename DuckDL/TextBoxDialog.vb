Imports System.Windows.Forms

Public Class TextBoxDialog

    Private _Lines As String()
    Public Property Lines() As String()
        Get
            _Lines = InputTxtBox.Lines
            Return _Lines
        End Get
        Set(ByVal value As String())
            _Lines = value
            InputTxtBox.Lines = _Lines
        End Set
    End Property

    Private _Prompt As String
    Public Property Prompt() As String
        Get
            Return _Prompt
        End Get
        Set(ByVal value As String)
            _Prompt = value
            PromptLabel.Text = _Prompt
        End Set
    End Property

    Private _Title As String
    Public Property Title() As String
        Get
            Return _Title
        End Get
        Set(ByVal value As String)
            _Title = value
            Me.Text = _Title
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKBtn.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
