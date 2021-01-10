Imports System.Data.OleDb
Public Class Material
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")

    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As Integer
    Dim dr As OleDbDataReader
    Dim da As New OleDb.OleDbDataAdapter
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dateMaterial.Format = DateTimePickerFormat.Custom
        dateMaterial.CustomFormat = "dd-MM-yyyy"

        dateMaterial.Value = Date.Today

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
        comboProName.Items.Clear()
        cmd.CommandText = "select * from ProjectTable"
        cmd.Connection = con

        dr = cmd.ExecuteReader
        While dr.Read
            comboProName.Items.Add(dr.GetString(1))
        End While
        dr.Close()
        con.Close()
    End Sub

    Sub loadrecord()
        Try
            Dim dt As New DataTable
            con.Open()


            sql = "select * from Material "
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
        GunaDataGridView1.Columns(2).HeaderText = "Date"


        GunaDataGridView1.Columns(3).HeaderText = "Material 1"
        GunaDataGridView1.Columns(4).HeaderText = "Qty 1"
        GunaDataGridView1.Columns(5).HeaderText = "Price 1"

        GunaDataGridView1.Columns(6).HeaderText = "Material 2"
        GunaDataGridView1.Columns(7).HeaderText = "Qty 2"
        GunaDataGridView1.Columns(8).HeaderText = "Price 2"

        GunaDataGridView1.Columns(9).HeaderText = "Material 3"
        GunaDataGridView1.Columns(10).HeaderText = "Qty 3"
        GunaDataGridView1.Columns(11).HeaderText = "Price 3"

        GunaDataGridView1.Columns(12).HeaderText = "Material 4"
        GunaDataGridView1.Columns(13).HeaderText = "Qty 4"
        GunaDataGridView1.Columns(14).HeaderText = "Price 4"

        GunaDataGridView1.Columns(15).HeaderText = "Material 5"
        GunaDataGridView1.Columns(16).HeaderText = "Qty 5"
        GunaDataGridView1.Columns(17).HeaderText = "Price 5"

    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        loadrecord()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMat1.Clear()
        txtQt1.Clear()
        txtPriz1.Clear()

        txtMat2.Clear()
        txtQt2.Clear()
        txtPriz2.Clear()

        txtMat3.Clear()
        txtQt3.Clear()
        txtPriz3.Clear()

        txtMat4.Clear()
        txtQt4.Clear()
        txtPriz4.Clear()

        txtMat5.Clear()
        txtQt5.Clear()
        txtPriz5.Clear()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (txtMat1.Text = "" Or txtPriz1.Text = "" Or txtQt1.Text = "") Then
            MessageBox.Show("Please Fill The Details !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'MsgBox("Please Fill The Details !")
        Else

            Try
                con.Open()


                sql = "INSERT INTO Material (ProjectName,MaterialDate,Mat1,Qty1,Priz1,Mat2,Qty2,Priz2,Mat3,Qty3,Priz3,Mat4,Qty4,Priz4,Mat5,Qty5,Priz5) values ('" & comboProName.Text & "','" & dateMaterial.Value.ToString("dd - MM - yyyy") & "','" & txtMat1.Text & "'," & Val(txtQt1.Text) & "," & Val(txtPriz1.Text) & ",'" & txtMat2.Text & "'," & Val(txtQt2.Text) & "," & Val(txtPriz2.Text) & ",'" & txtMat3.Text & "'," & Val(txtQt3.Text) & "," & Val(txtPriz3.Text) & ",'" & txtMat4.Text & "'," & Val(txtQt4.Text) & "," & Val(txtPriz4.Text) & ",'" & txtMat5.Text & "'," & Val(txtQt5.Text) & "," & Val(txtPriz5.Text) & ")"
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
            txtMat1.Clear()
            txtQt1.Clear()
            txtPriz1.Clear()

            txtMat2.Clear()
            txtQt2.Clear()
            txtPriz2.Clear()

            txtMat3.Clear()
            txtQt3.Clear()
            txtPriz3.Clear()

            txtMat4.Clear()
            txtQt4.Clear()
            txtPriz4.Clear()

            txtMat5.Clear()
            txtQt5.Clear()
            txtPriz5.Clear()
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con.Open()


            sql = "UPDATE Material SET ProjectName='" & comboProName.Text & "',MaterialDate='" & dateMaterial.Value.ToString("dd - MM - yyyy") & "',Mat1='" & txtMat1.Text & "',Qty1=" & Val(txtQt1.Text) & ",Priz1=" & Val(txtPriz1.Text) & ",Mat2='" & txtMat2.Text & "',Qty2=" & Val(txtQt2.Text) & ",Priz2=" & Val(txtPriz2.Text) & ",Mat3='" & txtMat3.Text & "',Qty3=" & Val(txtQt3.Text) & ",Priz3=" & Val(txtPriz3.Text) & ",Mat4='" & txtMat4.Text & "',Qty4=" & Val(txtQt4.Text) & ",Priz4=" & Val(txtPriz4.Text) & ",Mat5='" & txtMat5.Text & "',Qty5=" & Val(txtQt5.Text) & ",Priz5=" & Val(txtPriz5.Text) & " WHERE MaterialID = " & Val(Me.Text) & ""
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
        txtMat1.Clear()
        txtQt1.Clear()
        txtPriz1.Clear()

        txtMat2.Clear()
        txtQt2.Clear()
        txtPriz2.Clear()

        txtMat3.Clear()
        txtQt3.Clear()
        txtPriz3.Clear()

        txtMat4.Clear()
        txtQt4.Clear()
        txtPriz4.Clear()

        txtMat5.Clear()
        txtQt5.Clear()
        txtPriz5.Clear()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans As String
        ans = MsgBox("Are you sure you want to DELETE this record ?", vbYesNo)
        If ans = vbYes Then
            Try
                con.Open()


                sql = "DELETE * from Material WHERE MaterialID = " & Val(Me.Text) & ""
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
        comboProName.Text = GunaDataGridView1.CurrentRow.Cells(1).Value
        dateMaterial.Value = GunaDataGridView1.CurrentRow.Cells(2).Value

        txtMat1.Text = GunaDataGridView1.CurrentRow.Cells(3).Value
        txtQt1.Text = GunaDataGridView1.CurrentRow.Cells(4).Value
        txtPriz1.Text = GunaDataGridView1.CurrentRow.Cells(5).Value

        txtMat2.Text = GunaDataGridView1.CurrentRow.Cells(6).Value
        txtQt2.Text = GunaDataGridView1.CurrentRow.Cells(7).Value
        txtPriz2.Text = GunaDataGridView1.CurrentRow.Cells(8).Value

        txtMat3.Text = GunaDataGridView1.CurrentRow.Cells(9).Value
        txtQt3.Text = GunaDataGridView1.CurrentRow.Cells(10).Value
        txtPriz3.Text = GunaDataGridView1.CurrentRow.Cells(11).Value

        txtMat4.Text = GunaDataGridView1.CurrentRow.Cells(12).Value
        txtQt4.Text = GunaDataGridView1.CurrentRow.Cells(13).Value
        txtPriz4.Text = GunaDataGridView1.CurrentRow.Cells(14).Value

        txtMat5.Text = GunaDataGridView1.CurrentRow.Cells(15).Value
        txtQt5.Text = GunaDataGridView1.CurrentRow.Cells(16).Value
        txtPriz5.Text = GunaDataGridView1.CurrentRow.Cells(17).Value
    End Sub
End Class