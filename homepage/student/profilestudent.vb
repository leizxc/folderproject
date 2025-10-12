Imports MySql.Data.MySqlClient
Public Class profilestudent
    Dim connection As String = "server=localhost;userid=root;password=;database=database_panel;port=3306"

    Private Sub profilestudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
     
        Try
            Using conn As New MySqlConnection(connection)
                conn.Open()

                Dim query As String = "SELECT * FROM stud_prfl"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                DataGridView1.DataSource = table
                'design
                '  DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                ' DataGridView1.RowsDefaultCellStyle.BackColor = Drawing.Color.Aquamarine
                ' DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.White
            End Using
        Catch ex As Exception
            MessageBox.Show("ERROR" & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
