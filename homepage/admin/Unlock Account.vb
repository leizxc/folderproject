Imports MySql.Data.MySqlClient
Public Class Unlock_Account
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Dim connString As String = ("server = 127.0.0.1; userid = root; password =; database = database_panel; port = 3306")
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Using connn As New MySqlConnection(connString)
                connn.Open()

                Dim query As String = "SELECT id, lastname, firstname, middlename, username,role,acc_status, attempt_count from account"
                adapter = New MySqlDataAdapter(query, connn)
                table = New DataTable()

                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message)

        End Try

    End Sub

    Private Sub Unlock_Account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If DataGridView1.SelectedRows.Count = 0 Then
                MessageBox.Show("Please Select an Account to Unlock.")
                Exit Sub
            End If

            Dim row As DataGridViewRow = DataGridView1.SelectedRows(0)

            row.Cells("acc_status").Value = "ON"
            row.Cells("attempt_count").Value = 0

            Dim builder As New MySqlCommandBuilder(adapter)
            adapter.Update(table)

            MessageBox.Show("Account Successfully Unlocked!")
        Catch ex As Exception
            MessageBox.Show("Update error: " & ex.Message)
        End Try

    End Sub
End Class
