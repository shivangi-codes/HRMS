Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.SqlClient.SqlConnection
Imports System.Globalization



Public Class frm_profession
    Dim conhrms As SqlConnection = New SqlConnection("Server=LAPTOP-P94P69H7\SQLEXPRESS;Database=HRMSDB;User Id=sa;Password=qatar123;")
    Dim insert_result, del_result As Integer


    Private Sub frm_profession_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_dataGrid()
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
                'rankId ,name 

                cmdprofession.CommandText = ("delete dbo.profession where Employee ID= @Employee ID")

                cmdprofession.Parameters.Add("@Employee ID", SqlDbType.Int).Value = Trim(Val(txt_pro_empid.Text))


                del_result = cmdprofession.ExecuteNonQuery()
                If del_result = 1 Then
                    MessageBox.Show("deleted successfully")
                    txt_pro_empid.Text = ""
                    txt_pro_name.Text = ""
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
        Dim mydata As New SqlDataAdapter("select * from dbo.profession", conhrms)
        Dim ds As New DataSet
        mydata.Fill(ds, "profession")
        DataGridView1.DataSource = ds.Tables(0)
        conhrms.Close()
        DataGridView1.ClearSelection()
    End Sub





    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click


        If btn_save.Text = "Save" Then

            If txt_pro_empid.Text <> "" And txt_pro_name.Text <> "" Then


                Try
                    If conhrms.State = ConnectionState.Closed Then conhrms.Open()

                    Dim cmdprofession As New SqlCommand
                    cmdprofession.Connection = conhrms

                    cmdprofession.Parameters.Clear()
                    'rankId ,name 

                    cmdprofession.CommandText = ("insert into dbo.profession (profession,Employee ID) values (@profession,@Employee ID) ")

                    cmdprofession.Parameters.Add("@profession", SqlDbType.Int).Value = Trim(txt_pro_name.Text)
                    cmdprofession.Parameters.Add("@Employee ID", SqlDbType.VarChar).Value = Trim(txt_pro_empid.Text)

                    insert_result = cmdprofession.ExecuteNonQuery()
                    If insert_result = 1 Then
                        MessageBox.Show("insert successfully")
                        txt_pro_empid.Text = ""
                        txt_pro_name.Text = ""
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

            If txt_pro_empid.Text <> "" And txt_pro_name.Text <> "" Then
                Dim insert_result As Integer

                Try
                    If conhrms.State = ConnectionState.Closed Then conhrms.Open()

                    Dim cmdprofession As New SqlCommand
                    cmdprofession.Connection = conhrms

                    cmdprofession.Parameters.Clear()
                    'rankId ,name 

                    cmdprofession.CommandText = ("update dbo.profession set profession =@profession, Employee ID= @Employee ID where  Employee ID= @Employee ID")

                    cmdprofession.Parameters.Add("@profession", SqlDbType.Int).Value = Trim(txt_pro_name.Text)
                    cmdprofession.Parameters.Add("@Employee ID", SqlDbType.VarChar).Value = Trim(txt_pro_empid.Text)

                    insert_result = cmdprofession.ExecuteNonQuery()
                    If insert_result = 1 Then
                        MessageBox.Show("updated successfully")
                        txt_pro_empid.Text = ""
                        txt_pro_name.Text = ""
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click


        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader
        If conhrms.State = ConnectionState.Closed Then conhrms.Open()
        cmd = New SqlCommand(" select profession,Employee ID from profession where Employee ID ='" + txt_pro_empid.Text + "'  ", conhrms)
        sdr = cmd.ExecuteReader()
        If (sdr.HasRows) Then
            While sdr.Read = True
                txt_pro_empid.Text = sdr.Item("Emp_categ_ID")
                txt_pro_name.Text = sdr.Item("Emp_categ_Desc")
            End While
            sdr.Close()
            btn_save.Text = "Update"
        Else
            MessageBox.Show("Data not found")
        End If
        conhrms.Close()
    End Sub
End Class
