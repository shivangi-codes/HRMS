<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmlogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_heading = New System.Windows.Forms.Label()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_signup = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_heading
        '
        Me.lbl_heading.AutoSize = True
        Me.lbl_heading.BackColor = System.Drawing.Color.Black
        Me.lbl_heading.Font = New System.Drawing.Font("Lucida Bright", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_heading.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_heading.Location = New System.Drawing.Point(42, 62)
        Me.lbl_heading.Name = "lbl_heading"
        Me.lbl_heading.Size = New System.Drawing.Size(634, 31)
        Me.lbl_heading.TabIndex = 0
        Me.lbl_heading.Text = "HUMAN RESOURCE MANAGEMENT SYSTEM"
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.BackColor = System.Drawing.Color.Black
        Me.lbl_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_login.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_login.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_login.Location = New System.Drawing.Point(139, 143)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(118, 26)
        Me.lbl_login.TabIndex = 1
        Me.lbl_login.Text = "Username:"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.Color.Black
        Me.lbl_password.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_password.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_password.Location = New System.Drawing.Point(139, 183)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(112, 26)
        Me.lbl_password.TabIndex = 2
        Me.lbl_password.Text = "Password:"
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.White
        Me.txt_username.Location = New System.Drawing.Point(271, 141)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(266, 27)
        Me.txt_username.TabIndex = 3
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(271, 183)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(266, 27)
        Me.txt_password.TabIndex = 4
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_login.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_login.Location = New System.Drawing.Point(356, 276)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(171, 57)
        Me.btn_login.TabIndex = 13
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'btn_signup
        '
        Me.btn_signup.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_signup.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_signup.Location = New System.Drawing.Point(356, 396)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(171, 42)
        Me.btn_signup.TabIndex = 14
        Me.btn_signup.Text = "SIGN UP"
        Me.btn_signup.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(164, 276)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 57)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Garamond", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(193, 404)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 26)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "New Member?"
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.HRMS.My.Resources.Resources.what_makes_human_resource_managemnt_system
        Me.ClientSize = New System.Drawing.Size(729, 485)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_signup)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.lbl_heading)
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HRMS LOGIN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_heading As Label
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_login As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents txt_username As TextBox
    Friend WithEvents btn_signup As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
