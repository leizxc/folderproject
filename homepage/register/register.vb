Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class register
    Dim connstring As String = "server = 127.0.0.1; userid = root; password =; database = database_panel; port = 3306"

    Public Function md5fromstring(ByVal source As String) As String
        Dim sb As New StringBuilder()
        Dim bytes() As Byte
        If String.IsNullOrEmpty(source) Then

            Throw New ArgumentNullException()
        End If

        bytes = Encoding.Default.GetBytes(source)
        bytes = MD5.Create().ComputeHash(bytes)
        For Each b As Byte In bytes
            sb.Append(b.ToString("x2"))
        Next
        Return sb.ToString()
    End Function
    Private Sub register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Maximize window on load
        Me.WindowState = FormWindowState.Maximized

        ' Hide password characters
        pass.UseSystemPasswordChar = True

        ' Try to connect and get the latest ID from the account table
        Try
            Dim conn As New MySqlConnection(connstring)
            conn.Open()

            ' Get the highest existing ID from the account table
            Dim cmd As New MySqlCommand("SELECT IFNULL(MAX(account_id), 0) FROM account", conn)
            Dim uid As Integer = cmd.ExecuteScalar()

            ' Set the next ID in TextBox1 (auto-generated)
            id.Text = (uid + 1).ToString()
        Catch ex As Exception
            ' If there's an error fallback to ID = 1
            MessageBox.Show("Error generating ID: " & ex.Message)
            id.Text = "1"
        End Try
        stat.Text = "ON"

        coursepanel.Visible = False
        subjectpanel.Visible = False

    End Sub



    Private Sub get_u_id()
        Dim ad As New MySqlDataAdapter("select max (account_id)from account", conn)
        Dim ds As New System.Data.DataSet
        id.Text = ds.Tables(0).Rows(0).Item("account_id") + 1
    End Sub

    Private Sub register_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Panel2.Left = (Me.ClientSize.Width - Panel2.Width) \ 2
        Panel2.Top = (Me.ClientSize.Height - Panel2.Height) \ 2
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form.Show()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim hashcode As register
        hashcode = New register()
        ' Validation
        If id.Text = "" Or ln.Text = "" Or fn.Text = "" Or mi.Text = "" Or un.Text = "" Or pass.Text = "" Or add.Text = "" Or secques.SelectedIndex = -1 Or sa.Text = "" Or role.SelectedIndex = -1 Or stat.Text = "" Then

            MessageBox.Show("Please fill in all fields!")
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(connstring)
                conn.Open()

                ' Check kung may existing username
                Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM account WHERE username=@username", conn)
                checkCmd.Parameters.AddWithValue("@username", un.Text)
                Dim count As Integer = checkCmd.ExecuteScalar()

                If count > 0 Then
                    MessageBox.Show("Username already exists!")
                Else
                    ' Insert new account
                    Dim insertCmd As New MySqlCommand("INSERT INTO account(account_id, lastname, firstname, middlename, username, passwordusername, address, role, secque, secans, account_status, course, subject)  VALUES(@account_id, @lastname, @firstname, @middlename, @username, @passwordusername, @address, @role, @secque, @secans, 'ON', @course, @subject)", conn)

                    insertCmd.Parameters.AddWithValue("@account_id", id.Text)
                    insertCmd.Parameters.AddWithValue("@lastname", ln.Text)
                    insertCmd.Parameters.AddWithValue("@firstname", fn.Text)
                    insertCmd.Parameters.AddWithValue("@middlename", mi.Text)
                    insertCmd.Parameters.AddWithValue("@username", un.Text)
                    insertCmd.Parameters.AddWithValue("@passwordusername", hashcode.md5fromstring(pass.Text))
                    insertCmd.Parameters.AddWithValue("@address", add.Text)
                    insertCmd.Parameters.AddWithValue("@role", role.SelectedItem.ToString())
                    insertCmd.Parameters.AddWithValue("@secque", secques.SelectedItem.ToString())
                    insertCmd.Parameters.AddWithValue("@secans", sa.Text)
                    insertCmd.Parameters.AddWithValue("@account_status", "ON")
                    insertCmd.Parameters.AddWithValue("@course", course.Text)
                    insertCmd.Parameters.AddWithValue("@subject", subject.Text)


                    insertCmd.ExecuteNonQuery()

                    MessageBox.Show("Registration Successful!")

                    ' Example: balik sa login form (palitan depende sa form name mo)
                    Me.Hide()
                    Form.Show()


                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles role.SelectedIndexChanged
        Dim selectrole As String = role.SelectedItem.ToString
        coursepanel.Visible = False
        subjectpanel.Visible = False
        If selectrole = "STUDENT" Then
            coursepanel.Visible = True
        ElseIf selectrole = "PROFESSOR" Then
            subjectpanel.Visible = True


        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            pass.UseSystemPasswordChar = False
        Else
            pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles course.SelectedIndexChanged
        If course.SelectedIndex <> -1 Then

        End If
        ' Optional: show confirmation
        MessageBox.Show("You selected: " & course.SelectedItem.ToString(), "Course Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' I-hide yung panel
        coursepanel.Visible = False
    End Sub

    Private Sub subject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subject.SelectedIndexChanged
        If subject.SelectedIndex <> -1 Then

        End If
        ' Optional: show confirmation
        MessageBox.Show("You selected: " & subject.SelectedItem.ToString(), "Subject Selected(", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' I-hide yung panel
        subjectpanel.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        subjectpanel.Visible = False
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        coursepanel.Visible = False
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class