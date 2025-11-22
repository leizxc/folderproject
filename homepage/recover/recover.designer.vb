<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recover
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(recover))
        Me.lblusename = New System.Windows.Forms.Label
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.lblquestion = New System.Windows.Forms.Label
        Me.txtanswer = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.btbrecover = New System.Windows.Forms.Button
        Me.lblresult = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.confirm = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblusename
        '
        Me.lblusename.AutoSize = True
        Me.lblusename.Location = New System.Drawing.Point(203, 138)
        Me.lblusename.Name = "lblusename"
        Me.lblusename.Size = New System.Drawing.Size(55, 13)
        Me.lblusename.TabIndex = 0
        Me.lblusename.Text = "Username"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(264, 135)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(113, 20)
        Me.txtusername.TabIndex = 1
        '
        'lblquestion
        '
        Me.lblquestion.AutoSize = True
        Me.lblquestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblquestion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblquestion.Location = New System.Drawing.Point(205, 169)
        Me.lblquestion.Name = "lblquestion"
        Me.lblquestion.Size = New System.Drawing.Size(170, 21)
        Me.lblquestion.TabIndex = 2
        Me.lblquestion.Text = "dito yung security question"
        '
        'txtanswer
        '
        Me.txtanswer.AutoSize = True
        Me.txtanswer.Location = New System.Drawing.Point(216, 216)
        Me.txtanswer.Name = "txtanswer"
        Me.txtanswer.Size = New System.Drawing.Size(42, 13)
        Me.txtanswer.TabIndex = 3
        Me.txtanswer.Text = "Answer"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(264, 209)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(113, 20)
        Me.TextBox1.TabIndex = 4
        '
        'btbrecover
        '
        Me.btbrecover.Location = New System.Drawing.Point(264, 249)
        Me.btbrecover.Name = "btbrecover"
        Me.btbrecover.Size = New System.Drawing.Size(95, 19)
        Me.btbrecover.TabIndex = 5
        Me.btbrecover.Text = "Recover"
        Me.btbrecover.UseVisualStyleBackColor = True
        '
        'lblresult
        '
        Me.lblresult.AutoSize = True
        Me.lblresult.Location = New System.Drawing.Point(220, 288)
        Me.lblresult.Name = "lblresult"
        Me.lblresult.Size = New System.Drawing.Size(39, 13)
        Me.lblresult.TabIndex = 6
        Me.lblresult.Text = "Label2"
        Me.lblresult.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(473, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'confirm
        '
        Me.confirm.Location = New System.Drawing.Point(383, 135)
        Me.confirm.Name = "confirm"
        Me.confirm.Size = New System.Drawing.Size(75, 23)
        Me.confirm.TabIndex = 8
        Me.confirm.Text = "confirm"
        Me.confirm.UseVisualStyleBackColor = True
        '
        'recover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.homepage.My.Resources.Resources.company_pic
        Me.ClientSize = New System.Drawing.Size(582, 455)
        Me.Controls.Add(Me.confirm)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblresult)
        Me.Controls.Add(Me.btbrecover)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtanswer)
        Me.Controls.Add(Me.lblquestion)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.lblusename)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "recover"
        Me.Text = "recover"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblusename As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents lblquestion As System.Windows.Forms.Label
    Friend WithEvents txtanswer As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btbrecover As System.Windows.Forms.Button
    Friend WithEvents lblresult As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents confirm As System.Windows.Forms.Button
End Class
