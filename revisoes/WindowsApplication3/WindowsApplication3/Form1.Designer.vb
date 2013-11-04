<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim IdLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim NicknameLabel As System.Windows.Forms.Label
        Dim Id_livrosLabel As System.Windows.Forms.Label
        Me.Database1DataSet = New WindowsApplication1.Database1DataSet()
        Me.UtilizadoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UtilizadoresTableAdapter = New WindowsApplication1.Database1DataSetTableAdapters.UtilizadoresTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager()
        Me.UtilizadoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.UtilizadoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.NicknameTextBox = New System.Windows.Forms.TextBox()
        Me.Id_livrosTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        NicknameLabel = New System.Windows.Forms.Label()
        Id_livrosLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilizadoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtilizadoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UtilizadoresBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtilizadoresBindingSource
        '
        Me.UtilizadoresBindingSource.DataMember = "Utilizadores"
        Me.UtilizadoresBindingSource.DataSource = Me.Database1DataSet
        '
        'UtilizadoresTableAdapter
        '
        Me.UtilizadoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClassificaçaoTableAdapter = Nothing
        Me.TableAdapterManager.LivrosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UtilizadoresTableAdapter = Me.UtilizadoresTableAdapter
        '
        'UtilizadoresBindingNavigator
        '
        Me.UtilizadoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UtilizadoresBindingNavigator.BindingSource = Me.UtilizadoresBindingSource
        Me.UtilizadoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UtilizadoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UtilizadoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UtilizadoresBindingNavigatorSaveItem})
        Me.UtilizadoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.UtilizadoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UtilizadoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UtilizadoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UtilizadoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UtilizadoresBindingNavigator.Name = "UtilizadoresBindingNavigator"
        Me.UtilizadoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UtilizadoresBindingNavigator.Size = New System.Drawing.Size(284, 25)
        Me.UtilizadoresBindingNavigator.TabIndex = 0
        Me.UtilizadoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'UtilizadoresBindingNavigatorSaveItem
        '
        Me.UtilizadoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UtilizadoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("UtilizadoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UtilizadoresBindingNavigatorSaveItem.Name = "UtilizadoresBindingNavigatorSaveItem"
        Me.UtilizadoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.UtilizadoresBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(50, 70)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilizadoresBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(112, 67)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(50, 96)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(34, 13)
        EmailLabel.TabIndex = 3
        EmailLabel.Text = "email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilizadoresBindingSource, "email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(112, 93)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 4
        '
        'NicknameLabel
        '
        NicknameLabel.AutoSize = True
        NicknameLabel.Location = New System.Drawing.Point(50, 122)
        NicknameLabel.Name = "NicknameLabel"
        NicknameLabel.Size = New System.Drawing.Size(56, 13)
        NicknameLabel.TabIndex = 5
        NicknameLabel.Text = "nickname:"
        '
        'NicknameTextBox
        '
        Me.NicknameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilizadoresBindingSource, "nickname", True))
        Me.NicknameTextBox.Location = New System.Drawing.Point(112, 119)
        Me.NicknameTextBox.Name = "NicknameTextBox"
        Me.NicknameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NicknameTextBox.TabIndex = 6
        '
        'Id_livrosLabel
        '
        Id_livrosLabel.AutoSize = True
        Id_livrosLabel.Location = New System.Drawing.Point(50, 148)
        Id_livrosLabel.Name = "Id_livrosLabel"
        Id_livrosLabel.Size = New System.Drawing.Size(45, 13)
        Id_livrosLabel.TabIndex = 7
        Id_livrosLabel.Text = "id livros:"
        '
        'Id_livrosTextBox
        '
        Me.Id_livrosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UtilizadoresBindingSource, "id_livros", True))
        Me.Id_livrosTextBox.Location = New System.Drawing.Point(112, 145)
        Me.Id_livrosTextBox.Name = "Id_livrosTextBox"
        Me.Id_livrosTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Id_livrosTextBox.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(NicknameLabel)
        Me.Controls.Add(Me.NicknameTextBox)
        Me.Controls.Add(Id_livrosLabel)
        Me.Controls.Add(Me.Id_livrosTextBox)
        Me.Controls.Add(Me.UtilizadoresBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilizadoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtilizadoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UtilizadoresBindingNavigator.ResumeLayout(False)
        Me.UtilizadoresBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet As WindowsApplication1.Database1DataSet
    Friend WithEvents UtilizadoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UtilizadoresTableAdapter As WindowsApplication1.Database1DataSetTableAdapters.UtilizadoresTableAdapter
    Friend WithEvents TableAdapterManager As WindowsApplication1.Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents UtilizadoresBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UtilizadoresBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NicknameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Id_livrosTextBox As System.Windows.Forms.TextBox

End Class
