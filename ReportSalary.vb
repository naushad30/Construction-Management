Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class ReportSalary
    Private Sub ReportSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")
        con.Open()
        ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\SalaryInfoReport.rdlc"



        Me.SalaryTableTableAdapter.Fill(Me.SalaryDataSet.SalaryTable)

        Guna2ShadowForm1.SetShadowForm(Me)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            If Not String.IsNullOrEmpty(txtSearch.Text) Then
                Dim keyword As String = Me.txtSearch.Text.Trim()
                Me.SalaryTableBindingSource.Filter =
                    "(EmpName LIKE '%" & keyword & "%')" &
                    " OR (Convert(SalaryAmt, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Convert(SalaryDate, 'System.String') LIKE '%" & keyword & "%')"

                Me.ReportViewer1.RefreshReport()
            Else
                Me.SalaryTableBindingSource.RemoveFilter()
                ReportSalary_Load(sender, e)

            End If
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message.ToString(),
                            "Error Handler - Code A Minute.",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtSearch.Focus()
        End Try

    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub
End Class