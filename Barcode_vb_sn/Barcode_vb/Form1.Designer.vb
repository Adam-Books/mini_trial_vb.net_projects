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
        Me.search_TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Product_ListBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Product_ListBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Product_ListDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Barcode_ds = New Barcode_vb.barcode_ds()
        Me.Product_ListTableAdapter = New Barcode_vb.barcode_dsTableAdapters.Product_ListTableAdapter()
        Me.TableAdapterManager = New Barcode_vb.barcode_dsTableAdapters.TableAdapterManager()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.Product_ListBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Product_ListBindingNavigator.SuspendLayout()
        CType(Me.Product_ListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Product_ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Barcode_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'search_TextBox1
        '
        Me.search_TextBox1.Location = New System.Drawing.Point(241, 34)
        Me.search_TextBox1.Name = "search_TextBox1"
        Me.search_TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.search_TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Search Barcode:"
        '
        'Product_ListBindingNavigator
        '
        Me.Product_ListBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Product_ListBindingNavigator.AutoSize = False
        Me.Product_ListBindingNavigator.BindingSource = Me.Product_ListBindingSource
        Me.Product_ListBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Product_ListBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Product_ListBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Product_ListBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Product_ListBindingNavigatorSaveItem})
        Me.Product_ListBindingNavigator.Location = New System.Drawing.Point(0, 349)
        Me.Product_ListBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Product_ListBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Product_ListBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Product_ListBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Product_ListBindingNavigator.Name = "Product_ListBindingNavigator"
        Me.Product_ListBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Product_ListBindingNavigator.Size = New System.Drawing.Size(471, 36)
        Me.Product_ListBindingNavigator.TabIndex = 2
        Me.Product_ListBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 33)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 33)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 36)
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 33)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 36)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 33)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 33)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 36)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 33)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 33)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Product_ListBindingNavigatorSaveItem
        '
        Me.Product_ListBindingNavigatorSaveItem.Image = CType(resources.GetObject("Product_ListBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Product_ListBindingNavigatorSaveItem.Name = "Product_ListBindingNavigatorSaveItem"
        Me.Product_ListBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 33)
        Me.Product_ListBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Product_ListDataGridView
        '
        Me.Product_ListDataGridView.AutoGenerateColumns = False
        Me.Product_ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Product_ListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Product_ListDataGridView.DataSource = Me.Product_ListBindingSource
        Me.Product_ListDataGridView.Location = New System.Drawing.Point(12, 87)
        Me.Product_ListDataGridView.Name = "Product_ListDataGridView"
        Me.Product_ListDataGridView.Size = New System.Drawing.Size(443, 249)
        Me.Product_ListDataGridView.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 44)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Load All"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Load Barcode Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Product_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Product_Barcode"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product_Barcode"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Product_Price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Product_Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Product_ListBindingSource
        '
        Me.Product_ListBindingSource.DataMember = "Product_List"
        Me.Product_ListBindingSource.DataSource = Me.Barcode_ds
        '
        'Barcode_ds
        '
        Me.Barcode_ds.DataSetName = "barcode_ds"
        Me.Barcode_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Product_ListTableAdapter
        '
        Me.Product_ListTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Product_ListTableAdapter = Me.Product_ListTableAdapter
        Me.TableAdapterManager.UpdateOrder = Barcode_vb.barcode_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(389, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 32)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(471, 385)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Product_ListDataGridView)
        Me.Controls.Add(Me.Product_ListBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.search_TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barcode Reder"
        CType(Me.Product_ListBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Product_ListBindingNavigator.ResumeLayout(False)
        Me.Product_ListBindingNavigator.PerformLayout()
        CType(Me.Product_ListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Product_ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Barcode_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents search_TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Barcode_ds As barcode_ds
    Friend WithEvents Product_ListBindingSource As BindingSource
    Friend WithEvents Product_ListTableAdapter As barcode_dsTableAdapters.Product_ListTableAdapter
    Friend WithEvents TableAdapterManager As barcode_dsTableAdapters.TableAdapterManager
    Friend WithEvents Product_ListBindingNavigator As BindingNavigator
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
    Friend WithEvents Product_ListBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Product_ListDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
