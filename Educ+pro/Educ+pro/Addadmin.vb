Public Class Addadmin
    Private Sub AdministradoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AdministradoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AdministradoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabasePAPDataSet)

    End Sub

    Private Sub Addadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabasePAPDataSet.Administradores'. Você pode movê-la ou removê-la conforme necessário.
        Me.AdministradoresTableAdapter.Fill(Me.DatabasePAPDataSet.Administradores)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Administrador.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Administrador.Show()
        Me.Close()
    End Sub
End Class