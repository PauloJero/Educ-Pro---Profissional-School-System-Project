Public Class MenuInicial

    Private Sub MenuSair_Click(sender As Object, e As EventArgs) Handles MenuSair.Click
        Dim resp = MsgBox("Tem a certeza que quer sair do programa?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Sair")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LoginForm.ShowDialog()
    End Sub

    Private Sub MenuInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
