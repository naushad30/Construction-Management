Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class ReportAttendance

    Private Sub ReportAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")
        con.Open()
        ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\AttendanceInfoReport.rdlc"



        'TODO: This line of code loads data into the 'EmpDataSet.EmpTable' table. You can move, or remove it, as needed.
        Me.AttendanceTableTableAdapter.Fill(Me.AttendanceDataSet.AttendanceTable)



        Guna2ShadowForm1.SetShadowForm(Me)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            If Not String.IsNullOrEmpty(txtSearch.Text) Then
                Dim keyword As String = Me.txtSearch.Text.Trim()
                Me.AttendanceTableBindingSource.Filter =
                "(EmpName LIKE '%" & keyword & "%')" &
                " OR (Attendance LIKE '%" & keyword & "%')" &
                " OR (Convert(AttendanceDate, 'System.String') LIKE '%" & keyword & "%')"

                Me.ReportViewer1.RefreshReport()
            Else
                Me.AttendanceTableBindingSource.RemoveFilter()
                ReportAttendance_Load(sender, e)

            End If
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message.ToString(),
                            "Error Handler - Code A Minute.",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtSearch.Focus()
        End Try
    End Sub
End Class