Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub

    Private Sub BtnHomePro_Click(sender As Object, e As EventArgs) Handles btnHomePro.Click
        Dim newForm As New Projects()
        newForm.Show()
    End Sub

    Private Sub BtnHomeAttendance_Click(sender As Object, e As EventArgs) Handles btnHomeAttendance.Click
        Dim newForm As New Attendance()
        newForm.Show()
    End Sub

    Private Sub BtnHomeWorkers_Click(sender As Object, e As EventArgs) Handles btnHomeWorkers.Click
        Dim newForm As New AddEmp()
        newForm.Show()
    End Sub

    Private Sub BtnHomeSalary_Click(sender As Object, e As EventArgs) Handles btnHomeSalary.Click
        Dim newForm As New Salary()
        newForm.Show()
    End Sub

    Private Sub BtnHomeAdvPay_Click(sender As Object, e As EventArgs) Handles btnHomeAdvPay.Click
        Dim newForm As New AdvPay()
        newForm.Show()
    End Sub

    Private Sub BtnHomeReports_Click(sender As Object, e As EventArgs) Handles btnHomeReports.Click
        Dim newForm As New Reports()
        newForm.Show()
    End Sub



    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim newForm As New Material()
        newForm.Show()
    End Sub

    Private Sub BtnFog_Click(sender As Object, e As EventArgs) Handles btnFog.Click
        Me.Hide()
        Dim newForm As New Login()
        newForm.Show()
    End Sub
End Class