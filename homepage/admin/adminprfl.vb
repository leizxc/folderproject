Imports MySql.Data.MySqlClient
Public Class adminprfl
    Dim connectionString As String = "server=localhost; user id=root; password= ; database=database_panel"

    Private Sub adminprfl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query1 As New MySqlCommand("SELECT * FROM admin_prfl where username=@username", conn)
            query1.Parameters.AddWithValue("@username", sessionlogin.loginuser)
            Dim reader As MySqlDataReader = query1.ExecuteReader()

            If reader.Read() Then
                id.Text = reader("id")
                status.Text = reader("acc_status")
            End If
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("error" & ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint


    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lastname.ReadOnly = False
        firstname.ReadOnly = False
        middlename.ReadOnly = False
        age.ReadOnly = False
        contact.ReadOnly = False
        address.ReadOnly = False
        gender.Enabled = True
        birthday.Enabled = True

        MessageBox.Show("Fields are now editable.")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        lastname.ReadOnly = True
        firstname.ReadOnly = True
        middlename.ReadOnly = True
        age.ReadOnly = True
        contact.ReadOnly = True
        address.ReadOnly = True
        gender.Enabled = False
        birthday.Enabled = False

        MessageBox.Show("Profile Updated")

        Try
            Dim conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "UPDATE admin_prfl SET firstname=@firstname, middlename=@middlename, lastname=@lastname, age=@age, gender=@gender, birthday=@birthday, contact=@contact, address=@address"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@firstname", firstname.Text)
            cmd.Parameters.AddWithValue("@middlename", middlename.Text)
            cmd.Parameters.AddWithValue("@lastname", lastname.Text)
            cmd.Parameters.AddWithValue("@age", age.Text)
            cmd.Parameters.AddWithValue("@birthday", Convert.ToDateTime(birthday.Text))
            cmd.Parameters.AddWithValue("@gender", gender.SelectedItem)
            cmd.Parameters.AddWithValue("@contact", contact.Text)
            cmd.Parameters.AddWithValue("@address", address.Text)
            cmd.ExecuteNonQuery()


            MsgBox("Database Updated Successfuly")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub gender_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gender.SelectedIndexChanged

    End Sub
End Class
