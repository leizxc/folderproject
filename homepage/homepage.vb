Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography

Public Class Form
    ' MySQL connection setup
    Dim connector As New MySqlConnection("server=localhost; userid=root; password=; database=database_panel")
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
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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
        Dim rec As New recover()
        rec.Show()
    End Sub

    ' Login logic
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim hashcode As Form = New Form()
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If username = "" Or password = "" Or selectrole = "" Then
            MessageBox.Show("PLEASE INPUT YOUR ACCOUNT AND SELECT ROLE!!")
        End If

        Try
            Dim connector As New MySqlConnection("server=localhost; userid=root; password=; database=database_panel")
            connector.Open()

            Dim query As String = "SELECT * FROM account WHERE role='" & selectrole & "' AND username='" & username & "' AND passwordusername='" & hashcode.md5fromstring(password) & "'"
            Dim command As New MySqlCommand(query, connector)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                sessionlogin.loginrole = selectrole.ToUpper()

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
                TextBox1.Text = ""
                TextBox2.Text = ""
                selectrole = ""
                If activebutton IsNot Nothing Then
                    activebutton.BackColor = SystemColors.Control
                    activebutton = Nothing
                End If
                TextBox1.Focus()
            End If

            reader.Close()
            connector.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        End Try
    End Sub

    ' Form initialization
    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        centerpanel()
        Me.KeyPreview = True
        TextBox2.UseSystemPasswordChar = False
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
