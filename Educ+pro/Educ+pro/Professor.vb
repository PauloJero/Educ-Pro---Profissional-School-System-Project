Public Class Professor
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Professor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabasePAPDataSet.Professores'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProfessoresTableAdapter.Fill(Me.DatabasePAPDataSet.Professores)

    End Sub

    Private Sub Buttonprof_Click(sender As Object, e As EventArgs) Handles Buttonprof.Click
        addprof.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ProfessoresBindingSource.MoveFirst()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ProfessoresBindingSource.MovePrevious()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ProfessoresBindingSource.MoveNext()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ProfessoresBindingSource.MoveLast()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addprof.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r = MsgBox("Tem a certeza que deseja eliminar o registo selecionado? " + vbNewLine + "Atenção, o registo após ser eliminado não poderá ser recuperado.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Educ+pro")
        If r = MsgBoxResult.Yes Then
            ProfessoresBindingSource.RemoveCurrent()
            ProfessoresBindingSource.EndEdit()
            ProfessoresTableAdapter.Update(DatabasePAPDataSet.Professores)
            ProfessoresTableAdapter.Fill(DatabasePAPDataSet.Professores)
        End If
    End Sub
End Class