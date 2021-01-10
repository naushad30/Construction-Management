Imports MySql.Data.MySqlClient
Public Class AdvPay

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")

    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As Integer

    Dim da As New OleDb.OleDbDataAdapter



    Private Sub AdvPay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtAdvDate.Format = DateTimePickerFormat.Custom
        txtAdvDate.CustomFormat = "dd-MM-yyyy"



        txtAdvDate.Value = Date.Today
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



    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAdvName.Clear()
        txtAdvAmo.Clear()

        txtAdvAddress.Clear()
        txtAdvMob.Clear()

        txtAdvRemain.Clear()
    End Sub

    Sub loadrecord()
        Try
            Dim dt As New DataTable
            con.Open()


            sql = "select * from AdvPayTable"
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
        GunaDataGridView1.Columns(2).HeaderText = "Amount"
        GunaDataGridView1.Columns(3).HeaderText = "Date"
        GunaDataGridView1.Columns(4).HeaderText = "Address"
        GunaDataGridView1.Columns(5).HeaderText = "Mobile no"
        GunaDataGridView1.Columns(6).HeaderText = "Status"
        GunaDataGridView1.Columns(7).HeaderText = "Type"
        GunaDataGridView1.Columns(8).HeaderText = "Remaining"
    End Sub
    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        loadrecord()

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (txtAdvAddress.Text = "" Or txtAdvAmo.Text = "" Or txtAdvDate.Text = "" Or txtAdvMob.Text = "" Or txtAdvName.Text = "" Or txtAdvRemain.Text = "") Then
            MessageBox.Show("Please Fill The Details !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'MsgBox("Please Fill The Details !")
        Else


            Try
                con.Open()


                sql = "INSERT INTO AdvPayTable (AdvPayName,AdvPayAmount,AdvPayDate,AdvPayAddress,AdvPayMob,Status,Type,Remaining) values ('" & txtAdvName.Text & "'," & Val(txtAdvAmo.Text) & ",'" & txtAdvDate.Value.ToString("dd - MM - yyyy") & "','" & txtAdvAddress.Text & "','" & txtAdvMob.Text & "','" & comboStatus.Text & "','" & comboType.Text & "'," & Val(txtAdvRemain.Text) & ")"
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
            txtAdvName.Clear()
            txtAdvAmo.Clear()

            txtAdvAddress.Clear()
            txtAdvMob.Clear()

            txtAdvRemain.Clear()
        End If
    End Sub



    Private Sub GunaDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GunaDataGridView1.CellClick
        Me.Text = GunaDataGridView1.CurrentRow.Cells(0).Value
        txtAdvName.Text = GunaDataGridView1.CurrentRow.Cells(1).Value
        txtAdvAmo.Text = GunaDataGridView1.CurrentRow.Cells(2).Value
        txtAdvDate.Value = GunaDataGridView1.CurrentRow.Cells(3).Value
        txtAdvAddress.Text = GunaDataGridView1.CurrentRow.Cells(4).Value
        txtAdvMob.Text = GunaDataGridView1.CurrentRow.Cells(5).Value
        comboStatus.Text = GunaDataGridView1.CurrentRow.Cells(6).Value
        comboType.Text &= GunaDataGridView1.CurrentRow.Cells(7).Value
        txtAdvRemain.Text = GunaDataGridView1.CurrentRow.Cells(8).Value

    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click



        Try
            con.Open()


            sql = "UPDATE AdvPayTable SET AdvPayName='" & txtAdvName.Text & "', AdvPayAmount=" & Val(txtAdvAmo.Text) & ", AdvPayDate='" & txtAdvDate.Value.ToString("dd - MM - yyyy") & "',AdvPayAddress='" & txtAdvAddress.Text & "',AdvPayMob='" & txtAdvMob.Text & "',Status='" & comboStatus.Text & "',Type='" & comboType.Text & "',Remaining=" & Val(txtAdvRemain.Text) & " WHERE AdvPayID = " & Val(Me.Text) & ""
            cmd.Connection = con
            cmd.CommandText = sql

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("New Record  has Been Updated Successfully !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MsgBox(" Record  has Been Updated Successfully !")
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
        txtAdvName.Clear()
        txtAdvAmo.Clear()

        txtAdvAddress.Clear()
        txtAdvMob.Clear()

        txtAdvRemain.Clear()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans As String
        ans = MsgBox("Are you sure you want to DELETE this record ?", vbYesNo)
        If ans = vbYes Then

            Try
                con.Open()


                sql = "DELETE * from AdvPayTable WHERE AdvPayID = " & Val(Me.Text) & ""
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


End Class