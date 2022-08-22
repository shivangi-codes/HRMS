<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nationality
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
        Me.lbl_emp_nationality = New System.Windows.Forms.Label()
        Me.lbl_emp_qid = New System.Windows.Forms.Label()
        Me.GroupBox_nationality = New System.Windows.Forms.GroupBox()
        Me.txt_qaid = New System.Windows.Forms.TextBox()
        Me.txt_emp_nationality = New System.Windows.Forms.TextBox()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_QID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.GroupBox_nationality.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_emp_nationality
        '
        Me.lbl_emp_nationality.AutoSize = True
        Me.lbl_emp_nationality.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_emp_nationality.Location = New System.Drawing.Point(77, 64)
        Me.lbl_emp_nationality.Name = "lbl_emp_nationality"
        Me.lbl_emp_nationality.Size = New System.Drawing.Size(105, 21)
        Me.lbl_emp_nationality.TabIndex = 0
        Me.lbl_emp_nationality.Text = "Nationality:"
        '
        'lbl_emp_qid
        '
        Me.lbl_emp_qid.AutoSize = True
        Me.lbl_emp_qid.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_emp_qid.Location = New System.Drawing.Point(77, 107)
        Me.lbl_emp_qid.Name = "lbl_emp_qid"
        Me.lbl_emp_qid.Size = New System.Drawing.Size(84, 21)
        Me.lbl_emp_qid.TabIndex = 1
        Me.lbl_emp_qid.Text = "Qatar ID:"
        '
        'GroupBox_nationality
        '
        Me.GroupBox_nationality.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox_nationality.Controls.Add(Me.txt_qaid)
        Me.GroupBox_nationality.Controls.Add(Me.txt_emp_nationality)
        Me.GroupBox_nationality.Controls.Add(Me.lbl_emp_qid)
        Me.GroupBox_nationality.Controls.Add(Me.lbl_emp_nationality)
        Me.GroupBox_nationality.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox_nationality.Location = New System.Drawing.Point(57, 22)
        Me.GroupBox_nationality.Name = "GroupBox_nationality"
        Me.GroupBox_nationality.Size = New System.Drawing.Size(597, 190)
        Me.GroupBox_nationality.TabIndex = 5
        Me.GroupBox_nationality.TabStop = False
        Me.GroupBox_nationality.Text = "Employee Nationality"
        '
        'txt_qaid
        '
        Me.txt_qaid.Location = New System.Drawing.Point(194, 104)
        Me.txt_qaid.Name = "txt_qaid"
        Me.txt_qaid.Size = New System.Drawing.Size(220, 30)
        Me.txt_qaid.TabIndex = 3
        '
        'txt_emp_nationality
        '
        Me.txt_emp_nationality.Location = New System.Drawing.Point(194, 64)
        Me.txt_emp_nationality.Name = "txt_emp_nationality"
        Me.txt_emp_nationality.Size = New System.Drawing.Size(220, 30)
        Me.txt_emp_nationality.TabIndex = 2
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_edit.Location = New System.Drawing.Point(82, 255)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(124, 34)
        Me.btn_edit.TabIndex = 10
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_reset.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_reset.Location = New System.Drawing.Point(221, 255)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(124, 34)
        Me.btn_reset.TabIndex = 9
        Me.btn_reset.Text = "Reset"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_save.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_save.Location = New System.Drawing.Point(365, 255)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(124, 34)
        Me.btn_save.TabIndex = 8
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Emp_QID})
        Me.DataGridView1.Location = New System.Drawing.Point(57, 304)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(597, 149)
        Me.DataGridView1.TabIndex = 11
        '
        'ID
        '
        Me.ID.DataPropertyName = "Emp_nationality"
        Me.ID.HeaderText = "Nationality"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 125
        '
        'Emp_QID
        '
        Me.Emp_QID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Emp_QID.DataPropertyName = "Emp_categ_Desc"
        Me.Emp_QID.HeaderText = "Qatar ID"
        Me.Emp_QID.MinimumWidth = 6
        Me.Emp_QID.Name = "Emp_QID"
        Me.Emp_QID.ReadOnly = True
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_delete.Location = New System.Drawing.Point(514, 255)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(124, 34)
        Me.btn_delete.TabIndex = 12
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'frm_nationality
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 536)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox_nationality)
        Me.Name = "frm_nationality"
        Me.Text = "frm_nationality"
        Me.GroupBox_nationality.ResumeLayout(False)
        Me.GroupBox_nationality.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_emp_nationality As Label
    Friend WithEvents lbl_emp_qid As Label
    Friend WithEvents GroupBox_nationality As GroupBox
    Friend WithEvents txt_qaid As TextBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Emp_QID As DataGridViewTextBoxColumn
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_emp_nationality As TextBox
End Class
