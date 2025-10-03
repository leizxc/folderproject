Public Class student
    Dim homes As New home()
    Dim containeruc As New Panel()
    Dim lbl As New Label()

    Private Sub student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        loadusercontrol(homes)

        'remove sidebar
        Panel2.Dock = DockStyle.Fill
        Panel2.BackColor = Color.FromArgb(50, 50, 50)
        Panel2.Padding = New Padding(20)
        Panel2.BackColor = Color.Transparent
        Me.Controls.Add(Panel2)

        'sidebar layout
        Panel1.Dock = DockStyle.Left
        Panel1.Width = 170
        Panel1.BackColor = Color.FromArgb(40, 40, 40)
        Me.Controls.Add(Panel1)

        'overlay
        Dim overlayMain As New Panel
        overlayMain.BackColor = Color.FromArgb(120, 0, 0, 0)
        overlayMain.Dock = DockStyle.Fill
        Me.Controls.Add(overlayMain)
        overlayMain.BringToFront()
        overlayMain.Controls.Add(Panel1)
        overlayMain.Controls.Add(Panel2)

        'profile icon
        PictureBox1.Image = My.Resources.pfl_pic
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.Location = New Point((Panel1.Width - PictureBox1.Width) \ 2, 20)
        PictureBox1.BackColor = Color.Transparent
        Panel1.Controls.Add(PictureBox1)

        'label
        Dim lbl As New Label()
        lbl.Text = "STUDENT"
        lbl.AutoSize = True
        lbl.ForeColor = Color.White
        lbl.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        lbl.BackColor = Color.Transparent
        lbl.TextAlign = ContentAlignment.MiddleCenter
        lbl.Location = New Point((Panel1.Width - lbl.Width) \ 2, PictureBox1.Bottom + 10)
        Panel1.Controls.Add(lbl)


        'button in left side panel
        For Each uc As Control In Panel1.Controls
            If TypeOf uc Is Button Then
                Dim btn As Button = CType(uc, Button)
                btn.FlatStyle = FlatStyle.Flat
                btn.FlatAppearance.BorderSize = 0
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 60, 60)
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 80, 80)
                btn.BackColor = Color.Transparent
                btn.ForeColor = Color.White
                btn.Font = New Font("Segoe UI", 10, FontStyle.Regular)
                btn.TextAlign = ContentAlignment.MiddleLeft
                btn.ImageAlign = ContentAlignment.MiddleLeft
                btn.Padding = New Padding(10, 0, 0, 0)
                btn.Height = 45
                btn.Margin = Padding.Empty
            End If

        Next
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
        CType(sender, Button).BackColor = Color.FromArgb(50, 50, 50)
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

        Dim galon As New Panel()
        galon.Dock = DockStyle.Fill
        galon.BackColor = Color.Transparent
        galon.Padding = New Padding(30)
        galon.AutoScroll = True

        uc.Dock = DockStyle.None
        uc.AutoSize = True
        uc.Anchor = AnchorStyles.None
        uc.Location = New Point((galon.Width - uc.Width) \ 2, (galon.Height - uc.Height) \ 2)

        galon.Controls.Add(uc)
        Panel2.Controls.Add(galon)
        galon.BringToFront()
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
End Class