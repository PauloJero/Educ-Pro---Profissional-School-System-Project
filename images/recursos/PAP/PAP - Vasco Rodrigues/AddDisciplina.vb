Imports System.Data.OleDb

Public Class AddDisciplina
    Dim con As New OleDbConnection

    Private Sub AddDisciplina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=C:\PAP - Vasco Rodrigues\DatabasePAP.accdb;"
        con.Open()
        If alterar = True Then
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT coddisciplina, designacao FROM Disciplinas WHERE coddisciplina = " & coddisciplinaselecionado & "", con)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                cod = dr("coddisciplina").ToString
                designacao = dr("designacao").ToString
            End While

            'Controlo dos objetos'
            tbdesignacao.Text = designacao
            ButtonGuardarDisciplina.Visible = True
            ButtonAdicionarDisciplina.Visible = False
            Me.Text = "eValuatePRO - Alterar disciplina"
        Else
            'Controlo dos objetos'
            tbdesignacao.ResetText()
            ButtonGuardarDisciplina.Visible = False
            ButtonAdicionarDisciplina.Visible = True
            Me.Text = "eValuatePRO - Adicionar disciplina"
        End If

        alterar = False
        con.Close()
    End Sub

    Private Sub ButtonGuardarDisciplina_Click(sender As Object, e As EventArgs) Handles ButtonGuardarDisciplina.Click
        con.Open()
        Try
            Dim cmd As OleDbCommand = New OleDbCommand("update Disciplinas set designacao = '" & tbdesignacao.Text & "' WHERE coddisciplina = " & coddisciplinaselecionado & "", con)
            cmd.ExecuteNonQuery()
            MsgBox("Disciplina alterada com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "eValuatePRO")
            Disciplinas.DisciplinasTableAdapter.Fill(Disciplinas.DatabasePAPDataSet.Disciplinas)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "eValuatePRO")
        End Try
        con.Close()
    End Sub

    Private Sub ButtonVoltar_Click(sender As Object, e As EventArgs) Handles ButtonVoltar.Click
        'Fechar a conexão à base de dados'
        con.Close()
        'Fechar o formulário'
        Me.Close()
    End Sub

    Private Sub ButtonAdicionarDisciplina_Click(sender As Object, e As EventArgs) Handles ButtonAdicionarDisciplina.Click
        con.Open()
        Try
            Dim cmd As OleDbCommand = New OleDbCommand("insert into Disciplinas (designacao) values ('" & tbdesignacao.Text & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Disciplina adicionada com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "eValuatePRO")
            Disciplinas.DisciplinasTableAdapter.Fill(Disciplinas.DatabasePAPDataSet.Disciplinas)
            Disciplinas.Button7.Enabled = True
            Disciplinas.Button6.Enabled = True
            tbdesignacao.ResetText()
            tbdesignacao.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "eValuatePRO")
        End Try
        con.Close()
    End Sub
End Class