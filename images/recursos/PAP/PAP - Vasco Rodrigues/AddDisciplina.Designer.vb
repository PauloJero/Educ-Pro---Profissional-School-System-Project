<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDisciplina
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddDisciplina))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbdesignacao = New System.Windows.Forms.TextBox()
        Me.ButtonAdicionarDisciplina = New System.Windows.Forms.Button()
        Me.ButtonVoltar = New System.Windows.Forms.Button()
        Me.ButtonGuardarDisciplina = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Designação da disciplina:"
        '
        'tbdesignacao
        '
        Me.tbdesignacao.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbdesignacao.Location = New System.Drawing.Point(201, 21)
        Me.tbdesignacao.Name = "tbdesignacao"
        Me.tbdesignacao.Size = New System.Drawing.Size(276, 29)
        Me.tbdesignacao.TabIndex = 1
        '
        'ButtonAdicionarDisciplina
        '
        Me.ButtonAdicionarDisciplina.BackgroundImage = CType(resources.GetObject("ButtonAdicionarDisciplina.BackgroundImage"), System.Drawing.Image)
        Me.ButtonAdicionarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAdicionarDisciplina.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdicionarDisciplina.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAdicionarDisciplina.Location = New System.Drawing.Point(375, 65)
        Me.ButtonAdicionarDisciplina.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonAdicionarDisciplina.Name = "ButtonAdicionarDisciplina"
        Me.ButtonAdicionarDisciplina.Size = New System.Drawing.Size(102, 34)
        Me.ButtonAdicionarDisciplina.TabIndex = 29
        Me.ButtonAdicionarDisciplina.Text = "Adicionar"
        Me.ButtonAdicionarDisciplina.UseVisualStyleBackColor = True
        '
        'ButtonVoltar
        '
        Me.ButtonVoltar.BackgroundImage = CType(resources.GetObject("ButtonVoltar.BackgroundImage"), System.Drawing.Image)
        Me.ButtonVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonVoltar.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonVoltar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonVoltar.Location = New System.Drawing.Point(15, 65)
        Me.ButtonVoltar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonVoltar.Name = "ButtonVoltar"
        Me.ButtonVoltar.Size = New System.Drawing.Size(102, 34)
        Me.ButtonVoltar.TabIndex = 30
        Me.ButtonVoltar.Text = "< Voltar"
        Me.ButtonVoltar.UseVisualStyleBackColor = True
        '
        'ButtonGuardarDisciplina
        '
        Me.ButtonGuardarDisciplina.BackgroundImage = CType(resources.GetObject("ButtonGuardarDisciplina.BackgroundImage"), System.Drawing.Image)
        Me.ButtonGuardarDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonGuardarDisciplina.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGuardarDisciplina.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonGuardarDisciplina.Location = New System.Drawing.Point(375, 65)
        Me.ButtonGuardarDisciplina.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ButtonGuardarDisciplina.Name = "ButtonGuardarDisciplina"
        Me.ButtonGuardarDisciplina.Size = New System.Drawing.Size(102, 34)
        Me.ButtonGuardarDisciplina.TabIndex = 31
        Me.ButtonGuardarDisciplina.Text = "Guardar"
        Me.ButtonGuardarDisciplina.UseVisualStyleBackColor = True
        '
        'AddDisciplina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(489, 106)
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonVoltar)
        Me.Controls.Add(Me.tbdesignacao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonAdicionarDisciplina)
        Me.Controls.Add(Me.ButtonGuardarDisciplina)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddDisciplina"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eValuatePRO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbdesignacao As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAdicionarDisciplina As System.Windows.Forms.Button
    Friend WithEvents ButtonVoltar As System.Windows.Forms.Button
    Friend WithEvents ButtonGuardarDisciplina As System.Windows.Forms.Button
End Class
