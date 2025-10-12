Imports MySql.Data.MySqlClient

Public Class Prof_Sal
    Dim MysqlConn As New MySqlConnection("server=localhost;user id=root;password=;database=stud_acc_man;port=3306")

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        Panel1.BorderStyle = Windows.Forms.BorderStyle.FixedSingle

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.BorderStyle = Windows.Forms.BorderStyle.FixedSingle



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Panel2.BorderStyle = Windows.Forms.BorderStyle.FixedSingle

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel2_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
    Dim str As String
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            str = "INSERT INTO cort_code VALUES ('0','" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox4.Text & "')"
            MysqlConn.Open()
            Dim mysc As New MySqlCommand(str, MysqlConn)
            mysc.ExecuteNonQuery()
            MysqlConn.Close()
            MsgBox("DONE!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
            MysqlConn.Close()
        End Try
    End Sub

    Private Sub Prof_Sal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            str = "SELECT * FROM cort_code"
            MysqlConn.Open()
            Dim search As New MySqlDataAdapter(str, MysqlConn)
            Dim ds As DataSet = New DataSet
            search.Fill(ds, "cort_code")
            DataGridView1.DataSource = ds.Tables("cort_code")
            MysqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            MysqlConn.Close()


        End Try
    End Sub
End Class
