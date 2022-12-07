Public Class Condicionales
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        evaluacionC.Show()
    End Sub



    Private Sub Label3_MouseMove(sender As Object, e As MouseEventArgs) Handles Label3.MouseMove
        PictureBox1.Visible = True
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter
        AxWindowsMediaPlayer1.URL = "videos/condicionales.mp4"
    End Sub
End Class