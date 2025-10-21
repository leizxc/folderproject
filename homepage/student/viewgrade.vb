Imports MySql.Data.MySqlClient
Public Class viewgrade
    Dim connection As String
    Dim commanadtext As String
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TableLayoutPanel1.Visible = True
    End Sub

    Private Sub viewgrade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TableLayoutPanel1.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TableLayoutPanel1.Visible = True
    End Sub
End Class
