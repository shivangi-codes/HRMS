
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.SqlClient.SqlConnection
Imports System.Globalization



Public Class frm_dept
    Dim conhrms As SqlConnection = New SqlConnection("Server=LAPTOP-P94P69H7\SQLEXPRESS;Database=HRMSDB;User Id=sa;Password=qatar123;")
    Dim insert_result, del_result As Integer
    Private Sub frm_dept_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_dataGrid()
    End Sub

    Private Sub Load_dataGrid()
        If conhrms.State = ConnectionState.Closed Then conhrms.Open()
        Dim mydata As New SqlDataAdapter("select * from dbo.department", conhrms)
        Dim ds As New DataSet
        mydata.Fill(ds, "department")
        DataGridView1.DataSource = ds.Tables(0)
        conhrms.Close()
        DataGridView1.ClearSelection()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        If conhrms.State = ConnectionState.Closed Then conhrms.Open()
        cmd = New SqlCommand(" select dept_id, dept_name, manger from dbo.department where dept_id ='" + txt_dept_id.Text + "'  ", conhrms)
        sdr = cmd.ExecuteReader()
        If (sdr.HasRows) Then
            While sdr.Read = True
                txt_dept_id.Text = sdr.Item("dept_id")
                txt_dept_name.Text = sdr.Item("dept_name")
                txt_dept_manager.Text = sdr.Item("manager")
            End While
            sdr.Close()
            btn_save.Text = "Update"
        Else
            MessageBox.Show("Data not found")
        End If
        conhrms.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click


        Dim conf As DialogResult
        conf = MessageBox.Show("Are you sure want to delete", "Confirmation", MessageBoxButtons.YesNo)

        If conf = DialogResult.Yes Then
            Try
                If conhrms.State = ConnectionState.Closed Then conhrms.Open()

                Dim cmdprofession As New SqlCommand
                cmdprofession.Connection = conhrms

                cmdprofession.Parameters.Clear()


                cmdprofession.CommandText = ("delete dbo.MST_Category where Emp_categ_ID= @Emp_categ_ID")

                cmdprofession.Parameters.Add("@Emp_categ_ID", SqlDbType.Int).Value = Trim(Val(txt_dept_id.Text))


                del_result = cmdprofession.ExecuteNonQuery()
                If del_result = 1 Then
                    MessageBox.Show("deleted successfully")
                    txt_dept_id.Text = ""
                    txt_dept_name.Text = ""
                    txt_dept_manager.Text = ""
                    Load_dataGrid()
                Else
                    MessageBox.Show("error")
                End If

            Catch ex As Exception
                MessageBox.Show("An error occured: " & ex.Message)
            End Try
        End If

    End Sub


    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click


        If txt_dept_id.Text <> "" And txt_dept_manager.Text <> "" And txt_dept_name.Text <> "" Then
            Dim insert_result As Integer

            Try
                If conhrms.State = ConnectionState.Closed Then conhrms.Open()

                Dim cmddept As New SqlCommand
                cmddept.Connection = conhrms

                cmddept.Parameters.Clear()
                'dept_name, dept_id, manager

                cmddept.CommandText = ("insert into dbo.department (dept_name, dept_id, manager) values (@dept_name,@dept_id,@manager)")

                cmddept.Parameters.Add("@dept_id", SqlDbType.Int).Value = Trim(txt_dept_id.Text)
                cmddept.Parameters.Add("@dept_name", SqlDbType.VarChar).Value = Trim(txt_dept_name.Text)
                cmddept.Parameters.Add("@manager", SqlDbType.VarChar).Value = Trim(txt_dept_manager.Text)


                insert_result = cmddept.ExecuteNonQuery()
                If insert_result = 1 Then
                    MessageBox.Show("insert successfully")
                    txt_dept_id.Text = ""
                    txt_dept_name.Text = ""
                    txt_dept_manager.Text = ""
                Else
                    MessageBox.Show("error")
                End If

            Catch ex As Exception
                MessageBox.Show("An error occured: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please enter department name", "Information", MessageBoxButtons.OK)
        End If
    End Sub
End Class