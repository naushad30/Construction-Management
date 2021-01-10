Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AttendanceDataSet.AttendanceTable' table. You can move, or remove it, as needed.

    End Sub

    Sub LoadReport()
        ReportViewer1.RefreshReport()

        Dim rptDataSourcce As ReportDataSource
        With ReportViewer1.LocalReport
            .ReportPath = Application.StartupPath & "\Report1.rdlc"
            .DataSources.Clear()
        End With

        Dim ds As New DataSetsample
        Dim da As New OleDbDataAdapter

        da.SelectCommand = New OleDbCommand("select AttendanceID, EmpName, Attendance, AttendanceDate from AttendanceTable where EmpName Like '" & Form1.txtSearch.Text & "%'", cn)
        da.Fill(ds.Tables("AttendanceTable"))

        rptDataSourcce = New ReportDataSource("DataSet1", ds.Tables("AttendanceTable"))
        ReportViewer1.LocalReport.DataSources.Add(rptDataSourcce)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

    End Sub

    Private Sub Form2_FontChanged(sender As Object, e As EventArgs) Handles Me.FontChanged
        Me.Dispose()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class