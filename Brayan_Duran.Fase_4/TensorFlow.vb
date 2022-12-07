Public Class TensorFlow
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        PictureBox1.Visible = True
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        evaluacion.show()
    End Sub

    Private Sub Label3_MouseMove(sender As Object, e As MouseEventArgs) Handles Label3.MouseMove
        PictureBox1.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs) Handles AxWindowsMediaPlayer1.Enter
        AxWindowsMediaPlayer1.URL = "videos/TensorFlow.mp4"
    End Sub
End Class