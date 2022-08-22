Public Class frm_signupvb
    Dim conhrms As SqlConnection = New SqlConnection("Server=LAPTOP-P94P69H7\SQLEXPRESS;Database=HRMSDB;User Id=sa;Password=qatar123;")
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim insert_result






    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click

        Try
            If conhrms.State = ConnectionState.Closed Then conhrms.Open()

            Dim cmdpass As New SqlCommand
            cmdpass.Connection = conhrms

            cmdpass.Parameters.Clear()


            cmdpass.CommandText = ("insert into dbo.signupvb(emp_newusername, emp_newpassword) values (@emp_newusername, @emp_newpassword) ")

            cmdpass.Parameters.Add("@emp_newusername", SqlDbType.VarChar).Value = Trim(txt_username.Text)
            cmdpass.Parameters.Add("@emp_newpassword", SqlDbType.VarChar).Value = Trim(txt_password.Text)

            insert_result = cmdpass.ExecuteNonQuery()
            If insert_result = 1 Then
                MessageBox.Show("Sign up successful")

            ElseIf txt_username.Text <> "" Or txt_password.Text <> "" Then
                MessageBox.Show("Error")

            End If


        Catch ex As Exception
            MessageBox.Show("Sign up not successful " & ex.Message)
        End Try






        conhrms.Close()

    End Sub

    Private Sub frm_signupvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class