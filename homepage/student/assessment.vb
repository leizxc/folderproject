Public Class assessment

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo errorfound
        PrintForm1.Print()
        Exit Sub
errorfound:
        MessageBox.Show("Error found in Printing")
        Resume Next



    End Sub
End Class
