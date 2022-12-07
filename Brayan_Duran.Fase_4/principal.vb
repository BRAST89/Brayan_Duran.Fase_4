Public Class principal
    Dim contador As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "123" And TextBox2.Text = "usuario" Then
            Form1.Show()
            Timer1.Stop()
        Else
            MsgBox("usuario y contraseña no coinciden")
            contador = contador + 1

            If contador = 4 Then
                MsgBox("Numero de intentos 4")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox1.Focus()
                Timer1.Enabled = False
                Label3.Text = 60
                TextBox1.Enabled = False
                TextBox2.Enabled = False
                Button1.Enabled = False

            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text += -1
        If Label3.Text = 0 Then
            Timer1.Enabled = False
            MsgBox("tu tiempo termino")
            Me.Close()
        End If
    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Timer1.Enabled = True
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        Button1.Enabled = True
    End Sub
End Class