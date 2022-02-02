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
        Me.Combo_ds = New combo_sql_project.combo_ds()
        Me.Sender_ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboitemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Combo_itemsTableAdapter = New combo_sql_project.combo_dsTableAdapters.combo_itemsTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboitemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sel_Item_Text_Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sel_Item_IndexLabel5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sel_Item_value__Label6 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.Combo_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboitemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboitemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Combo_ds
        '
        Me.Combo_ds.DataSetName = "combo_ds"
        Me.Combo_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sender_ComboBox1
        '
        Me.Sender_ComboBox1.DataSource = Me.ComboitemsBindingSource
        Me.Sender_ComboBox1.DisplayMember = "item_title"
        Me.Sender_ComboBox1.FormattingEnabled = True
        Me.Sender_ComboBox1.Location = New System.Drawing.Point(199, 136)
        Me.Sender_ComboBox1.Name = "Sender_ComboBox1"
        Me.Sender_ComboBox1.Size = New System.Drawing.Size(148, 23)
        Me.Sender_ComboBox1.TabIndex = 0
        Me.Sender_ComboBox1.ValueMember = "id"
        '
        'ComboitemsBindingSource
        '
        Me.ComboitemsBindingSource.DataMember = "combo_items"
        Me.ComboitemsBindingSource.DataSource = Me.Combo_ds
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sender:"
        '
        'Combo_itemsTableAdapter
        '
        Me.Combo_itemsTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 229)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ComboitemsBindingSource1
        Me.ComboBox1.DisplayMember = "item_title"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(199, 226)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(148, 23)
        Me.ComboBox1.TabIndex = 2
        '
        'ComboitemsBindingSource1
        '
        Me.ComboitemsBindingSource1.DataMember = "combo_items"
        Me.ComboitemsBindingSource1.DataSource = Me.Combo_ds
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(224, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Load Items ASC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(351, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 34)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Load Items DESC"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(364, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Selected Item Index"
        '
        'sel_Item_Text_Label6
        '
        Me.sel_Item_Text_Label6.Location = New System.Drawing.Point(503, 139)
        Me.sel_Item_Text_Label6.Name = "sel_Item_Text_Label6"
        Me.sel_Item_Text_Label6.Size = New System.Drawing.Size(81, 15)
        Me.sel_Item_Text_Label6.TabIndex = 9
        Me.sel_Item_Text_Label6.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Selected Item Text"
        '
        'sel_Item_IndexLabel5
        '
        Me.sel_Item_IndexLabel5.Location = New System.Drawing.Point(503, 103)
        Me.sel_Item_IndexLabel5.Name = "sel_Item_IndexLabel5"
        Me.sel_Item_IndexLabel5.Size = New System.Drawing.Size(81, 15)
        Me.sel_Item_IndexLabel5.TabIndex = 7
        Me.sel_Item_IndexLabel5.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(364, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Selected Item Value"
        '
        'sel_Item_value__Label6
        '
        Me.sel_Item_value__Label6.Location = New System.Drawing.Point(503, 173)
        Me.sel_Item_value__Label6.Name = "sel_Item_value__Label6"
        Me.sel_Item_value__Label6.Size = New System.Drawing.Size(81, 15)
        Me.sel_Item_value__Label6.TabIndex = 11
        Me.sel_Item_value__Label6.Text = "-"
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(265, 303)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(179, 34)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Advance ComboBox Form"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(265, 373)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(179, 34)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Crud ComboBox Form"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(684, 461)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.sel_Item_value__Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.sel_Item_Text_Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sel_Item_IndexLabel5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Sender_ComboBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Combo Items"
        CType(Me.Combo_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboitemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboitemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Combo_ds As combo_ds
    Friend WithEvents Sender_ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboitemsBindingSource As BindingSource
    Friend WithEvents Combo_itemsTableAdapter As combo_dsTableAdapters.combo_itemsTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboitemsBindingSource1 As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents sel_Item_Text_Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents sel_Item_IndexLabel5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sel_Item_value__Label6 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
