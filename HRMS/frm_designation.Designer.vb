<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_designation
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.groupbox_category = New System.Windows.Forms.GroupBox()
        Me.lbl_desig = New System.Windows.Forms.Label()
        Me.lbl_desig_id = New System.Windows.Forms.Label()
        Me.txt_desig_id = New System.Windows.Forms.TextBox()
        Me.txt_desig = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Designation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbox_category.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Designation})
        Me.DataGridView1.Location = New System.Drawing.Point(63, 336)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(585, 149)
        Me.DataGridView1.TabIndex = 15
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_delete.Location = New System.Drawing.Point(513, 272)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(124, 34)
        Me.btn_delete.TabIndex = 14
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_edit.Location = New System.Drawing.Point(79, 272)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(124, 34)
        Me.btn_edit.TabIndex = 13
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_reset.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_reset.Location = New System.Drawing.Point(218, 272)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(124, 34)
        Me.btn_reset.TabIndex = 12
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_save.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_save.Location = New System.Drawing.Point(362, 272)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(124, 34)
        Me.btn_save.TabIndex = 10
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'groupbox_category
        '
        Me.groupbox_category.BackColor = System.Drawing.Color.MistyRose
        Me.groupbox_category.Controls.Add(Me.lbl_desig)
        Me.groupbox_category.Controls.Add(Me.lbl_desig_id)
        Me.groupbox_category.Controls.Add(Me.txt_desig_id)
        Me.groupbox_category.Controls.Add(Me.txt_desig)
        Me.groupbox_category.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.groupbox_category.Location = New System.Drawing.Point(63, 31)
        Me.groupbox_category.Name = "groupbox_category"
        Me.groupbox_category.Size = New System.Drawing.Size(578, 204)
        Me.groupbox_category.TabIndex = 11
        Me.groupbox_category.TabStop = False
        Me.groupbox_category.Text = "Employee Category"
        '
        'lbl_desig
        '
        Me.lbl_desig.AutoSize = True
        Me.lbl_desig.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_desig.Location = New System.Drawing.Point(48, 128)
        Me.lbl_desig.Name = "lbl_desig"
        Me.lbl_desig.Size = New System.Drawing.Size(112, 21)
        Me.lbl_desig.TabIndex = 5
        Me.lbl_desig.Text = "Designation:"
        '
        'lbl_desig_id
        '
        Me.lbl_desig_id.AutoSize = True
        Me.lbl_desig_id.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_desig_id.Location = New System.Drawing.Point(48, 88)
        Me.lbl_desig_id.Name = "lbl_desig_id"
        Me.lbl_desig_id.Size = New System.Drawing.Size(120, 21)
        Me.lbl_desig_id.TabIndex = 3
        Me.lbl_desig_id.Text = "Employee ID:"
        '
        'txt_desig_id
        '
        Me.txt_desig_id.Location = New System.Drawing.Point(205, 85)
        Me.txt_desig_id.Name = "txt_desig_id"
        Me.txt_desig_id.Size = New System.Drawing.Size(199, 30)
        Me.txt_desig_id.TabIndex = 2
        '
        'txt_desig
        '
        Me.txt_desig.Location = New System.Drawing.Point(205, 121)
        Me.txt_desig.Name = "txt_desig"
        Me.txt_desig.Size = New System.Drawing.Size(342, 30)
        Me.txt_desig.TabIndex = 1
        '
        'ID
        '
        Me.ID.DataPropertyName = "Emp_desig_ID"
        Me.ID.HeaderText = "Employee ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 125
        '
        'Designation
        '
        Me.Designation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Designation.DataPropertyName = "Emp_desig"
        Me.Designation.HeaderText = "Designation"
        Me.Designation.MinimumWidth = 6
        Me.Designation.Name = "Designation"
        Me.Designation.ReadOnly = True
        '
        'frm_designation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(741, 506)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.groupbox_category)
        Me.Name = "frm_designation"
        Me.Text = "frm_designation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox_category.ResumeLayout(False)
        Me.groupbox_category.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents groupbox_category As GroupBox
    Friend WithEvents lbl_desig As Label
    Friend WithEvents lbl_desig_id As Label
    Friend WithEvents txt_desig_id As TextBox
    Friend WithEvents txt_desig As TextBox
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Designation As DataGridViewTextBoxColumn
End Class
