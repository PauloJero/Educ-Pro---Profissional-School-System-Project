﻿Public Class Notas
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Notas_e_modulo.Show()
        Me.Close()
    End Sub

    Private Sub Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabasePAPDataSet.Notas'. Você pode movê-la ou removê-la conforme necessário.
        Me.NotasTableAdapter.Fill(Me.DatabasePAPDataSet.Notas)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        NotasBindingSource.MoveFirst()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        NotasBindingSource.MovePrevious()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        NotasBindingSource.MoveNext()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        NotasBindingSource.MoveLast()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Notas_e_modulo.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim r = MsgBox("Tem a certeza que deseja eliminar o registo selecionado? " + vbNewLine + "Atenção, o registo após ser eliminado não poderá ser recuperado.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Educ+pro")
        If r = MsgBoxResult.Yes Then
            NotasBindingSource.RemoveCurrent()
            NotasBindingSource.EndEdit()
            NotasTableAdapter.Update(DatabasePAPDataSet.Notas)
            NotasTableAdapter.Fill(DatabasePAPDataSet.Notas)
        End If
    End Sub
End Class