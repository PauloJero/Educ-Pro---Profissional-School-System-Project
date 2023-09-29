Imports System.Data.OleDb
Public Class LoginForm
    Dim provider As String
    Dim ficheiro As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Private Sub AdmPicBox_Click(sender As Object, e As EventArgs) Handles AdmPicBox.Click

        'Controlo de objetos'
        ProfPicBox.Visible = False
        ProfLabel.Visible = False
        AdmPicBox.Location = New Point(144, 60)
        AdmLabel.Location = New Point(134, 37)
        ButtonVoltar.Visible = True
        Label3.Visible = False
        TextBoxUsername.Enabled = True
        TextBoxPassword.Enabled = True
        ButtonEntrar.Enabled = True

        'Identificação o tipo de utilizador que vai fazer login'
        TipoUser = "Administrador"

    End Sub

    Private Sub ProfPicBox_Click(sender As Object, e As EventArgs) Handles ProfPicBox.Click

        'Controlo de objetos'
        AdmPicBox.Visible = False
        AdmLabel.Visible = False
        ProfPicBox.Location = New Point(144, 60)
        ProfLabel.Location = New Point(160, 37)
        ButtonVoltar.Visible = True
        Label3.Visible = False
        TextBoxUsername.Enabled = True
        TextBoxPassword.Enabled = True
        ButtonEntrar.Enabled = True

        'Identificação o tipo de utilizador que vai fazer login'
        TipoUser = "Professor"

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Controlo de objetos'
        AdmPicBox.Location = New Point(60, 60)
        AdmLabel.Location = New Point(57, 37)
        AdmPicBox.Visible = True
        AdmLabel.Visible = True
        ProfPicBox.Location = New Point(230, 60)
        ProfLabel.Location = New Point(245, 37)
        ProfPicBox.Visible = True
        ProfLabel.Visible = True
        ButtonVoltar.Visible = False
        Label3.Visible = True
        TextBoxUsername.Enabled = False
        TextBoxPassword.Enabled = False
        ButtonEntrar.Enabled = False
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()

    End Sub

    Private Sub ButtonVoltar_Click(sender As Object, e As EventArgs) Handles ButtonVoltar.Click

        'Controlo de objetos'
        AdmPicBox.Location = New Point(60, 60)
        AdmLabel.Location = New Point(57, 37)
        AdmPicBox.Visible = True
        AdmLabel.Visible = True
        ProfPicBox.Location = New Point(230, 60)
        ProfLabel.Location = New Point(245, 37)
        ProfPicBox.Visible = True
        ProfLabel.Visible = True
        ButtonVoltar.Visible = False
        Label3.Visible = True
        TextBoxUsername.Enabled = False
        TextBoxPassword.Enabled = False
        ButtonEntrar.Enabled = False
        TextBoxUsername.Clear()
        TextBoxPassword.Clear()

    End Sub

    Private Sub ButtonEntrar_Click(sender As Object, e As EventArgs) Handles ButtonEntrar.Click
        'Verificação do preenchimento das caixas de texto e mensagens de erro.'
        If TextBoxUsername.Text <> "" Then
            If TextBoxPassword.Text <> "" Then

                'Ligação manual à base de dados
                provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
                ficheiro = "C:\PAP - Vasco Rodrigues\DatabasePAP.accdb"
                connString = provider & ficheiro
                myConnection.ConnectionString = connString

                Dim password As String = ""

                myConnection.Open()

                If TipoUser = "Administrador" Then

                    'Definir a pesquisa na tabela de Administradores'
                    Dim cmd As OleDbCommand = New OleDbCommand("SELECT codadmin, username, passadmin, nome, sexo, foto FROM Administradores WHERE username = '" & TextBoxUsername.Text & "'", myConnection)
                    Dim dr As OleDbDataReader = cmd.ExecuteReader

                    Dim userFound As Boolean = False

                    'Se a pesquisa encontrar resultados o leitor de dados vai ser executado'
                    While dr.Read
                        'Guardar os dados da pessoa que vai fazer login'
                        userFound = True
                        codlogin = dr("codadmin").ToString
                        username = dr("username").ToString
                        password = dr("passadmin").ToString
                        nome = dr("nome").ToString
                        sexo = dr("sexo").ToString
                        foto = dr("foto").ToString
                        picture = Nothing
                        If foto <> "" Then
                            Dim pictureData As Byte() = DirectCast(dr("foto"), Byte())
                            'Create a stream in memory containing the bytes that comprise the image.
                            Using stream As New IO.MemoryStream(pictureData)
                                'Read the stream and create an Image object from the data.'
                                picture = Image.FromStream(stream)
                            End Using
                        End If
                    End While

                    'Verificar se o utilizador foi encontrado
                    If userFound = True Then
                        'Se o utilizador for encontrado vai ver se a password está correta ou não'
                        If TextBoxPassword.Text = password Then
                            MenuInicial.Hide()
                            Me.Hide()
                            MenuPrincipal.ShowDialog()
                        Else
                            MsgBox("Password Incorreta", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "eValuatePRO - Iniciar sessão")
                            TextBoxPassword.Text = ""
                        End If
                    Else
                        'Se não for encontrado vai dar erro
                        MsgBox("Utilizador não encontrado", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "eValuatePRO - Iniciar sessão")
                    End If

                    myConnection.Close()

                    TextBoxPassword.Text = ""

                ElseIf TipoUser = "Professor" Then

                    'Definir a pesquisa na tabela de Professores'
                    Dim cmd As OleDbCommand = New OleDbCommand("SELECT codprof, username, passprof, nome, sexo, foto FROM Professores WHERE username = '" & TextBoxUsername.Text & "'", myConnection)
                    Dim dr As OleDbDataReader = cmd.ExecuteReader

                    Dim userFound As Boolean = False

                    'Se a pesquisa encontrar resultados o leitor de dados vai ser executado'
                    While dr.Read
                        'Guardar os dados da pessoa que vai fazer login'
                        userFound = True
                        codlogin = dr("codprof").ToString
                        username = dr("username").ToString
                        password = dr("passprof").ToString
                        nome = dr("nome").ToString
                        sexo = dr("sexo").ToString
                        foto = dr("foto").ToString
                        picture = Nothing
                        If foto <> "" Then
                            Dim pictureData As Byte() = DirectCast(dr("foto"), Byte())
                            'Create a stream in memory containing the bytes that comprise the image.
                            Using stream As New IO.MemoryStream(pictureData)
                                'Read the stream and create an Image object from the data.'
                                picture = Image.FromStream(stream)
                            End Using
                        End If
                    End While

                    'Verificar se o utilizador foi encontrado
                    If userFound = True Then
                        'Se o utilizador for encontrado vai ver se a password está correta ou não
                        If TextBoxPassword.Text = password Then
                            MenuInicial.Hide()
                            Me.Hide()
                            MenuPrincipal.ShowDialog()
                        Else
                            MsgBox("Password Incorreta", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "eValuatePRO - Iniciar sessão")
                            TextBoxPassword.Text = ""
                        End If
                    Else
                        'Se não for encontrado vai dar erro
                        MsgBox("Utilizador não encontrado", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "eValuatePRO - Iniciar sessão")
                    End If

                    myConnection.Close()

                    TextBoxPassword.Text = ""

                End If



            Else : MsgBox("Por favor introduza a sua password.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "eValuatePRO - Iniciar sessão")
            End If
        Else : MsgBox("Por favor introduza o seu username.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "eValuatePRO - Iniciar sessão")
        End If

    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        TextBoxPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        TextBoxPassword.UseSystemPasswordChar = False
    End Sub
End Class