<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alunos
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
        Dim ContactoLabel As System.Windows.Forms.Label
        Dim MoradaLabel As System.Windows.Forms.Label
        Dim IdadeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alunos))
        Me.DatabasePAPDataSet = New PAP___Vasco_Rodrigues.DatabasePAPDataSet()
        Me.AlunosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlunosTableAdapter = New PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.AlunosTableAdapter()
        Me.TableAdapterManager = New PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TableAdapterManager()
        Me.AlunosDataGridView = New System.Windows.Forms.DataGridView()
        Me.codaluno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ContactoLabel1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MoradaLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SexoLabel1 = New System.Windows.Forms.Label()
        Me.IdadeLabel1 = New System.Windows.Forms.Label()
        Me.NomeLabel1 = New System.Windows.Forms.Label()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonLast = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonFirst = New System.Windows.Forms.Button()
        Me.TurmaTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        ContactoLabel = New System.Windows.Forms.Label()
        MoradaLabel = New System.Windows.Forms.Label()
        IdadeLabel = New System.Windows.Forms.Label()
        CType(Me.DatabasePAPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlunosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContactoLabel
        '
        ContactoLabel.BackColor = System.Drawing.SystemColors.Control
        ContactoLabel.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        ContactoLabel.Location = New System.Drawing.Point(466, 73)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(75, 23)
        ContactoLabel.TabIndex = 47
        ContactoLabel.Text = "Contacto:"
        '
        'MoradaLabel
        '
        MoradaLabel.BackColor = System.Drawing.SystemColors.Control
        MoradaLabel.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MoradaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        MoradaLabel.Location = New System.Drawing.Point(225, 115)
        MoradaLabel.Name = "MoradaLabel"
        MoradaLabel.Size = New System.Drawing.Size(67, 23)
        MoradaLabel.TabIndex = 43
        MoradaLabel.Text = "Morada:"
        '
        'IdadeLabel
        '
        IdadeLabel.BackColor = System.Drawing.SystemColors.Control
        IdadeLabel.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdadeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        IdadeLabel.Location = New System.Drawing.Point(352, 73)
        IdadeLabel.Name = "IdadeLabel"
        IdadeLabel.Size = New System.Drawing.Size(51, 23)
        IdadeLabel.TabIndex = 39
        IdadeLabel.Text = "Idade:"
        IdadeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DatabasePAPDataSet
        '
        Me.DatabasePAPDataSet.DataSetName = "DatabasePAPDataSet"
        Me.DatabasePAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlunosBindingSource
        '
        Me.AlunosBindingSource.DataMember = "Alunos"
        Me.AlunosBindingSource.DataSource = Me.DatabasePAPDataSet
        '
        'AlunosTableAdapter
        '
        Me.AlunosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdministradoresTableAdapter = Nothing
        Me.TableAdapterManager.AlunosTableAdapter = Me.AlunosTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DisciplinasTableAdapter = Nothing
        Me.TableAdapterManager.ModulosTableAdapter = Nothing
        Me.TableAdapterManager.NotasTableAdapter = Nothing
        Me.TableAdapterManager.ProfessoresTableAdapter = Nothing
        Me.TableAdapterManager.TurmasDisciplinasTableAdapter = Nothing
        Me.TableAdapterManager.TurmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AlunosDataGridView
        '
        Me.AlunosDataGridView.AllowUserToAddRows = False
        Me.AlunosDataGridView.AllowUserToDeleteRows = False
        Me.AlunosDataGridView.AllowUserToResizeColumns = False
        Me.AlunosDataGridView.AllowUserToResizeRows = False
        Me.AlunosDataGridView.AutoGenerateColumns = False
        Me.AlunosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.AlunosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codaluno, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.contacto})
        Me.AlunosDataGridView.DataSource = Me.AlunosBindingSource
        Me.AlunosDataGridView.Location = New System.Drawing.Point(91, 237)
        Me.AlunosDataGridView.MultiSelect = False
        Me.AlunosDataGridView.Name = "AlunosDataGridView"
        Me.AlunosDataGridView.ReadOnly = True
        Me.AlunosDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.AlunosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AlunosDataGridView.Size = New System.Drawing.Size(1119, 318)
        Me.AlunosDataGridView.TabIndex = 1
        '
        'codaluno
        '
        Me.codaluno.DataPropertyName = "codaluno"
        Me.codaluno.HeaderText = "Cód. Aluno"
        Me.codaluno.Name = "codaluno"
        Me.codaluno.ReadOnly = True
        Me.codaluno.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 350
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idade"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Idade"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "turma"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Turma"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "morada"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Morada"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 350
        '
        'contacto
        '
        Me.contacto.DataPropertyName = "contacto"
        Me.contacto.HeaderText = "Contacto"
        Me.contacto.Name = "contacto"
        Me.contacto.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(724, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 30)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Turma:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Silver
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(268, 166)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(176, 41)
        Me.Button6.TabIndex = 55
        Me.Button6.Text = "Alterar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Silver
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(95, 166)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(176, 41)
        Me.Button5.TabIndex = 54
        Me.Button5.Text = "Adicionar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Silver
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(449, 166)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(176, 41)
        Me.Button7.TabIndex = 56
        Me.Button7.Text = "Remover"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ContactoLabel1
        '
        Me.ContactoLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ContactoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "contacto", True))
        Me.ContactoLabel1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactoLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ContactoLabel1.Location = New System.Drawing.Point(541, 73)
        Me.ContactoLabel1.Name = "ContactoLabel1"
        Me.ContactoLabel1.Size = New System.Drawing.Size(137, 23)
        Me.ContactoLabel1.TabIndex = 48
        Me.ContactoLabel1.Text = "Contacto"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(458, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 23)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(701, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(2, 120)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Label2"
        '
        'MoradaLabel1
        '
        Me.MoradaLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.MoradaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "morada", True))
        Me.MoradaLabel1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoradaLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MoradaLabel1.Location = New System.Drawing.Point(289, 115)
        Me.MoradaLabel1.Name = "MoradaLabel1"
        Me.MoradaLabel1.Size = New System.Drawing.Size(389, 23)
        Me.MoradaLabel1.TabIndex = 44
        Me.MoradaLabel1.Text = "Morada"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(344, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 23)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Label1"
        '
        'SexoLabel1
        '
        Me.SexoLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.SexoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "sexo", True))
        Me.SexoLabel1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexoLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SexoLabel1.Location = New System.Drawing.Point(225, 73)
        Me.SexoLabel1.Name = "SexoLabel1"
        Me.SexoLabel1.Size = New System.Drawing.Size(113, 23)
        Me.SexoLabel1.TabIndex = 41
        Me.SexoLabel1.Text = "Sexo"
        Me.SexoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'IdadeLabel1
        '
        Me.IdadeLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.IdadeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "idade", True))
        Me.IdadeLabel1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdadeLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IdadeLabel1.Location = New System.Drawing.Point(398, 73)
        Me.IdadeLabel1.Name = "IdadeLabel1"
        Me.IdadeLabel1.Size = New System.Drawing.Size(53, 23)
        Me.IdadeLabel1.TabIndex = 40
        Me.IdadeLabel1.Text = "Idade"
        Me.IdadeLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NomeLabel1
        '
        Me.NomeLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.NomeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "nome", True))
        Me.NomeLabel1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NomeLabel1.Location = New System.Drawing.Point(225, 29)
        Me.NomeLabel1.Name = "NomeLabel1"
        Me.NomeLabel1.Size = New System.Drawing.Size(453, 30)
        Me.NomeLabel1.TabIndex = 38
        Me.NomeLabel1.Text = "Nome"
        Me.NomeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoPictureBox.ErrorImage = CType(resources.GetObject("FotoPictureBox.ErrorImage"), System.Drawing.Image)
        Me.FotoPictureBox.Image = CType(resources.GetObject("FotoPictureBox.Image"), System.Drawing.Image)
        Me.FotoPictureBox.Location = New System.Drawing.Point(95, 29)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(110, 110)
        Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FotoPictureBox.TabIndex = 37
        Me.FotoPictureBox.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 166)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1275, 41)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 60
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1275, 169)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 59
        Me.PictureBox2.TabStop = False
        '
        'ButtonLast
        '
        Me.ButtonLast.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonLast.Image = CType(resources.GetObject("ButtonLast.Image"), System.Drawing.Image)
        Me.ButtonLast.Location = New System.Drawing.Point(53, 509)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(39, 47)
        Me.ButtonLast.TabIndex = 65
        Me.ButtonLast.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonNext.Image = CType(resources.GetObject("ButtonNext.Image"), System.Drawing.Image)
        Me.ButtonNext.Location = New System.Drawing.Point(53, 406)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(39, 47)
        Me.ButtonNext.TabIndex = 64
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonPrevious.Image = CType(resources.GetObject("ButtonPrevious.Image"), System.Drawing.Image)
        Me.ButtonPrevious.Location = New System.Drawing.Point(53, 362)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(39, 47)
        Me.ButtonPrevious.TabIndex = 63
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        '
        'ButtonFirst
        '
        Me.ButtonFirst.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonFirst.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonFirst.Image = CType(resources.GetObject("ButtonFirst.Image"), System.Drawing.Image)
        Me.ButtonFirst.Location = New System.Drawing.Point(54, 259)
        Me.ButtonFirst.Name = "ButtonFirst"
        Me.ButtonFirst.Size = New System.Drawing.Size(39, 47)
        Me.ButtonFirst.TabIndex = 62
        Me.ButtonFirst.UseVisualStyleBackColor = True
        '
        'TurmaTextBox
        '
        Me.TurmaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlunosBindingSource, "turma", True))
        Me.TurmaTextBox.Enabled = False
        Me.TurmaTextBox.Font = New System.Drawing.Font("Leelawadee UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TurmaTextBox.Location = New System.Drawing.Point(728, 71)
        Me.TurmaTextBox.Name = "TurmaTextBox"
        Me.TurmaTextBox.ReadOnly = True
        Me.TurmaTextBox.Size = New System.Drawing.Size(133, 25)
        Me.TurmaTextBox.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-4, 605)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1306, 24)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "   Filtros de pesquisa:"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(0, 590)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1302, 115)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 68
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(0, 586)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1302, 124)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 69
        Me.PictureBox5.TabStop = False
        '
        'Alunos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1267, 717)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.TurmaTextBox)
        Me.Controls.Add(Me.AlunosDataGridView)
        Me.Controls.Add(Me.ButtonLast)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.ButtonFirst)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(ContactoLabel)
        Me.Controls.Add(Me.ContactoLabel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(MoradaLabel)
        Me.Controls.Add(Me.MoradaLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SexoLabel1)
        Me.Controls.Add(IdadeLabel)
        Me.Controls.Add(Me.IdadeLabel1)
        Me.Controls.Add(Me.NomeLabel1)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Alunos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alunos"
        CType(Me.DatabasePAPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlunosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabasePAPDataSet As PAP___Vasco_Rodrigues.DatabasePAPDataSet
    Friend WithEvents AlunosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AlunosTableAdapter As PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.AlunosTableAdapter
    Friend WithEvents TableAdapterManager As PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AlunosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ContactoLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MoradaLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SexoLabel1 As System.Windows.Forms.Label
    Friend WithEvents IdadeLabel1 As System.Windows.Forms.Label
    Friend WithEvents NomeLabel1 As System.Windows.Forms.Label
    Friend WithEvents FotoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonLast As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonPrevious As System.Windows.Forms.Button
    Friend WithEvents ButtonFirst As System.Windows.Forms.Button
    Friend WithEvents codaluno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contacto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TurmaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
