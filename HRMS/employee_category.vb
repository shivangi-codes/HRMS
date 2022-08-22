Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.SqlClient.SqlConnection


Imports System.Globalization




Public Class frm_category
    Dim conhrms As SqlConnection = New SqlConnection("Server=LAPTOP-P94P69H7\SQLEXPRESS;Database=HRMSDB;User Id=sa;Password=qatar123;")
    Dim insert_result, del_result As Integer
    Private Sub frm_category_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_dataGrid()
    End Sub

    Private Sub Load_dataGrid()
        If conhrms.State = ConnectionState.Closed Then conhrms.Open()
        Dim mydata As New SqlDataAdapter("select * from dbo.MST_Category", conhrms)
        Dim ds As New DataSet
        mydata.Fill(ds, "category")
        DataGridView1.DataSource = ds.Tables(0)
        conhrms.Close()
        DataGridView1.ClearSelection()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        'Code for connecting table
        If btn_save.Text = "Save" Then

            If txt_catg_id.Text <> "" And txt_categ_desc.Text <> "" Then


                Try
                    If conhrms.State = ConnectionState.Closed Then conhrms.Open()

                    Dim cmdcatg As New SqlCommand
                    cmdcatg.Connection = conhrms

                    cmdcatg.Parameters.Clear()


                    cmdcatg.CommandText = ("insert into dbo.MST_Category (Emp_categ_ID,Emp_categ_Desc) values (@Emp_categ_ID,@Emp_categ_Desc) ")

                    cmdcatg.Parameters.Add("@Emp_categ_ID", SqlDbType.Int).Value = Trim(txt_catg_id.Text)
                    cmdcatg.Parameters.Add("@Emp_categ_Desc", SqlDbType.VarChar).Value = Trim(txt_categ_desc.Text)

                    insert_result = cmdcatg.ExecuteNonQuery()
                    If insert_result = 1 Then
                        MessageBox.Show("insert successfully")
                        txt_catg_id.Text = ""
                        txt_categ_desc.Text = ""
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

            If txt_catg_id.Text <> "" And txt_categ_desc.Text <> "" Then
                Dim insert_result As Integer

                Try
                    If conhrms.State = ConnectionState.Closed Then conhrms.Open()

                    Dim cmdcatg As New SqlCommand
                    cmdcatg.Connection = conhrms

                    cmdcatg.Parameters.Clear()
                    'rankId ,name 

                    cmdcatg.CommandText = ("update dbo.MST_Category set Emp_categ_ID =@Emp_categ_ID, Emp_categ_Desc=@Emp_categ_Desc where Emp_categ_ID=@Emp_categ_ID")

                    cmdcatg.Parameters.Add("@Emp_categ_ID", SqlDbType.Int).Value = Trim(txt_catg_id.Text)
                    cmdcatg.Parameters.Add("@Emp_categ_Desc", SqlDbType.VarChar).Value = Trim(txt_categ_desc.Text)

                    insert_result = cmdcatg.ExecuteNonQuery()
                    If insert_result = 1 Then
                        MessageBox.Show("updated successfully")
                        txt_catg_id.Text = ""
                        txt_categ_desc.Text = ""
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

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        'Code for retriveing table


        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        If conhrms.State = ConnectionState.Closed Then conhrms.Open()
        cmd = New SqlCommand(" select Emp_name, Emp_time  from dbo.loginregister where Emp_categ_ID ='" + txt_catg_id.Text + "'  ", conhrms)
        sdr = cmd.ExecuteReader()
        If (sdr.HasRows) Then
            While sdr.Read = True
                txt_catg_id.Text = sdr.Item("Emp_categ_ID")
                txt_categ_desc.Text = sdr.Item("Emp_categ_Desc")
            End While
            sdr.Close()
            btn_save.Text = "Update"
        Else
            MessageBox.Show("Data not found")
        End If
        conhrms.Close()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim conf As DialogResult
        conf = MessageBox.Show("Are you sure want to delete", "Confirmation", MessageBoxButtons.YesNo)

        If conf = DialogResult.Yes Then
            Try
                If conhrms.State = ConnectionState.Closed Then conhrms.Open()

                Dim cmdcatg As New SqlCommand
                cmdcatg.Connection = conhrms

                cmdcatg.Parameters.Clear()
                'rankId ,name 

                cmdcatg.CommandText = ("delete dbo.MST_Category where Emp_categ_ID= @Emp_categ_ID")

                cmdcatg.Parameters.Add("@Emp_categ_ID", SqlDbType.Int).Value = Trim(Val(txt_catg_id.Text))


                del_result = cmdcatg.ExecuteNonQuery()
                If del_result = 1 Then
                    MessageBox.Show("deleted successfully")
                    txt_catg_id.Text = ""
                    txt_categ_desc.Text = ""
                    Load_dataGrid()
                Else
                    MessageBox.Show("error")
                End If

            Catch ex As Exception
                MessageBox.Show("An error occured: " & ex.Message)
            End Try
        End If

    End Sub
End Class