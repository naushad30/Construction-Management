Imports System.Data.OleDb
Imports System.Data.SqlClient


Public Class ChangePassword

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")
    Dim cmd As New OleDbCommand
    Dim sql As String
    Dim i As Integer



    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnSubmit.Enabled = False

        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (txtNewPass.Text = "" Or txtAns.Text = "" Or txtUser.Text = "" Or txtConfPass.Text = "") Then
            MessageBox.Show("Please Fill The Details !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'MsgBox("Please Enter All Details !")
        Else
            Try
                con.Open()


                sql = "UPDATE AdminUserTable SET UserPass='" & txtNewPass.Text & "' where SAn='" & txtAns.Text & "' and UserName='" & txtUser.Text & "' "
                'sql = "UPDATE AdminUserTable SET UserPass='" & txtNewPass.Text & "' WHERE AdminID = """


                cmd.Connection = con
                cmd.CommandText = sql

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Password Changed Successfully !")
                    Me.Hide()
                    Login.Show()

                Else
                    MsgBox("Error !")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally



            End Try

        End If

        con.Close()
    End Sub
    Private Sub TxtConfPass_TextChanged(sender As Object, e As EventArgs) Handles txtConfPass.TextChanged
        If (txtConfPass.Text = "") Then
            labCon.Text = ""
        Else
            con.Open()
            If (txtNewPass.Text = txtConfPass.Text) Then
                labCon.Text = "Matched"
                labCon.ForeColor = Color.Green
                btnSubmit.Enabled = True
            Else
                labCon.Text = "Not Matched"
                labCon.ForeColor = Color.Red
                btnSubmit.Enabled = False
            End If
            con.Close()
        End If
    End Sub







    Private Sub ComboQsn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboQsn.SelectedIndexChanged
        If (comboQsn.Text = "") Then
            labVal.Text = ""
        Else

            con.Open()
            'Dim cmd As New OleDbCommand("select UserName from AdminUserTable where SQn= '" & comboQsn.Text & "' ", con)
            Dim cmd As New OleDbCommand("select SQn from AdminUserTable where UserName= '" & txtUser.Text & "' ", con)
            Dim pass1 As String = cmd.ExecuteScalar()



            If (pass1 = comboQsn.Text) Then
                labVal.Text = "User Found"
                labVal.ForeColor = Color.Green
                btnSubmit.Enabled = True
            Else
                labVal.Text = "User Not Found"
                labVal.ForeColor = Color.Red
                btnSubmit.Enabled = False
            End If
            con.Close()
        End If
    End Sub


    Private Sub TxtAns_TextChanged(sender As Object, e As EventArgs) Handles txtAns.TextChanged
        If (txtAns.Text = "") Then
            labmat.Text = ""
        Else
            con.Open()
            Dim cmd As New OleDbCommand("select SQn from AdminUserTable where SAn= '" & txtAns.Text & "' ", con)
            Dim pass As String = cmd.ExecuteScalar()



            If (pass = comboQsn.Text) Then
                labmat.Text = "Correct"
                labmat.ForeColor = Color.Green
                btnSubmit.Enabled = True
            Else
                labmat.Text = "Incorrect"
                labmat.ForeColor = Color.Red
                btnSubmit.Enabled = False
            End If
            con.Close()
        End If
    End Sub
    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles txtUser.TextChanged

    End Sub
End Class