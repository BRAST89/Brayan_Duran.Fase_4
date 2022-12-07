Public Class evaluacionC


    Private Property puntaje As Single
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
        GroupBox4.Visible = True
        GroupBox5.Visible = True
        Button3.Visible = True
        Timer1.Enabled = True
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        puntaje = 0
        If RadioButton1.Checked = True Then
            puntaje = puntaje + 1
        End If
        If RadioButton2.Checked = True Then
            MsgBox("la respuesta de la pregunta 1 es incorrecta")
        End If
        If RadioButton3.Checked = True Then
            MsgBox("la respuesta de la pregunta 1 es incorrecta")
        End If

        If RadioButton6.Checked = True Then
            puntaje = puntaje + 1
        End If
        If RadioButton4.Checked = True Then
            MsgBox("la respuesta de la pregunta 2 es incorrecta")
        End If
        If RadioButton5.Checked = True Then
            MsgBox("la respuesta de la pregunta 2 es incorrecta")
        End If

        If RadioButton7.Checked = True Then
            puntaje = puntaje + 1
        End If
        If RadioButton8.Checked = True Then
            MsgBox("la respuesta de la pregunta 3 es incorrecta")
        End If
        If RadioButton9.Checked = True Then
            MsgBox("la respuesta de la pregunta 3 es incorrecta")
        End If

        If RadioButton11.Checked = True Then
            puntaje = puntaje + 1
        End If
        If RadioButton10.Checked = True Then
            MsgBox("la respuesta de la pregunta 4 es incorrecta")
        End If


        If RadioButton15.Checked = True Then
            puntaje = puntaje + 1
        End If
        If RadioButton13.Checked = True Then
            MsgBox("la respuesta de la pregunta 5 es incorrecta")
        End If
        If RadioButton14.Checked = True Then
            MsgBox("la respuesta de la pregunta 5 es incorrecta")
        End If

        Label8.Text = puntaje

        MsgBox("su nota es" + " " + puntaje.ToString)


        If puntaje > 2 Then
            MsgBox("Aprobo el examen")
            Button2.Visible = True
        Else
            MsgBox("Reprobo el examen. intentelo nuevamente")
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = False
            GroupBox5.Visible = False
            Timer1.Stop()
            Timer1.Enabled = False
            Label10.Text = 180
        End If

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label10.Text += -1
        If Label10.Text = 0 Then
            Timer1.Enabled = False
            MsgBox("tu tiempo termino")
            Me.Close()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub


End Class