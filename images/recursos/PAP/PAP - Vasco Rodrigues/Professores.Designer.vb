<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Professores
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
        Dim IdadeLabel As System.Windows.Forms.Label
        Dim MoradaLabel As System.Windows.Forms.Label
        Dim ContactoLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PassprofLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Professores))
        Me.DatabasePAPDataSet = New PAP___Vasco_Rodrigues.DatabasePAPDataSet()
        Me.ProfessoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfessoresTableAdapter = New PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.ProfessoresTableAdapter()
        Me.TableAdapterManager = New PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TableAdapterManager()
        Me.ProfessoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.codprof = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.ButtonFirst = New System.Windows.Forms.Button()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.NomeLabel1 = New System.Windows.Forms.Label()
        Me.IdadeLabel1 = New System.Windows.Forms.Label()
        Me.SexoLabel1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MoradaLabel1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContactoLabel1 = New System.Windows.Forms.Label()
        Me.UsernameLabel1 = New System.Windows.Forms.Label()
        Me.PassprofTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonLast = New System.Windows.Forms.Button()
        Me.DescdisciplinasTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        IdadeLabel = New System.Windows.Forms.Label()
        MoradaLabel = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PassprofLabel = New System.Windows.Forms.Label()
        CType(Me.DatabasePAPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfessoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfessoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdadeLabel
        '
        IdadeLabel.BackColor = System.Drawing.SystemColors.Control
        IdadeLabel.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdadeLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        IdadeLabel.Location = New System.Drawing.Point(350, 72)
        IdadeLabel.Name = "IdadeLabel"
        IdadeLabel.Size = New System.Drawing.Size(51, 23)
        IdadeLabel.TabIndex = 9
        IdadeLabel.Text = "Idade:"
        IdadeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MoradaLabel
        '
        MoradaLabel.BackColor = System.Drawing.SystemColors.Control
        MoradaLabel.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MoradaLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        MoradaLabel.Location = New System.Drawing.Point(223, 114)
        MoradaLabel.Name = "MoradaLabel"
        MoradaLabel.Size = New System.Drawing.Size(67, 23)
        MoradaLabel.TabIndex = 13
        MoradaLabel.Text = "Morada:"
        '
        'ContactoLabel
        '
        ContactoLabel.BackColor = System.Drawing.SystemColors.Control
        ContactoLabel.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactoLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        ContactoLabel.Location = New System.Drawing.Point(464, 72)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(75, 23)
        ContactoLabel.TabIndex = 17
        ContactoLabel.Text = "Contacto:"
        '
        'UsernameLabel
        '
        UsernameLabel.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(723, 72)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(84, 23)
        UsernameLabel.TabIndex = 19
        UsernameLabel.Text = "Username:"
        '
        'PassprofLabel
        '
        PassprofLabel.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PassprofLabel.Location = New System.Drawing.Point(723, 114)
        PassprofLabel.Name = "PassprofLabel"
        PassprofLabel.Size = New System.Drawing.Size(82, 23)
        PassprofLabel.TabIndex = 21
        PassprofLabel.Text = "Password:"
        '
        'DatabasePAPDataSet
        '
        Me.DatabasePAPDataSet.DataSetName = "DatabasePAPDataSet"
        Me.DatabasePAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProfessoresBindingSource
        '
        Me.ProfessoresBindingSource.DataMember = "Professores"
        Me.ProfessoresBindingSource.DataSource = Me.DatabasePAPDataSet
        '
        'ProfessoresTableAdapter
        '
        Me.ProfessoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdministradoresTableAdapter = Nothing
        Me.TableAdapterManager.AlunosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DisciplinasTableAdapter = Nothing
        Me.TableAdapterManager.ModulosTableAdapter = Nothing
        Me.TableAdapterManager.NotasTableAdapter = Nothing
        Me.TableAdapterManager.ProfessoresTableAdapter = Me.ProfessoresTableAdapter
        Me.TableAdapterManager.TurmasDisciplinasTableAdapter = Nothing
        Me.TableAdapterManager.TurmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProfessoresDataGridView
        '
        Me.ProfessoresDataGridView.AllowUserToAddRows = False
        Me.ProfessoresDataGridView.AllowUserToDeleteRows = False
        Me.ProfessoresDataGridView.AllowUserToResizeColumns = False
        Me.ProfessoresDataGridView.AllowUserToResizeRows = False
        Me.ProfessoresDataGridView.AutoGenerateColumns = False
        Me.ProfessoresDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.ProfessoresDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.ProfessoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ProfessoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codprof, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ProfessoresDataGridView.DataSource = Me.ProfessoresBindingSource
        Me.ProfessoresDataGridView.Location = New System.Drawing.Point(91, 237)
        Me.ProfessoresDataGridView.MultiSelect = False
        Me.ProfessoresDataGridView.Name = "ProfessoresDataGridView"
        Me.ProfessoresDataGridView.ReadOnly = True
        Me.ProfessoresDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ProfessoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProfessoresDataGridView.Size = New System.Drawing.Size(1119, 318)
        Me.ProfessoresDataGridView.TabIndex = 1
        '
        'codprof
        '
        Me.codprof.DataPropertyName = "codprof"
        Me.codprof.HeaderText = "Cód. Prof"
        Me.codprof.Name = "codprof"
        Me.codprof.ReadOnly = True
        Me.codprof.Width = 75
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 400
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idade"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Idade"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "sexo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sexo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "morada"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Morada"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 350
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "contacto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Contacto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProfessoresBindingSource, "foto", True))
        Me.FotoPictureBox.ErrorImage = CType(resources.GetObject("FotoPictureBox.ErrorImage"), System.Drawing.Image)
        Me.FotoPictureBox.Image = CType(resources.GetObject("FotoPictureBox.Image"), System.Drawing.Image)
        Me.FotoPictureBox.Location = New System.Drawing.Point(93, 28)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(110, 110)
        Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FotoPictureBox.TabIndex = 2
        Me.FotoPictureBox.TabStop = False
        '
        'ButtonFirst
        '
        Me.ButtonFirst.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonFirst.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonFirst.Image = CType(resources.GetObject("ButtonFirst.Image"), System.Drawing.Image)
        Me.ButtonFirst.Location = New System.Drawing.Point(53, 260)
        Me.ButtonFirst.Name = "ButtonFirst"
        Me.ButtonFirst.Size = New System.Drawing.Size(39, 47)
        Me.ButtonFirst.TabIndex = 4
        Me.ButtonFirst.UseVisualStyleBackColor = True
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonPrevious.Image = CType(resources.GetObject("ButtonPrevious.Image"), System.Drawing.Image)
        Me.ButtonPrevious.Location = New System.Drawing.Point(53, 362)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(39, 47)
        Me.ButtonPrevious.TabIndex = 5
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        '
        'NomeLabel1
        '
        Me.NomeLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.NomeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "nome", True))
        Me.NomeLabel1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.NomeLabel1.Location = New System.Drawing.Point(223, 28)
        Me.NomeLabel1.Name = "NomeLabel1"
        Me.NomeLabel1.Size = New System.Drawing.Size(453, 30)
        Me.NomeLabel1.TabIndex = 7
        Me.NomeLabel1.Text = "Nome"
        Me.NomeLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IdadeLabel1
        '
        Me.IdadeLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.IdadeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "idade", True))
        Me.IdadeLabel1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdadeLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.IdadeLabel1.Location = New System.Drawing.Point(396, 72)
        Me.IdadeLabel1.Name = "IdadeLabel1"
        Me.IdadeLabel1.Size = New System.Drawing.Size(53, 23)
        Me.IdadeLabel1.TabIndex = 10
        Me.IdadeLabel1.Text = "Idade"
        Me.IdadeLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SexoLabel1
        '
        Me.SexoLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.SexoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "sexo", True))
        Me.SexoLabel1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexoLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SexoLabel1.Location = New System.Drawing.Point(223, 72)
        Me.SexoLabel1.Name = "SexoLabel1"
        Me.SexoLabel1.Size = New System.Drawing.Size(113, 23)
        Me.SexoLabel1.TabIndex = 12
        Me.SexoLabel1.Text = "Sexo"
        Me.SexoLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(342, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'MoradaLabel1
        '
        Me.MoradaLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.MoradaLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "contacto", True))
        Me.MoradaLabel1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MoradaLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MoradaLabel1.Location = New System.Drawing.Point(287, 114)
        Me.MoradaLabel1.Name = "MoradaLabel1"
        Me.MoradaLabel1.Size = New System.Drawing.Size(389, 23)
        Me.MoradaLabel1.TabIndex = 14
        Me.MoradaLabel1.Text = "Morada"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(699, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(2, 120)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(456, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(2, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Label3"
        '
        'ContactoLabel1
        '
        Me.ContactoLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ContactoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "contacto", True))
        Me.ContactoLabel1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactoLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ContactoLabel1.Location = New System.Drawing.Point(539, 72)
        Me.ContactoLabel1.Name = "ContactoLabel1"
        Me.ContactoLabel1.Size = New System.Drawing.Size(137, 23)
        Me.ContactoLabel1.TabIndex = 18
        Me.ContactoLabel1.Text = "Contacto"
        '
        'UsernameLabel1
        '
        Me.UsernameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "username", True))
        Me.UsernameLabel1.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel1.Location = New System.Drawing.Point(802, 72)
        Me.UsernameLabel1.Name = "UsernameLabel1"
        Me.UsernameLabel1.Size = New System.Drawing.Size(195, 23)
        Me.UsernameLabel1.TabIndex = 20
        Me.UsernameLabel1.Text = "Username"
        '
        'PassprofTextBox
        '
        Me.PassprofTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "passprof", True))
        Me.PassprofTextBox.Enabled = False
        Me.PassprofTextBox.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassprofTextBox.Location = New System.Drawing.Point(806, 114)
        Me.PassprofTextBox.Multiline = True
        Me.PassprofTextBox.Name = "PassprofTextBox"
        Me.PassprofTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassprofTextBox.ReadOnly = True
        Me.PassprofTextBox.Size = New System.Drawing.Size(160, 24)
        Me.PassprofTextBox.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(1020, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(2, 120)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Label4"
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
        Me.Button5.Location = New System.Drawing.Point(93, 165)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(176, 41)
        Me.Button5.TabIndex = 25
        Me.Button5.Text = "Adicionar"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Silver
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(266, 165)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(176, 41)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Alterar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), System.Drawing.Image)
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.Silver
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(447, 165)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(176, 41)
        Me.Button7.TabIndex = 27
        Me.Button7.Text = "Remover"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonNext.Image = CType(resources.GetObject("ButtonNext.Image"), System.Drawing.Image)
        Me.ButtonNext.Location = New System.Drawing.Point(53, 406)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(39, 47)
        Me.ButtonNext.TabIndex = 28
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonLast
        '
        Me.ButtonLast.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonLast.Image = CType(resources.GetObject("ButtonLast.Image"), System.Drawing.Image)
        Me.ButtonLast.Location = New System.Drawing.Point(53, 508)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(39, 47)
        Me.ButtonLast.TabIndex = 29
        Me.ButtonLast.UseVisualStyleBackColor = True
        '
        'DescdisciplinasTextBox
        '
        Me.DescdisciplinasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "descdisciplinas", True))
        Me.DescdisciplinasTextBox.Enabled = False
        Me.DescdisciplinasTextBox.Font = New System.Drawing.Font("Leelawadee UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescdisciplinasTextBox.Location = New System.Drawing.Point(1044, 72)
        Me.DescdisciplinasTextBox.Multiline = True
        Me.DescdisciplinasTextBox.Name = "DescdisciplinasTextBox"
        Me.DescdisciplinasTextBox.ReadOnly = True
        Me.DescdisciplinasTextBox.Size = New System.Drawing.Size(195, 23)
        Me.DescdisciplinasTextBox.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(972, 112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-6, 605)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1279, 24)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "   Filtros de pesquisa:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1275, 169)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-2, 165)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(1275, 41)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(722, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(275, 30)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Detalhes de conta:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Leelawadee UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1044, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 30)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Disciplina:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-2, 590)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(1275, 115)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 37
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(-2, 586)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(1275, 124)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 38
        Me.PictureBox5.TabStop = False
        '
        'Professores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1267, 717)
        Me.Controls.Add(Me.ProfessoresDataGridView)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DescdisciplinasTextBox)
        Me.Controls.Add(Me.ButtonLast)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PassprofTextBox)
        Me.Controls.Add(PassprofLabel)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameLabel1)
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
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.ButtonFirst)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Professores"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Professores"
        CType(Me.DatabasePAPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfessoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfessoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabasePAPDataSet As PAP___Vasco_Rodrigues.DatabasePAPDataSet
    Friend WithEvents ProfessoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProfessoresTableAdapter As PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.ProfessoresTableAdapter
    Friend WithEvents TableAdapterManager As PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProfessoresDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents FotoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonFirst As System.Windows.Forms.Button
    Friend WithEvents ButtonPrevious As System.Windows.Forms.Button
    Friend WithEvents NomeLabel1 As System.Windows.Forms.Label
    Friend WithEvents IdadeLabel1 As System.Windows.Forms.Label
    Friend WithEvents SexoLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MoradaLabel1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ContactoLabel1 As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel1 As System.Windows.Forms.Label
    Friend WithEvents PassprofTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonLast As System.Windows.Forms.Button
    Friend WithEvents codprof As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescdisciplinasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
