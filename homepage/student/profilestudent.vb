Imports MySql.Data.MySqlClient
Public Class profilestudent

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label10_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub profilestudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Using connector As New MySqlConnection("server=localhost; userid=root; password=; database=database_panel; port=3306")
                connector.Open()

                Dim query As String = "SELECT * FROM stud_prfl LIMIT 1"
                Dim adapter As New MySqlDataAdapter(query, connector)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                If dt.Rows.Count > 0 Then

                    Dim vertical As New DataTable()
                    vertical.Columns.Add("Field")
                    vertical.Columns.Add("Value")

                    vertical.Rows.Add("BASIC INFORMATION", "")
                    vertical.Rows.Add("Student Number", dt.Rows(0)("stud_num").ToString())
                    vertical.Rows.Add("First Name", dt.Rows(0)("frstname").ToString())
                    vertical.Rows.Add("Last Name", dt.Rows(0)("lstname").ToString())
                    vertical.Rows.Add("Middle Name", dt.Rows(0)("mname").ToString())
                    vertical.Rows.Add("Age", dt.Rows(0)("age").ToString())
                    vertical.Rows.Add("Gender", dt.Rows(0)("gender").ToString())
                    vertical.Rows.Add("Birthday", dt.Rows(0)("birthday").ToString())

                    vertical.Rows.Add("CONTACT INFORMATION", "")
                    vertical.Rows.Add("Address", dt.Rows(0)("full_address").ToString())
                    vertical.Rows.Add("Contact Number", dt.Rows(0)("contact_num").ToString())
                    vertical.Rows.Add("Email", dt.Rows(0)("email").ToString())

                    vertical.Rows.Add("FAMILY INFORMATION", "")
                    vertical.Rows.Add("Mother's Name", dt.Rows(0)("mothers_name").ToString())
                    vertical.Rows.Add("Mother's Contact", dt.Rows(0)("mothers_contact").ToString())
                    vertical.Rows.Add("Father's Name", dt.Rows(0)("fathers_name").ToString())
                    vertical.Rows.Add("Father's Contact", dt.Rows(0)("fathers_contact").ToString())

                    vertical.Rows.Add("ACADEMIC INFORMATION", "")
                    vertical.Rows.Add("Course", dt.Rows(0)("course").ToString())
                    vertical.Rows.Add("Status", dt.Rows(0)("status").ToString())

                    DataGridView1.DataSource = vertical

                    With DataGridView1
                        .ColumnHeadersVisible = False
                        .RowHeadersVisible = False
                        .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        .DefaultCellStyle.Font = New Font("Segoe UI", 10)
                        .DefaultCellStyle.BackColor = Color.White
                        .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                        .DefaultCellStyle.SelectionBackColor = Color.LightBlue
                        .DefaultCellStyle.SelectionForeColor = Color.Black
                    End With

                    For Each row As DataGridViewRow In DataGridView1.Rows
                        If row.Cells("Value").Value.ToString() = "" Then
                            row.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                            row.DefaultCellStyle.BackColor = Color.LightGray
                        End If
                    Next
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student profile: " & ex.Message)
        End Try

    End Sub

    Private Sub SetColumnBindings()
        With DataGridView1
           
        End With
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class