Public Class Disciplinas

    Private Sub Disciplinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasePAPDataSet.Disciplinas' table. You can move, or remove it, as needed.
        Me.DisciplinasTableAdapter.Fill(Me.DatabasePAPDataSet.Disciplinas)

        If DisciplinasDataGridView.Rows.Count >= 1 Then
            Button7.Enabled = True
            Button6.Enabled = True
        Else
            Button7.Enabled = False
            Button6.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AddDisciplina.ShowDialog()
        alterar = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        alterar = True
        coddisciplinaselecionado = DisciplinasDataGridView.CurrentRow.Cells("coddisciplina").Value
        AddDisciplina.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim resp = MsgBox("Tem a certeza que quer eliminar o registo selecionado? " + vbNewLine + "Atenção, o registo será eliminado permanentemente, e" + vbNewLine + "não poderá ser recuperado.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "eValuatePRO")
        If resp = MsgBoxResult.Yes Then
            DisciplinasBindingSource.RemoveCurrent()
            DisciplinasBindingSource.EndEdit()
            DisciplinasTableAdapter.Update(DatabasePAPDataSet.Disciplinas)
            DisciplinasTableAdapter.Fill(DatabasePAPDataSet.Disciplinas)

            If DisciplinasDataGridView.Rows.Count = 0 Then
                Button7.Enabled = False
                Button6.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button7_MouseEnter(sender As Object, e As EventArgs) Handles Button7.MouseEnter
        Button7.ForeColor = Color.White
    End Sub

    Private Sub Button7_MouseLeave(sender As Object, e As EventArgs) Handles Button7.MouseLeave
        Button7.ForeColor = Color.Silver
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.ForeColor = Color.White
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.ForeColor = Color.Silver
    End Sub

    Private Sub Button6_MouseEnter(sender As Object, e As EventArgs) Handles Button6.MouseEnter
        Button6.ForeColor = Color.White
    End Sub

    Private Sub Button6_MouseLeave(sender As Object, e As EventArgs) Handles Button6.MouseLeave
        Button6.ForeColor = Color.Silver
    End Sub

    Private Sub ButtonFirst_Click(sender As Object, e As EventArgs) Handles ButtonFirst.Click
        DisciplinasBindingSource.MoveFirst()
    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        DisciplinasBindingSource.MovePrevious()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        DisciplinasBindingSource.MoveNext()
    End Sub

    Private Sub ButtonLast_Click(sender As Object, e As EventArgs) Handles ButtonLast.Click
        DisciplinasBindingSource.MoveLast()
    End Sub
End Class