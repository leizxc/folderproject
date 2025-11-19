Public Class ResetPassword

    Public UsernameToReset As String = ""

    Private Sub ResetPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

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
End Class