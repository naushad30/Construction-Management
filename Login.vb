Imports MySql.Data.MySqlClient
Imports System.Data.OleDb
Public Class Login

    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\SSConstruction.accdb")


    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If (txtUser.Text = "" Or txtPass.Text = "") Then

            MessageBox.Show("Please Enter Username & Password !",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'MsgBox("Please Enter Username & Password !")
        Else

            Dim cmd As New OleDbCommand("select UserPass, UserPass from AdminUserTable where UserName= '" & txtUser.Text & "' and UserPass= '" & txtPass.Text & "' ", con)

            Dim adapter As New OleDbDataAdapter(cmd)
            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count = 0 Then
                MessageBox.Show("Invalid Username Or Password", "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                'MessageBox.Show("Login Successful...!!!", "S S Construction")

                MessageBox.Show("Login Successful...!",
                            "S S Construction",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)


                Dim newForm As New Home()
                newForm.Show()

                Me.Hide()

            End If
        End If
    End Sub



    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2ShadowForm1.SetShadowForm(Me)
    End Sub

    Friend Shared Sub open()
        Throw New NotImplementedException()
    End Sub





    Private Sub BtnFog_Click(sender As Object, e As EventArgs) Handles btnFog.Click
        Dim newForm As New ChangePassword()
        newForm.Show()
    End Sub

    Private Sub BtnSignup_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton1_Click_1(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim newForm As New SignUp()
        newForm.Show()
    End Sub
End Class