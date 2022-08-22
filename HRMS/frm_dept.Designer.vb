<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_dept
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
        Me.lbl_dept_name = New System.Windows.Forms.Label()
        Me.lbl_dept_id = New System.Windows.Forms.Label()
        Me.lbl_dept_manager = New System.Windows.Forms.Label()
        Me.txt_dept_name = New System.Windows.Forms.TextBox()
        Me.txt_dept_id = New System.Windows.Forms.TextBox()
        Me.txt_dept_manager = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dept_col_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dept_colname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dept_col_manger = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_dept_name
        '
        Me.lbl_dept_name.AutoSize = True
        Me.lbl_dept_name.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_dept_name.Location = New System.Drawing.Point(57, 54)
        Me.lbl_dept_name.Name = "lbl_dept_name"
        Me.lbl_dept_name.Size = New System.Drawing.Size(161, 21)
        Me.lbl_dept_name.TabIndex = 0
        Me.lbl_dept_name.Text = "Department name:"
        '
        'lbl_dept_id
        '
        Me.lbl_dept_id.AutoSize = True
        Me.lbl_dept_id.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_dept_id.Location = New System.Drawing.Point(57, 91)
        Me.lbl_dept_id.Name = "lbl_dept_id"
        Me.lbl_dept_id.Size = New System.Drawing.Size(78, 21)
        Me.lbl_dept_id.TabIndex = 4
        Me.lbl_dept_id.Text = "Dept ID:"
        '
        'lbl_dept_manager
        '
        Me.lbl_dept_manager.AutoSize = True
        Me.lbl_dept_manager.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_dept_manager.Location = New System.Drawing.Point(57, 130)
        Me.lbl_dept_manager.Name = "lbl_dept_manager"
        Me.lbl_dept_manager.Size = New System.Drawing.Size(87, 21)
        Me.lbl_dept_manager.TabIndex = 7
        Me.lbl_dept_manager.Text = "Manager:"
        '
        'txt_dept_name
        '
        Me.txt_dept_name.Location = New System.Drawing.Point(245, 51)
        Me.txt_dept_name.Name = "txt_dept_name"
        Me.txt_dept_name.Size = New System.Drawing.Size(375, 30)
        Me.txt_dept_name.TabIndex = 8
        '
        'txt_dept_id
        '
        Me.txt_dept_id.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txt_dept_id.Location = New System.Drawing.Point(245, 88)
        Me.txt_dept_id.Name = "txt_dept_id"
        Me.txt_dept_id.Size = New System.Drawing.Size(375, 30)
        Me.txt_dept_id.TabIndex = 10
        '
        'txt_dept_manager
        '
        Me.txt_dept_manager.Location = New System.Drawing.Point(245, 127)
        Me.txt_dept_manager.Name = "txt_dept_manager"
        Me.txt_dept_manager.Size = New System.Drawing.Size(227, 30)
        Me.txt_dept_manager.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.txt_dept_manager)
        Me.GroupBox1.Controls.Add(Me.txt_dept_id)
        Me.GroupBox1.Controls.Add(Me.txt_dept_name)
        Me.GroupBox1.Controls.Add(Me.lbl_dept_manager)
        Me.GroupBox1.Controls.Add(Me.lbl_dept_id)
        Me.GroupBox1.Controls.Add(Me.lbl_dept_name)
        Me.GroupBox1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(22, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(738, 218)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Department Information"
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_edit.Location = New System.Drawing.Point(110, 262)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(124, 34)
        Me.btn_edit.TabIndex = 20
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_reset.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_reset.Location = New System.Drawing.Point(265, 262)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(124, 34)
        Me.btn_reset.TabIndex = 19
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_save.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_save.Location = New System.Drawing.Point(414, 262)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(124, 34)
        Me.btn_save.TabIndex = 18
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeight = 29
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dept_col_ID, Me.dept_colname, Me.dept_col_manger})
        Me.DataGridView1.Location = New System.Drawing.Point(49, 302)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(656, 149)
        Me.DataGridView1.TabIndex = 9
        '
        'dept_col_ID
        '
        Me.dept_col_ID.DataPropertyName = "dept_col_ID"
        Me.dept_col_ID.Frozen = True
        Me.dept_col_ID.HeaderText = "Department ID"
        Me.dept_col_ID.MinimumWidth = 6
        Me.dept_col_ID.Name = "dept_col_ID"
        Me.dept_col_ID.ReadOnly = True
        Me.dept_col_ID.Width = 200
        '
        'dept_colname
        '
        Me.dept_colname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dept_colname.DataPropertyName = "dept_col_name"
        Me.dept_colname.Frozen = True
        Me.dept_colname.HeaderText = "Department Name"
        Me.dept_colname.MinimumWidth = 6
        Me.dept_colname.Name = "dept_colname"
        Me.dept_colname.ReadOnly = True
        Me.dept_colname.Width = 200
        '
        'dept_col_manger
        '
        Me.dept_col_manger.Frozen = True
        Me.dept_col_manger.HeaderText = "Manager"
        Me.dept_col_manger.MinimumWidth = 6
        Me.dept_col_manger.Name = "dept_col_manger"
        Me.dept_col_manger.ReadOnly = True
        Me.dept_col_manger.Width = 200
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_delete.Location = New System.Drawing.Point(555, 262)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(124, 34)
        Me.btn_delete.TabIndex = 21
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'frm_dept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(864, 483)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_dept"
        Me.Text = "frm_dept"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_dept_name As Label
    Friend WithEvents lbl_dept_id As Label
    Friend WithEvents lbl_dept_manager As Label
    Friend WithEvents txt_dept_name As TextBox
    Friend WithEvents txt_dept_id As TextBox
    Friend WithEvents txt_dept_manager As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dept_col_ID As DataGridViewTextBoxColumn
    Friend WithEvents dept_colname As DataGridViewTextBoxColumn
    Friend WithEvents dept_col_manger As DataGridViewTextBoxColumn
    Friend WithEvents btn_delete As Button
End Class
