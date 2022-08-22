Public Class Main_window
    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        frm_employeeinfo.MdiParent = Me
        frm_employeeinfo.Show()
    End Sub

    Private Sub CategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryToolStripMenuItem.Click
        frm_category.MdiParent = Me
        frm_category.Show()
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartmentToolStripMenuItem.Click
        frm_dept.MdiParent = Me
        frm_dept.Show()
    End Sub

    Private Sub DesignationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesignationToolStripMenuItem.Click
        frm_Designation.MdiParent = Me
        frm_Designation.Show()
    End Sub

    Private Sub ProfessionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfessionToolStripMenuItem.Click
        frm_profession.MdiParent = Me
        frm_profession.Show()
    End Sub

    Private Sub NationalityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NationalityToolStripMenuItem.Click
        frm_Designation.MdiParent = Me
        frm_Designation.Show()
    End Sub

    Private Sub Main_window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Label1.Text = DateTime.Now()
        Timer1.Enabled = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Visible = True Then
            Label1.Text = DateTime.Now.ToString("hh:mm")
            Label1.Visible = False
        Else
            Label1.Text = DateTime.Now.ToString("hh:mm")
            Label1.Visible = True
        End If

    End Sub
End Class

