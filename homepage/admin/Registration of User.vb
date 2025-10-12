Imports MySql.Data.MySqlClient
Public Class Registration_of_User
    Dim connString As String = ("server = 127.0.0.1; userid = root; password =; database = Project_db; port = 3306")
    Private Sub Registration_of_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Using connn As New MySqlConnection(connString)
                connn.Open()

                Dim query As String = "SELECT * FROM account"
                Dim adapter As New MySqlDataAdapter(query, connn)
                Dim table As New DataTable()
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                DataGridView1.RowsDefaultCellStyle.BackColor = Drawing.Color.Aquamarine
                DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.White

                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message)

        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Using connn As New MySqlConnection(connString)
                connn.Open()

                Dim query As String = "SELECT * FROM stud_prfl"
                Dim adapter As New MySqlDataAdapter(query, connn)
                Dim table As New DataTable()

                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message)

        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Using connn As New MySqlConnection(connString)
                connn.Open()

                Dim query As String = "SELECT * FROM professors_gradingsys"
                Dim adapter As New MySqlDataAdapter(query, connn)
                Dim table As New DataTable()

                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message)

        End Try
    End Sub
End Class
