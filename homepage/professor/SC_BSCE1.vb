Public Class SC_BSCE1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
    Public Event BackButtonClicked As EventHandler
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        RaiseEvent BackButtonClicked(Me, EventArgs.Empty)

    End Sub
End Class
