<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.AdmPicBox = New System.Windows.Forms.PictureBox()
        Me.ProfPicBox = New System.Windows.Forms.PictureBox()
        Me.AdmLabel = New System.Windows.Forms.Label()
        Me.ProfLabel = New System.Windows.Forms.Label()
        Me.ButtonVoltar = New System.Windows.Forms.Button()
        Me.ButtonEntrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.AdmPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AdmPicBox
        '
        Me.AdmPicBox.BackColor = System.Drawing.Color.Transparent
        Me.AdmPicBox.Image = CType(resources.GetObject("AdmPicBox.Image"), System.Drawing.Image)
        Me.AdmPicBox.Location = New System.Drawing.Point(60, 60)
        Me.AdmPicBox.Name = "AdmPicBox"
        Me.AdmPicBox.Size = New System.Drawing.Size(120, 120)
        Me.AdmPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AdmPicBox.TabIndex = 0
        Me.AdmPicBox.TabStop = False
        '
        'ProfPicBox
        '
        Me.ProfPicBox.BackColor = System.Drawing.Color.Transparent
        Me.ProfPicBox.Image = CType(resources.GetObject("ProfPicBox.Image"), System.Drawing.Image)
        Me.ProfPicBox.Location = New System.Drawing.Point(230, 60)
        Me.ProfPicBox.Name = "ProfPicBox"
        Me.ProfPicBox.Size = New System.Drawing.Size(120, 120)
        Me.ProfPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfPicBox.TabIndex = 1
        Me.ProfPicBox.TabStop = False
        '
        'AdmLabel
        '
        Me.AdmLabel.AutoSize = True
        Me.AdmLabel.BackColor = System.Drawing.Color.Transparent
        Me.AdmLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdmLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AdmLabel.Location = New System.Drawing.Point(57, 37)
        Me.AdmLabel.Name = "AdmLabel"
        Me.AdmLabel.Size = New System.Drawing.Size(126, 24)
        Me.AdmLabel.TabIndex = 2
        Me.AdmLabel.Text = "Administrador"
        '
        'ProfLabel
        '
        Me.ProfLabel.AutoSize = True
        Me.ProfLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProfLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProfLabel.Location = New System.Drawing.Point(245, 37)
        Me.ProfLabel.Name = "ProfLabel"
        Me.ProfLabel.Size = New System.Drawing.Size(89, 24)
        Me.ProfLabel.TabIndex = 3
        Me.ProfLabel.Text = "Professor"
        '
        'ButtonVoltar
        '
        Me.ButtonVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVoltar.Location = New System.Drawing.Point(169, 206)
        Me.ButtonVoltar.Name = "ButtonVoltar"
        Me.ButtonVoltar.Size = New System.Drawing.Size(75, 31)
        Me.ButtonVoltar.TabIndex = 4
        Me.ButtonVoltar.Text = "Voltar"
        Me.ButtonVoltar.UseVisualStyleBackColor = True
        Me.ButtonVoltar.Visible = False
        '
        'ButtonEntrar
        '
        Me.ButtonEntrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEntrar.Location = New System.Drawing.Point(169, 364)
        Me.ButtonEntrar.Name = "ButtonEntrar"
        Me.ButtonEntrar.Size = New System.Drawing.Size(75, 31)
        Me.ButtonEntrar.TabIndex = 5
        Me.ButtonEntrar.Text = "Entrar"
        Me.ButtonEntrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(57, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(60, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password:"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.Location = New System.Drawing.Point(163, 268)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(174, 30)
        Me.TextBoxUsername.TabIndex = 8
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("Bahnschrift SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(163, 308)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(174, 30)
        Me.TextBoxPassword.TabIndex = 9
        Me.TextBoxPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(27, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(364, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Por favor selecione o seu tipo de utilizador"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(341, 309)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(410, 437)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonEntrar)
        Me.Controls.Add(Me.ButtonVoltar)
        Me.Controls.Add(Me.ProfLabel)
        Me.Controls.Add(Me.AdmLabel)
        Me.Controls.Add(Me.ProfPicBox)
        Me.Controls.Add(Me.AdmPicBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eValuatePRO - Iniciar sessão"
        CType(Me.AdmPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AdmPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents ProfPicBox As System.Windows.Forms.PictureBox
    Friend WithEvents AdmLabel As System.Windows.Forms.Label
    Friend WithEvents ProfLabel As System.Windows.Forms.Label
    Friend WithEvents ButtonVoltar As System.Windows.Forms.Button
    Friend WithEvents ButtonEntrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
