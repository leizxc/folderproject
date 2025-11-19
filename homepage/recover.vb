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

        Try
            conn.Open()
        Catch ex As Exception

        End Try

        If txtanswer.Text = "" Then
            lblresult.ForeColor = Color.Red
            lblresult.Text = "Please fill your answer."
            lblresult.Visible = True
            Return
        End If

        ' Case-insensitive comparison laban sa hardcoded storedAnswer ("blue")
        If String.Equals(txtanswer.Text, storedAnswer, StringComparison.OrdinalIgnoreCase) Then

            ' SUCCESS - BUKAS NG RESET FORM
            Dim resetForm As New ResetPassword()

            ' Ipasa ang username (Testuser) sa bagong form
            resetForm.UsernameToReset = txtusername.Text

            resetForm.Show()
            Me.Close()

        Else
            ' FAILURE
            lblresult.ForeColor = Color.Red
            lblresult.Text = "Try again. Incorrect answer."
            lblresult.Visible = True
        End If
    End Sub


    Private Sub recover_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


    End Sub
End Class