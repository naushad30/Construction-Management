Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
        loadrecords()
    End Sub


    Sub loadrecords()
        DataGridView1.Rows.Clear()
        cm = New OleDbCommand("select AttendanceID, EmpName, Attendance, AttendanceDate from AttendanceTable where empname like '" & txtSearch.Text & "%'", cn)
        dr = cm.ExecuteReader
        While dr.Read

            DataGridView1.Rows.Add(dr.Item(0).ToString, dr.Item(1).ToString, dr.Item(2).ToString, dr.Item(3).ToString)
            'DataGridView1.Columns(3).DefaultCellStyle.Format = "dd/mm/yy"
            'Convert.ToDateTime().ToString("dd/mm/yyyy")
        End While
        dr.Close()
    End Sub



    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        loadrecords()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        With Form2
            .LoadReport()
            .ShowDialog()
        End With
    End Sub
End Class