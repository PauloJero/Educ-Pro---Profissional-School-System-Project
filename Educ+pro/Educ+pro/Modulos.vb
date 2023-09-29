Public Class Modulos
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Notas_e_modulo.Show()
        Me.Close()
    End Sub


    Private Sub Modulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabasePAPDataSet.Modulos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ModulosTableAdapter.Fill(Me.DatabasePAPDataSet.Modulos)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ModulosBindingSource.MoveFirst()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        ModulosBindingSource.MovePrevious()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        ModulosBindingSource.MoveNext()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        ModulosBindingSource.MoveLast()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Notas_e_modulo.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r = MsgBox("Tem a certeza que deseja eliminar o registo selecionado? " + vbNewLine + "Atenção, o registo após ser eliminado não poderá ser recuperado.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Educ+pro")
        If r = MsgBoxResult.Yes Then
            ModulosBindingSource.RemoveCurrent()
            ModulosBindingSource.EndEdit()
            ModulosTableAdapter.Update(DatabasePAPDataSet.Modulos)
            ModulosTableAdapter.Fill(DatabasePAPDataSet.Modulos)
        End If
    End Sub
End Class