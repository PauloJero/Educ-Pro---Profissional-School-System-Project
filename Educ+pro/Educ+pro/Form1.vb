Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If UsernameTextBox.Text = "" Or PassadminTextBox.Text = "" Then
            MsgBox("Introduza os Dados em Falta!", MsgBoxStyle.Information)
        Else
            If Me.AdministradoresTableAdapter.Login(Me.DatabasePAPDataSet.Administradores, UsernameTextBox.Text, PassadminTextBox.Text) Then
                Form2.Show()
            Else
                MsgBox("Username ou Password Incorretos!", MsgBoxStyle.Exclamation)
            End If
        End If

        Dim AG As Form2 = New Form2

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.AdministradoresTableAdapter.Fill(Me.DatabasePAPDataSet.Administradores)
        UsernameTextBox.Text = ""
        PassadminTextBox.Text = ""
        PassadminTextBox.UseSystemPasswordChar = True

    End Sub
End Class