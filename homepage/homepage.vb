Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class Form
    ' MySQL connection setup
    Dim conn As New MySqlConnection("server=localhost; userid=root; password=; database=database_panel")
    Dim selectrole As String = ""
    Dim activebutton As Button = Nothing

    ' MD5 hashing function for password encryption
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

    ' Role selection: STUDENT
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        selectrole = "STUDENT"
        HighlightRole(Button1)
    End Sub

    ' Role selection: PROFESSOR
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        selectrole = "PROFESSOR"
        HighlightRole(Button2)
    End Sub

    ' Open registration form
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim reg As New register()
        reg.Show()
        Me.Hide()
    End Sub

    ' Open password recovery form
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim recover As New recover()
        recover.Show()
        Me.Hide()
    End Sub

    ' Login logic
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim hashcode As Form = New Form
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If username = "" Or password = "" Or selectrole = "" Then
            MessageBox.Show("PLEASE INPUT YOUR ACCOUNT AND SELECT ROLE!!")
            Refreshme()
            Exit Sub
        End If

        Try
            conn.Open()
            Dim checkStatusQuery As String = "SELECT acc_status FROM account WHERE username=@username AND passwordusername=@password"
            Dim statusCmd As New MySqlCommand(checkStatusQuery, conn)
            statusCmd.Parameters.AddWithValue("@username", username)
            statusCmd.Parameters.AddWithValue("@password", md5fromstring(password))
            Dim status As Object = statusCmd.ExecuteScalar()

            Dim updateattempt As String = "UPDATE account SET attempt_count = attempt_count + 1 where username= @username"
            Dim updatecmd As New MySqlCommand(updateattempt, conn)
            updatecmd.Parameters.AddWithValue("@username", username)
            updatecmd.ExecuteNonQuery()

            Dim attemptcount As String = "SELECT attempt_count FROM account WHERE username = @username"
            Dim attemptcmd As New MySqlCommand(attemptcount, conn)
            attemptcmd.Parameters.AddWithValue("@username", username)
            Dim attempt As Integer = Convert.ToInt32(attemptcmd.ExecuteScalar())


            If attempt >= 5 Then
                Dim block As String = "UPDATE account SET acc_status = 'OFF' WHERE username = @username"
                Dim blockcmd As New MySqlCommand(block, conn)
                blockcmd.Parameters.AddWithValue("@username", username)
                blockcmd.ExecuteNonQuery()


            End If


            ' If no account found
            If status Is Nothing Then
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Refreshme()
                conn.Close()
                Exit Sub
            End If

            ' If account is OFF
            If status.ToString().ToUpper() = "OFF" Then
                MessageBox.Show("Your account is currently OFF. Please wait for admin approval.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Refreshme()
                conn.Close()
                Exit Sub
            End If

            ' Continue login if status = ON
            Dim query As String = "SELECT * FROM account WHERE role=@role AND username=@username AND passwordusername=@password"
            Dim command As New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@role", selectrole)
            command.Parameters.AddWithValue("@username", username)
            command.Parameters.AddWithValue("@password", md5fromstring(password))
            Dim reader As MySqlDataReader = command.ExecuteReader()


            If reader.HasRows Then
                reader.Read()
                sessionlogin.loginuser = username
                sessionlogin.loginrole = selectrole.ToUpper()
                reader.Close()


                Dim reset As String = "UPDATE account SET attempt_count = 0 where username = @username"
                Dim resetcmd As New MySqlCommand(reset, conn)
                resetcmd.Parameters.AddWithValue("@username", username)
                resetcmd.ExecuteNonQuery()


                If selectrole = "STUDENT" Then
                    student.Show()
                ElseIf selectrole = "PROFESSOR" Then
                    prof.Show()
                ElseIf selectrole = "CASHIER" Then
                    cashier.Show()
                ElseIf selectrole = "ADMIN" Then
                    admin.Show()
                End If

                Me.Hide()
            Else
                MessageBox.Show("INVALID USERNAME OR PASSWORD OR ROLE", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Refreshme()
            End If

            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub Refreshme()
        TextBox1.Text = ""
        TextBox2.Text = ""
        selectrole = ""

        If activebutton IsNot Nothing Then
            activebutton.BackColor = SystemColors.Control
            activebutton = Nothing
        End If

        TextBox1.Focus()
    End Sub



    ' Form initialization
    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        centerpanel()
        Me.KeyPreview = True
        TextBox2.UseSystemPasswordChar = False
        TextBox2.UseSystemPasswordChar = False
        TextBox2.PasswordChar = ChrW(&H25CF)

    End Sub

    ' Re-center panel on form resize
    Private Sub form_resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
        centerpanel()
    End Sub

    ' Center the login panel
    Private Sub centerpanel()
        Panel1.Left = (Me.ClientSize.Width - Panel1.Width) \ 2
        Panel1.Top = (Me.ClientSize.Height - Panel1.Height) \ 2
    End Sub

    ' Role selection: CASHIER
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        selectrole = "CASHIER"
        HighlightRole(Button3)
    End Sub

    ' Highlight selected role button
    Private Sub HighlightRole(ByVal btn As Button)
        If activebutton IsNot Nothing Then
            activebutton.BackColor = SystemColors.Control
        End If
        btn.BackColor = Color.Blue
        Button7.BackColor = Color.Transparent
        activebutton = btn
    End Sub

    ' Trigger login on Enter key
    Private Sub form_keydown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button6.PerformClick()
        End If
    End Sub

    ' Toggle password visibility
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = True
        Else
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    ' Role selection: ADMIN
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        selectrole = "ADMIN"
        HighlightRole(Button7)
    End Sub
End Class