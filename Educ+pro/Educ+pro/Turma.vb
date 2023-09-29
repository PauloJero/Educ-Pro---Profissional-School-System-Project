Public Class Turma
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form2.Show()
        Me.Close()
    End Sub


    Private Sub Turma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabasePAPDataSet.Turmas'. Você pode movê-la ou removê-la conforme necessário.
        Me.TurmasTableAdapter.Fill(Me.DatabasePAPDataSet.Turmas)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        TurmasBindingSource.MoveFirst()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        TurmasBindingSource.MovePrevious()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        TurmasBindingSource.MoveNext()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        TurmasBindingSource.MoveLast()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r = MsgBox("Tem a certeza que deseja eliminar o registo selecionado? " + vbNewLine + "Atenção, o registo após ser eliminado não poderá ser recuperado.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Educ+pro")
        If r = MsgBoxResult.Yes Then
            TurmasBindingSource.RemoveCurrent()
            TurmasBindingSource.EndEdit()
            TurmasTableAdapter.Update(DatabasePAPDataSet.Turmas)
            TurmasTableAdapter.Fill(DatabasePAPDataSet.Turmas)
        End If
    End Sub
End Class