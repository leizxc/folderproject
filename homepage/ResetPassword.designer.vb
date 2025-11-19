<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResetPassword
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblResetStatus = New System.Windows.Forms.Label
        Me.txtNewPassword = New System.Windows.Forms.TextBox
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox
        Me.btnSaveNewPassword = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.btnSaveNewPassword)
        Me.GroupBox1.Controls.Add(Me.txtConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.txtNewPassword)
        Me.GroupBox1.Controls.Add(Me.lblResetStatus)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(157, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 343)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Set new Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Confirm Password"
        '
        'lblResetStatus
        '
        Me.lblResetStatus.AutoSize = True
        Me.lblResetStatus.Location = New System.Drawing.Point(59, 217)
        Me.lblResetStatus.Name = "lblResetStatus"
        Me.lblResetStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblResetStatus.TabIndex = 2
        Me.lblResetStatus.Text = "Label3"
        Me.lblResetStatus.Visible = False
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(128, 86)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPassword.TabIndex = 3
        Me.txtNewPassword.UseSystemPasswordChar = True
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Location = New System.Drawing.Point(128, 147)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtConfirmPassword.TabIndex = 4
        Me.txtConfirmPassword.UseSystemPasswordChar = True
        '
        'btnSaveNewPassword
        '
        Me.btnSaveNewPassword.Location = New System.Drawing.Point(96, 182)
        Me.btnSaveNewPassword.Name = "btnSaveNewPassword"
        Me.btnSaveNewPassword.Size = New System.Drawing.Size(132, 23)
        Me.btnSaveNewPassword.TabIndex = 5
        Me.btnSaveNewPassword.Text = "Save New Password"
        Me.btnSaveNewPassword.UseVisualStyleBackColor = True
        '
        'ResetPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.homepage.My.Resources.Resources.company_pic
        Me.ClientSize = New System.Drawing.Size(582, 455)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ResetPassword"
        Me.Text = "ResetPassword"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveNewPassword As System.Windows.Forms.Button
    Friend WithEvents txtConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblResetStatus As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
