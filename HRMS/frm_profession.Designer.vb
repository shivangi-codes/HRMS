<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_profession
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
        Me.lbl_pro_empid = New System.Windows.Forms.Label()
        Me.lbl_pro_name = New System.Windows.Forms.Label()
        Me.txt_pro_empid = New System.Windows.Forms.TextBox()
        Me.txt_pro_name = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_profession = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_pro_empid
        '
        Me.lbl_pro_empid.AutoSize = True
        Me.lbl_pro_empid.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_pro_empid.Location = New System.Drawing.Point(49, 60)
        Me.lbl_pro_empid.Name = "lbl_pro_empid"
        Me.lbl_pro_empid.Size = New System.Drawing.Size(120, 21)
        Me.lbl_pro_empid.TabIndex = 0
        Me.lbl_pro_empid.Text = "Employee ID:"
        '
        'lbl_pro_name
        '
        Me.lbl_pro_name.AutoSize = True
        Me.lbl_pro_name.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_pro_name.Location = New System.Drawing.Point(49, 105)
        Me.lbl_pro_name.Name = "lbl_pro_name"
        Me.lbl_pro_name.Size = New System.Drawing.Size(101, 21)
        Me.lbl_pro_name.TabIndex = 1
        Me.lbl_pro_name.Text = "Profession:"
        '
        'txt_pro_empid
        '
        Me.txt_pro_empid.Location = New System.Drawing.Point(184, 53)
        Me.txt_pro_empid.Name = "txt_pro_empid"
        Me.txt_pro_empid.Size = New System.Drawing.Size(255, 30)
        Me.txt_pro_empid.TabIndex = 4
        '
        'txt_pro_name
        '
        Me.txt_pro_name.Location = New System.Drawing.Point(184, 98)
        Me.txt_pro_name.Name = "txt_pro_name"
        Me.txt_pro_name.Size = New System.Drawing.Size(255, 30)
        Me.txt_pro_name.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.txt_pro_name)
        Me.GroupBox1.Controls.Add(Me.txt_pro_empid)
        Me.GroupBox1.Controls.Add(Me.lbl_pro_name)
        Me.GroupBox1.Controls.Add(Me.lbl_pro_empid)
        Me.GroupBox1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(80, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 207)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profession"
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_edit.Location = New System.Drawing.Point(106, 281)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(124, 34)
        Me.btn_edit.TabIndex = 16
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(252, 281)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 34)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_save.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_save.Location = New System.Drawing.Point(395, 281)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(124, 34)
        Me.btn_save.TabIndex = 14
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Emp_profession})
        Me.DataGridView1.Location = New System.Drawing.Point(80, 330)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(585, 149)
        Me.DataGridView1.TabIndex = 17
        '
        'ID
        '
        Me.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ID.DataPropertyName = "Emp_categ_ID"
        Me.ID.HeaderText = "Employee ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'Emp_profession
        '
        Me.Emp_profession.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Emp_profession.DataPropertyName = "Emp_categ_Desc"
        Me.Emp_profession.HeaderText = "Profession"
        Me.Emp_profession.MinimumWidth = 6
        Me.Emp_profession.Name = "Emp_profession"
        Me.Emp_profession.ReadOnly = True
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_delete.Location = New System.Drawing.Point(541, 281)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(124, 34)
        Me.btn_delete.TabIndex = 18
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'frm_profession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(780, 573)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_profession"
        Me.Text = "frm_profession"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_pro_empid As Label
    Friend WithEvents lbl_pro_name As Label
    Friend WithEvents txt_pro_empid As TextBox
    Friend WithEvents txt_pro_name As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_delete As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Emp_profession As DataGridViewTextBoxColumn
End Class
