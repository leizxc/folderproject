Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Public Class register
    Dim connstring As String = "server = 127.0.0.1; userid = root; password =; database = database_panel; port = 3306"

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
    Private Sub register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Maximize window on load
        Me.WindowState = FormWindowState.Maximized

        ' Hide password characters
        TextBox6.UseSystemPasswordChar = True

        ' Try to connect and get the latest ID from the account table
        Try
            Dim conn As New MySqlConnection(connstring)
            conn.Open()

            ' Get the highest existing ID from the account table
            Dim cmd As New MySqlCommand("SELECT IFNULL(MAX(id), 0) FROM account", conn)
            Dim uid As Integer = cmd.ExecuteScalar()

            ' Set the next ID in TextBox1 (auto-generated)
            TextBox1.Text = (uid + 1).ToString()
        Catch ex As Exception
            ' If there's an error fallback to ID = 1
            MessageBox.Show("Error generating ID: " & ex.Message)
            TextBox1.Text = "1"
        End Try
    End Sub



    Private Sub get_u_id()
        Dim ad As New MySqlDataAdapter("select max (id)from account", conn)
        Dim ds As New System.Data.DataSet
        TextBox1.Text = ds.Tables(0).Rows(0).Item("id") + 1
    End Sub

    Private Sub register_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Resize
        Panel2.Left = (Me.ClientSize.Width - Panel2.Width) \ 2
        Panel2.Top = (Me.ClientSize.Height - Panel2.Height) \ 2
    End Sub


    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim hashcode As register
        hashcode = New register()
        ' Validation
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or ComboBox1.SelectedIndex = -1 Then

            MessageBox.Show("Please fill in all fields!")
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(connstring)
                conn.Open()

                ' Check kung may existing username
                Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM account WHERE username=@username", conn)
                checkCmd.Parameters.AddWithValue("@username", TextBox5.Text)
                Dim count As Integer = checkCmd.ExecuteScalar()

                If count > 0 Then
                    MessageBox.Show("Username already exists!")
                Else
                    ' Insert new account
                    Dim insertCmd As New MySqlCommand("INSERT INTO account(id, lastname, name, middlename, username, passwordusername, email, role, secques, secans)  VALUES(@id, @lastname, @name, @middlename, @username, @passwordusername, @email, @role, @secques, @secans)", conn)

                    insertCmd.Parameters.AddWithValue("@id", TextBox1.Text)
                    insertCmd.Parameters.AddWithValue("@lastname", TextBox2.Text)
                    insertCmd.Parameters.AddWithValue("@name", TextBox3.Text)
                    insertCmd.Parameters.AddWithValue("@middlename", TextBox4.Text)
                    insertCmd.Parameters.AddWithValue("@username", TextBox5.Text)
                    insertCmd.Parameters.AddWithValue("@passwordusername", hashcode.md5fromstring(TextBox6.Text))
                    insertCmd.Parameters.AddWithValue("@email", TextBox7.Text)
                    insertCmd.Parameters.AddWithValue("@role", ComboBox1.SelectedItem.ToString().ToUpper()) ' naka-uppercase
                    insertCmd.Parameters.AddWithValue("@secques", TextBox9.Text)
                    insertCmd.Parameters.AddWithValue("@secans", TextBox10.Text)

                    insertCmd.ExecuteNonQuery()

                    MessageBox.Show("Registration Successful!")

                    ' Clear all fields
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    TextBox5.Clear()
                    TextBox6.Clear()
                    TextBox7.Clear()
                    TextBox9.Clear()
                    TextBox10.Clear()
                    ComboBox1.SelectedIndex = -1

                    ' Example: balik sa login form (palitan depende sa form name mo)
                    Me.Close()
                    Form.Show()
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Panel1_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub


    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox6.UseSystemPasswordChar = False
        Else
            TextBox6.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class