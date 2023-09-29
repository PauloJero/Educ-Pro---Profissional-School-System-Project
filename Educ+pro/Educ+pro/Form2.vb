Public Class Form2
    Public SP As Form1
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Form1.Visible = False
        Label2.Text = My.Forms.Form1.UsernameTextBox.Text + " !"

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
        Form1.Visible = True
        Form1.UsernameTextBox.Text = ""
        Form1.PassadminTextBox.Text = ""

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Text = TimeString
        Label7.Text = Today
    End Sub

    Private Sub ButtonAlunos_Click(sender As Object, e As EventArgs) Handles ButtonAlunos.Click
        Aluno.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Professor.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Turma.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Disciplina.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Notas_e_modulo.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Administrador.Show()
        Me.Close()
    End Sub
End Class