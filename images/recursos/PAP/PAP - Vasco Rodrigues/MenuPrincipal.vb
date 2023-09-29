Public Class MenuPrincipal
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameLabel.Text = nome
        TipoUserLabel.Text = TipoUser
        ProfilePicBox.Image = picture

        If TipoUser = "Administrador" Then
            AdminTipoUserPicBox.Visible = True
            ProfTipoUserPicBox.Visible = False
            Panel1.Visible = True
            Panel2.Visible = False
        ElseIf TipoUser = "Professor" Then
            AdminTipoUserPicBox.Visible = False
            ProfTipoUserPicBox.Visible = True
            Panel1.Visible = False
            Panel2.Visible = True
        End If
        If sexo = "Masculino" Then
            LabelWelcome.Text = "Bem vindo,"
        ElseIf sexo = "Feminino" Then
            LabelWelcome.Text = "Bem vinda,"
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim resp = MsgBox("Tem a certeza que quer fechar o programa?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "eValuatePRO - Fechar o programa")
        If resp = MsgBoxResult.Yes Then
            MenuInicial.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim resp = MsgBox("Tem a certeza que quer terminar a sessão?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "eValuatePRO - Terminar sessão")
        If resp = MsgBoxResult.Yes Then
            Me.Close()
            LoginForm.Show()
            LoginForm.Close()
            MenuInicial.Show()
        End If
    End Sub

    Private Sub ButtonProfessores_Click(sender As Object, e As EventArgs) Handles ButtonProfessores.Click
        Professores.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Admins.ShowDialog()
    End Sub

    Private Sub ButtonDisciplinas_Click(sender As Object, e As EventArgs) Handles ButtonDisciplinas.Click
        Disciplinas.ShowDialog()
    End Sub

    Private Sub ButtonTurmas_Click(sender As Object, e As EventArgs) Handles ButtonTurmas.Click
        Turmas.ShowDialog()
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs) Handles Button5.MouseEnter
        Button5.ForeColor = Color.White
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        Button5.ForeColor = Color.DarkGray
    End Sub

    Private Sub ButtonAlunos_MouseEnter(sender As Object, e As EventArgs) Handles ButtonAlunos.MouseEnter
        ButtonAlunos.ForeColor = Color.White
    End Sub

    Private Sub ButtonAlunos_MouseLeave(sender As Object, e As EventArgs) Handles ButtonAlunos.MouseLeave
        ButtonAlunos.ForeColor = Color.DarkGray
    End Sub

    Private Sub ButtonProfessores_MouseEnter(sender As Object, e As EventArgs) Handles ButtonProfessores.MouseEnter
        ButtonProfessores.ForeColor = Color.White

    End Sub

    Private Sub ButtonProfessores_MouseLeave(sender As Object, e As EventArgs) Handles ButtonProfessores.MouseLeave
        ButtonProfessores.ForeColor = Color.DarkGray

    End Sub

    Private Sub ButtonTurmas_MouseEnter(sender As Object, e As EventArgs) Handles ButtonTurmas.MouseEnter
        ButtonTurmas.ForeColor = Color.White

    End Sub

    Private Sub ButtonTurmas_MouseLeave(sender As Object, e As EventArgs) Handles ButtonTurmas.MouseLeave
        ButtonTurmas.ForeColor = Color.DarkGray

    End Sub

    Private Sub ButtonDisciplinas_MouseEnter(sender As Object, e As EventArgs) Handles ButtonDisciplinas.MouseEnter
        ButtonDisciplinas.ForeColor = Color.White

    End Sub

    Private Sub ButtonDisciplinas_MouseLeave(sender As Object, e As EventArgs) Handles ButtonDisciplinas.MouseLeave
        ButtonDisciplinas.ForeColor = Color.DarkGray

    End Sub

    Private Sub ButtonModulos_MouseEnter(sender As Object, e As EventArgs) Handles ButtonModulos.MouseEnter
        ButtonModulos.ForeColor = Color.White

    End Sub

    Private Sub ButtonModulos_MouseLeave(sender As Object, e As EventArgs) Handles ButtonModulos.MouseLeave
        ButtonModulos.ForeColor = Color.DarkGray

    End Sub

    Private Sub ButtonAlunos_Click(sender As Object, e As EventArgs) Handles ButtonAlunos.Click
        Alunos.ShowDialog()
    End Sub
End Class