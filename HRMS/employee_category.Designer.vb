<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_category
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
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_catg_id = New System.Windows.Forms.TextBox()
        Me.lbl_catg_id = New System.Windows.Forms.Label()
        Me.txt_categ_desc = New System.Windows.Forms.TextBox()
        Me.groupbox_category = New System.Windows.Forms.GroupBox()
        Me.lbl_catg_desc = New System.Windows.Forms.Label()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categ_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.groupbox_category.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_save.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_save.Location = New System.Drawing.Point(350, 291)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(124, 34)
        Me.btn_save.TabIndex = 4
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'txt_catg_id
        '
        Me.txt_catg_id.Location = New System.Drawing.Point(205, 85)
        Me.txt_catg_id.Name = "txt_catg_id"
        Me.txt_catg_id.Size = New System.Drawing.Size(199, 30)
        Me.txt_catg_id.TabIndex = 2
        '
        'lbl_catg_id
        '
        Me.lbl_catg_id.AutoSize = True
        Me.lbl_catg_id.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_catg_id.Location = New System.Drawing.Point(48, 88)
        Me.lbl_catg_id.Name = "lbl_catg_id"
        Me.lbl_catg_id.Size = New System.Drawing.Size(36, 21)
        Me.lbl_catg_id.TabIndex = 3
        Me.lbl_catg_id.Text = "ID:"
        '
        'txt_categ_desc
        '
        Me.txt_categ_desc.Location = New System.Drawing.Point(205, 121)
        Me.txt_categ_desc.Name = "txt_categ_desc"
        Me.txt_categ_desc.Size = New System.Drawing.Size(342, 30)
        Me.txt_categ_desc.TabIndex = 1
        '
        'groupbox_category
        '
        Me.groupbox_category.BackColor = System.Drawing.Color.MistyRose
        Me.groupbox_category.Controls.Add(Me.lbl_catg_desc)
        Me.groupbox_category.Controls.Add(Me.lbl_catg_id)
        Me.groupbox_category.Controls.Add(Me.txt_catg_id)
        Me.groupbox_category.Controls.Add(Me.txt_categ_desc)
        Me.groupbox_category.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.groupbox_category.Location = New System.Drawing.Point(55, 17)
        Me.groupbox_category.Name = "groupbox_category"
        Me.groupbox_category.Size = New System.Drawing.Size(578, 228)
        Me.groupbox_category.TabIndex = 5
        Me.groupbox_category.TabStop = False
        Me.groupbox_category.Text = "Employee Category"
        '
        'lbl_catg_desc
        '
        Me.lbl_catg_desc.AutoSize = True
        Me.lbl_catg_desc.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_catg_desc.Location = New System.Drawing.Point(48, 128)
        Me.lbl_catg_desc.Name = "lbl_catg_desc"
        Me.lbl_catg_desc.Size = New System.Drawing.Size(87, 21)
        Me.lbl_catg_desc.TabIndex = 5
        Me.lbl_catg_desc.Text = "Category:"
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_reset.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_reset.Location = New System.Drawing.Point(206, 291)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(124, 34)
        Me.btn_reset.TabIndex = 6
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_edit.Location = New System.Drawing.Point(67, 291)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(124, 34)
        Me.btn_edit.TabIndex = 7
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_delete.Location = New System.Drawing.Point(501, 291)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(124, 34)
        Me.btn_delete.TabIndex = 8
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Categ_des})
        Me.DataGridView1.Location = New System.Drawing.Point(48, 355)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(585, 149)
        Me.DataGridView1.TabIndex = 9
        '
        'ID
        '
        Me.ID.DataPropertyName = "Emp_categ_ID"
        Me.ID.HeaderText = "Catg ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 125
        '
        'Categ_des
        '
        Me.Categ_des.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Categ_des.DataPropertyName = "Emp_categ_Desc"
        Me.Categ_des.HeaderText = "Description"
        Me.Categ_des.MinimumWidth = 6
        Me.Categ_des.Name = "Categ_des"
        Me.Categ_des.ReadOnly = True
        '
        'frm_category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(733, 533)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.groupbox_category)
        Me.Name = "frm_category"
        Me.Text = "employee_category"
        Me.groupbox_category.ResumeLayout(False)
        Me.groupbox_category.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_save As Button
    Friend WithEvents txt_catg_id As TextBox
    Friend WithEvents lbl_catg_id As Label
    Friend WithEvents txt_categ_desc As TextBox
    Friend WithEvents groupbox_category As GroupBox
    Friend WithEvents lbl_catg_desc As Label
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Categ_des As DataGridViewTextBoxColumn
End Class
