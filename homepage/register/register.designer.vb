<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.subjectpanel = New System.Windows.Forms.Panel
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.subject = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.coursepanel = New System.Windows.Forms.Panel
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel
        Me.course = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.stat = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.secques = New System.Windows.Forms.ComboBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.role = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.id = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ln = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.fn = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.sa = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.mi = New System.Windows.Forms.TextBox
        Me.add = New System.Windows.Forms.TextBox
        Me.un = New System.Windows.Forms.TextBox
        Me.pass = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.subjectpanel.SuspendLayout()
        Me.coursepanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.homepage.My.Resources.Resources.company_pic
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1322, 747)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.subjectpanel)
        Me.Panel2.Controls.Add(Me.coursepanel)
        Me.Panel2.Controls.Add(Me.stat)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.secques)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.role)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.id)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.ln)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.fn)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.sa)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.mi)
        Me.Panel2.Controls.Add(Me.add)
        Me.Panel2.Controls.Add(Me.un)
        Me.Panel2.Controls.Add(Me.pass)
        Me.Panel2.Location = New System.Drawing.Point(510, 76)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(359, 586)
        Me.Panel2.TabIndex = 23
        '
        'subjectpanel
        '
        Me.subjectpanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.subjectpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.subjectpanel.Controls.Add(Me.LinkLabel1)
        Me.subjectpanel.Controls.Add(Me.subject)
        Me.subjectpanel.Controls.Add(Me.Label13)
        Me.subjectpanel.Location = New System.Drawing.Point(42, 335)
        Me.subjectpanel.Name = "subjectpanel"
        Me.subjectpanel.Size = New System.Drawing.Size(290, 107)
        Me.subjectpanel.TabIndex = 27
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(266, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(27, 25)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "X" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'subject
        '
        Me.subject.FormattingEnabled = True
        Me.subject.Items.AddRange(New Object() {"Introduction to Computing", "Computer Programming (Python, Java, or C++)", "Data Structures and Algorithms", "Database Management Systems", "Web Development", "System Analysis and Design", "Networking Fundamentals"})
        Me.subject.Location = New System.Drawing.Point(29, 36)
        Me.subject.Name = "subject"
        Me.subject.Size = New System.Drawing.Size(228, 21)
        Me.subject.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(63, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(162, 15)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "PLEASE SELECT SUBJECT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'coursepanel
        '
        Me.coursepanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.coursepanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.coursepanel.Controls.Add(Me.LinkLabel2)
        Me.coursepanel.Controls.Add(Me.course)
        Me.coursepanel.Controls.Add(Me.Label12)
        Me.coursepanel.Location = New System.Drawing.Point(79, 339)
        Me.coursepanel.Name = "coursepanel"
        Me.coursepanel.Size = New System.Drawing.Size(200, 100)
        Me.coursepanel.TabIndex = 0
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel2.Location = New System.Drawing.Point(176, 0)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(27, 25)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "X" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'course
        '
        Me.course.FormattingEnabled = True
        Me.course.Items.AddRange(New Object() {"BSIT", "BSCS", "BSIS", "BSMA", "BSCpE"})
        Me.course.Location = New System.Drawing.Point(24, 47)
        Me.course.Name = "course"
        Me.course.Size = New System.Drawing.Size(156, 21)
        Me.course.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bookman Old Style", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(156, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "PLEASE SELECT COURSE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'stat
        '
        Me.stat.Enabled = False
        Me.stat.Location = New System.Drawing.Point(106, 199)
        Me.stat.Name = "stat"
        Me.stat.Size = New System.Drawing.Size(73, 20)
        Me.stat.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(60, 206)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Status:"
        '
        'secques
        '
        Me.secques.FormattingEnabled = True
        Me.secques.Items.AddRange(New Object() {"Favorite Food", "Favorite Color", "Favorite Hobby", "Favorite Sport", "Favorite Book"})
        Me.secques.Location = New System.Drawing.Point(106, 411)
        Me.secques.Name = "secques"
        Me.secques.Size = New System.Drawing.Size(146, 21)
        Me.secques.TabIndex = 24
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(256, 335)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(53, 17)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "Show"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'role
        '
        Me.role.FormattingEnabled = True
        Me.role.Items.AddRange(New Object() {"STUDENT", "PROFESSOR", "CASHIER"})
        Me.role.Location = New System.Drawing.Point(106, 386)
        Me.role.Name = "role"
        Me.role.Size = New System.Drawing.Size(144, 21)
        Me.role.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Bookman Old Style", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(75, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(200, 46)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Joselina Maricar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mercado University"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 445)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Security Answer:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(143, 507)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 20)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 419)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Security Question:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.homepage.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(117, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 110)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(65, 393)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Role:"
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(106, 173)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(73, 20)
        Me.id.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Password:"
        '
        'ln
        '
        Me.ln.Location = New System.Drawing.Point(106, 225)
        Me.ln.Name = "ln"
        Me.ln.Size = New System.Drawing.Size(146, 20)
        Me.ln.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(143, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 20)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "REGISTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Last Name:"
        '
        'fn
        '
        Me.fn.Location = New System.Drawing.Point(106, 251)
        Me.fn.Name = "fn"
        Me.fn.Size = New System.Drawing.Size(146, 20)
        Me.fn.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "User Name:"
        '
        'sa
        '
        Me.sa.Location = New System.Drawing.Point(106, 438)
        Me.sa.Name = "sa"
        Me.sa.Size = New System.Drawing.Size(146, 20)
        Me.sa.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 254)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "First Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Middle Initial:"
        '
        'mi
        '
        Me.mi.Location = New System.Drawing.Point(106, 277)
        Me.mi.Name = "mi"
        Me.mi.Size = New System.Drawing.Size(146, 20)
        Me.mi.TabIndex = 3
        '
        'add
        '
        Me.add.Location = New System.Drawing.Point(106, 360)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(146, 20)
        Me.add.TabIndex = 6
        '
        'un
        '
        Me.un.Location = New System.Drawing.Point(106, 306)
        Me.un.Name = "un"
        Me.un.Size = New System.Drawing.Size(146, 20)
        Me.un.TabIndex = 4
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(106, 332)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(146, 20)
        Me.pass.TabIndex = 5
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1322, 747)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.subjectpanel.ResumeLayout(False)
        Me.subjectpanel.PerformLayout()
        Me.coursepanel.ResumeLayout(False)
        Me.coursepanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ln As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fn As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents sa As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mi As System.Windows.Forms.TextBox
    Friend WithEvents add As System.Windows.Forms.TextBox
    Friend WithEvents un As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents role As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents secques As System.Windows.Forms.ComboBox
    Friend WithEvents stat As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents coursepanel As System.Windows.Forms.Panel
    Friend WithEvents course As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents subjectpanel As System.Windows.Forms.Panel
    Friend WithEvents subject As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
End Class
