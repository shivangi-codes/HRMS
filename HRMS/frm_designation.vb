Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.SqlClient.SqlConnection
Imports System.Globalization




Public Class frm_designation
    Dim conhrms As SqlConnection = New SqlConnection("Server=LAPTOP-P94P69H7\SQLEXPRESS;Database=HRMSDB;User Id=sa;Password=qatar123;")
    Dim insert_result, del_result As Integer
    Private Sub frm_designation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_dataGrid()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If btn_save.Text = "Save" Then

            If txt_desig_id.Text <> "" And txt_desig.Text <> "" Then


                Try
                    If conhrms.State = ConnectionState.Closed Then conhrms.Open()

                    Dim cmddesig As New SqlCommand
                    cmddesig.Connection = conhrms

                    cmddesig.Parameters.Clear()


                    cmddesig.CommandText = ("insert into dbo.designation (Employee_ID, designation) values (@Employee_ID,@designation) ")

                    cmddesig.Parameters.Add("@Employee_ID", SqlDbType.Int).Value = Trim(txt_desig_id.Text)
                    cmddesig.Parameters.Add("@designation", SqlDbType.VarChar).Value = Trim(txt_desig.Text)

                    insert_result = cmddesig.ExecuteNonQuery()
                    If insert_result = 1 Then
                        MessageBox.Show("insert successfully")
                        txt_desig_id.Text = ""
                        txt_desig.Text = ""
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

            If txt_desig_id.Text <> "" And txt_desig.Text <> "" Then
                Dim insert_result As Integer

                Try
                    If conhrms.State = ConnectionState.Closed Then conhrms.Open()

                    Dim cmddesig As New SqlCommand
                    cmddesig.Connection = conhrms

                    cmddesig.Parameters.Clear()


                    cmddesig.CommandText = ("update dbo.designation set Employee_ID =@Employee_ID, designation= @designation where Employee_ID= @Employee_ID")

                    cmddesig.Parameters.Add("@Employee_ID", SqlDbType.Int).Value = Trim(txt_desig_id.Text)
                    cmddesig.Parameters.Add("@designation", SqlDbType.VarChar).Value = Trim(txt_desig.Text)

                    insert_result = cmddesig.ExecuteNonQuery()
                    If insert_result = 1 Then
                        MessageBox.Show("updated successfully")
                        txt_desig_id.Text = ""
                        txt_desig.Text = ""
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




        End If

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        If conhrms.State = ConnectionState.Closed Then conhrms.Open()
        cmd = New SqlCommand(" select Employee_ID,designation from dbo.designation where Employee_ID ='" + txt_desig_id.Text + "'  ", conhrms)
        sdr = cmd.ExecuteReader()
        If (sdr.HasRows) Then
            While sdr.Read = True
                txt_desig_id.Text = sdr.Item("Employee_ID")
                txt_desig.Text = sdr.Item("designation")
            End While
            sdr.Close()
            btn_save.Text = "Update"
        Else
            MessageBox.Show("Data not found")
        End If
        conhrms.Close()
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        'Me.reset()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim conf As DialogResult
        conf = MessageBox.Show("Are you sure want to delete", "Confirmation", MessageBoxButtons.YesNo)

        If conf = DialogResult.Yes Then
            Try
                If conhrms.State = ConnectionState.Closed Then conhrms.Open()

                Dim cmddesig As New SqlCommand
                cmddesig.Connection = conhrms

                cmddesig.Parameters.Clear()
                'rankId ,name 

                cmddesig.CommandText = ("delete dbo.designation where Employee_ID= @Employee_ID")

                cmddesig.Parameters.Add("@Employee_ID", SqlDbType.Int).Value = Trim(Val(txt_desig_id.Text))


                del_result = cmddesig.ExecuteNonQuery()
                If del_result = 1 Then
                    MessageBox.Show("deleted successfully")
                    txt_desig.Text = ""
                    txt_desig_id.Text = ""
                    Load_dataGrid()
                Else
                    MessageBox.Show("error")
                End If

            Catch ex As Exception
                MessageBox.Show("An error occured: " & ex.Message)
            End Try
        End If

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








End Class