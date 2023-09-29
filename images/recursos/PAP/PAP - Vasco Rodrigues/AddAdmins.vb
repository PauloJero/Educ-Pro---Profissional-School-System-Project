Imports System.Data.OleDb
Imports System.IO

Public Class AddAdmins
    Dim img As String
    Dim con As New OleDbConnection
    Dim picselected As Boolean
    Private Sub PictureBox3_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDown
        tbpassword.PasswordChar = ""
    End Sub

    Private Sub PictureBox3_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseUp
        tbpassword.PasswordChar = "*"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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

    Private Sub AddAdmins_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.Ace.Oledb.12.0; Data Source=C:\PAP - Vasco Rodrigues\DatabasePAP.accdb;"
        con.Open()
        If alterar = True Then
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT codadmin, username, passadmin, nome, sexo, foto FROM Administradores WHERE codadmin = " & codadminselecionado & "", con)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                cod = dr("codadmin").ToString
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

            tbusername.Text = username
            tbpassword.Text = password
            tbnome.Text = nome
            cbsexo.Text = sexo
            PictureBox1.Image = picture
            picselected = True
            Label9.Visible = True
            ButtonGuardarAdmin.Visible = True
            ButtonAdicionarAdmin.Visible = False
            Me.Text = "eValuatePRO - Alterar administrador"
        Else
            'Controlo dos objetos'
            tbusername.ResetText()
            tbpassword.ResetText()
            tbnome.ResetText()
            cbsexo.SelectedIndex = 0
            PictureBox1.Image = PictureBox2.Image
            picselected = False
            Label9.Visible = False
            ButtonGuardarAdmin.Visible = False
            ButtonAdicionarAdmin.Visible = True
            Me.Text = "eValuatePRO - Adicionar administrador"
        End If

        alterar = False
        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Fechar a conexão à base de dados'
        con.Close()
        'Fechar o formulário'
        Me.Close()
    End Sub

    Private Sub ButtonAdicionarAdmin_Click(sender As Object, e As EventArgs) Handles ButtonAdicionarAdmin.Click
        con.Open()
        Try

            If picselected = True Then
                Dim cmd As OleDbCommand = New OleDbCommand("insert into Administradores (username, passadmin, nome, sexo, foto) values ('" & tbusername.Text & "','" & tbpassword.Text & "','" & tbnome.Text & "','" & cbsexo.Text & "',@EmpPic)", con)
                Dim MemStream As New MemoryStream
                Dim DataPic_Update As Byte()
                Me.PictureBox1.Image.Save(MemStream, Imaging.ImageFormat.Png)
                DataPic_Update = MemStream.GetBuffer()
                MemStream.Read(DataPic_Update, 0, MemStream.Length)
                Dim photo As OleDbParameter = New OleDbParameter("@EmpPic", SqlDbType.Image)
                photo.Value = DataPic_Update
                cmd.Parameters.Add(photo)
                cmd.ExecuteNonQuery()
                MsgBox("Administrador adicionado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "eValuatePRO")
                Admins.AdministradoresTableAdapter.Fill(Admins.DatabasePAPDataSet.Administradores)
                tbusername.ResetText()
                tbusername.Focus()
                tbpassword.ResetText()
                tbnome.ResetText()
                cbsexo.SelectedIndex = 0
                PictureBox1.Image = Nothing
                picselected = False
                Label9.Visible = False
            Else
                Dim cmd As OleDbCommand = New OleDbCommand("insert into Administradores (username, passadmin, nome, sexo, foto) values ('" & tbusername.Text & "','" & tbpassword.Text & "','" & tbnome.Text & "','" & cbsexo.Text & "',@EmpPic)", con)
                Dim MemStream As New MemoryStream
                Dim DataPic_Update As Byte()
                Me.PictureBox2.Image.Save(MemStream, Imaging.ImageFormat.Png)
                DataPic_Update = MemStream.GetBuffer()
                MemStream.Read(DataPic_Update, 0, MemStream.Length)
                Dim photo As OleDbParameter = New OleDbParameter("@EmpPic", SqlDbType.Image)
                photo.Value = DataPic_Update
                cmd.Parameters.Add(photo)
                cmd.ExecuteNonQuery()
                MsgBox("Administrador adicionado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "eValuatePRO")
                Admins.AdministradoresTableAdapter.Fill(Admins.DatabasePAPDataSet.Administradores)
                tbusername.ResetText()
                tbusername.Focus()
                tbpassword.ResetText()
                tbnome.ResetText()
                cbsexo.SelectedIndex = 0
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Button4_Click(sender, e)
    End Sub

    Private Sub ButtonGuardarAdmin_Click(sender As Object, e As EventArgs) Handles ButtonGuardarAdmin.Click
        con.Open()
        Try

            If picselected = True Then
                Dim cmd As OleDbCommand = New OleDbCommand("update Administradores set username = '" & tbusername.Text & "', passadmin = '" & tbpassword.Text & "', nome = '" & tbnome.Text & "', sexo = '" & cbsexo.Text & "', foto = @EmpPic WHERE codadmin = " & codadminselecionado & "", con)
                Dim MemStream As New MemoryStream
                Dim DataPic_Update As Byte()
                Me.PictureBox1.Image.Save(MemStream, Imaging.ImageFormat.Png)
                DataPic_Update = MemStream.GetBuffer()
                MemStream.Read(DataPic_Update, 0, MemStream.Length)
                Dim photo As OleDbParameter = New OleDbParameter("@EmpPic", SqlDbType.Image)
                photo.Value = DataPic_Update
                cmd.Parameters.Add(photo)
                cmd.ExecuteNonQuery()
                MsgBox("Administrador alterado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "eValuatePRO")
                Admins.AdministradoresTableAdapter.Fill(Admins.DatabasePAPDataSet.Administradores)
            Else
                Dim cmd As OleDbCommand = New OleDbCommand("update Administradores set username = '" & tbusername.Text & "', passadmin = '" & tbpassword.Text & "', nome = '" & tbnome.Text & "', sexo = '" & cbsexo.Text & "', foto = @EmpPic WHERE codadmin = " & codadminselecionado & "", con)
                Dim MemStream As New MemoryStream
                Dim DataPic_Update As Byte()
                Me.PictureBox2.Image.Save(MemStream, Imaging.ImageFormat.Png)
                DataPic_Update = MemStream.GetBuffer()
                MemStream.Read(DataPic_Update, 0, MemStream.Length)
                Dim photo As OleDbParameter = New OleDbParameter("@EmpPic", SqlDbType.Image)
                photo.Value = DataPic_Update
                cmd.Parameters.Add(photo)
                cmd.ExecuteNonQuery()
                MsgBox("Administrador alterado com sucesso!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "eValuatePRO")
                Admins.AdministradoresTableAdapter.Fill(Admins.DatabasePAPDataSet.Administradores)
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        con.Close()
    End Sub
End Class