Public Class cashier

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint
        Panel3.BorderStyle = BorderStyle.FixedSingle

    End Sub

    Private Sub loadusercontrol(ByVal uc As UserControl)
        Panel3.Controls.Clear()
        uc.Dock = DockStyle.Fill
        Panel3.Controls.Add(uc)

    End Sub

    Private Sub form_closing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            MessageBox.Show("TANGINA MO MAY LOGOUT BUTTON, WAG TONG X SA TAAS", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

    End Sub

    Private Sub table1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Dim dashboard As New dashboard()
        loadusercontrol(dashboard)
        Dim btn1 As New Button()
        btn1.Text = "Save"
        btn1.Size = New Size(120, 40)
        Me.Controls.Add(btn1)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim studentpay As New studentpay()
        loadusercontrol(studentpay)

    End Sub

    Private Sub cashier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim profsal As New profsal()
        loadusercontrol(profsal)

    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        Dim Result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If Result = DialogResult.Yes Then
            Me.Hide()
            Form.Show()
            Form.BringToFront()
            Form.Activate()
        Else
        End If

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint


    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        
    End Sub

    Private Sub Panel4_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim result As DialogResult = MessageBox.Show("are you sure you want to logout", "Logout confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Hide()
            Form.Show()
            Form.BringToFront()
            Form.Activate()
        Else

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With Button4
            .Text = "Logout"
            .BackColor = Color.LightGray
            .ForeColor = Color.Black    'change color font 

            ' Set FlatStyle so we can control appearance
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 1
            .FlatAppearance.BorderColor = Color.Black
        End With

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        Panel2.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub Panel4_Paint_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint
        Panel4.BorderStyle = BorderStyle.FixedSingle
        With Panel4
            .BackColor = Color.White

        End With

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class