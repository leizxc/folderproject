Imports MySql.Data.MySqlClient
Public Class profilestudent
    Dim connection As String = "server=localhost;userid=root;password=;database=database_panel;port=3306"

    Private Sub profilestudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Try
            Dim conn As New MySqlConnection(connection)
            conn.Open()

            Dim cmdProfile As New MySqlCommand("SELECT * FROM stud_prfl WHERE username=@username", conn)
            cmdProfile.Parameters.AddWithValue("@username", sessionlogin.loginuser)
            Dim reader As MySqlDataReader = cmdProfile.ExecuteReader()

            If reader.Read() Then
                txtid.Text = reader("id")
                txtname.Text = reader("firstname")
                txtlastname.Text = reader("lastname")
                txtmiddlename.Text = reader("middlename")
                txtage.Text = reader("age")


                txtadd.Text = reader("address")
                txtcontact.Text = reader("contact")
                txtcourse.Text = reader("course")
                txtstatus.Text = reader("acc_status")
            End If
            reader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading profile: " & ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
