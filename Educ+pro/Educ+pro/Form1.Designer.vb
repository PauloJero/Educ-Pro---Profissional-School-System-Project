<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DatabasePAPDataSet = New Educ_pro.DatabasePAPDataSet()
        Me.AdministradoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdministradoresTableAdapter = New Educ_pro.DatabasePAPDataSetTableAdapters.AdministradoresTableAdapter()
        Me.TableAdapterManager = New Educ_pro.DatabasePAPDataSetTableAdapters.TableAdapterManager()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PassadminTextBox = New System.Windows.Forms.TextBox()
        CType(Me.DatabasePAPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdministradoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(121, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(401, 48)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.TableAdapterManager.UpdateOrder = Educ_pro.DatabasePAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministradoresBindingSource, "username", True))
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(167, 211)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(248, 31)
        Me.UsernameTextBox.TabIndex = 5
        '
        'PassadminTextBox
        '
        Me.PassadminTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AdministradoresBindingSource, "passadmin", True))
        Me.PassadminTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassadminTextBox.Location = New System.Drawing.Point(167, 299)
        Me.PassadminTextBox.Name = "PassadminTextBox"
        Me.PassadminTextBox.Size = New System.Drawing.Size(248, 31)
        Me.PassadminTextBox.TabIndex = 7
        Me.PassadminTextBox.UseSystemPasswordChar = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(641, 573)
        Me.Controls.Add(Me.PassadminTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Login"
        CType(Me.DatabasePAPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdministradoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DatabasePAPDataSet As DatabasePAPDataSet
    Friend WithEvents AdministradoresBindingSource As BindingSource
    Friend WithEvents AdministradoresTableAdapter As DatabasePAPDataSetTableAdapters.AdministradoresTableAdapter
    Friend WithEvents TableAdapterManager As DatabasePAPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PassadminTextBox As TextBox
End Class
