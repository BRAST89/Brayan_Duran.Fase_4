Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Unad1DataSet.Estudiantes' Puede moverla o quitarla según sea necesario.
        Me.EstudiantesTableAdapter.Fill(Me.Unad1DataSet.Estudiantes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.EstudiantesTableAdapter.ingresar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
        Me.EstudiantesTableAdapter.Fill(Me.Unad1DataSet.Estudiantes)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.EstudiantesTableAdapter.borrar(TextBox1.Text)
        Me.EstudiantesTableAdapter.Fill(Me.Unad1DataSet.Estudiantes)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TensorFlow.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
