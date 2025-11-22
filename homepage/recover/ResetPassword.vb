Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Public Class ResetPassword
    Public UsernameToReset As String = ""
    Dim conn As New MySqlConnection("server=localhost; userid=root; password=; database=database_panel")

    Private Sub ResetPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveNewPassword.Click
        ' 1. Check kung may laman
        If txtNewPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            lblResetStatus.ForeColor = Color.Red
            lblResetStatus.Text = "Please fill in both fields."
            Return
        End If

        ' 2. Check kung magkatugma
        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            lblResetStatus.ForeColor = Color.Red
            lblResetStatus.Text = "Passwords do not match."
            Return
        End If

        ' 3. SUCCESS (Simulation of Database Update)

        ' TANDAAN: Dito dapat ang MySql UPDATE query mo!

        lblResetStatus.ForeColor = Color.Green
        lblResetStatus.Text = "Password MATCHED! (Username: " & UsernameToReset & "). You can now implement the database UPDATE."

        btnSaveNewPassword.Enabled = False

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblResetStatus.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConfirmPassword.TextChanged

    End Sub

    Private Sub btnoldpassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoldpassword.Click
        Try
            conn.Open()
            Dim query As String = "SELECT passwordusername FROM account WHERE username=@username"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", txtoldpassword.Text.Trim())

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                Dim dbpass As String = reader("passwordusername")
                Dim hash As String = md5fromstring(txtoldpassword.Text.Trim())
                txtNewPassword.Enabled = True
                txtConfirmPassword.Enabled = True
                btnSaveNewPassword.Enabled = True
            Else
                MessageBox.Show("password incorrect")
                txtoldpassword.Text = ""
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("error" & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class