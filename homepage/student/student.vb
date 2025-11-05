Imports MySql.Data.MySqlClient
Public Class student
    Dim connection As String = "server=localhost;userid=root;password=;database=database_panel;port=3306"
    Dim homes As New home()



    Private Sub student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        loadusercontrol(homes)

        'left side panel
        Panel1.Dock = DockStyle.Left
        Panel1.Width = 240
        Panel1.BackColor = Color.FromArgb(40, 40, 40)

        Try
            Dim conn As New MySqlConnection(connection)
            conn.Open()

            Dim cmdProfile As New MySqlCommand("SELECT * FROM account", conn)
            Dim reader As MySqlDataReader = cmdProfile.ExecuteReader()

            If reader.Read() Then
                txtlname.Text = reader("name") & " " & reader("lastname")
            End If
            reader.Close()
            conn.Close()
        Catch ex As Exception
        End Try
    End Sub
    'x button
    Private Sub form_closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            MessageBox.Show("PLEASE USE THE LOG OUT", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub
    'hoverbutton in leftside panel
    Private Sub button_hover(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.MouseEnter, Button2.MouseEnter, Button3.MouseEnter, Button4.MouseEnter, Button5.MouseEnter
        CType(sender, Button).BackColor = Color.LightBlue
    End Sub

    Private Sub button_leave(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.MouseLeave, Button2.MouseLeave, Button3.MouseLeave, Button4.MouseLeave, Button5.MouseLeave
        CType(sender, Button).BackColor = Color.Transparent
    End Sub
    'highlightbutton
    Private Sub highlightbutton(ByVal activebtn As Button)
        For Each uc As Control In Panel1.Controls
            If TypeOf uc Is Button Then
                CType(uc, Button).BackColor = Color.Transparent
            End If
        Next
        activebtn.BackColor = Color.FromArgb(70, 70, 70)
    End Sub
    'usercontrol
    Private Sub loadusercontrol(ByVal uc As UserControl)
        Panel2.Controls.Clear()
        uc.Dock = DockStyle.Fill 'para ma fill ng user control yung lahat ng panel

        Panel2.Controls.Add(uc)
        uc.BringToFront()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        highlightbutton(Button1)
        Dim profilestudent As New profilestudent()
        loadusercontrol(profilestudent)
    End Sub

    Private Sub MENU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        highlightbutton(Button2)
        Dim view As New viewgrade()
        loadusercontrol(view)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        highlightbutton(Button4)
        Dim assessments As New assessment()
        loadusercontrol(assessments)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        highlightbutton(Button5)
        Dim result As DialogResult = MessageBox.Show("are you sure you want to logout", "Logout confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide()
            Form.Show()
            Form.BringToFront()
            Form.Activate()
        Else
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        loadusercontrol(homes)
        highlightbutton(Button3)
    End Sub



    Private Sub profilestudent_resize(ByVal sender As Object, ByVal e As EventArgs) Handles Panel2.Resize

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtlname_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtlname.Click

    End Sub
End Class