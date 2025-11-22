Imports MySql.Data.MySqlClient

Public Class prof

    Dim connection As String = "server=localhost;userid=root;password=;database=database_panel;port=3306"
    Dim homes As New home()

    Private Sub prof_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Panel2.Dock = DockStyle.Left
        Panel2.BackColor = Color.FromArgb(40, 40, 40)

        Try
            Dim conn As New MySqlConnection(connection)
            conn.Open()
            Dim cmdProfile As New MySqlCommand("SELECT * FROM account WHERE username=@username", conn)
            cmdProfile.Parameters.AddWithValue("@username", sessionlogin.loginuser)
            Dim reader As MySqlDataReader = cmdProfile.ExecuteReader()

            If reader.Read() Then
                txtlname.Text = reader("firstname") & " " & reader("lastname")

            End If
            reader.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        End Try

    End Sub

    Private Sub loadusercontrol(ByVal uc As UserControl)
        Panel3.Controls.Clear()
        uc.Dock = DockStyle.Fill
        Panel3.Controls.Add(uc)

    End Sub



    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim classes As New classes()
        loadusercontrol(classes)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim schedule As New sched()
        loadusercontrol(schedule)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim time As New timevb()
        loadusercontrol(time)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            Form.Show()
        End If



    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel2_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim profileprof As New profileprof()
        loadusercontrol(profileprof)


    End Sub

    Private Sub txtlname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlname.Click

    End Sub
End Class