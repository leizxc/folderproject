Public Class SC_BSIS2

    Private Sub SC_BSIS2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Event BackButtonClicked As EventHandler
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RaiseEvent BackButtonClicked(Me, EventArgs.Empty)
    End Sub
End Class
