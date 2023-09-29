Imports System.Data.OleDb
Imports System.IO

Public Class AddProfessor
    Dim myConnection As OleDbConnection = New OleDbConnection
    Dim img As String
    Dim con As New OleDbConnection
    Dim picselected As Boolean



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = " JPG | *.jpg"
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
            img = OpenFileDialog1.FileName
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
            'Confirma que foi selecionada uma foto'
            picselected = True
            Label9.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Fechar a conexão à base de dados'
        con.Close()
        'Fechar o formulário'
        Me.Close()
    End Sub

    Private Sub AddProfessor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabasePAPDataSet.Disciplinas' table. You can move, or remove it, as needed.
        Me.DisciplinasTableAdapter.Fill(Me.DatabasePAPDataSet.Disciplinas)
        'TODO: This line of code loads data into the 'DatabasePAPDataSet.Disciplinas' table. You can move, or remove it, as needed.
        Me.DisciplinasTableAdapter.Fill(Me.DatabasePAPDataSet.Disciplinas)
        'TODO: This line of code loads data into the 'DatabasePAPDataSet.Disciplinas' table. You can move, or remove it, as needed.
        'Me.DisciplinasTableAdapter.Fill(Me.DatabasePAPDataSet.Disciplinas)
        'Abrir a conexão à base de dados'
        con.ConnectionString = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=C:\PAP - Vasco Rodrigues\DatabasePAP.accdb;"
        con.Open()
        If alterar = True Then
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT codprof, username, passprof, nome, sexo, idade, morada, contacto, descdisciplinas, foto FROM Professores WHERE codprof = " & codprofselecionado & "", con)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                cod = dr("codprof").ToString
                username = dr("username").ToString
                password = dr("passprof").ToString
                nome = dr("nome").ToString
                sexo = dr("sexo").ToString
                idade = dr("idade").ToString
                morada = dr("morada").ToString
                contacto = dr("contacto").ToString
                descdisciplinas = dr("descdisciplinas").ToString

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

            tbusername.Text = username
            tbpassword.Text = password
            tbnome.Text = nome
            cbsexo.Text = sexo
            tbidade.Text = idade
            tbmorada.Text = morada
            tbcontacto.Text = contacto
            cbdisciplina.Text = descdisciplinas
            PictureBox1.Image = picture
            picselected = True
            Label9.Visible = True
            ButtonGuardarProf.Visible = True
            ButtonAdicionarProf.Visible = False
            Me.Text = "eValuatePRO - Alterar professor"
        Else
            'Controlo dos objetos'
            tbusername.ResetText()
            tbpassword.ResetText()
            tbnome.ResetText()
            tbidade.ResetText()
            cbsexo.SelectedIndex = 0
            tbmorada.ResetText()
            tbcontacto.ResetText()
            cbdisciplina.SelectedIndex = 0
            PictureBox1.Image = PictureBox2.Image
            picselected = False
            Label9.Visible = False
            ButtonGuardarProf.Visible = False
            ButtonAdicionarProf.Visible = True
            Me.Text = "eValuatePRO - Adicionar professor"
        End If

        alterar = False
        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAdicionarProf.Click
        con.Open()
        Try

            If picselected = True Then
                Dim cmd As OleDbCommand = New OleDbCommand("insert into Professores (nome, idade, sexo, morada, contacto, descdisciplinas, username, passprof, foto) values ('" & tbnome.Text & "','" & Val(tbidade.Text) & "','" & cbsexo.Text & "','" & tbmorada.Text & "','" & tbcontacto.Text & "','" & cbdisciplina.Text & "','" & tbusername.Text & "','" & tbpassword.Text & "',@EmpPic)", con)
                Dim MemStream As New MemoryStream
                Dim DataPic_Update As Byte()
                Me.PictureBox1.Image.Save(MemStream, Imaging.ImageFormat.Png)
                DataPic_Update = MemStream.GetBuffer()
                MemStream.Read(DataPic_Update, 0, MemStream.Length)
                Dim photo As OleDbParameter = New OleDbParameter("@EmpPic", SqlDbType.Image)
                photo.Value = DataPic_Update
                cmd.Parameters.Add(photo)
                cmd.ExecuteNonQuery()
                MsgBox("Professor adicionado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "eValuatePRO")
                Professores.ProfessoresTableAdapter.Fill(Professores.DatabasePAPDataSet.Professores)
                tbusername.ResetText()
                tbusername.Focus()
                tbpassword.ResetText()
                tbnome.ResetText()
                tbidade.ResetText()
                cbsexo.SelectedIndex = 0
                tbmorada.ResetText()
                tbcontacto.ResetText()
                cbdisciplina.SelectedIndex = 0
                PictureBox1.Image = Nothing
                picselected = False
                Label9.Visible = False
            Else
                Dim cmd As OleDbCommand = New OleDbCommand("insert into Professores (nome, idade, sexo, morada, contacto, descdisciplinas, username, passprof, foto) values ('" & tbnome.Text & "','" & Val(tbidade.Text) & "','" & cbsexo.Text & "','" & tbmorada.Text & "','" & tbcontacto.Text & "','" & cbdisciplina.Text & "','" & tbusername.Text & "','" & tbpassword.Text & "',@EmpPic)", con)
                Dim MemStream As New MemoryStream
                Dim DataPic_Update As Byte()
                Me.PictureBox2.Image.Save(MemStream, Imaging.ImageFormat.Png)
                DataPic_Update = MemStream.GetBuffer()
                MemStream.Read(DataPic_Update, 0, MemStream.Length)
                Dim photo As OleDbParameter = New OleDbParameter("@EmpPic", SqlDbType.Image)
                photo.Value = DataPic_Update
                cmd.Parameters.Add(photo)
                cmd.ExecuteNonQuery()
                MsgBox("Professor adicionado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "eValuatePRO")
                Professores.ProfessoresTableAdapter.Fill(Professores.DatabasePAPDataSet.Professores)
                tbusername.ResetText()
                tbusername.Focus()
                tbpassword.ResetText()
                tbnome.ResetText()
                tbidade.ResetText()
                cbsexo.SelectedIndex = 0
                tbmorada.ResetText()
                tbcontacto.ResetText()
                cbdisciplina.SelectedIndex = 0
                PictureBox1.Image = Nothing
                picselected = False
                Label9.Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        PictureBox1.Image = PictureBox2.Image
        Label9.Visible = False
        picselected = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonGuardarProf.Click
        con.Open()
        Try

            If picselected = True Then
                Dim cmd As OleDbCommand = New OleDbCommand("update Professores set nome = '" & tbnome.Text & "', idade = '" & Val(tbidade.Text) & "', sexo = '" & cbsexo.Text & "', morada = '" & tbmorada.Text & "', contacto = '" & tbcontacto.Text & "', descdisciplinas = '" & cbdisciplina.Text & "', username = '" & tbusername.Text & "', passprof = '" & tbpassword.Text & "', foto = @EmpPic WHERE codprof = " & codprofselecionado & "", con)
                Dim MemStream As New MemoryStream
                Dim DataPic_Update As Byte()
                Me.PictureBox1.Image.Save(MemStream, Imaging.ImageFormat.Png)
                DataPic_Update = MemStream.GetBuffer()
                MemStream.Read(DataPic_Update, 0, MemStream.Length)
                Dim photo As OleDbParameter = New OleDbParameter("@EmpPic", SqlDbType.Image)
                photo.Value = DataPic_Update
                cmd.Parameters.Add(photo)
                cmd.ExecuteNonQuery()
                MsgBox("Professor alterado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "eValuatePRO")
                Professores.ProfessoresTableAdapter.Fill(Professores.DatabasePAPDataSet.Professores)
            Else
                Dim cmd As OleDbCommand = New OleDbCommand("update Professores set nome = '" & tbnome.Text & "', idade = '" & Val(tbidade.Text) & "', sexo = '" & cbsexo.Text & "', morada = '" & tbmorada.Text & "', contacto = '" & tbcontacto.Text & "', descdisciplinas = '" & cbdisciplina.Text & "', username = '" & tbusername.Text & "', passprof = '" & tbpassword.Text & "', foto = @EmpPic WHERE codprof = " & codprofselecionado & "", con)
                Dim MemStream As New MemoryStream
                Dim DataPic_Update As Byte()
                Me.PictureBox2.Image.Save(MemStream, Imaging.ImageFormat.Png)
                DataPic_Update = MemStream.GetBuffer()
                MemStream.Read(DataPic_Update, 0, MemStream.Length)
                Dim photo As OleDbParameter = New OleDbParameter("@EmpPic", SqlDbType.Image)
                photo.Value = DataPic_Update
                cmd.Parameters.Add(photo)
                cmd.ExecuteNonQuery()
                MsgBox("Professor alterado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "eValuatePRO")
                Professores.ProfessoresTableAdapter.Fill(Professores.DatabasePAPDataSet.Professores)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Button1_Click(sender, e)
    End Sub

    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseUp
        tbpassword.PasswordChar = "*"
    End Sub

    Private Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        tbpassword.PasswordChar = ""
    End Sub
End Class