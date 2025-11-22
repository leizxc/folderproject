<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminprfl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.birthday = New System.Windows.Forms.DateTimePicker
        Me.status = New System.Windows.Forms.Label
        Me.gender = New System.Windows.Forms.ComboBox
        Me.id = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.age = New System.Windows.Forms.TextBox
        Me.contact = New System.Windows.Forms.TextBox
        Me.address = New System.Windows.Forms.TextBox
        Me.middlename = New System.Windows.Forms.TextBox
        Me.firstname = New System.Windows.Forms.TextBox
        Me.lastname = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.birthday)
        Me.Panel1.Controls.Add(Me.status)
        Me.Panel1.Controls.Add(Me.gender)
        Me.Panel1.Controls.Add(Me.id)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.age)
        Me.Panel1.Controls.Add(Me.contact)
        Me.Panel1.Controls.Add(Me.address)
        Me.Panel1.Controls.Add(Me.middlename)
        Me.Panel1.Controls.Add(Me.firstname)
        Me.Panel1.Controls.Add(Me.lastname)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(896, 575)
        Me.Panel1.TabIndex = 0
        '
        'birthday
        '
        Me.birthday.Enabled = False
        Me.birthday.Location = New System.Drawing.Point(457, 417)
        Me.birthday.Name = "birthday"
        Me.birthday.Size = New System.Drawing.Size(200, 20)
        Me.birthday.TabIndex = 58
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status.ForeColor = System.Drawing.Color.Black
        Me.status.Location = New System.Drawing.Point(153, 393)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(117, 37)
        Me.status.TabIndex = 57
        Me.status.Text = "STATUS:"
        '
        'gender
        '
        Me.gender.Enabled = False
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.gender.Location = New System.Drawing.Point(424, 365)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(121, 21)
        Me.gender.TabIndex = 56
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.Color.Black
        Me.id.Location = New System.Drawing.Point(96, 356)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(51, 37)
        Me.id.TabIndex = 55
        Me.id.Text = "ID:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(63, 514)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 35)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "CONFIRM"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(63, 473)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 35)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "EDIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'age
        '
        Me.age.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.age.Location = New System.Drawing.Point(369, 309)
        Me.age.Name = "age"
        Me.age.ReadOnly = True
        Me.age.Size = New System.Drawing.Size(165, 39)
        Me.age.TabIndex = 51
        '
        'contact
        '
        Me.contact.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contact.Location = New System.Drawing.Point(446, 451)
        Me.contact.Name = "contact"
        Me.contact.ReadOnly = True
        Me.contact.Size = New System.Drawing.Size(336, 39)
        Me.contact.TabIndex = 46
        '
        'address
        '
        Me.address.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.Location = New System.Drawing.Point(435, 497)
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Size = New System.Drawing.Size(347, 39)
        Me.address.TabIndex = 45
        '
        'middlename
        '
        Me.middlename.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.middlename.Location = New System.Drawing.Point(504, 266)
        Me.middlename.Name = "middlename"
        Me.middlename.ReadOnly = True
        Me.middlename.Size = New System.Drawing.Size(278, 39)
        Me.middlename.TabIndex = 40
        '
        'firstname
        '
        Me.firstname.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.Location = New System.Drawing.Point(476, 220)
        Me.firstname.Name = "firstname"
        Me.firstname.ReadOnly = True
        Me.firstname.Size = New System.Drawing.Size(306, 39)
        Me.firstname.TabIndex = 39
        '
        'lastname
        '
        Me.lastname.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.Location = New System.Drawing.Point(467, 168)
        Me.lastname.Name = "lastname"
        Me.lastname.ReadOnly = True
        Me.lastname.Size = New System.Drawing.Size(315, 39)
        Me.lastname.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(39, 393)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(117, 37)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "STATUS:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(39, 356)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 37)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(301, 496)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 37)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "ADDRESS:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(301, 450)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 37)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "CONTACT:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(301, 404)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(150, 37)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "BIRTHDAY:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(301, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 37)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "GENDER:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(301, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 37)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "AGE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(301, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 37)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "MIDDLE NAME:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(301, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 37)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "FIRST NAME:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.homepage.My.Resources.Resources.profile
        Me.PictureBox1.Location = New System.Drawing.Point(46, 171)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(301, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 37)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "LAST NAME:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(181, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(558, 37)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "JOSELINA MARICAR MERCADO UNIVERSITY"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.homepage.My.Resources.Resources.Copilot_20250917_190320
        Me.PictureBox2.Location = New System.Drawing.Point(77, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(98, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'adminprfl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "adminprfl"
        Me.Size = New System.Drawing.Size(896, 575)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lastname As System.Windows.Forms.TextBox
    Friend WithEvents middlename As System.Windows.Forms.TextBox
    Friend WithEvents firstname As System.Windows.Forms.TextBox
    Friend WithEvents contact As System.Windows.Forms.TextBox
    Friend WithEvents address As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents age As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.Label
    Friend WithEvents gender As System.Windows.Forms.ComboBox
    Friend WithEvents birthday As System.Windows.Forms.DateTimePicker

End Class
