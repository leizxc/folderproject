Imports MySql.Data.MySqlClient
Public Class profileprof
    Dim connection As String = "server=localhost;userid=root;password=;database=database_panel;port=3306"
    Private Sub profileprof_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim conn As New MySqlConnection(connection)
            conn.Open()

            Dim cmdProfile As New MySqlCommand("SELECT * FROM prof_prfl WHERE username=@username", conn)
            cmdProfile.Parameters.AddWithValue("@username", sessionlogin.loginuser)
            Dim reader As MySqlDataReader = cmdProfile.ExecuteReader()

            If reader.Read() Then
                txtid.Text = reader("id")
                txtname.Text = reader("firstname")
                txtlastname.Text = reader("lastname")
                txtmiddlename.Text = reader("middlename")
                txtage.Text = reader("age")
                txtgender.Text = reader("gender")
                txtbirth.Text = reader("birthday")
                txtadd.Text = reader("address")
                txtcontact.Text = reader("contact")
                txtcourse.Text = reader("subject")
                txtstatus.Text = reader("acc_status")
            End If
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading profile: " & ex.Message)
        End Try
    End Sub
End Class
