<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_employeeinfo
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
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_qdcid = New System.Windows.Forms.TextBox()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_phoneno = New System.Windows.Forms.Label()
        Me.lbl_dept = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_phoneno = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.GroupBox_info = New System.Windows.Forms.GroupBox()
        Me.lbl_pro = New System.Windows.Forms.Label()
        Me.txt_pro = New System.Windows.Forms.TextBox()
        Me.btn_r_inactive = New System.Windows.Forms.RadioButton()
        Me.btn_r_timesh = New System.Windows.Forms.RadioButton()
        Me.btn_r_all = New System.Windows.Forms.RadioButton()
        Me.btn_r_active = New System.Windows.Forms.RadioButton()
        Me.lbl_usertype = New System.Windows.Forms.Label()
        Me.date_dob = New System.Windows.Forms.DateTimePicker()
        Me.lbl_dob = New System.Windows.Forms.Label()
        Me.txt_fullname = New System.Windows.Forms.TextBox()
        Me.txtcombo_category = New System.Windows.Forms.ComboBox()
        Me.lbl_category = New System.Windows.Forms.Label()
        Me.lbl_position = New System.Windows.Forms.Label()
        Me.txtcombo_position = New System.Windows.Forms.ComboBox()
        Me.txtcombo_dept = New System.Windows.Forms.ComboBox()
        Me.txtcombo_designation = New System.Windows.Forms.ComboBox()
        Me.lbl_designation = New System.Windows.Forms.Label()
        Me.lbl_fullname = New System.Windows.Forms.Label()
        Me.lbl_qdcid = New System.Windows.Forms.Label()
        Me.txt_staffid = New System.Windows.Forms.TextBox()
        Me.lbl_staffid = New System.Windows.Forms.Label()
        Me.GroupBox_contactinfo = New System.Windows.Forms.GroupBox()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.Groupbox_passinfo = New System.Windows.Forms.GroupBox()
        Me.date_pass_e = New System.Windows.Forms.DateTimePicker()
        Me.lbl_pass_e = New System.Windows.Forms.Label()
        Me.date_pass_i = New System.Windows.Forms.DateTimePicker()
        Me.lbl_pass_i = New System.Windows.Forms.Label()
        Me.lbl_nationality = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nationality = New System.Windows.Forms.TextBox()
        Me.txt_pass_num = New System.Windows.Forms.TextBox()
        Me.lbl_passnum = New System.Windows.Forms.Label()
        Me.Groupbox_qid = New System.Windows.Forms.GroupBox()
        Me.date_QID_e = New System.Windows.Forms.DateTimePicker()
        Me.lbl_qid_e = New System.Windows.Forms.Label()
        Me.date_QID_i = New System.Windows.Forms.DateTimePicker()
        Me.lbl_qid_i = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_qid = New System.Windows.Forms.TextBox()
        Me.lbl_qid = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Date_hc_e = New System.Windows.Forms.DateTimePicker()
        Me.lbl_hc_e = New System.Windows.Forms.Label()
        Me.Date_hc_i = New System.Windows.Forms.DateTimePicker()
        Me.lbl_hc_i = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_hc_num = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Emp_info_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_info_qdcid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_info_nationality = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_info_dept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_info_pro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_info_categ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_info_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox_info.SuspendLayout()
        Me.GroupBox_contactinfo.SuspendLayout()
        Me.Groupbox_passinfo.SuspendLayout()
        Me.Groupbox_qid.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_name.Location = New System.Drawing.Point(45, 46)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(64, 21)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "Name:"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(173, 43)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(295, 30)
        Me.txt_name.TabIndex = 2
        '
        'txt_qdcid
        '
        Me.txt_qdcid.Location = New System.Drawing.Point(173, 88)
        Me.txt_qdcid.Name = "txt_qdcid"
        Me.txt_qdcid.Size = New System.Drawing.Size(220, 30)
        Me.txt_qdcid.TabIndex = 3
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_email.Location = New System.Drawing.Point(61, 38)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(63, 21)
        Me.lbl_email.TabIndex = 7
        Me.lbl_email.Text = "Email:"
        '
        'lbl_phoneno
        '
        Me.lbl_phoneno.AutoSize = True
        Me.lbl_phoneno.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_phoneno.Location = New System.Drawing.Point(60, 67)
        Me.lbl_phoneno.Name = "lbl_phoneno"
        Me.lbl_phoneno.Size = New System.Drawing.Size(95, 21)
        Me.lbl_phoneno.TabIndex = 8
        Me.lbl_phoneno.Text = "Phone No."
        '
        'lbl_dept
        '
        Me.lbl_dept.AutoSize = True
        Me.lbl_dept.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_dept.Location = New System.Drawing.Point(46, 222)
        Me.lbl_dept.Name = "lbl_dept"
        Me.lbl_dept.Size = New System.Drawing.Size(112, 21)
        Me.lbl_dept.TabIndex = 11
        Me.lbl_dept.Text = "Department:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(203, 29)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(297, 30)
        Me.txt_email.TabIndex = 12
        '
        'txt_phoneno
        '
        Me.txt_phoneno.Location = New System.Drawing.Point(203, 64)
        Me.txt_phoneno.Name = "txt_phoneno"
        Me.txt_phoneno.Size = New System.Drawing.Size(191, 30)
        Me.txt_phoneno.TabIndex = 16
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_save.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_save.Location = New System.Drawing.Point(594, 831)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(124, 34)
        Me.btn_save.TabIndex = 18
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_edit.Location = New System.Drawing.Point(287, 831)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(124, 34)
        Me.btn_edit.TabIndex = 19
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_refresh
        '
        Me.btn_refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_refresh.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_refresh.Location = New System.Drawing.Point(447, 831)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(124, 34)
        Me.btn_refresh.TabIndex = 20
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_close.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_close.Location = New System.Drawing.Point(895, 831)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(124, 34)
        Me.btn_close.TabIndex = 21
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'GroupBox_info
        '
        Me.GroupBox_info.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox_info.Controls.Add(Me.lbl_pro)
        Me.GroupBox_info.Controls.Add(Me.txt_pro)
        Me.GroupBox_info.Controls.Add(Me.btn_r_inactive)
        Me.GroupBox_info.Controls.Add(Me.btn_r_timesh)
        Me.GroupBox_info.Controls.Add(Me.btn_r_all)
        Me.GroupBox_info.Controls.Add(Me.btn_r_active)
        Me.GroupBox_info.Controls.Add(Me.lbl_usertype)
        Me.GroupBox_info.Controls.Add(Me.date_dob)
        Me.GroupBox_info.Controls.Add(Me.lbl_dob)
        Me.GroupBox_info.Controls.Add(Me.txt_fullname)
        Me.GroupBox_info.Controls.Add(Me.txtcombo_category)
        Me.GroupBox_info.Controls.Add(Me.lbl_category)
        Me.GroupBox_info.Controls.Add(Me.lbl_position)
        Me.GroupBox_info.Controls.Add(Me.txtcombo_position)
        Me.GroupBox_info.Controls.Add(Me.txtcombo_dept)
        Me.GroupBox_info.Controls.Add(Me.txtcombo_designation)
        Me.GroupBox_info.Controls.Add(Me.lbl_designation)
        Me.GroupBox_info.Controls.Add(Me.lbl_fullname)
        Me.GroupBox_info.Controls.Add(Me.lbl_qdcid)
        Me.GroupBox_info.Controls.Add(Me.txt_staffid)
        Me.GroupBox_info.Controls.Add(Me.lbl_staffid)
        Me.GroupBox_info.Controls.Add(Me.lbl_dept)
        Me.GroupBox_info.Controls.Add(Me.txt_qdcid)
        Me.GroupBox_info.Controls.Add(Me.txt_name)
        Me.GroupBox_info.Controls.Add(Me.lbl_name)
        Me.GroupBox_info.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox_info.ForeColor = System.Drawing.Color.Black
        Me.GroupBox_info.Location = New System.Drawing.Point(5, 17)
        Me.GroupBox_info.Name = "GroupBox_info"
        Me.GroupBox_info.Size = New System.Drawing.Size(602, 563)
        Me.GroupBox_info.TabIndex = 22
        Me.GroupBox_info.TabStop = False
        Me.GroupBox_info.Text = "Employee Information"
        '
        'lbl_pro
        '
        Me.lbl_pro.AutoSize = True
        Me.lbl_pro.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_pro.Location = New System.Drawing.Point(46, 426)
        Me.lbl_pro.Name = "lbl_pro"
        Me.lbl_pro.Size = New System.Drawing.Size(101, 21)
        Me.lbl_pro.TabIndex = 38
        Me.lbl_pro.Text = "Profession:"
        '
        'txt_pro
        '
        Me.txt_pro.Location = New System.Drawing.Point(173, 426)
        Me.txt_pro.Name = "txt_pro"
        Me.txt_pro.Size = New System.Drawing.Size(291, 30)
        Me.txt_pro.TabIndex = 37
        '
        'btn_r_inactive
        '
        Me.btn_r_inactive.AutoSize = True
        Me.btn_r_inactive.Location = New System.Drawing.Point(369, 473)
        Me.btn_r_inactive.Name = "btn_r_inactive"
        Me.btn_r_inactive.Size = New System.Drawing.Size(99, 26)
        Me.btn_r_inactive.TabIndex = 36
        Me.btn_r_inactive.TabStop = True
        Me.btn_r_inactive.Text = "Inactive"
        Me.btn_r_inactive.UseVisualStyleBackColor = True
        '
        'btn_r_timesh
        '
        Me.btn_r_timesh.AutoSize = True
        Me.btn_r_timesh.Location = New System.Drawing.Point(173, 505)
        Me.btn_r_timesh.Name = "btn_r_timesh"
        Me.btn_r_timesh.Size = New System.Drawing.Size(166, 26)
        Me.btn_r_timesh.TabIndex = 35
        Me.btn_r_timesh.TabStop = True
        Me.btn_r_timesh.Text = "Time Sheet user"
        Me.btn_r_timesh.UseVisualStyleBackColor = True
        '
        'btn_r_all
        '
        Me.btn_r_all.AutoSize = True
        Me.btn_r_all.Location = New System.Drawing.Point(367, 505)
        Me.btn_r_all.Name = "btn_r_all"
        Me.btn_r_all.Size = New System.Drawing.Size(56, 26)
        Me.btn_r_all.TabIndex = 34
        Me.btn_r_all.TabStop = True
        Me.btn_r_all.Text = "All"
        Me.btn_r_all.UseVisualStyleBackColor = True
        '
        'btn_r_active
        '
        Me.btn_r_active.AutoSize = True
        Me.btn_r_active.Location = New System.Drawing.Point(173, 473)
        Me.btn_r_active.Name = "btn_r_active"
        Me.btn_r_active.Size = New System.Drawing.Size(83, 26)
        Me.btn_r_active.TabIndex = 33
        Me.btn_r_active.TabStop = True
        Me.btn_r_active.Text = "Active"
        Me.btn_r_active.UseVisualStyleBackColor = True
        '
        'lbl_usertype
        '
        Me.lbl_usertype.AutoSize = True
        Me.lbl_usertype.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_usertype.Location = New System.Drawing.Point(46, 478)
        Me.lbl_usertype.Name = "lbl_usertype"
        Me.lbl_usertype.Size = New System.Drawing.Size(97, 21)
        Me.lbl_usertype.TabIndex = 32
        Me.lbl_usertype.Text = "User Type:"
        '
        'date_dob
        '
        Me.date_dob.Location = New System.Drawing.Point(173, 382)
        Me.date_dob.Name = "date_dob"
        Me.date_dob.Size = New System.Drawing.Size(291, 30)
        Me.date_dob.TabIndex = 31
        '
        'lbl_dob
        '
        Me.lbl_dob.AutoSize = True
        Me.lbl_dob.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_dob.Location = New System.Drawing.Point(46, 388)
        Me.lbl_dob.Name = "lbl_dob"
        Me.lbl_dob.Size = New System.Drawing.Size(54, 21)
        Me.lbl_dob.TabIndex = 30
        Me.lbl_dob.Text = "DOB:"
        '
        'txt_fullname
        '
        Me.txt_fullname.Location = New System.Drawing.Point(173, 135)
        Me.txt_fullname.Name = "txt_fullname"
        Me.txt_fullname.Size = New System.Drawing.Size(291, 30)
        Me.txt_fullname.TabIndex = 19
        '
        'txtcombo_category
        '
        Me.txtcombo_category.FormattingEnabled = True
        Me.txtcombo_category.Location = New System.Drawing.Point(173, 345)
        Me.txtcombo_category.Name = "txtcombo_category"
        Me.txtcombo_category.Size = New System.Drawing.Size(260, 30)
        Me.txtcombo_category.TabIndex = 29
        '
        'lbl_category
        '
        Me.lbl_category.AutoSize = True
        Me.lbl_category.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_category.Location = New System.Drawing.Point(46, 345)
        Me.lbl_category.Name = "lbl_category"
        Me.lbl_category.Size = New System.Drawing.Size(87, 21)
        Me.lbl_category.TabIndex = 28
        Me.lbl_category.Text = "Category:"
        '
        'lbl_position
        '
        Me.lbl_position.AutoSize = True
        Me.lbl_position.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_position.Location = New System.Drawing.Point(46, 309)
        Me.lbl_position.Name = "lbl_position"
        Me.lbl_position.Size = New System.Drawing.Size(82, 21)
        Me.lbl_position.TabIndex = 27
        Me.lbl_position.Text = "Position:"
        '
        'txtcombo_position
        '
        Me.txtcombo_position.FormattingEnabled = True
        Me.txtcombo_position.Location = New System.Drawing.Point(173, 306)
        Me.txtcombo_position.Name = "txtcombo_position"
        Me.txtcombo_position.Size = New System.Drawing.Size(260, 30)
        Me.txtcombo_position.TabIndex = 26
        '
        'txtcombo_dept
        '
        Me.txtcombo_dept.FormattingEnabled = True
        Me.txtcombo_dept.Items.AddRange(New Object() {"Finance", "IT", "Human Resource ", "Marketing", "Administration"})
        Me.txtcombo_dept.Location = New System.Drawing.Point(173, 219)
        Me.txtcombo_dept.Name = "txtcombo_dept"
        Me.txtcombo_dept.Size = New System.Drawing.Size(260, 30)
        Me.txtcombo_dept.TabIndex = 25
        '
        'txtcombo_designation
        '
        Me.txtcombo_designation.FormattingEnabled = True
        Me.txtcombo_designation.Items.AddRange(New Object() {"Engg.", "Analyst", "Head", "Director"})
        Me.txtcombo_designation.Location = New System.Drawing.Point(173, 261)
        Me.txtcombo_designation.Name = "txtcombo_designation"
        Me.txtcombo_designation.Size = New System.Drawing.Size(260, 30)
        Me.txtcombo_designation.TabIndex = 24
        '
        'lbl_designation
        '
        Me.lbl_designation.AutoSize = True
        Me.lbl_designation.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_designation.Location = New System.Drawing.Point(46, 264)
        Me.lbl_designation.Name = "lbl_designation"
        Me.lbl_designation.Size = New System.Drawing.Size(112, 21)
        Me.lbl_designation.TabIndex = 23
        Me.lbl_designation.Text = "Designation:"
        '
        'lbl_fullname
        '
        Me.lbl_fullname.AutoSize = True
        Me.lbl_fullname.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_fullname.Location = New System.Drawing.Point(45, 138)
        Me.lbl_fullname.Name = "lbl_fullname"
        Me.lbl_fullname.Size = New System.Drawing.Size(97, 21)
        Me.lbl_fullname.TabIndex = 22
        Me.lbl_fullname.Text = "Full name:"
        '
        'lbl_qdcid
        '
        Me.lbl_qdcid.AutoSize = True
        Me.lbl_qdcid.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_qdcid.Location = New System.Drawing.Point(45, 88)
        Me.lbl_qdcid.Name = "lbl_qdcid"
        Me.lbl_qdcid.Size = New System.Drawing.Size(78, 21)
        Me.lbl_qdcid.TabIndex = 21
        Me.lbl_qdcid.Text = "QDC ID:"
        '
        'txt_staffid
        '
        Me.txt_staffid.Location = New System.Drawing.Point(173, 178)
        Me.txt_staffid.Name = "txt_staffid"
        Me.txt_staffid.Size = New System.Drawing.Size(220, 30)
        Me.txt_staffid.TabIndex = 20
        '
        'lbl_staffid
        '
        Me.lbl_staffid.AutoSize = True
        Me.lbl_staffid.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_staffid.Location = New System.Drawing.Point(46, 181)
        Me.lbl_staffid.Name = "lbl_staffid"
        Me.lbl_staffid.Size = New System.Drawing.Size(77, 21)
        Me.lbl_staffid.TabIndex = 18
        Me.lbl_staffid.Text = "Staff ID:"
        '
        'GroupBox_contactinfo
        '
        Me.GroupBox_contactinfo.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox_contactinfo.Controls.Add(Me.txt_phoneno)
        Me.GroupBox_contactinfo.Controls.Add(Me.lbl_email)
        Me.GroupBox_contactinfo.Controls.Add(Me.txt_email)
        Me.GroupBox_contactinfo.Controls.Add(Me.lbl_phoneno)
        Me.GroupBox_contactinfo.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox_contactinfo.Location = New System.Drawing.Point(617, 17)
        Me.GroupBox_contactinfo.Name = "GroupBox_contactinfo"
        Me.GroupBox_contactinfo.Size = New System.Drawing.Size(584, 109)
        Me.GroupBox_contactinfo.TabIndex = 23
        Me.GroupBox_contactinfo.TabStop = False
        Me.GroupBox_contactinfo.Text = "Contact Information"
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_new.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_new.Location = New System.Drawing.Point(137, 831)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(124, 34)
        Me.btn_new.TabIndex = 25
        Me.btn_new.Text = "New"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_print
        '
        Me.btn_print.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_print.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_print.Location = New System.Drawing.Point(744, 831)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(124, 34)
        Me.btn_print.TabIndex = 26
        Me.btn_print.Text = "Print"
        Me.btn_print.UseVisualStyleBackColor = False
        '
        'Groupbox_passinfo
        '
        Me.Groupbox_passinfo.BackColor = System.Drawing.Color.MistyRose
        Me.Groupbox_passinfo.Controls.Add(Me.date_pass_e)
        Me.Groupbox_passinfo.Controls.Add(Me.lbl_pass_e)
        Me.Groupbox_passinfo.Controls.Add(Me.date_pass_i)
        Me.Groupbox_passinfo.Controls.Add(Me.lbl_pass_i)
        Me.Groupbox_passinfo.Controls.Add(Me.lbl_nationality)
        Me.Groupbox_passinfo.Controls.Add(Me.Label7)
        Me.Groupbox_passinfo.Controls.Add(Me.txt_nationality)
        Me.Groupbox_passinfo.Controls.Add(Me.txt_pass_num)
        Me.Groupbox_passinfo.Controls.Add(Me.lbl_passnum)
        Me.Groupbox_passinfo.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Groupbox_passinfo.ForeColor = System.Drawing.Color.Black
        Me.Groupbox_passinfo.Location = New System.Drawing.Point(617, 132)
        Me.Groupbox_passinfo.Name = "Groupbox_passinfo"
        Me.Groupbox_passinfo.Size = New System.Drawing.Size(584, 221)
        Me.Groupbox_passinfo.TabIndex = 27
        Me.Groupbox_passinfo.TabStop = False
        Me.Groupbox_passinfo.Text = "Passport Information"
        '
        'date_pass_e
        '
        Me.date_pass_e.Location = New System.Drawing.Point(217, 165)
        Me.date_pass_e.Name = "date_pass_e"
        Me.date_pass_e.Size = New System.Drawing.Size(292, 30)
        Me.date_pass_e.TabIndex = 33
        '
        'lbl_pass_e
        '
        Me.lbl_pass_e.AutoSize = True
        Me.lbl_pass_e.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_pass_e.Location = New System.Drawing.Point(60, 171)
        Me.lbl_pass_e.Name = "lbl_pass_e"
        Me.lbl_pass_e.Size = New System.Drawing.Size(126, 21)
        Me.lbl_pass_e.TabIndex = 32
        Me.lbl_pass_e.Text = "Date of expiry:"
        '
        'date_pass_i
        '
        Me.date_pass_i.Location = New System.Drawing.Point(217, 123)
        Me.date_pass_i.Name = "date_pass_i"
        Me.date_pass_i.Size = New System.Drawing.Size(292, 30)
        Me.date_pass_i.TabIndex = 31
        '
        'lbl_pass_i
        '
        Me.lbl_pass_i.AutoSize = True
        Me.lbl_pass_i.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_pass_i.Location = New System.Drawing.Point(60, 129)
        Me.lbl_pass_i.Name = "lbl_pass_i"
        Me.lbl_pass_i.Size = New System.Drawing.Size(118, 21)
        Me.lbl_pass_i.TabIndex = 30
        Me.lbl_pass_i.Text = "Date of issue:"
        '
        'lbl_nationality
        '
        Me.lbl_nationality.AutoSize = True
        Me.lbl_nationality.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_nationality.Location = New System.Drawing.Point(60, 86)
        Me.lbl_nationality.Name = "lbl_nationality"
        Me.lbl_nationality.Size = New System.Drawing.Size(105, 21)
        Me.lbl_nationality.TabIndex = 21
        Me.lbl_nationality.Text = "Nationality:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(60, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 21)
        Me.Label7.TabIndex = 18
        '
        'txt_nationality
        '
        Me.txt_nationality.Location = New System.Drawing.Point(219, 76)
        Me.txt_nationality.Name = "txt_nationality"
        Me.txt_nationality.Size = New System.Drawing.Size(220, 30)
        Me.txt_nationality.TabIndex = 3
        '
        'txt_pass_num
        '
        Me.txt_pass_num.Location = New System.Drawing.Point(219, 40)
        Me.txt_pass_num.Name = "txt_pass_num"
        Me.txt_pass_num.Size = New System.Drawing.Size(220, 30)
        Me.txt_pass_num.TabIndex = 2
        '
        'lbl_passnum
        '
        Me.lbl_passnum.AutoSize = True
        Me.lbl_passnum.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_passnum.Location = New System.Drawing.Point(60, 43)
        Me.lbl_passnum.Name = "lbl_passnum"
        Me.lbl_passnum.Size = New System.Drawing.Size(153, 21)
        Me.lbl_passnum.TabIndex = 0
        Me.lbl_passnum.Text = "Passport number:"
        '
        'Groupbox_qid
        '
        Me.Groupbox_qid.BackColor = System.Drawing.Color.MistyRose
        Me.Groupbox_qid.Controls.Add(Me.date_QID_e)
        Me.Groupbox_qid.Controls.Add(Me.lbl_qid_e)
        Me.Groupbox_qid.Controls.Add(Me.date_QID_i)
        Me.Groupbox_qid.Controls.Add(Me.lbl_qid_i)
        Me.Groupbox_qid.Controls.Add(Me.Label4)
        Me.Groupbox_qid.Controls.Add(Me.txt_qid)
        Me.Groupbox_qid.Controls.Add(Me.lbl_qid)
        Me.Groupbox_qid.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Groupbox_qid.ForeColor = System.Drawing.Color.Black
        Me.Groupbox_qid.Location = New System.Drawing.Point(617, 359)
        Me.Groupbox_qid.Name = "Groupbox_qid"
        Me.Groupbox_qid.Size = New System.Drawing.Size(584, 221)
        Me.Groupbox_qid.TabIndex = 28
        Me.Groupbox_qid.TabStop = False
        Me.Groupbox_qid.Text = "Qatar ID details"
        '
        'date_QID_e
        '
        Me.date_QID_e.Location = New System.Drawing.Point(218, 120)
        Me.date_QID_e.Name = "date_QID_e"
        Me.date_QID_e.Size = New System.Drawing.Size(291, 30)
        Me.date_QID_e.TabIndex = 33
        '
        'lbl_qid_e
        '
        Me.lbl_qid_e.AutoSize = True
        Me.lbl_qid_e.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_qid_e.Location = New System.Drawing.Point(61, 120)
        Me.lbl_qid_e.Name = "lbl_qid_e"
        Me.lbl_qid_e.Size = New System.Drawing.Size(126, 21)
        Me.lbl_qid_e.TabIndex = 32
        Me.lbl_qid_e.Text = "Date of expiry:"
        '
        'date_QID_i
        '
        Me.date_QID_i.Location = New System.Drawing.Point(218, 81)
        Me.date_QID_i.Name = "date_QID_i"
        Me.date_QID_i.Size = New System.Drawing.Size(291, 30)
        Me.date_QID_i.TabIndex = 31
        '
        'lbl_qid_i
        '
        Me.lbl_qid_i.AutoSize = True
        Me.lbl_qid_i.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_qid_i.Location = New System.Drawing.Point(61, 81)
        Me.lbl_qid_i.Name = "lbl_qid_i"
        Me.lbl_qid_i.Size = New System.Drawing.Size(118, 21)
        Me.lbl_qid_i.TabIndex = 30
        Me.lbl_qid_i.Text = "Date of issue:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(46, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 18
        '
        'txt_qid
        '
        Me.txt_qid.Location = New System.Drawing.Point(220, 40)
        Me.txt_qid.Name = "txt_qid"
        Me.txt_qid.Size = New System.Drawing.Size(248, 30)
        Me.txt_qid.TabIndex = 2
        '
        'lbl_qid
        '
        Me.lbl_qid.AutoSize = True
        Me.lbl_qid.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_qid.Location = New System.Drawing.Point(61, 43)
        Me.lbl_qid.Name = "lbl_qid"
        Me.lbl_qid.Size = New System.Drawing.Size(49, 21)
        Me.lbl_qid.TabIndex = 0
        Me.lbl_qid.Text = "QID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MistyRose
        Me.GroupBox1.Controls.Add(Me.Date_hc_e)
        Me.GroupBox1.Controls.Add(Me.lbl_hc_e)
        Me.GroupBox1.Controls.Add(Me.Date_hc_i)
        Me.GroupBox1.Controls.Add(Me.lbl_hc_i)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_hc_num)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Garamond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(617, 586)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 221)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Health card details"
        '
        'Date_hc_e
        '
        Me.Date_hc_e.Location = New System.Drawing.Point(218, 120)
        Me.Date_hc_e.Name = "Date_hc_e"
        Me.Date_hc_e.Size = New System.Drawing.Size(291, 30)
        Me.Date_hc_e.TabIndex = 33
        '
        'lbl_hc_e
        '
        Me.lbl_hc_e.AutoSize = True
        Me.lbl_hc_e.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_hc_e.Location = New System.Drawing.Point(61, 129)
        Me.lbl_hc_e.Name = "lbl_hc_e"
        Me.lbl_hc_e.Size = New System.Drawing.Size(126, 21)
        Me.lbl_hc_e.TabIndex = 32
        Me.lbl_hc_e.Text = "Date of expiry:"
        '
        'Date_hc_i
        '
        Me.Date_hc_i.Location = New System.Drawing.Point(218, 81)
        Me.Date_hc_i.Name = "Date_hc_i"
        Me.Date_hc_i.Size = New System.Drawing.Size(291, 30)
        Me.Date_hc_i.TabIndex = 31
        '
        'lbl_hc_i
        '
        Me.lbl_hc_i.AutoSize = True
        Me.lbl_hc_i.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_hc_i.Location = New System.Drawing.Point(61, 87)
        Me.lbl_hc_i.Name = "lbl_hc_i"
        Me.lbl_hc_i.Size = New System.Drawing.Size(118, 21)
        Me.lbl_hc_i.TabIndex = 30
        Me.lbl_hc_i.Text = "Date of issue:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(46, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 21)
        Me.Label3.TabIndex = 18
        '
        'txt_hc_num
        '
        Me.txt_hc_num.Location = New System.Drawing.Point(220, 40)
        Me.txt_hc_num.Name = "txt_hc_num"
        Me.txt_hc_num.Size = New System.Drawing.Size(248, 30)
        Me.txt_hc_num.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(60, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Health card no.:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Emp_info_name, Me.Emp_info_qdcid, Me.Emp_info_nationality, Me.Emp_info_dept, Me.Emp_info_pro, Me.Emp_info_categ, Me.Emp_info_email})
        Me.DataGridView1.Location = New System.Drawing.Point(5, 881)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(1196, 174)
        Me.DataGridView1.TabIndex = 30
        '
        'Emp_info_name
        '
        Me.Emp_info_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Emp_info_name.DataPropertyName = "Emp_name"
        Me.Emp_info_name.HeaderText = "Name"
        Me.Emp_info_name.MinimumWidth = 6
        Me.Emp_info_name.Name = "Emp_info_name"
        Me.Emp_info_name.ReadOnly = True
        '
        'Emp_info_qdcid
        '
        Me.Emp_info_qdcid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Emp_info_qdcid.DataPropertyName = "Emp_qdc_id"
        Me.Emp_info_qdcid.HeaderText = "QDC ID"
        Me.Emp_info_qdcid.MinimumWidth = 6
        Me.Emp_info_qdcid.Name = "Emp_info_qdcid"
        Me.Emp_info_qdcid.ReadOnly = True
        '
        'Emp_info_nationality
        '
        Me.Emp_info_nationality.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Emp_info_nationality.DataPropertyName = "Emp_nationality"
        Me.Emp_info_nationality.HeaderText = "Nationality"
        Me.Emp_info_nationality.MinimumWidth = 6
        Me.Emp_info_nationality.Name = "Emp_info_nationality"
        Me.Emp_info_nationality.ReadOnly = True
        '
        'Emp_info_dept
        '
        Me.Emp_info_dept.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Emp_info_dept.DataPropertyName = "Emp_dept"
        Me.Emp_info_dept.HeaderText = "Department"
        Me.Emp_info_dept.MinimumWidth = 6
        Me.Emp_info_dept.Name = "Emp_info_dept"
        Me.Emp_info_dept.ReadOnly = True
        '
        'Emp_info_pro
        '
        Me.Emp_info_pro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Emp_info_pro.DataPropertyName = "Emp_profession"
        Me.Emp_info_pro.HeaderText = "Profession"
        Me.Emp_info_pro.MinimumWidth = 6
        Me.Emp_info_pro.Name = "Emp_info_pro"
        Me.Emp_info_pro.ReadOnly = True
        '
        'Emp_info_categ
        '
        Me.Emp_info_categ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Emp_info_categ.DataPropertyName = "Emp_category"
        Me.Emp_info_categ.HeaderText = "Category"
        Me.Emp_info_categ.MinimumWidth = 6
        Me.Emp_info_categ.Name = "Emp_info_categ"
        Me.Emp_info_categ.ReadOnly = True
        '
        'Emp_info_email
        '
        Me.Emp_info_email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Emp_info_email.DataPropertyName = "Emp_email"
        Me.Emp_info_email.HeaderText = "Email"
        Me.Emp_info_email.MinimumWidth = 6
        Me.Emp_info_email.Name = "Emp_info_email"
        Me.Emp_info_email.ReadOnly = True
        '
        'frm_employeeinfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1469, 1055)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Groupbox_qid)
        Me.Controls.Add(Me.Groupbox_passinfo)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.GroupBox_info)
        Me.Controls.Add(Me.GroupBox_contactinfo)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_save)
        Me.Name = "frm_employeeinfo"
        Me.Text = "frm_employeeinfo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox_info.ResumeLayout(False)
        Me.GroupBox_info.PerformLayout()
        Me.GroupBox_contactinfo.ResumeLayout(False)
        Me.GroupBox_contactinfo.PerformLayout()
        Me.Groupbox_passinfo.ResumeLayout(False)
        Me.Groupbox_passinfo.PerformLayout()
        Me.Groupbox_qid.ResumeLayout(False)
        Me.Groupbox_qid.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_name As Label
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_qdcid As TextBox
    Friend WithEvents lbl_email As Label
    Friend WithEvents lbl_phoneno As Label
    Friend WithEvents lbl_dept As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_phoneno As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_refresh As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents GroupBox_info As GroupBox
    Friend WithEvents GroupBox_contactinfo As GroupBox
    Friend WithEvents txt_staffid As TextBox
    Friend WithEvents txt_fullname As TextBox
    Friend WithEvents lbl_staffid As Label
    Friend WithEvents btn_new As Button
    Friend WithEvents lbl_fullname As Label
    Friend WithEvents lbl_qdcid As Label
    Friend WithEvents btn_print As Button
    Friend WithEvents lbl_designation As Label
    Friend WithEvents lbl_position As Label
    Friend WithEvents txtcombo_position As ComboBox
    Friend WithEvents txtcombo_dept As ComboBox
    Friend WithEvents txtcombo_designation As ComboBox
    Friend WithEvents lbl_category As Label
    Friend WithEvents txtcombo_category As ComboBox
    Friend WithEvents lbl_dob As Label
    Friend WithEvents date_dob As DateTimePicker
    Friend WithEvents Groupbox_passinfo As GroupBox
    Friend WithEvents date_pass_i As DateTimePicker
    Friend WithEvents lbl_pass_i As Label
    Friend WithEvents lbl_nationality As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_nationality As TextBox
    Friend WithEvents txt_pass_num As TextBox
    Friend WithEvents lbl_passnum As Label
    Friend WithEvents date_pass_e As DateTimePicker
    Friend WithEvents lbl_pass_e As Label
    Friend WithEvents Groupbox_qid As GroupBox
    Friend WithEvents date_QID_e As DateTimePicker
    Friend WithEvents lbl_qid_e As Label
    Friend WithEvents date_QID_i As DateTimePicker
    Friend WithEvents lbl_qid_i As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_qid As TextBox
    Friend WithEvents lbl_qid As Label
    Friend WithEvents btn_r_inactive As RadioButton
    Friend WithEvents btn_r_timesh As RadioButton
    Friend WithEvents btn_r_all As RadioButton
    Friend WithEvents btn_r_active As RadioButton
    Friend WithEvents lbl_usertype As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Date_hc_e As DateTimePicker
    Friend WithEvents lbl_hc_e As Label
    Friend WithEvents Date_hc_i As DateTimePicker
    Friend WithEvents lbl_hc_i As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_hc_num As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_pro As Label
    Friend WithEvents txt_pro As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Emp_info_name As DataGridViewTextBoxColumn
    Friend WithEvents Emp_info_qdcid As DataGridViewTextBoxColumn
    Friend WithEvents Emp_info_nationality As DataGridViewTextBoxColumn
    Friend WithEvents Emp_info_dept As DataGridViewTextBoxColumn
    Friend WithEvents Emp_info_pro As DataGridViewTextBoxColumn
    Friend WithEvents Emp_info_categ As DataGridViewTextBoxColumn
    Friend WithEvents Emp_info_email As DataGridViewTextBoxColumn
End Class
