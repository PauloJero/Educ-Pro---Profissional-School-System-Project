<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turmas
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
        Me.components = New System.ComponentModel.Container()
        Dim TurmaLabel As System.Windows.Forms.Label
        Dim AnoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Turmas))
        Me.DatabasePAPDataSet = New PAP___Vasco_Rodrigues.DatabasePAPDataSet()
        Me.TurmasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TurmasTableAdapter = New PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TurmasTableAdapter()
        Me.TableAdapterManager = New PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TableAdapterManager()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ButtonLast = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonFirst = New System.Windows.Forms.Button()
        Me.TurmaLabel1 = New System.Windows.Forms.Label()
        Me.AnoLabel1 = New System.Windows.Forms.Label()
        Me.TurmasDataGridView = New System.Windows.Forms.DataGridView()
        Me.turma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        TurmaLabel = New System.Windows.Forms.Label()
        AnoLabel = New System.Windows.Forms.Label()
        CType(Me.DatabasePAPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurmasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TurmaLabel
        '
        TurmaLabel.AutoSize = True
        TurmaLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TurmaLabel.Location = New System.Drawing.Point(227, 53)
        TurmaLabel.Name = "TurmaLabel"
        TurmaLabel.Size = New System.Drawing.Size(166, 18)
        TurmaLabel.TabIndex = 34
        TurmaLabel.Text = "Designação de Turma:"
        '
        'AnoLabel
        '
        AnoLabel.AutoSize = True
        AnoLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AnoLabel.Location = New System.Drawing.Point(227, 109)
        AnoLabel.Name = "AnoLabel"
        AnoLabel.Size = New System.Drawing.Size(40, 18)
        AnoLabel.TabIndex = 35
        AnoLabel.Text = "Ano:"
        '
        'DatabasePAPDataSet
        '
        Me.DatabasePAPDataSet.DataSetName = "DatabasePAPDataSet"
        Me.DatabasePAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TurmasBindingSource
        '
        Me.TurmasBindingSource.DataMember = "Turmas"
        Me.TurmasBindingSource.DataSource = Me.DatabasePAPDataSet
        '
        'TurmasTableAdapter
        '
        Me.TurmasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdministradoresTableAdapter = Nothing
        Me.TableAdapterManager.AlunosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DisciplinasTableAdapter = Nothing
        Me.TableAdapterManager.ModulosTableAdapter = Nothing
        Me.TableAdapterManager.NotasTableAdapter = Nothing
        Me.TableAdapterManager.ProfessoresTableAdapter = Nothing
        Me.TableAdapterManager.TurmasDisciplinasTableAdapter = Nothing
        Me.TableAdapterManager.TurmasTableAdapter = Me.TurmasTableAdapter
        Me.TableAdapterManager.UpdateOrder = PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(12, 330)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(176, 56)
        Me.Button7.TabIndex = 30
        Me.Button7.Text = "Remover     "
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(12, 258)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(176, 56)
        Me.Button6.TabIndex = 29
        Me.Button6.Text = "Alterar       "
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(12, 186)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(176, 56)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "Adicionar    "
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ButtonLast
        '
        Me.ButtonLast.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonLast.Image = CType(resources.GetObject("ButtonLast.Image"), System.Drawing.Image)
        Me.ButtonLast.Location = New System.Drawing.Point(233, 372)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(43, 56)
        Me.ButtonLast.TabIndex = 34
        Me.ButtonLast.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonNext.Image = CType(resources.GetObject("ButtonNext.Image"), System.Drawing.Image)
        Me.ButtonNext.Location = New System.Drawing.Point(233, 310)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(43, 56)
        Me.ButtonNext.TabIndex = 33
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonPrevious.Image = CType(resources.GetObject("ButtonPrevious.Image"), System.Drawing.Image)
        Me.ButtonPrevious.Location = New System.Drawing.Point(233, 248)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(43, 56)
        Me.ButtonPrevious.TabIndex = 32
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        '
        'ButtonFirst
        '
        Me.ButtonFirst.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonFirst.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonFirst.Image = CType(resources.GetObject("ButtonFirst.Image"), System.Drawing.Image)
        Me.ButtonFirst.Location = New System.Drawing.Point(233, 186)
        Me.ButtonFirst.Name = "ButtonFirst"
        Me.ButtonFirst.Size = New System.Drawing.Size(43, 56)
        Me.ButtonFirst.TabIndex = 31
        Me.ButtonFirst.UseVisualStyleBackColor = True
        '
        'TurmaLabel1
        '
        Me.TurmaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "turma", True))
        Me.TurmaLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurmaLabel1.Location = New System.Drawing.Point(437, 53)
        Me.TurmaLabel1.Name = "TurmaLabel1"
        Me.TurmaLabel1.Size = New System.Drawing.Size(156, 61)
        Me.TurmaLabel1.TabIndex = 35
        Me.TurmaLabel1.Text = "Turma"
        '
        'AnoLabel1
        '
        Me.AnoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TurmasBindingSource, "ano", True))
        Me.AnoLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnoLabel1.Location = New System.Drawing.Point(283, 109)
        Me.AnoLabel1.Name = "AnoLabel1"
        Me.AnoLabel1.Size = New System.Drawing.Size(102, 53)
        Me.AnoLabel1.TabIndex = 36
        Me.AnoLabel1.Text = "Ano"
        '
        'TurmasDataGridView
        '
        Me.TurmasDataGridView.AllowUserToAddRows = False
        Me.TurmasDataGridView.AllowUserToDeleteRows = False
        Me.TurmasDataGridView.AllowUserToResizeColumns = False
        Me.TurmasDataGridView.AllowUserToResizeRows = False
        Me.TurmasDataGridView.AutoGenerateColumns = False
        Me.TurmasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TurmasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.turma, Me.DataGridViewTextBoxColumn2})
        Me.TurmasDataGridView.DataSource = Me.TurmasBindingSource
        Me.TurmasDataGridView.Location = New System.Drawing.Point(282, 186)
        Me.TurmasDataGridView.MultiSelect = False
        Me.TurmasDataGridView.Name = "TurmasDataGridView"
        Me.TurmasDataGridView.ReadOnly = True
        Me.TurmasDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.TurmasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TurmasDataGridView.Size = New System.Drawing.Size(243, 242)
        Me.TurmasDataGridView.TabIndex = 44
        '
        'turma
        '
        Me.turma.DataPropertyName = "turma"
        Me.turma.HeaderText = "Turma"
        Me.turma.Name = "turma"
        Me.turma.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ano"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ano"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Turmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(806, 519)
        Me.Controls.Add(Me.TurmasDataGridView)
        Me.Controls.Add(AnoLabel)
        Me.Controls.Add(Me.AnoLabel1)
        Me.Controls.Add(TurmaLabel)
        Me.Controls.Add(Me.TurmaLabel1)
        Me.Controls.Add(Me.ButtonLast)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.ButtonFirst)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Turmas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turmas"
        CType(Me.DatabasePAPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurmasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurmasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabasePAPDataSet As PAP___Vasco_Rodrigues.DatabasePAPDataSet
    Friend WithEvents TurmasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TurmasTableAdapter As PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TurmasTableAdapter
    Friend WithEvents TableAdapterManager As PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ButtonLast As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonPrevious As System.Windows.Forms.Button
    Friend WithEvents ButtonFirst As System.Windows.Forms.Button
    Friend WithEvents TurmaLabel1 As System.Windows.Forms.Label
    Friend WithEvents AnoLabel1 As System.Windows.Forms.Label
    Friend WithEvents TurmasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents turma As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
