<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTurma
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddTurma))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbano = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbturma = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonAdicionarTurma = New System.Windows.Forms.Button()
        Me.ButtonGuardarTurma = New System.Windows.Forms.Button()
        Me.ButtonVoltar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(307, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ano:"
        '
        'cbano
        '
        Me.cbano.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbano.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbano.FormattingEnabled = True
        Me.cbano.Items.AddRange(New Object() {"10", "11", "12"})
        Me.cbano.Location = New System.Drawing.Point(349, 21)
        Me.cbano.Name = "cbano"
        Me.cbano.Size = New System.Drawing.Size(61, 29)
        Me.cbano.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Designação da Turma:"
        '
        'tbturma
        '
        Me.tbturma.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbturma.Location = New System.Drawing.Point(181, 21)
        Me.tbturma.MaxLength = 10
        Me.tbturma.Name = "tbturma"
        Me.tbturma.Size = New System.Drawing.Size(120, 29)
        Me.tbturma.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(411, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "º"
        '
        'ButtonAdicionarTurma
        '
        Me.ButtonAdicionarTurma.BackgroundImage = CType(resources.GetObject("ButtonAdicionarTurma.BackgroundImage"), System.Drawing.Image)
        Me.ButtonAdicionarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAdicionarTurma.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdicionarTurma.Location = New System.Drawing.Point(326, 63)
        Me.ButtonAdicionarTurma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonAdicionarTurma.Name = "ButtonAdicionarTurma"
        Me.ButtonAdicionarTurma.Size = New System.Drawing.Size(102, 34)
        Me.ButtonAdicionarTurma.TabIndex = 30
        Me.ButtonAdicionarTurma.Text = "Adicionar"
        Me.ButtonAdicionarTurma.UseVisualStyleBackColor = True
        '
        'ButtonGuardarTurma
        '
        Me.ButtonGuardarTurma.BackgroundImage = CType(resources.GetObject("ButtonGuardarTurma.BackgroundImage"), System.Drawing.Image)
        Me.ButtonGuardarTurma.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonGuardarTurma.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardarTurma.Location = New System.Drawing.Point(326, 63)
        Me.ButtonGuardarTurma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonGuardarTurma.Name = "ButtonGuardarTurma"
        Me.ButtonGuardarTurma.Size = New System.Drawing.Size(102, 34)
        Me.ButtonGuardarTurma.TabIndex = 32
        Me.ButtonGuardarTurma.Text = "Guardar"
        Me.ButtonGuardarTurma.UseVisualStyleBackColor = True
        '
        'ButtonVoltar
        '
        Me.ButtonVoltar.BackgroundImage = CType(resources.GetObject("ButtonVoltar.BackgroundImage"), System.Drawing.Image)
        Me.ButtonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonVoltar.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVoltar.Location = New System.Drawing.Point(11, 65)
        Me.ButtonVoltar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonVoltar.Name = "ButtonVoltar"
        Me.ButtonVoltar.Size = New System.Drawing.Size(102, 34)
        Me.ButtonVoltar.TabIndex = 33
        Me.ButtonVoltar.Text = "< Voltar"
        Me.ButtonVoltar.UseVisualStyleBackColor = True
        '
        'AddTurma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(440, 109)
        Me.Controls.Add(Me.ButtonVoltar)
        Me.Controls.Add(Me.cbano)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbturma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonAdicionarTurma)
        Me.Controls.Add(Me.ButtonGuardarTurma)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddTurma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eValuatePRO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbano As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbturma As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ButtonAdicionarTurma As System.Windows.Forms.Button
    Friend WithEvents ButtonGuardarTurma As System.Windows.Forms.Button
    Friend WithEvents ButtonVoltar As System.Windows.Forms.Button
End Class
