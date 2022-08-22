Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.SqlClient.SqlConnection
Imports System.Globalization




Public Class frm_employeeinfo
    Dim conhrms As SqlConnection = New SqlConnection("Server=LAPTOP-P94P69H7\SQLEXPRESS;Database=HRMSDB;User Id=sa;Password=qatar123;")
    Dim insert_result, del_result As Integer



    Private Sub frm_employeeinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_dataGrid()
    End Sub

    Private Sub Load_dataGrid()

        If conhrms.State = ConnectionState.Closed Then conhrms.Open()
        Dim mydata As New SqlDataAdapter("select Emp_name, Emp_qdc_id, Emp_dept, Emp_category, Emp_profession, Emp_profession, Emp_email, Emp_nationality from dbo.info", conhrms)
        Dim ds As New DataSet
        mydata.Fill(ds, "Employee Information")
        DataGridView1.DataSource = ds.Tables(0)
        conhrms.Close()
        DataGridView1.ClearSelection()

    End Sub







    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click


    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If btn_save.Text = "Save" Then

            If txt_name.Text <> "" And txt_qdcid.Text <> "" And txt_nationality.Text <> "" And txtcombo_dept.Text <> "" And txtcombo_designation.Text <> "" And txtcombo_category.Text <> "" And txt_pro.Text <> "" And txt_email.Text <> "" Then


                Try
                    If conhrms.State = ConnectionState.Closed Then conhrms.Open()

                    Dim cmdinfo As New SqlCommand
                    cmdinfo.Connection = conhrms

                    cmdinfo.Parameters.Clear()

                    cmdinfo.CommandText = ("insert into dbo.info (Emp_name, Emp_qdc_id, Emp_nationality, Emp_name, Emp_dept, Emp_designation, Emp_category, Emp_profession, Emp_email) values (@Emp_name, @Emp_qdc_id, @Emp_nationality, @Emp_name, @Emp_dept, @Emp_designation, @Emp_category, @Emp_profession, @Emp_email")

                    cmdinfo.Parameters.Add("@Emp_name", SqlDbType.Int).Value = Trim(txt_name.Text)
                    cmdinfo.Parameters.Add("@Emp_qdc_id", SqlDbType.VarChar).Value = Trim(txt_qdcid.Text)
                    cmdinfo.Parameters.Add("@Emp_nationality", SqlDbType.VarChar).Value = Trim(txt_nationality.Text)
                    cmdinfo.Parameters.Add("@Emp_dept", SqlDbType.VarChar).Value = Trim(txtcombo_dept.Text)
                    cmdinfo.Parameters.Add("@Emp_Emp_designation", SqlDbType.VarChar).Value = Trim(txtcombo_designation.Text)
                    cmdinfo.Parameters.Add("@Emp_category", SqlDbType.VarChar).Value = Trim(txtcombo_category.Text)
                    cmdinfo.Parameters.Add("@Emp_profession", SqlDbType.VarChar).Value = Trim(txt_pro.Text)
                    cmdinfo.Parameters.Add("@Emp_email", SqlDbType.VarChar).Value = Trim(txt_email.Text)

                    insert_result = cmdinfo.ExecuteNonQuery()
                    If insert_result = 1 Then
                        MessageBox.Show("insert successfully")


                        txt_name.Text = ""
                        txt_qdcid.Text = ""
                        txt_nationality.Text = ""
                        txtcombo_dept.Text = ""
                        txtcombo_designation.Text = ""
                        txtcombo_category.Text = ""
                        txt_pro.Text = ""
                        txt_email.Text = ""



                        Load_dataGrid()
                    Else
                        MessageBox.Show("error")
                    End If

                Catch ex As Exception
                    MessageBox.Show("An error occured: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Please enter designation name", "Information", MessageBoxButtons.OK)
            End If
        ElseIf btn_save.Text = "Update" Then

            If txt_name.Text <> "" And txt_qdcid.Text <> "" And txt_nationality.Text <> "" And txtcombo_dept.Text <> "" And txtcombo_designation.Text <> "" And txtcombo_category.Text <> "" And txt_pro.Text <> "" And txt_email.Text <> "" Then
                Dim insert_result As Integer

                Try
                    If conhrms.State = ConnectionState.Closed Then conhrms.Open()

                    Dim cmdinfo As New SqlCommand
                    cmdinfo.Connection = conhrms

                    cmdinfo.Parameters.Clear()


                    cmdinfo.CommandText = ("update dbo.info set Emp_name = @Emp_name, Emp_qdc_id= @Emp_qdc_id, Emp_nationality= @Emp_nationality, Emp_dept= @Emp_dept, Emp_profession= @Emp_profession, Emp_category= @Emp_category, Emp_email= @Emp_email where Emp_qdc_id= @Emp_qdc_id")

                    cmdinfo.Parameters.Add("@Emp_name", SqlDbType.Int).Value = Trim(txt_name.Text)
                    cmdinfo.Parameters.Add("@Emp_qdc_id", SqlDbType.VarChar).Value = Trim(txt_qdcid.Text)
                    cmdinfo.Parameters.Add("@Emp_nationality", SqlDbType.VarChar).Value = Trim(txt_nationality.Text)
                    cmdinfo.Parameters.Add("@Emp_dept", SqlDbType.VarChar).Value = Trim(txtcombo_dept.Text)
                    cmdinfo.Parameters.Add("@Emp_profession", SqlDbType.VarChar).Value = Trim(txt_pro.Text)
                    cmdinfo.Parameters.Add("@Emp_category", SqlDbType.VarChar).Value = Trim(txtcombo_category.Text)
                    cmdinfo.Parameters.Add("@Emp_email", SqlDbType.VarChar).Value = Trim(txt_email.Text)




                    insert_result = cmdinfo.ExecuteNonQuery()
                    If insert_result = 1 Then
                        MessageBox.Show("updated successfully")

                        txt_name.Text = ""
                        txt_qdcid.Text = ""
                        txt_nationality.Text = ""
                        txtcombo_dept.Text = ""
                        txtcombo_designation.Text = ""
                        txtcombo_category.Text = ""
                        txt_pro.Text = ""
                        txt_email.Text = ""
                        Load_dataGrid()
                    Else
                        MessageBox.Show("error")
                    End If

                Catch ex As Exception
                    MessageBox.Show("An error occured: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Please enter category name", "Information", MessageBoxButtons.OK)
            End If




        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Load_staff_data()
    End Sub


    Private Sub Load_staff_data()
        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        If conhrms.State = ConnectionState.Closed Then conhrms.Open()
        cmd = New SqlCommand(" select * from dbo.info where Emp_qdc_id ='" + DataGridView1.CurrentRow.Cells(1).Value + "'  ", conhrms)
        sdr = cmd.ExecuteReader()
        If (sdr.HasRows) Then
            While sdr.Read = True
                'txt_catg_id.Text = sdr.Item("Emp_categ_ID")
                'txt_categ_desc.Text = sdr.Item("Emp_categ_Desc")



            End While
            sdr.Close()
            'btn_save.Text = "Update"
        Else
            MessageBox.Show("Data not found")
        End If
        conhrms.Close()
    End Sub
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        If conhrms.State = ConnectionState.Closed Then conhrms.Open()
        cmd = New SqlCommand(" select Emp_name ,Emp_qdc_id, Emp_nationality, Emp_dept, Emp_profession, Emp_category, Emp_email from dbo.info  where Emp_qdc_id ='" + txt_qdcid.Text + "'  ", conhrms)
        sdr = cmd.ExecuteReader()
                        If (sdr.HasRows) Then
                            While sdr.Read = True
                                txt_name.Text = sdr.Item("Emp_name")
                                txt_qdcid.Text = sdr.Item("Emp_qdc_id")
                                txt_nationality.Text = sdr.Item("Emp_nationality")
                                txtcombo_dept.Text = sdr.Item(" Emp_dept")
                                txt_pro.Text = sdr.Item(" Emp_profession")
                                txtcombo_category.Text = sdr.Item("Emp_category")
                                txt_email.Text = sdr.Item("Emp_email")


                            End While
                            sdr.Close()
                            btn_save.Text = "Update"
                        Else
                            MessageBox.Show("Data not found")
                        End If
                        conhrms.Close()
    End Sub
End Class