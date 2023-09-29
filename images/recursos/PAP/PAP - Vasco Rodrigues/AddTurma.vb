Imports System.Data.OleDb

Public Class AddTurma
    Dim con As New OleDbConnection

    Private Sub AddTurma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=C:\PAP - Vasco Rodrigues\DatabasePAP.accdb;"
        con.Open()
        If alterar = True Then
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT turma, ano FROM Turmas WHERE turma = '" & codturmaselecionado & "'", con)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                turma = dr("turma").ToString
                ano = dr("ano").ToString
            End While

            'Controlo dos objetos'
            tbturma.Text = turma
            cbano.Text = ano
            ButtonGuardarTurma.Visible = True
            ButtonAdicionarTurma.Visible = False
            Me.Text = "eValuatePRO - Alterar turma"
        Else
            'Controlo dos objetos'
            tbturma.ResetText()
            cbano.SelectedIndex = 0
            ButtonGuardarTurma.Visible = False
            ButtonAdicionarTurma.Visible = True
            Me.Text = "eValuatePRO - Adicionar turma"
        End If

        alterar = False
        con.Close()
    End Sub

    Private Sub ButtonGuardarTurma_Click(sender As Object, e As EventArgs) Handles ButtonGuardarTurma.Click
        con.Open()
        Try
            Dim cmd As OleDbCommand = New OleDbCommand("update Turmas set turma = '" & tbturma.Text & "', ano = " & cbano.Text & " WHERE turma = '" & turma & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Turma alterada com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "eValuatePRO")
            Turmas.TurmasTableAdapter.Fill(Turmas.DatabasePAPDataSet.Turmas)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "eValuatePRO")
        End Try
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonVoltar.Click
        Me.Close()
    End Sub

    Private Sub ButtonAdicionarTurma_Click(sender As Object, e As EventArgs) Handles ButtonAdicionarTurma.Click
        con.Open()
        Try
            Dim cmd As OleDbCommand = New OleDbCommand("insert into Turmas (turma, ano) values ('" & tbturma.Text & "','" & cbano.Text & "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Turma adicionada com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "eValuatePRO")
            Turmas.TurmasTableAdapter.Fill(Turmas.DatabasePAPDataSet.Turmas)
            Turmas.Button7.Enabled = True
            Turmas.Button6.Enabled = True
            tbturma.ResetText()
            tbturma.Focus()
            cbano.SelectedIndex = 0
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "eValuatePRO")
        End Try
        con.Close()
    End Sub
End Class