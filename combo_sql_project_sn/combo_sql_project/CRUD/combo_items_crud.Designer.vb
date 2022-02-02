<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class combo_items_crud
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim Item_titleLabel As System.Windows.Forms.Label
        Dim Group_idLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(combo_items_crud))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.item_title_TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemtitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboitemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Combo_ds = New combo_sql_project.combo_ds()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.Item_titleLabel1 = New System.Windows.Forms.Label()
        Me.Group_idLabel1 = New System.Windows.Forms.Label()
        Me.Combo_itemsTableAdapter = New combo_sql_project.combo_dsTableAdapters.combo_itemsTableAdapter()
        Me.TableAdapterManager = New combo_sql_project.combo_dsTableAdapters.TableAdapterManager()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.parent_group = New System.Windows.Forms.Label()
        Me.parent_group_id = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Item_titleLabel = New System.Windows.Forms.Label()
        Group_idLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboitemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Combo_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(600, 97)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 17)
        IdLabel.TabIndex = 5
        IdLabel.Text = "id:"
        '
        'Item_titleLabel
        '
        Item_titleLabel.AutoSize = True
        Item_titleLabel.Location = New System.Drawing.Point(600, 120)
        Item_titleLabel.Name = "Item_titleLabel"
        Item_titleLabel.Size = New System.Drawing.Size(61, 17)
        Item_titleLabel.TabIndex = 7
        Item_titleLabel.Text = "item title:"
        '
        'Group_idLabel
        '
        Group_idLabel.AutoSize = True
        Group_idLabel.Location = New System.Drawing.Point(600, 143)
        Group_idLabel.Name = "Group_idLabel"
        Group_idLabel.Size = New System.Drawing.Size(62, 17)
        Group_idLabel.TabIndex = 9
        Group_idLabel.Text = "group id:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.item_title_TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 66)
        Me.Panel1.TabIndex = 0
        '
        'item_title_TextBox1
        '
        Me.item_title_TextBox1.Location = New System.Drawing.Point(94, 23)
        Me.item_title_TextBox1.Name = "item_title_TextBox1"
        Me.item_title_TextBox1.Size = New System.Drawing.Size(347, 25)
        Me.item_title_TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Item Title:"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(447, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ItemtitleDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ComboitemsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(549, 290)
        Me.DataGridView1.TabIndex = 1
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 70
        '
        'ItemtitleDataGridViewTextBoxColumn
        '
        Me.ItemtitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemtitleDataGridViewTextBoxColumn.DataPropertyName = "item_title"
        Me.ItemtitleDataGridViewTextBoxColumn.HeaderText = "Item Title"
        Me.ItemtitleDataGridViewTextBoxColumn.Name = "ItemtitleDataGridViewTextBoxColumn"
        Me.ItemtitleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComboitemsBindingSource
        '
        Me.ComboitemsBindingSource.DataMember = "combo_items"
        Me.ComboitemsBindingSource.DataSource = Me.Combo_ds
        '
        'Combo_ds
        '
        Me.Combo_ds.DataSetName = "combo_ds"
        Me.Combo_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(16, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 35)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(279, 414)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 35)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Edit Record"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(405, 414)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 35)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Delete Record"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'IdLabel1
        '
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComboitemsBindingSource, "id", True))
        Me.IdLabel1.Location = New System.Drawing.Point(668, 97)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdLabel1.TabIndex = 6
        Me.IdLabel1.Text = "Label2"
        '
        'Item_titleLabel1
        '
        Me.Item_titleLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComboitemsBindingSource, "item_title", True))
        Me.Item_titleLabel1.Location = New System.Drawing.Point(668, 120)
        Me.Item_titleLabel1.Name = "Item_titleLabel1"
        Me.Item_titleLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Item_titleLabel1.TabIndex = 8
        Me.Item_titleLabel1.Text = "Label2"
        '
        'Group_idLabel1
        '
        Me.Group_idLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComboitemsBindingSource, "group_id", True))
        Me.Group_idLabel1.Location = New System.Drawing.Point(668, 143)
        Me.Group_idLabel1.Name = "Group_idLabel1"
        Me.Group_idLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Group_idLabel1.TabIndex = 10
        Me.Group_idLabel1.Text = "Label2"
        '
        'Combo_itemsTableAdapter
        '
        Me.Combo_itemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.combo_itemsTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.customers_infoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = combo_sql_project.combo_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.AutoSize = False
        Me.BindingNavigator1.BindingSource = Me.ComboitemsBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 369)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(549, 25)
        Me.BindingNavigator1.TabIndex = 11
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
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
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'parent_group
        '
        Me.parent_group.AutoSize = True
        Me.parent_group.Location = New System.Drawing.Point(575, 207)
        Me.parent_group.Name = "parent_group"
        Me.parent_group.Size = New System.Drawing.Size(86, 17)
        Me.parent_group.TabIndex = 12
        Me.parent_group.Text = "parent group"
        '
        'parent_group_id
        '
        Me.parent_group_id.AutoSize = True
        Me.parent_group_id.Location = New System.Drawing.Point(671, 207)
        Me.parent_group_id.Name = "parent_group_id"
        Me.parent_group_id.Size = New System.Drawing.Size(101, 17)
        Me.parent_group_id.TabIndex = 13
        Me.parent_group_id.Text = "parent group id"
        '
        'combo_items_crud
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(790, 469)
        Me.Controls.Add(Me.parent_group_id)
        Me.Controls.Add(Me.parent_group)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(Item_titleLabel)
        Me.Controls.Add(Me.Item_titleLabel1)
        Me.Controls.Add(Group_idLabel)
        Me.Controls.Add(Me.Group_idLabel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "combo_items_crud"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combo Items Crud"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboitemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Combo_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents item_title_TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Combo_ds As combo_ds
    Friend WithEvents ComboitemsBindingSource As BindingSource
    Friend WithEvents Combo_itemsTableAdapter As combo_dsTableAdapters.combo_itemsTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemtitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableAdapterManager As combo_dsTableAdapters.TableAdapterManager
    Friend WithEvents IdLabel1 As Label
    Friend WithEvents Item_titleLabel1 As Label
    Friend WithEvents Group_idLabel1 As Label
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents parent_group As Label
    Friend WithEvents parent_group_id As Label
End Class
