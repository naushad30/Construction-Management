Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class ReportMaterials
    Private Sub ReportMaterials_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")
        con.Open()
        ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\MaterialInfoReport.rdlc"



        'TODO: This line of code loads data into the 'MaterialDataSet.Material' table. You can move, or remove it, as needed.
        Me.MaterialTableAdapter.Fill(Me.MaterialDataSet.Material)



        Guna2ShadowForm1.SetShadowForm(Me)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            If Not String.IsNullOrEmpty(txtSearch.Text) Then
                Dim keyword As String = Me.txtSearch.Text.Trim()
                Me.MaterialBindingSource.Filter =
                    "(ProjectName LIKE '%" & keyword & "%')" &
                    " OR (Convert(MaterialDate, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Mat1 LIKE '%" & keyword & "%')" &
                    " OR (Convert(Qty1, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Convert(Priz1, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Mat2 LIKE '%" & keyword & "%')" &
                    " OR (Convert(Qty2, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Convert(Priz2, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Mat3 LIKE '%" & keyword & "%')" &
                    " OR (Convert(Qty3, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Convert(Priz3, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Mat4 LIKE '%" & keyword & "%')" &
                    " OR (Convert(Qty4, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Convert(Priz4, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Mat5 LIKE '%" & keyword & "%')" &
                    " OR (Convert(Qty5, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Convert(Priz5, 'System.String') LIKE '%" & keyword & "%')"


                Me.ReportViewer1.RefreshReport()
            Else
                Me.MaterialBindingSource.RemoveFilter()
                ReportMaterials_Load(sender, e)

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