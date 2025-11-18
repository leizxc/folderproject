Imports MySql.Data.MySqlClient

Public Class Registration_of_User
    Dim connString As String = "server=127.0.0.1; userid=root; password=; database=database_panel; port=3306"

    Private Sub Registration_of_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    ' Load all accounts into DataGridView
    Private Sub LoadAccounts()
        Try
            Using connn As New MySqlConnection(connString)
                connn.Open()

                ' Show only accounts with acc_status = OFF (pending approval)
                Dim query As String = "SELECT id, username, lastname, firstname, role, acc_status FROM account WHERE acc_status='OFF'"
                Dim adapter As New MySqlDataAdapter(query, connn)
                Dim table As New DataTable()
                adapter.Fill(table)

                DataGridView1.DataSource = table
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                DataGridView1.RowsDefaultCellStyle.BackColor = Drawing.Color.Aquamarine
                DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.White
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading accounts: " & ex.Message)
        End Try
    End Sub

    ' Approve selection ng account
    Private Sub Approve_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Approve.Click
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim selectedId As Integer = CInt(DataGridView1.CurrentRow.Cells("id").Value)

            Try
                Using connn As New MySqlConnection(connString)
                    connn.Open()
                    Dim updateQueryacc As String = "UPDATE account  SET acc_status='ON' WHERE id=@id"
                    Dim appcmd1 As New MySqlCommand(updateQueryacc, connn)
                    appcmd1.Parameters.AddWithValue("@id", selectedId)
                    appcmd1.ExecuteNonQuery()

                    Dim updateQuerystud As String = "UPDATE stud_prfl  SET acc_status='ON' WHERE id=@id"
                    Dim appcmd2 As New MySqlCommand(updateQuerystud, connn)
                    appcmd2.Parameters.AddWithValue("@id", selectedId)
                    appcmd2.ExecuteNonQuery()

                    MessageBox.Show("Account approved and activated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using

                ' Refresh ng DGV
                LoadAccounts()
            Catch ex As Exception
                MessageBox.Show("Error approving account: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select an account to approve.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoadAccounts()
    End Sub
End Class
