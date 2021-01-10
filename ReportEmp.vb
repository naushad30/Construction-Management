Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class ReportEmp
    Private Sub ReportEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\EmpInfoReport.rdlc"
        Me.EmpTableTableAdapter.Fill(Me.EmpDataSet.EmpTable)
        Guna2ShadowForm1.SetShadowForm(Me)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            If Not String.IsNullOrEmpty(txtSearch.Text) Then
                Dim keyword As String = Me.txtSearch.Text.Trim()
                Me.EmpTableBindingSource.Filter =
                    "(EmpName LIKE '%" & keyword & "%')" &
                    " OR (EmpAddress LIKE '%" & keyword & "%')" &
                    " OR (EmpGender LIKE '%" & keyword & "%')" &
                    " OR (EmpType LIKE '%" & keyword & "%')" &
                    " OR (Convert(EmpAadhaar, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Convert(Birthdate, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Convert(JoinDate, 'System.String')  LIKE '%" & keyword & "%')" &
                    " OR (MobileNo LIKE '%" & keyword & "%')" &
                    " Or (AlternateNo LIKE '%" & keyword & "%')"


                Me.ReportViewer1.RefreshReport()
            Else
                Me.EmpTableBindingSource.RemoveFilter()
                ReportEmp_Load(sender, e)

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