Public Class Form1
    Private Sub BtnClick_Click(sender As Object, e As EventArgs) Handles BtnClick.Click
        Form2.Show()
    End Sub

    Private Sub SparePartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SparePartToolStripMenuItem.Click
        AboutBox1.Show()

    End Sub

    Private Sub FeedbackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeedbackToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub
End Class
