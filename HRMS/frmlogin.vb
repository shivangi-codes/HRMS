Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.SqlClient.SqlConnection
Imports System.Globalization



Public Class frmlogin
    Dim conhrms As SqlConnection = New SqlConnection("Server=LAPTOP-P94P69H7\SQLEXPRESS;Database=HRMSDB;User Id=sa;Password=qatar123;")
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim time As Date



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_exit.Click, btn_signup.Click

        frm_signupvb.Show()
    End Sub



    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_username.Text <> "" And txt_password.Text <> "" Then

            Dim cmddeq As SqlCommand
            Dim sdrdeq As SqlDataReader
            conhrms.Open()

            cmddeq = New SqlCommand("select * from dbo.signupvb  where emp_newusername ='" + txt_username.Text + "' and emp_newpassword = '" + txt_password.Text + "' ", conhrms)



            sdrdeq = cmddeq.ExecuteReader()
            If (sdrdeq.HasRows) Then
                'While sdrdeq.Read = True
                '    'currentStaffid = sdrdeq.Item("STAFFID")
                'End While
                sdrdeq.Close()

                conhrms.Close()
                loginregister()
                Main_window.Show()
                Main_window.WindowState = FormWindowState.Minimized
                Main_window.WindowState = FormWindowState.Maximized
                'Me.Close()
            Else
                MessageBox.Show("Check User name and Password............", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_password.Focus()
                sdrdeq.Close()
                conhrms.Close()
            End If
        Else
            MessageBox.Show("Please Enter User Name & Password....", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If



    End Sub


    Private Sub loginregister()

        Dim cmd As SqlCommand
        Dim sdr As SqlDataReader


        If txt_username.Text <> "" Then


            If conhrms.State = ConnectionState.Closed Then conhrms.Open()

            Dim cmdcatg As New SqlCommand
            cmdcatg.Connection = conhrms

            cmdcatg.Parameters.Clear()

            cmdcatg.CommandText = ("insert into dbo.loginregister(Emp_name, Emp_time) values (@Emp_name,@Emp_time) ")

            cmdcatg.Parameters.Add("@Emp_name", SqlDbType.VarChar).Value = Trim(txt_username.Text)
            cmdcatg.Parameters.Add("@Emp_time", SqlDbType.DateTime).Value = Date.Now()
            cmdcatg.ExecuteNonQuery()

            'cmdcatg.Parameters.Add(time, SqlDbType.DateTime = Trim(txt_   Text)

        End If

    End Sub

    'insert_result = cmdcatg.ExecuteNonQuery()
    'If insert_result = 1 Then
    '    MessageBox.Show("insert successfully")
    '    txt_catg_id.Text = ""
    '    txt_categ_desc.Text = ""
    '  Load_dataGrid()
    'Else
    'MessageBox.Show("error")
    'End If

    'Catch ex As Exception
    '    MessageBox.Show("An error occured: " & ex.Message)
    'End Try
    'Else
    '    MessageBox.Show("Please enter designation name", "Information", MessageBoxButtons.OK)
    'End If
    'ElseIf btn_save.Text = "Update" Then

    'If txt_catg_id.Text <> "" And txt_categ_desc.Text <> "" Then
    '    Dim insert_result As Integer

    '    Try
    '        If conhrms.State = ConnectionState.Closed Then conhrms.Open()

    '        Dim cmdcatg As New SqlCommand
    '        cmdcatg.Connection = conhrms

    '        cmdcatg.Parameters.Clear()
    '        'rankId ,name 

    '        cmdcatg.CommandText = ("update dbo.MST_Category set Emp_categ_ID =@Emp_categ_ID, Emp_categ_Desc=@Emp_categ_Desc where Emp_categ_ID=@Emp_categ_ID")

    '        cmdcatg.Parameters.Add("@Emp_categ_ID", SqlDbType.Int).Value = Trim(txt_catg_id.Text)
    '        cmdcatg.Parameters.Add("@Emp_categ_Desc", SqlDbType.VarChar).Value = Trim(txt_categ_desc.Text)

    '        insert_result = cmdcatg.ExecuteNonQuery()
    '        If insert_result = 1 Then
    '            MessageBox.Show("updated successfully")
    '            txt_catg_id.Text = ""
    '            txt_categ_desc.Text = ""
    '            Load_dataGrid()
    '        Else
    '            MessageBox.Show("error")
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show("An error occured: " & ex.Message)
    '    End Try
    'Else
    '    MessageBox.Show("Please enter category name", "Information", MessageBoxButtons.OK)
    'End If











    'End Sub




    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

