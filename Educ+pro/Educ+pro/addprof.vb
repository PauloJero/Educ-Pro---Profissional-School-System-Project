Public Class addprof
    Private Sub ProfessoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProfessoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfessoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabasePAPDataSet)

    End Sub

    Private Sub Addprof_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DatabasePAPDataSet.Professores'. Você pode movê-la ou removê-la conforme necessário.
        Me.ProfessoresTableAdapter.Fill(Me.DatabasePAPDataSet.Professores)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Professor.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Professor.Show()
        Me.Close()
    End Sub
End Class