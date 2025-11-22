Imports MySql.Data.MySqlClient
Public Class viewgrade
    Dim connection As String
    Dim commanadtext As String
    Dim adapter As MySqlDataAdapter
    Dim table As DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TableLayoutPanel1.Visible = True
        Try
            conn.Open()

            Dim cmdgrades As New MySqlCommand("SELECT * FROM first_sem WHERE usename=@username", conn)
            cmdgrades.Parameters.AddWithValue("@username", sessionlogin.loginuser)
            Dim reader As MySqlDataReader = cmdgrades.ExecuteReader()

            If reader.Read() Then
                code0.Text = reader("subject_code")
                code1.Text = reader("subject_code")
                code2.Text = reader("subject_code")
                code03.Text = reader("subject_code")
                code4.Text = reader("subject_code")
                code5.Text = reader("subject_code")
                code6.Text = reader("subject_code")

                subject0.Text = reader("subject_name")
                subject1.Text = reader("subject_name")
                subject2.Text = reader("subject_name")
                subject3.Text = reader("subject_name")
                subject4.Text = reader("subject_name")
                subject5.Text = reader("subject_name")
                subject6.Text = reader("subject_name")

                unit0.Text = reader("units")
                unit1.Text = reader("units")
                unit3.Text = reader("units")
                unit4.Text = reader("units")
                unit5.Text = reader("units")
                unit6.Text = reader("units")

                grades0.Text = reader("units")
                grades1.Text = reader("units")
                grades2.Text = reader("units")
                grades3.Text = reader("units")
                grades4.Text = reader("units")
                grades5.Text = reader("units")
                grades6.Text = reader("units")

                remarks0.Text = reader("remarks")
                remarks1.Text = reader("remarks")
                remarks2.Text = reader("remarks")
                remarks3.Text = reader("remarks")
                remarks4.Text = reader("remarks")
                remarks5.Text = reader("remarks")
                remarks6.Text = reader("remarks")

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub viewgrade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TableLayoutPanel1.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TableLayoutPanel1.Visible = True

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles code2.Click

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subject4.Click

    End Sub

    Private Sub Label18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unit5.Click

    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remarks5.Click

    End Sub

    Private Sub code0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles code0.Click

    End Sub
End Class
