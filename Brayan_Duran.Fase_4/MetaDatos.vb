Public Class MetaDatos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        evaluacionM.Show()
    End Sub


    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox1.Visible = True
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_MouseMove(sender As Object, e As MouseEventArgs) Handles Label3.MouseMove
        PictureBox1.Visible = True
    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter
        AxWindowsMediaPlayer1.URL = "videos/metadatos.mp4"
    End Sub
End Class