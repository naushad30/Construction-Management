Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class ReportProject
    Private Sub ReportProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")
        con.Open()
        ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\ProjectInfoReport.rdlc"




        'TODO: This line of code loads data into the 'ProjectDataSet.ProjectTable' table. You can move, or remove it, as needed.
        Me.ProjectTableTableAdapter.Fill(Me.ProjectDataSet.ProjectTable)

        Guna2ShadowForm1.SetShadowForm(Me)
        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            If Not String.IsNullOrEmpty(txtSearch.Text) Then
                Dim keyword As String = Me.txtSearch.Text.Trim()
                Me.ProjectTableBindingSource.Filter =
                    "(ProjectName LIKE '%" & keyword & "%')" &
                    " OR (ProjectAddress LIKE '%" & keyword & "%')" &
                    " OR (ProjectStatus LIKE '%" & keyword & "%')" &
                    " OR (Convert(ProjectBudget, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (ProjectSupervisor LIKE '%" & keyword & "%')" &
                    " OR (Convert(NoOfWorkers, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Convert(StartDate, 'System.String')  LIKE '%" & keyword & "%')" &
                    " OR (Mobileno LIKE '%" & keyword & "%')" &
                    " Or (Altrno LIKE '%" & keyword & "%')"

                Me.ReportViewer1.RefreshReport()
            Else
                Me.ProjectTableBindingSource.RemoveFilter()
                ReportProject_Load(sender, e)

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