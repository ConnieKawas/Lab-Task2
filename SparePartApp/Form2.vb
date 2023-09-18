Public Class Form2
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
    End Sub

End Class