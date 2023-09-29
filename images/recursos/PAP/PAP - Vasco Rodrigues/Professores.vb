Public Class Professores

    Private Sub Professores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProfessoresTableAdapter.Fill(DatabasePAPDataSet.Professores)

        If ProfessoresDataGridView.Rows.Count >= 1 Then
            Button7.Enabled = True
            Button6.Enabled = True
        Else
            Button7.Enabled = False
            Button6.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AddProfessor.ShowDialog()
        alterar = False
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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim resp = MsgBox("Tem a certeza que quer eliminar o registo selecionado? " + vbNewLine + "Atenção, o registo será eliminado permanentemente, e" + vbNewLine + "não poderá ser recuperado.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "eValuatePRO")
        If resp = MsgBoxResult.Yes Then
            ProfessoresBindingSource.RemoveCurrent()
            ProfessoresBindingSource.EndEdit()
            ProfessoresTableAdapter.Update(DatabasePAPDataSet.Professores)
            ProfessoresTableAdapter.Fill(DatabasePAPDataSet.Professores)

            If ProfessoresDataGridView.Rows.Count = 0 Then
                Button7.Enabled = False
                Button6.Enabled = False
            End If
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles ButtonFirst.Click
        ProfessoresBindingSource.MoveFirst()
    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        ProfessoresBindingSource.MovePrevious()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        ProfessoresBindingSource.MoveNext()
    End Sub

    Private Sub ButtonLast_Click(sender As Object, e As EventArgs) Handles ButtonLast.Click
        ProfessoresBindingSource.MoveLast()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        alterar = True
        codprofselecionado = ProfessoresDataGridView.CurrentRow.Cells("codprof").Value
        AddProfessor.ShowDialog()
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        PassprofTextBox.PasswordChar = "*"
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        PassprofTextBox.PasswordChar = ""
    End Sub
End Class