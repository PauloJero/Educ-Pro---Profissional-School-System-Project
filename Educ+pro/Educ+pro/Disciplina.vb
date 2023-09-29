Public Class Disciplina
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Disciplina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabasePAPDataSet.Disciplinas'. Você pode movê-la ou removê-la conforme necessário.
        Me.DisciplinasTableAdapter.Fill(Me.DatabasePAPDataSet.Disciplinas)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        DisciplinasBindingSource.MoveFirst()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        DisciplinasBindingSource.MovePrevious()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        DisciplinasBindingSource.MoveNext()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        DisciplinasBindingSource.MoveLast()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r = MsgBox("Tem a certeza que deseja eliminar o registo selecionado? " + vbNewLine + "Atenção, o registo após ser eliminado não poderá ser recuperado.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Educ+pro")
        If r = MsgBoxResult.Yes Then
            DisciplinasBindingSource.RemoveCurrent()
            DisciplinasBindingSource.EndEdit()
            DisciplinasTableAdapter.Update(DatabasePAPDataSet.Disciplinas)
            DisciplinasTableAdapter.Fill(DatabasePAPDataSet.Disciplinas)
        End If
    End Sub
End Class