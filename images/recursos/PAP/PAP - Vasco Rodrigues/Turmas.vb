Public Class Turmas

    Private Sub Turmas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasePAPDataSet.Turmas' table. You can move, or remove it, as needed.
        Me.TurmasTableAdapter.Fill(Me.DatabasePAPDataSet.Turmas)

        If TurmasDataGridView.Rows.Count >= 1 Then
            Button7.Enabled = True
            Button6.Enabled = True
        Else
            Button7.Enabled = False
            Button6.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AddTurma.ShowDialog()
        alterar = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        alterar = True
        codturmaselecionado = TurmasDataGridView.CurrentRow.Cells("turma").Value
        AddTurma.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim resp = MsgBox("Tem a certeza que quer eliminar o registo selecionado? " + vbNewLine + "Atenção, o registo será eliminado permanentemente, e" + vbNewLine + "não poderá ser recuperado.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "eValuatePRO")
        If resp = MsgBoxResult.Yes Then
            TurmasBindingSource.RemoveCurrent()
            TurmasBindingSource.EndEdit()
            TurmasTableAdapter.Update(DatabasePAPDataSet.Turmas)
            TurmasTableAdapter.Fill(DatabasePAPDataSet.Turmas)

            If TurmasDataGridView.Rows.Count = 0 Then
                Button7.Enabled = False
                Button6.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.ForeColor = Color.Red
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.ForeColor = Color.Black
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.ForeColor = Color.Green
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.ForeColor = Color.Black
    End Sub

    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        Button6.ForeColor = Color.Orange
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Button6.ForeColor = Color.Black
    End Sub

    Private Sub ButtonFirst_Click(sender As Object, e As EventArgs) Handles ButtonFirst.Click
        TurmasBindingSource.MoveFirst()
    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        TurmasBindingSource.MovePrevious()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        TurmasBindingSource.MoveNext()
    End Sub

    Private Sub ButtonLast_Click(sender As Object, e As EventArgs) Handles ButtonLast.Click
        TurmasBindingSource.MoveLast()
    End Sub
End Class