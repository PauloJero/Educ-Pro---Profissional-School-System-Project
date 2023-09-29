Public Class addaluno
    Private Sub AlunosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AlunosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AlunosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabasePAPDataSet)

    End Sub

    Private Sub Addaluno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabasePAPDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
        Me.AlunosTableAdapter.Fill(Me.DatabasePAPDataSet.Alunos)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Aluno.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Aluno.Show()
        Me.Close()
    End Sub
End Class