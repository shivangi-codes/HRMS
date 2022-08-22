<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_signupvb
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
        Me.btn_signup = New System.Windows.Forms.Button()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.lbl_heading = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_signup
        '
        Me.btn_signup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_signup.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_signup.Location = New System.Drawing.Point(295, 292)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(171, 57)
        Me.btn_signup.TabIndex = 21
        Me.btn_signup.Text = "SIGN UP"
        Me.btn_signup.UseVisualStyleBackColor = False
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(312, 211)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(266, 27)
        Me.txt_password.TabIndex = 19
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.White
        Me.txt_username.Location = New System.Drawing.Point(312, 169)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(266, 27)
        Me.txt_username.TabIndex = 18
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.Color.Black
        Me.lbl_password.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_password.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_password.Location = New System.Drawing.Point(180, 211)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(112, 26)
        Me.lbl_password.TabIndex = 17
        Me.lbl_password.Text = "Password:"
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.BackColor = System.Drawing.Color.Black
        Me.lbl_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_login.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_login.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_login.Location = New System.Drawing.Point(180, 171)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(118, 26)
        Me.lbl_login.TabIndex = 16
        Me.lbl_login.Text = "Username:"
        '
        'lbl_heading
        '
        Me.lbl_heading.AutoSize = True
        Me.lbl_heading.BackColor = System.Drawing.Color.Black
        Me.lbl_heading.Font = New System.Drawing.Font("Lucida Bright", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_heading.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_heading.Location = New System.Drawing.Point(83, 90)
        Me.lbl_heading.Name = "lbl_heading"
        Me.lbl_heading.Size = New System.Drawing.Size(634, 31)
        Me.lbl_heading.TabIndex = 15
        Me.lbl_heading.Text = "HUMAN RESOURCE MANAGEMENT SYSTEM"
        '
        'frm_signupvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HRMS.My.Resources.Resources.what_makes_human_resource_managemnt_system
        Me.ClientSize = New System.Drawing.Size(780, 427)
        Me.Controls.Add(Me.btn_signup)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.lbl_heading)
        Me.Name = "frm_signupvb"
        Me.Text = "frm_signupvb"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_signup As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_heading As Label
End Class
