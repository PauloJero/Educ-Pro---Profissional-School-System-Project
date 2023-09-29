<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admins
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admins))
        Dim PassadminLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Me.DatabasePAPDataSet = New PAP___Vasco_Rodrigues.DatabasePAPDataSet()
        Me.AdministradoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdministradoresTableAdapter = New PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.AdministradoresTableAdapter()
        Me.TableAdapterManager = New PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TableAdapterManager()
        Me.AdministradoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.codadmin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonLast = New System.Windows.Forms.Button()
        Me.ButtonNext = New System.Windows.Forms.Button()
        Me.ButtonPrevious = New System.Windows.Forms.Button()
        Me.ButtonFirst = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PassadminTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameLabel1 = New System.Windows.Forms.Label()
        Me.NomeLabel1 = New System.Windows.Forms.Label()
        Me.SexoLabel1 = New System.Windows.Forms.Label()
        PassadminLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        CType(Me.DatabasePAPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdministradoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdministradoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatabasePAPDataSet
        '
        Me.DatabasePAPDataSet.DataSetName = "DatabasePAPDataSet"
        Me.DatabasePAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdministradoresBindingSource
        '
        Me.AdministradoresBindingSource.DataMember = "Administradores"
        Me.AdministradoresBindingSource.DataSource = Me.DatabasePAPDataSet
        '
        'AdministradoresTableAdapter
        '
        Me.AdministradoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdministradoresTableAdapter = Me.AdministradoresTableAdapter
        Me.TableAdapterManager.AlunosTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DisciplinasTableAdapter = Nothing
        Me.TableAdapterManager.ModulosTableAdapter = Nothing
        Me.TableAdapterManager.NotasTableAdapter = Nothing
        Me.TableAdapterManager.ProfessoresTableAdapter = Nothing
        Me.TableAdapterManager.TurmasDisciplinasTableAdapter = Nothing
        Me.TableAdapterManager.TurmasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AdministradoresDataGridView
        '
        Me.AdministradoresDataGridView.AllowUserToAddRows = False
        Me.AdministradoresDataGridView.AllowUserToDeleteRows = False
        Me.AdministradoresDataGridView.AllowUserToResizeColumns = False
        Me.AdministradoresDataGridView.AllowUserToResizeRows = False
        Me.AdministradoresDataGridView.AutoGenerateColumns = False
        Me.AdministradoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.AdministradoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codadmin, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4})
        Me.AdministradoresDataGridView.DataSource = Me.AdministradoresBindingSource
        Me.AdministradoresDataGridView.Location = New System.Drawing.Point(93, 251)
        Me.AdministradoresDataGridView.MultiSelect = False
        Me.AdministradoresDataGridView.Name = "AdministradoresDataGridView"
        Me.AdministradoresDataGridView.ReadOnly = True
        Me.AdministradoresDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.AdministradoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AdministradoresDataGridView.Size = New System.Drawing.Size(541, 317)
        Me.AdministradoresDataGridView.TabIndex = 1
        '
        'codadmin
        '
        Me.codadmin.DataPropertyName = "codadmin"
        Me.codadmin.HeaderText = "Cód. Admin"
        Me.codadmin.Name = "codadmin"
        Me.codadmin.ReadOnly = True
        Me.codadmin.Width = 85
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "username"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Username"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 312
        '
        'ButtonLast
        '
        Me.ButtonLast.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonLast.Image = CType(resources.GetObject("ButtonLast.Image"), System.Drawing.Image)
        Me.ButtonLast.Location = New System.Drawing.Point(44, 514)
        Me.ButtonLast.Name = "ButtonLast"
        Me.ButtonLast.Size = New System.Drawing.Size(43, 56)
        Me.ButtonLast.TabIndex = 33
        Me.ButtonLast.UseVisualStyleBackColor = True
        '
        'ButtonNext
        '
        Me.ButtonNext.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonNext.Image = CType(resources.GetObject("ButtonNext.Image"), System.Drawing.Image)
        Me.ButtonNext.Location = New System.Drawing.Point(44, 434)
        Me.ButtonNext.Name = "ButtonNext"
        Me.ButtonNext.Size = New System.Drawing.Size(43, 56)
        Me.ButtonNext.TabIndex = 32
        Me.ButtonNext.UseVisualStyleBackColor = True
        '
        'ButtonPrevious
        '
        Me.ButtonPrevious.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonPrevious.Image = CType(resources.GetObject("ButtonPrevious.Image"), System.Drawing.Image)
        Me.ButtonPrevious.Location = New System.Drawing.Point(44, 353)
        Me.ButtonPrevious.Name = "ButtonPrevious"
        Me.ButtonPrevious.Size = New System.Drawing.Size(43, 56)
        Me.ButtonPrevious.TabIndex = 31
        Me.ButtonPrevious.UseVisualStyleBackColor = True
        '
        'ButtonFirst
        '
        Me.ButtonFirst.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonFirst.ForeColor = System.Drawing.Color.Transparent
        Me.ButtonFirst.Image = CType(resources.GetObject("ButtonFirst.Image"), System.Drawing.Image)
        Me.ButtonFirst.Location = New System.Drawing.Point(44, 273)
        Me.ButtonFirst.Name = "ButtonFirst"
        Me.ButtonFirst.Size = New System.Drawing.Size(43, 56)
        Me.ButtonFirst.TabIndex = 30
        Me.ButtonFirst.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(684, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 18)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Filtros de pesquisa:"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(93, 189)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(176, 56)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "Adicionar    "
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(275, 189)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(176, 56)
        Me.Button6.TabIndex = 35
        Me.Button6.Text = "Alterar       "
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(458, 189)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(176, 56)
        Me.Button7.TabIndex = 36
        Me.Button7.Text = "Remover     "
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button7.UseVisualStyleBackColor = True
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.AdministradoresBindingSource, "foto", True))
        Me.FotoPictureBox.Location = New System.Drawing.Point(93, 34)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(110, 110)
        Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FotoPictureBox.TabIndex = 37
        Me.FotoPictureBox.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(699, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(2, 120)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1069, 101)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'PassadminLabel
        '
        PassadminLabel.AutoSize = True
        PassadminLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PassadminLabel.Location = New System.Drawing.Point(739, 101)
        PassadminLabel.Name = "PassadminLabel"
        PassadminLabel.Size = New System.Drawing.Size(82, 18)
        PassadminLabel.TabIndex = 40
        PassadminLabel.Text = "Password:"
        '
        'PassadminTextBox
        '
        Me.PassadminTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministradoresBindingSource, "passadmin", True))
        Me.PassadminTextBox.Enabled = False
        Me.PassadminTextBox.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassadminTextBox.Location = New System.Drawing.Point(857, 98)
        Me.PassadminTextBox.Name = "PassadminTextBox"
        Me.PassadminTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassadminTextBox.ReadOnly = True
        Me.PassadminTextBox.Size = New System.Drawing.Size(206, 26)
        Me.PassadminTextBox.TabIndex = 43
        '
        'UsernameLabel1
        '
        Me.UsernameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministradoresBindingSource, "username", True))
        Me.UsernameLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel1.Location = New System.Drawing.Point(853, 64)
        Me.UsernameLabel1.Name = "UsernameLabel1"
        Me.UsernameLabel1.Size = New System.Drawing.Size(210, 23)
        Me.UsernameLabel1.TabIndex = 42
        Me.UsernameLabel1.Text = "Username"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(739, 63)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(84, 18)
        UsernameLabel.TabIndex = 41
        UsernameLabel.Text = "Username:"
        '
        'NomeLabel1
        '
        Me.NomeLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministradoresBindingSource, "nome", True))
        Me.NomeLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeLabel1.Location = New System.Drawing.Point(231, 57)
        Me.NomeLabel1.Name = "NomeLabel1"
        Me.NomeLabel1.Size = New System.Drawing.Size(453, 30)
        Me.NomeLabel1.TabIndex = 38
        Me.NomeLabel1.Text = "Nome"
        '
        'SexoLabel1
        '
        Me.SexoLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministradoresBindingSource, "sexo", True))
        Me.SexoLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexoLabel1.Location = New System.Drawing.Point(231, 101)
        Me.SexoLabel1.Name = "SexoLabel1"
        Me.SexoLabel1.Size = New System.Drawing.Size(103, 23)
        Me.SexoLabel1.TabIndex = 39
        Me.SexoLabel1.Text = "Sexo"
        '
        'Admins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1124, 603)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PassadminTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameLabel1)
        Me.Controls.Add(PassadminLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SexoLabel1)
        Me.Controls.Add(Me.NomeLabel1)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.ButtonLast)
        Me.Controls.Add(Me.ButtonNext)
        Me.Controls.Add(Me.ButtonPrevious)
        Me.Controls.Add(Me.ButtonFirst)
        Me.Controls.Add(Me.AdministradoresDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Admins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admins"
        CType(Me.DatabasePAPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdministradoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdministradoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabasePAPDataSet As PAP___Vasco_Rodrigues.DatabasePAPDataSet
    Friend WithEvents AdministradoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AdministradoresTableAdapter As PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.AdministradoresTableAdapter
    Friend WithEvents TableAdapterManager As PAP___Vasco_Rodrigues.DatabasePAPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AdministradoresDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonLast As System.Windows.Forms.Button
    Friend WithEvents ButtonNext As System.Windows.Forms.Button
    Friend WithEvents ButtonPrevious As System.Windows.Forms.Button
    Friend WithEvents ButtonFirst As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents codadmin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents FotoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PassadminTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameLabel1 As System.Windows.Forms.Label
    Friend WithEvents NomeLabel1 As System.Windows.Forms.Label
    Friend WithEvents SexoLabel1 As System.Windows.Forms.Label
End Class
