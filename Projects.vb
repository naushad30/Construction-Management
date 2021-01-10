Imports System.Data.OleDb

Public Class Projects
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")

    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As Integer

    Dim dr As OleDbDataReader

    Dim da As New OleDb.OleDbDataAdapter

    Private Sub Projects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dateStartProject.Format = DateTimePickerFormat.Custom
        dateStartProject.CustomFormat = "dd-MM-yyyy"


        dateStartProject.Value = Date.Today

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
        comboProSup.Items.Clear()
        cmd.CommandText = "select * from EmpTable where emptype='Supervisor'"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While dr.Read
            comboProSup.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()
    End Sub

    Sub loadrecord()
        Try
            Dim dt As New DataTable
            con.Open()


            sql = "select * from ProjectTable "
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
        GunaDataGridView1.Columns(1).HeaderText = "Project Name"
        GunaDataGridView1.Columns(2).HeaderText = "Address"
        GunaDataGridView1.Columns(3).HeaderText = "Status"
        GunaDataGridView1.Columns(4).HeaderText = "Budget"
        GunaDataGridView1.Columns(5).HeaderText = "Supervisor"
        GunaDataGridView1.Columns(6).HeaderText = "No. of Workers"
        GunaDataGridView1.Columns(7).HeaderText = "Date"
        GunaDataGridView1.Columns(8).HeaderText = "Mobile no."
        GunaDataGridView1.Columns(9).HeaderText = "Alternate no."

    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadrecord()
    End Sub



    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtProName.Clear()
        txtAddress.Clear()
        txtProBudget.Clear()
        txtMob.Clear()
        txtNoOfWorkers.Clear()
        txtAltNo.Clear()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (txtAddress.Text = "" Or txtAltNo.Text = "" Or txtMob.Text = "" Or txtProName.Text = "" Or txtNoOfWorkers.Text = "" Or txtProBudget.Text = "" Or txtProStatus.Text = "") Then
            MessageBox.Show("Please Fill The Details !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'MsgBox("Please Fill The Details !")
        Else
            Try
                con.Open()


                sql = "INSERT INTO ProjectTable (ProjectName,ProjectAddress,ProjectStatus,ProjectBudget,ProjectSupervisor,NoOfWorkers,StartDate,Mobileno,Altrno) values ('" & txtProName.Text & "','" & txtAddress.Text & "','" & txtProStatus.Text & "'," & Val(txtProBudget.Text) & ",'" & comboProSup.Text & "','" & txtNoOfWorkers.Text & "','" & dateStartProject.Value.ToString("dd - MM - yyyy") & "','" & txtMob.Text & "','" & txtAltNo.Text & "')"
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
            txtProName.Clear()
            txtAddress.Clear()
            txtProBudget.Clear()
            txtMob.Clear()
            txtNoOfWorkers.Clear()
            txtAltNo.Clear()
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con.Open()


            sql = "UPDATE ProjectTable SET ProjectName='" & txtProName.Text & "',ProjectAddress='" & txtAddress.Text & "',ProjectStatus='" & txtProStatus.Text & "',ProjectBudget=" & Val(txtProBudget.Text) & ",ProjectSupervisor='" & comboProSup.Text & "',NoOfWorkers='" & txtNoOfWorkers.Text & "',StartDate='" & dateStartProject.Value.ToString("dd - MM - yyyy") & "',Mobileno='" & txtMob.Text & "',Altrno='" & txtAltNo.Text & "' WHERE ProjectID = " & Val(Me.Text) & ""
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
        txtProName.Clear()
        txtAddress.Clear()
        txtProBudget.Clear()
        txtMob.Clear()
        txtNoOfWorkers.Clear()
        txtAltNo.Clear()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans As String
        ans = MsgBox("Are you sure you want to DELETE this record ?", vbYesNo)
        If ans = vbYes Then

            Try
                con.Open()


                sql = "DELETE * from ProjectTable WHERE ProjectID = " & Val(Me.Text) & ""
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

        txtProName.Text = GunaDataGridView1.CurrentRow.Cells(1).Value
        txtAddress.Text = GunaDataGridView1.CurrentRow.Cells(2).Value
        txtProStatus.Text = GunaDataGridView1.CurrentRow.Cells(3).Value
        txtProBudget.Text = GunaDataGridView1.CurrentRow.Cells(4).Value
        comboProSup.Text = GunaDataGridView1.CurrentRow.Cells(5).Value
        txtNoOfWorkers.Text = GunaDataGridView1.CurrentRow.Cells(6).Value
        dateStartProject.Value = GunaDataGridView1.CurrentRow.Cells(7).Value
        txtMob.Text = GunaDataGridView1.CurrentRow.Cells(8).Value
        txtAltNo.Text = GunaDataGridView1.CurrentRow.Cells(9).Value


    End Sub


End Class