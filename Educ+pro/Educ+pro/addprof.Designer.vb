<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addprof
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NomeLabel As System.Windows.Forms.Label
        Dim IdadeLabel As System.Windows.Forms.Label
        Dim GeneroLabel As System.Windows.Forms.Label
        Dim MoradaLabel As System.Windows.Forms.Label
        Dim ContactoLabel As System.Windows.Forms.Label
        Dim DescdisciplinasLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addprof))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DatabasePAPDataSet = New Educ_pro.DatabasePAPDataSet()
        Me.ProfessoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProfessoresTableAdapter = New Educ_pro.DatabasePAPDataSetTableAdapters.ProfessoresTableAdapter()
        Me.TableAdapterManager = New Educ_pro.DatabasePAPDataSetTableAdapters.TableAdapterManager()
        Me.ProfessoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProfessoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.IdadeTextBox = New System.Windows.Forms.TextBox()
        Me.GeneroTextBox = New System.Windows.Forms.TextBox()
        Me.MoradaTextBox = New System.Windows.Forms.TextBox()
        Me.ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.DescdisciplinasTextBox = New System.Windows.Forms.TextBox()
        NomeLabel = New System.Windows.Forms.Label()
        IdadeLabel = New System.Windows.Forms.Label()
        GeneroLabel = New System.Windows.Forms.Label()
        MoradaLabel = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        DescdisciplinasLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabasePAPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfessoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProfessoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProfessoresBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.BackColor = System.Drawing.Color.Transparent
        NomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(275, 142)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(58, 18)
        NomeLabel.TabIndex = 72
        NomeLabel.Text = "Nome:"
        '
        'IdadeLabel
        '
        IdadeLabel.AutoSize = True
        IdadeLabel.BackColor = System.Drawing.Color.Transparent
        IdadeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdadeLabel.Location = New System.Drawing.Point(275, 193)
        IdadeLabel.Name = "IdadeLabel"
        IdadeLabel.Size = New System.Drawing.Size(53, 18)
        IdadeLabel.TabIndex = 73
        IdadeLabel.Text = "Idade:"
        '
        'GeneroLabel
        '
        GeneroLabel.AutoSize = True
        GeneroLabel.BackColor = System.Drawing.Color.Transparent
        GeneroLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GeneroLabel.Location = New System.Drawing.Point(552, 193)
        GeneroLabel.Name = "GeneroLabel"
        GeneroLabel.Size = New System.Drawing.Size(69, 18)
        GeneroLabel.TabIndex = 74
        GeneroLabel.Text = "Género:"
        '
        'MoradaLabel
        '
        MoradaLabel.AutoSize = True
        MoradaLabel.BackColor = System.Drawing.Color.Transparent
        MoradaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MoradaLabel.Location = New System.Drawing.Point(275, 244)
        MoradaLabel.Name = "MoradaLabel"
        MoradaLabel.Size = New System.Drawing.Size(70, 18)
        MoradaLabel.TabIndex = 75
        MoradaLabel.Text = "Morada:"
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.BackColor = System.Drawing.Color.Transparent
        ContactoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContactoLabel.Location = New System.Drawing.Point(275, 289)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(82, 18)
        ContactoLabel.TabIndex = 76
        ContactoLabel.Text = "Contacto:"
        '
        'DescdisciplinasLabel
        '
        DescdisciplinasLabel.AutoSize = True
        DescdisciplinasLabel.BackColor = System.Drawing.Color.Transparent
        DescdisciplinasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescdisciplinasLabel.Location = New System.Drawing.Point(469, 291)
        DescdisciplinasLabel.Name = "DescdisciplinasLabel"
        DescdisciplinasLabel.Size = New System.Drawing.Size(177, 18)
        DescdisciplinasLabel.TabIndex = 77
        DescdisciplinasLabel.Text = "Disciplina que leciona:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(28, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 47)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Imprimir Ficha de Professor"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(28, 133)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(140, 164)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 67
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 436)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 66
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(54, 436)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Voltar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(58, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(759, 426)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 71
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(655, 436)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 24)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Adicionar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Leelawadee UI Semilight", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(272, 350)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(228, 17)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "*Campos de preenchimento obrigatório"
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
        Me.TableAdapterManager.UpdateOrder = Educ_pro.DatabasePAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProfessoresBindingNavigator
        '
        Me.ProfessoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProfessoresBindingNavigator.BindingSource = Me.ProfessoresBindingSource
        Me.ProfessoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProfessoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProfessoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProfessoresBindingNavigatorSaveItem})
        Me.ProfessoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProfessoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProfessoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProfessoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProfessoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProfessoresBindingNavigator.Name = "ProfessoresBindingNavigator"
        Me.ProfessoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProfessoresBindingNavigator.Size = New System.Drawing.Size(814, 25)
        Me.ProfessoresBindingNavigator.TabIndex = 72
        Me.ProfessoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ProfessoresBindingNavigatorSaveItem
        '
        Me.ProfessoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProfessoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProfessoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProfessoresBindingNavigatorSaveItem.Name = "ProfessoresBindingNavigatorSaveItem"
        Me.ProfessoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ProfessoresBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(344, 142)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(383, 20)
        Me.NomeTextBox.TabIndex = 73
        '
        'IdadeTextBox
        '
        Me.IdadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "idade", True))
        Me.IdadeTextBox.Location = New System.Drawing.Point(347, 194)
        Me.IdadeTextBox.Name = "IdadeTextBox"
        Me.IdadeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdadeTextBox.TabIndex = 74
        '
        'GeneroTextBox
        '
        Me.GeneroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "genero", True))
        Me.GeneroTextBox.Location = New System.Drawing.Point(627, 193)
        Me.GeneroTextBox.Name = "GeneroTextBox"
        Me.GeneroTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GeneroTextBox.TabIndex = 75
        '
        'MoradaTextBox
        '
        Me.MoradaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "morada", True))
        Me.MoradaTextBox.Location = New System.Drawing.Point(347, 242)
        Me.MoradaTextBox.Name = "MoradaTextBox"
        Me.MoradaTextBox.Size = New System.Drawing.Size(380, 20)
        Me.MoradaTextBox.TabIndex = 76
        '
        'ContactoTextBox
        '
        Me.ContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "contacto", True))
        Me.ContactoTextBox.Location = New System.Drawing.Point(363, 289)
        Me.ContactoTextBox.Name = "ContactoTextBox"
        Me.ContactoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ContactoTextBox.TabIndex = 77
        '
        'DescdisciplinasTextBox
        '
        Me.DescdisciplinasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProfessoresBindingSource, "descdisciplinas", True))
        Me.DescdisciplinasTextBox.Location = New System.Drawing.Point(652, 292)
        Me.DescdisciplinasTextBox.Name = "DescdisciplinasTextBox"
        Me.DescdisciplinasTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescdisciplinasTextBox.TabIndex = 78
        '
        'addprof
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(814, 490)
        Me.Controls.Add(DescdisciplinasLabel)
        Me.Controls.Add(Me.DescdisciplinasTextBox)
        Me.Controls.Add(ContactoLabel)
        Me.Controls.Add(Me.ContactoTextBox)
        Me.Controls.Add(MoradaLabel)
        Me.Controls.Add(Me.MoradaTextBox)
        Me.Controls.Add(GeneroLabel)
        Me.Controls.Add(Me.GeneroTextBox)
        Me.Controls.Add(IdadeLabel)
        Me.Controls.Add(Me.IdadeTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(Me.ProfessoresBindingNavigator)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addprof"
        Me.Text = "Addprof"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabasePAPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfessoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProfessoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProfessoresBindingNavigator.ResumeLayout(False)
        Me.ProfessoresBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DatabasePAPDataSet As DatabasePAPDataSet
    Friend WithEvents ProfessoresBindingSource As BindingSource
    Friend WithEvents ProfessoresTableAdapter As DatabasePAPDataSetTableAdapters.ProfessoresTableAdapter
    Friend WithEvents TableAdapterManager As DatabasePAPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProfessoresBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProfessoresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents IdadeTextBox As TextBox
    Friend WithEvents GeneroTextBox As TextBox
    Friend WithEvents MoradaTextBox As TextBox
    Friend WithEvents ContactoTextBox As TextBox
    Friend WithEvents DescdisciplinasTextBox As TextBox
End Class
