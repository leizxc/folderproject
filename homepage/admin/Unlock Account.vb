Imports MySql.Data.MySqlClient
Public Class Unlock_Account
    Dim connString As String = ("server = 127.0.0.1; userid = root; password =; database = database_panel; port = 3306")
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim alreadyExists As Boolean = False
        For Each col As DataGridViewColumn In DataGridView1.Columns
            If col.Name = "status" AndAlso TypeOf col Is DataGridViewComboBoxColumn Then
                alreadyExists = True
                Exit For
            End If
        Next

        If Not alreadyExists Then
            Dim statusColumn As New DataGridViewComboBoxColumn()
            statusColumn.Name = "status"
            statusColumn.HeaderText = "Status"
            statusColumn.FlatStyle = FlatStyle.Flat
            statusColumn.Items.AddRange("pending", "approved", "denied")

            ' Optional: remove old column first
            If DataGridView1.Columns.Contains("status") Then
                Dim index As Integer = DataGridView1.Columns("status").Index
                DataGridView1.Columns.Remove("status")
                DataGridView1.Columns.Insert(index, statusColumn)
            Else
                DataGridView1.Columns.Add(statusColumn)
            End If
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Using connn As New MySqlConnection(connString)
                connn.Open()

                Dim query As String = "SELECT lastname, firstname, middlename, username,role,acc_status, attempt_count from account"
                Dim adapter As New MySqlDataAdapter(query, connn)
                Dim table As New DataTable()

                adapter.Fill(table)
                DataGridView1.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("error: " & ex.Message)

        End Try
      
    End Sub

    Private Sub Unlock_Account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
