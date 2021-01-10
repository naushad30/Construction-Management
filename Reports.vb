Public Class Reports
    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub

    Private Sub BtnHomePro_Click(sender As Object, e As EventArgs) Handles btnHomePro.Click
        Dim newForm As New ReportProject()
        newForm.Show()
    End Sub

    Private Sub BtnHomeAttendance_Click(sender As Object, e As EventArgs) Handles btnHomeAttendance.Click
        Dim newForm As New ReportAttendance()
        newForm.Show()
    End Sub

    Private Sub BtnHomeWorkers_Click(sender As Object, e As EventArgs) Handles btnHomeWorkers.Click
        Dim newForm As New ReportEmp()
        newForm.Show()
    End Sub

    Private Sub BtnHomeSalary_Click(sender As Object, e As EventArgs) Handles btnHomeSalary.Click
        Dim newForm As New ReportSalary()
        newForm.Show()
    End Sub

    Private Sub BtnHomeAdvPay_Click(sender As Object, e As EventArgs) Handles btnHomeAdvPay.Click
        Dim newForm As New ReportAdvPay()
        newForm.Show()
    End Sub

    Private Sub BtnMaterials_Click(sender As Object, e As EventArgs) Handles btnMaterials.Click
        Dim newForm As New ReportMaterials()
        newForm.Show()
    End Sub
End Class