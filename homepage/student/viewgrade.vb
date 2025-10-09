Imports MySql.Data.MySqlClient
Public Class viewgrade
    Dim connection As String
    Dim commanadtext As String
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        commanadtext = "select * from firstsem"
        connection = "server = localhost; user id = root; password = ; database = database_panel;"


        Try
            adapter = New MySqlDataAdapter(commanadtext, connection)
            table = New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub

    Private Sub viewgrade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        commanadtext = "select * from secondsem"

        Try
            adapter = New MySqlDataAdapter(commanadtext, connection)
            table = New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub
End Class
