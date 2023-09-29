Public Class Aluno
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Aluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabasePAPDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
        Me.AlunosTableAdapter.Fill(Me.DatabasePAPDataSet.Alunos)

    End Sub

    Private Sub ButtonAlunos_Click(sender As Object, e As EventArgs) Handles ButtonAlunos.Click
        addaluno.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        AlunosBindingSource.MoveFirst()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        AlunosBindingSource.MovePrevious()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        AlunosBindingSource.MoveNext()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        AlunosBindingSource.MoveLast()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addaluno.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r = MsgBox("Tem a certeza que deseja eliminar o registo selecionado? " + vbNewLine + "Atenção, o registo após ser eliminado não poderá ser recuperado.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Educ+pro")
        If r = MsgBoxResult.Yes Then
            AlunosBindingSource.RemoveCurrent()
            AlunosBindingSource.EndEdit()
            AlunosTableAdapter.Update(DatabasePAPDataSet.Alunos)
            AlunosTableAdapter.Fill(DatabasePAPDataSet.Alunos)
        End If
    End Sub
End Class