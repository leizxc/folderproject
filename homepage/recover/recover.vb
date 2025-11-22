Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class recover
    Dim conn As New MySqlConnection("server=localhost; userid=root; password=; database=database_panel")
    Private storedAnswer As String = ""
    Private storedPassword As String = ""


    Private Sub txtusename_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblusename.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub txtusername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub lblresult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblresult.Click

    End Sub

    Private Sub btbrecover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btbrecover.Click


        If txtanswer.Text = "" Then
            lblresult.ForeColor = Color.Red
            lblresult.Text = "Please fill your answer."
            lblresult.Visible = True
            Return
        End If

        Try
            conn.Open()

            Dim query2 As String = "SELECT secans FROM account WHERE username=@username"
            Dim cmd2 As New MySqlCommand(query2, conn)
            cmd2.Parameters.AddWithValue("@username", TextBox1.Text.Trim())
            cmd2.ExecuteReader()

            If String.Equals(TextBox1.Text, storedAnswer, StringComparison.OrdinalIgnoreCase) Then
                ResetPassword.Show()
                Me.Hide()
            Else
                lblresult.ForeColor = Color.Red
                lblresult.Text = "Try again. Incorrect answer."
                lblresult.Visible = True
                TextBox1.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub


    Private Sub recover_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form.Show()
        Me.Hide()

    End Sub

    Private Sub confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles confirm.Click
        Try
            conn.Open()
            Dim query As String = "SELECT secques, secans FROM account WHERE username=@username"
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", txtusername.Text.Trim())

            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                lblquestion.Text = reader("secques")
                storedAnswer = reader("secans")
                TextBox1.Enabled = True
            Else
                lblresult.ForeColor = Color.Red
                lblresult.Text = "Username not found."
                lblresult.Visible = True
                txtanswer.Enabled = False
                txtusername.Text = ""
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class