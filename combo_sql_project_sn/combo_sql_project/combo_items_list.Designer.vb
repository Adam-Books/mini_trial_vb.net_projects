<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class combo_items_list
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboitemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Combo_ds = New combo_sql_project.combo_ds()
        Me.save_Button1 = New System.Windows.Forms.Button()
        Me.exit_Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.group_id_Label1 = New System.Windows.Forms.Label()
        Me.Combo_itemsTableAdapter = New combo_sql_project.combo_dsTableAdapters.combo_itemsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemtitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.del_Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboitemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Combo_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ItemtitleDataGridViewTextBoxColumn, Me.del_Column1})
        Me.DataGridView1.DataSource = Me.ComboitemsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(2, 1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(333, 348)
        Me.DataGridView1.TabIndex = 0
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
        'save_Button1
        '
        Me.save_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save_Button1.Location = New System.Drawing.Point(62, 362)
        Me.save_Button1.Name = "save_Button1"
        Me.save_Button1.Size = New System.Drawing.Size(98, 33)
        Me.save_Button1.TabIndex = 1
        Me.save_Button1.Text = "Save && Exit"
        Me.save_Button1.UseVisualStyleBackColor = True
        '
        'exit_Button2
        '
        Me.exit_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exit_Button2.Location = New System.Drawing.Point(166, 362)
        Me.exit_Button2.Name = "exit_Button2"
        Me.exit_Button2.Size = New System.Drawing.Size(82, 33)
        Me.exit_Button2.TabIndex = 2
        Me.exit_Button2.Text = "Exit"
        Me.exit_Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(-25, 351)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 1)
        Me.Panel1.TabIndex = 3
        '
        'group_id_Label1
        '
        Me.group_id_Label1.Location = New System.Drawing.Point(534, 9)
        Me.group_id_Label1.Name = "group_id_Label1"
        Me.group_id_Label1.Size = New System.Drawing.Size(57, 22)
        Me.group_id_Label1.TabIndex = 4
        Me.group_id_Label1.Text = "0"
        '
        'Combo_itemsTableAdapter
        '
        Me.Combo_itemsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(538, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Rows Count"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(538, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 35)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Columns Count"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(538, 130)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 32)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Row State"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(354, 1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(159, 32)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "All Row States"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(354, 39)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(159, 259)
        Me.ListBox1.TabIndex = 9
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.BorderRadius = 10
        Me.Guna2GradientButton1.CheckedState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientButton1.CustomImages.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.LightGray
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.LightGray
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton1.HoverState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(354, 304)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(159, 41)
        Me.Guna2GradientButton1.TabIndex = 10
        Me.Guna2GradientButton1.Text = "Accept Changes"
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.BorderRadius = 10
        Me.Guna2GradientButton2.CheckedState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientButton2.CustomImages.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.LightGray
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.LightGray
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton2.HoverState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(538, 208)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(130, 42)
        Me.Guna2GradientButton2.TabIndex = 11
        Me.Guna2GradientButton2.Text = "Read Column value"
        '
        'Guna2GradientButton3
        '
        Me.Guna2GradientButton3.BorderRadius = 10
        Me.Guna2GradientButton3.CheckedState.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2GradientButton3.CustomImages.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.FillColor = System.Drawing.Color.LightGray
        Me.Guna2GradientButton3.FillColor2 = System.Drawing.Color.LightGray
        Me.Guna2GradientButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Guna2GradientButton3.ForeColor = System.Drawing.Color.Black
        Me.Guna2GradientButton3.HoverState.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.Location = New System.Drawing.Point(538, 256)
        Me.Guna2GradientButton3.Name = "Guna2GradientButton3"
        Me.Guna2GradientButton3.ShadowDecoration.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.Size = New System.Drawing.Size(130, 42)
        Me.Guna2GradientButton3.TabIndex = 12
        Me.Guna2GradientButton3.Text = "Write Column value"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Width = 40
        '
        'ItemtitleDataGridViewTextBoxColumn
        '
        Me.ItemtitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemtitleDataGridViewTextBoxColumn.DataPropertyName = "item_title"
        Me.ItemtitleDataGridViewTextBoxColumn.HeaderText = "Item Title"
        Me.ItemtitleDataGridViewTextBoxColumn.Name = "ItemtitleDataGridViewTextBoxColumn"
        '
        'del_Column1
        '
        Me.del_Column1.HeaderText = "Delete"
        Me.del_Column1.Name = "del_Column1"
        Me.del_Column1.Text = "Delete"
        Me.del_Column1.UseColumnTextForButtonValue = True
        Me.del_Column1.Width = 65
        '
        'combo_items_list
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(337, 401)
        Me.ControlBox = False
        Me.Controls.Add(Me.Guna2GradientButton3)
        Me.Controls.Add(Me.Guna2GradientButton2)
        Me.Controls.Add(Me.Guna2GradientButton1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.group_id_Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.exit_Button2)
        Me.Controls.Add(Me.save_Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "combo_items_list"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combo Items List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboitemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Combo_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents save_Button1 As Button
    Friend WithEvents exit_Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Combo_ds As combo_ds
    Friend WithEvents ComboitemsBindingSource As BindingSource
    Friend WithEvents Combo_itemsTableAdapter As combo_dsTableAdapters.combo_itemsTableAdapter
    Friend WithEvents group_id_Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemtitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents del_Column1 As DataGridViewButtonColumn
End Class
