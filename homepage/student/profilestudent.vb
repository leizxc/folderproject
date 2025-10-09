Imports MySql.Data.MySqlClient
Public Class profilestudent
    Dim connection As String
    Dim commandtext As String
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Private Sub profilestudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'dgv profile student
        commandtext = "select * from stud_prfl"
        connection = "server=localhost; user id = root; password = ; database = database_panel "
        Try
            adapter = New MySqlDataAdapter(commandtext, connection)
            table = New DataTable
            adapter.Fill(table)
            DataGridView1.DataSource = table
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            DataGridView1.RowsDefaultCellStyle.BackColor = Drawing.Color.Aquamarine
            DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.White

        Catch ex As Exception
            MessageBox.Show("ERROR")
        End Try
    End Sub
End Class
