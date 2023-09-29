Public Class Admins
    Private Sub Admins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AdministradoresTableAdapter.Fill(Me.DatabasePAPDataSet.Administradores)

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles ButtonFirst.Click
        AdministradoresBindingSource.MoveFirst()
    End Sub

    Private Sub ButtonPrevious_Click(sender As Object, e As EventArgs) Handles ButtonPrevious.Click
        AdministradoresBindingSource.MovePrevious()
    End Sub

    Private Sub ButtonNext_Click(sender As Object, e As EventArgs) Handles ButtonNext.Click
        AdministradoresBindingSource.MoveNext()
    End Sub

    Private Sub ButtonLast_Click(sender As Object, e As EventArgs) Handles ButtonLast.Click
        AdministradoresBindingSource.MoveLast()
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

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        PassadminTextBox.PasswordChar = ""
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        PassadminTextBox.PasswordChar = "*"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AddAdmins.ShowDialog()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim resp = MsgBox("Tem a certeza que quer eliminar o registo selecionado? " + vbNewLine + "Atenção, o registo será eliminado permanentemente, e" + vbNewLine + "não poderá ser recuperado.", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "eValuatePRO")
        If resp = MsgBoxResult.Yes Then
            AdministradoresBindingSource.RemoveCurrent()
            AdministradoresBindingSource.EndEdit()
            AdministradoresTableAdapter.Update(DatabasePAPDataSet.Administradores)
            AdministradoresTableAdapter.Fill(DatabasePAPDataSet.Administradores)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        alterar = True
        codadminselecionado = AdministradoresDataGridView.CurrentRow.Cells("codadmin").Value
        AddAdmins.ShowDialog()
    End Sub
End Class