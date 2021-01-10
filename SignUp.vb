Imports System.Data.OleDb

Public Class SignUp
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")
    Dim sql As String
    Dim cmd As New OleDb.OleDbCommand
    Dim i As Integer
    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint
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
    End Sub


    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub

    Private Sub BtnSbmt_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (txtUser.Text = "" Or txtAns.Text = "" Or txtConfPass.Text = "" Or txtPass.Text = "") Then
            MessageBox.Show("Please Fill The Details !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'MsgBox("Please Fill The Details !")
        Else

            Try
                con.Open()


                sql = "INSERT INTO AdminUserTable (UserName,UserPass,SQn,SAn) values ('" & txtUser.Text & "','" & txtPass.Text & "','" & comboQsn.Text & "','" & txtAns.Text & "')"
                cmd.Connection = con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Sign Up Successfully !")
                    Me.Hide()

                Else
                    MsgBox("No Record  has Been Inserted !")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally

                con.Close()

            End Try
        End If
    End Sub

    Private Sub TxtConfPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfPass.TextChanged
        If (txtConfPass.Text = "") Then
            labmat.Text = ""
        Else

            con.Open()
            If (txtPass.Text = txtConfPass.Text) Then
                labmat.Text = "Matched"
                labmat.ForeColor = Color.Green
                btnSubmit.Enabled = True
            Else
                labmat.Text = "Not Matched"
                labmat.ForeColor = Color.Red
                btnSubmit.Enabled = False
            End If
            con.Close()
        End If
    End Sub
End Class