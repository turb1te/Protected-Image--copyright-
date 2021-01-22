Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WebBrowser1.Navigate("about:blank")
        Me.WebBrowser1.Document.Write(String.Empty)
        WebBrowser1.DocumentText = My.Resources.Resource1._12345
    End Sub
End Class
