Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Public Class ReportAdvPay
    Private Sub ReportAdvPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")
        con.Open()

        ReportViewer1.LocalReport.ReportPath = Application.StartupPath & "\AdvPayInfoReport.rdlc"

        ' With ReportViewer1.LocalReport
        '.ReportPath = Application.StartupPath & "\AdvPayInfoReport.rdlc"
        'ataSources.Clear()

        'End With


        Guna2ShadowForm1.SetShadowForm(Me)
        Me.AdvPayTableTableAdapter.Fill(Me.AdvPayDataSet.AdvPayTable)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            If Not String.IsNullOrEmpty(txtSearch.Text) Then
                Dim keyword As String = Me.txtSearch.Text.Trim()
                Me.AdvPayTableBindingSource.Filter =
                    "(AdvPayName LIKE '%" & keyword & "%')" &
                    " OR (Convert(AdvPayAmount, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (Convert(AdvPayDate, 'System.String') LIKE '%" & keyword & "%')" &
                    " OR (AdvPayAddress LIKE '%" & keyword & "%')" &
                    " OR (AdvPayMob LIKE '%" & keyword & "%')" &
                    " OR (Status LIKE '%" & keyword & "%')" &
                    " OR (Type LIKE '%" & keyword & "%')" &
                    " OR (Convert(Remaining, 'System.String') LIKE '%" & keyword & "%')"


                Me.ReportViewer1.RefreshReport()
            Else
                Me.AdvPayTableBindingSource.RemoveFilter()
                ReportAdvPay_Load(sender, e)

            End If
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message.ToString(),
                            "Error Handler - Code A Minute.",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.txtSearch.Focus()
        End Try


    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            btnSearch.PerformClick()
        End If
    End Sub


End Class