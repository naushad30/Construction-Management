Public Class SSscreen
    Private Sub SSscreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
        Timer1.Interval = 100
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2ProgressBar1.Increment(10)
        labLoad.Text = Val(labLoad.Text) + 1
        If (Guna2ProgressBar1.Value = 100) Then
            Timer1.Stop()
            Me.Hide()
            Login.Show()
        End If


    End Sub

    Private Sub Guna2ProgressIndicator1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaWinCircleProgressIndicator1_Load(sender As Object, e As EventArgs)

    End Sub
End Class