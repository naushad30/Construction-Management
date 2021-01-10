Imports System.Data.OleDb
Public Class Attendance

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")
    Dim attendance As String
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As Integer

    Dim dr As OleDbDataReader

    Dim da As New OleDb.OleDbDataAdapter


    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AttenDate.Format = DateTimePickerFormat.Custom
        AttenDate.CustomFormat = "dd-MM-yyyy"




        AttenDate.Value = Date.Today
        loadrecord()
        Try
            con.Open()
            If con.State = ConnectionState.Open Then
                'MsgBox("Connected")
            Else
                MsgBox("Not Connected")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

        Guna2ShadowForm1.SetShadowForm(Me)

        con.Open()
        comboEmpName.Items.Clear()
        cmd.CommandText = "select * from EmpTable"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While dr.Read
            comboEmpName.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()



    End Sub



    Sub loadrecord()
        Try
            Dim dt As New DataTable
            con.Open()


            sql = "select * from AttendanceTable"
            cmd.Connection = con
            cmd.CommandText = sql
            da.SelectCommand = cmd
            da.Fill(dt)

            GunaDataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            con.Close()
        End Try
        GunaDataGridView1.Columns(0).HeaderText = "ID"
        GunaDataGridView1.Columns(1).HeaderText = "Employee Name"
        GunaDataGridView1.Columns(2).HeaderText = "Attendance"
        GunaDataGridView1.Columns(3).HeaderText = "Date"
    End Sub





    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If (comboAtten.Text = "" Or comboEmpName.Text = "") Then
            MessageBox.Show("Please Fill The Details !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'MsgBox("Please Fill The Details !")
        Else
            Try
                con.Open()


                sql = "INSERT INTO AttendanceTable (EmpName,Attendance,AttendanceDate) values ('" & comboEmpName.Text & "','" & comboAtten.Text & "','" & AttenDate.Value.ToString("dd - MM - yyyy") & "')"
                cmd.Connection = con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("New Record  has Been Inserted Successfully !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MsgBox("New Record  has Been Inserted Successfully !")
                Else
                    MessageBox.Show("No Record  has Been Inserted !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MessageBox.Show("You Are Inserting Duplicate Value" & vbCrLf & "Please Change" & vbCrLf & "Name / Attendance / Date !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)


            Finally

                con.Close()
                loadrecord()
            End Try

        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try
            con.Open()


            sql = "UPDATE AttendanceTable SET EmpName='" & comboEmpName.Text & "',Attendance='" & comboAtten.Text & "',AttendanceDate='" & AttenDate.Value.ToString("dd - MM - yyyy") & "' WHERE AttendanceID = " & Val(Me.Text) & ""
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("New Record  has Been Updated Successfully !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MsgBox("New Record  has Been Updated Successfully !")
            Else
                MessageBox.Show("No Record  has Been Updated !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            con.Close()
            loadrecord()
        End Try

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        Dim ans As String
        ans = MsgBox("Are you sure you want to DELETE this record ?", vbYesNo)
        If ans = vbYes Then


            Try
                con.Open()


                sql = "DELETE * from AttendanceTable WHERE AttendanceID = " & Val(Me.Text) & ""
                cmd.Connection = con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("New Record  has Been Deleted Successfully !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MsgBox(" Record  has Been Deleted Successfully !")
                Else
                    MessageBox.Show("No Record  has Been Deleted !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                loadrecord()
            End Try


        End If
    End Sub



    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        Me.Text = GunaDataGridView1.CurrentRow.Cells(0).Value

        comboEmpName.Text = GunaDataGridView1.CurrentRow.Cells(1).Value
        comboAtten.Text = GunaDataGridView1.CurrentRow.Cells(2).Value

        AttenDate.Value = GunaDataGridView1.CurrentRow.Cells(3).Value

    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadrecord()
    End Sub



End Class