
Imports MySql.Data.MySqlClient
Public Class AddEmp
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")

    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As Integer

    Dim da As New OleDb.OleDbDataAdapter




    Sub loadrecord()
        Try
            Dim dt As New DataTable
            con.Open()


            sql = "select * from EmpTable"
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
        GunaDataGridView1.Columns(1).HeaderText = "Name"
        GunaDataGridView1.Columns(2).HeaderText = "Address"
        GunaDataGridView1.Columns(3).HeaderText = "Gender"
        GunaDataGridView1.Columns(4).HeaderText = "Type"
        GunaDataGridView1.Columns(5).HeaderText = "Aadhaar no"
        GunaDataGridView1.Columns(6).HeaderText = "Birthdate"
        GunaDataGridView1.Columns(7).HeaderText = "Join Date"
        GunaDataGridView1.Columns(8).HeaderText = "Mobile no."
        GunaDataGridView1.Columns(9).HeaderText = "Alternate no."
    End Sub




    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadrecord()
    End Sub

    Private Sub BtnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        If (txtEmpAadhaar.Text = "" Or txtEmpAddress.Text = "" Or txtEmpAlter.Text = "" Or txtEmpBirthdate.Text = "" Or txtEmpGender.Text = "" Or txtEmpJoinDate.Text = "" Or txtEmpMobile.Text = "" Or txtEmpName.Text = "" Or txtEmpName.Text = "" Or txtEmpType.Text = "") Then

            MessageBox.Show("Please Fill The Details !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'MsgBox("Please Fill The Details !")
        Else

            Try
                con.Open()


                sql = "INSERT INTO EmpTable (EmpName,EmpAddress,EmpGender,EmpType,EmpAadhaar,Birthdate,JoinDate,MobileNo,AlternateNo) values ('" & txtEmpName.Text & "','" & txtEmpAddress.Text & "','" & txtEmpGender.Text & "','" & txtEmpType.Text & "','" & txtEmpAadhaar.Text & "','" & txtEmpBirthdate.Value.ToString("dd - MM - yyyy") & "','" & txtEmpJoinDate.Value.ToString("dd - MM - yyyy") & "','" & txtEmpMobile.Text & "','" & txtEmpAlter.Text & "') "
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
                    'MsgBox("No Record  has Been Inserted !")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

                con.Close()
                loadrecord()
            End Try
            txtEmpName.Clear()
            txtEmpAadhaar.Clear()
            txtEmpAddress.Clear()
            txtEmpAlter.Clear()
            txtEmpMobile.Clear()
        End If
    End Sub



    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        Me.Text = GunaDataGridView1.CurrentRow.Cells(0).Value
        txtEmpName.Text = GunaDataGridView1.CurrentRow.Cells(1).Value
        txtEmpAddress.Text = GunaDataGridView1.CurrentRow.Cells(2).Value
        txtEmpGender.Text = GunaDataGridView1.CurrentRow.Cells(3).Value
        txtEmpType.Text = GunaDataGridView1.CurrentRow.Cells(4).Value
        txtEmpAadhaar.Text = GunaDataGridView1.CurrentRow.Cells(5).Value
        txtEmpBirthdate.Value = GunaDataGridView1.CurrentRow.Cells(6).Value
        txtEmpJoinDate.Value = GunaDataGridView1.CurrentRow.Cells(7).Value
        txtEmpMobile.Text = GunaDataGridView1.CurrentRow.Cells(8).Value
        txtEmpAlter.Text = GunaDataGridView1.CurrentRow.Cells(9).Value

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try
            con.Open()


            sql = "UPDATE EmpTable SET EmpName='" & txtEmpName.Text & "', EmpAddress='" & txtEmpAddress.Text & "', EmpGender='" & txtEmpGender.Text & "', EmpType='" & txtEmpType.Text & "', EmpAadhaar='" & txtEmpAadhaar.Text & "', Birthdate='" & txtEmpBirthdate.Value.ToString("dd - MM - yyyy") & "', JoinDate='" & txtEmpJoinDate.Value.ToString("dd - MM - yyyy") & "', MobileNo='" & txtEmpMobile.Text & "', AlternateNo='" & txtEmpAlter.Text & "' WHERE EmpID = " & Val(Me.Text) & ""
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Record  has Been Updated Successfully !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MsgBox(" Record  has Been Updated Successfully !")
            Else
                MessageBox.Show("No Record  has Been Updated !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
                'MsgBox("No Record  has Been Updated !")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            con.Close()
            loadrecord()
        End Try
        txtEmpName.Clear()
        txtEmpAadhaar.Clear()
        txtEmpAddress.Clear()
        txtEmpAlter.Clear()
        txtEmpMobile.Clear()


    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans As String
        ans = MsgBox("Are you sure you want to DELETE this record ?", vbYesNo)
        If ans = vbYes Then

            Try
                con.Open()


                sql = "DELETE * from EmpTable WHERE EmpID = " & Val(Me.Text) & ""
                cmd.Connection = con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Record  has Been Deleted Successfully !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'MsgBox(" Record  has Been Deleted Successfully !")
                Else
                    MessageBox.Show("No Record  has Been Deleted !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
                    MsgBox("No Record  has Been Deleted !")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
                loadrecord()
            End Try
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmpName.Clear()
        txtEmpAadhaar.Clear()
        txtEmpAddress.Clear()
        txtEmpAlter.Clear()
        txtEmpMobile.Clear()
        txtEmpName.Clear()
    End Sub

    Private Sub AddEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmpJoinDate.Format = DateTimePickerFormat.Custom
        txtEmpJoinDate.CustomFormat = "dd-MM-yyyy"

        txtEmpBirthdate.Format = DateTimePickerFormat.Custom
        txtEmpBirthdate.CustomFormat = "dd-MM-yyyy"

        txtEmpBirthdate.Value = Date.Today
        txtEmpJoinDate.Value = Date.Today

        loadrecord()
        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub TxtEmpBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles txtEmpBirthdate.ValueChanged

    End Sub
End Class