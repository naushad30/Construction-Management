Imports System.Data.OleDb
Public Class Salary

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")

    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As Integer

    Dim dr As OleDbDataReader

    Dim da As New OleDb.OleDbDataAdapter

    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dateSalary.Format = DateTimePickerFormat.Custom
        dateSalary.CustomFormat = "dd-MM-yyyy"


        dateSalary.Value = Date.Today
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


        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub

    Sub loadrecord()
        Try
            Dim dt As New DataTable
            con.Open()


            sql = "select * from SalaryTable "
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
        GunaDataGridView1.Columns(2).HeaderText = "Salary"
        GunaDataGridView1.Columns(3).HeaderText = "Date"


    End Sub



    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtEmpSalary.Clear()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (txtEmpSalary.Text = "" Or comboEmpName.Text = "") Then
            MessageBox.Show("Please Fill The Details !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'MsgBox("Please Fill The Details !")
        Else
            Try
                con.Open()


                sql = "INSERT INTO SalaryTable (EmpName,SalaryAmt,SalaryDate) values ('" & comboEmpName.Text & "'," & Val(txtEmpSalary.Text) & ",'" & dateSalary.Value.ToString("dd - MM - yyyy") & "')"
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
                MsgBox(ex.Message)
            Finally

                con.Close()
                loadrecord()
            End Try
            txtEmpSalary.Clear()
        End If

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try
            con.Open()


            sql = "UPDATE SalaryTable SET EmpName='" & comboEmpName.Text & "',SalaryAmt=" & Val(txtEmpSalary.Text) & ",SalaryDate='" & dateSalary.Value.ToString("dd - MM - yyyy") & "'"
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
        txtEmpSalary.Clear()

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans As String
        ans = MsgBox("Are you sure you want to DELETE this record ?", vbYesNo)
        If ans = vbYes Then
            Try
                con.Open()


                sql = "DELETE * from SalaryTable WHERE SalaryID = " & Val(Me.Text) & ""
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

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellContentClick

    End Sub

    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        Me.Text = GunaDataGridView1.CurrentRow.Cells(0).Value

        comboEmpName.Text = GunaDataGridView1.CurrentRow.Cells(1).Value
        txtEmpSalary.Text = GunaDataGridView1.CurrentRow.Cells(2).Value
        dateSalary.Text = GunaDataGridView1.CurrentRow.Cells(3).Value

    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadrecord()
    End Sub

    Private Sub ComboEmpName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboEmpName.SelectedIndexChanged

    End Sub
End Class