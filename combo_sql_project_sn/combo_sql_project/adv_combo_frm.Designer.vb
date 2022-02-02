<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adv_combo_frm
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
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim Reg_dateLabel As System.Windows.Forms.Label
        Dim CommentLabel As System.Windows.Forms.Label
        Dim Sender_incomeLabel As System.Windows.Forms.Label
        Dim Sender_debtLabel As System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Priority_ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Customers_infoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Combo_ds = New combo_sql_project.combo_ds()
        Me.Priority_BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Sender_ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Sender_BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Gender_ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Gender_BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Combo_itemsTableAdapter = New combo_sql_project.combo_dsTableAdapters.combo_itemsTableAdapter()
        Me.sender_add_Button1 = New System.Windows.Forms.Button()
        Me.priority_add_Button1 = New System.Windows.Forms.Button()
        Me.gender_Button2 = New System.Windows.Forms.Button()
        Me.Customers_infoTableAdapter = New combo_sql_project.combo_dsTableAdapters.customers_infoTableAdapter()
        Me.TableAdapterManager = New combo_sql_project.combo_dsTableAdapters.TableAdapterManager()
        Me.Customers_infoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.Reg_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CommentTextBox = New System.Windows.Forms.TextBox()
        Me.Sender_incomeTextBox = New System.Windows.Forms.TextBox()
        Me.Sender_debtTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.save_Button1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        SubjectLabel = New System.Windows.Forms.Label()
        Reg_dateLabel = New System.Windows.Forms.Label()
        CommentLabel = New System.Windows.Forms.Label()
        Sender_incomeLabel = New System.Windows.Forms.Label()
        Sender_debtLabel = New System.Windows.Forms.Label()
        CType(Me.Customers_infoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Combo_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Priority_BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sender_BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gender_BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Customers_infoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.Location = New System.Drawing.Point(252, 22)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 17)
        IdLabel.TabIndex = 12
        IdLabel.Text = "id:"
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SubjectLabel.Location = New System.Drawing.Point(223, 47)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(52, 17)
        SubjectLabel.TabIndex = 13
        SubjectLabel.Text = "subject:"
        '
        'Reg_dateLabel
        '
        Reg_dateLabel.AutoSize = True
        Reg_dateLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Reg_dateLabel.Location = New System.Drawing.Point(215, 79)
        Reg_dateLabel.Name = "Reg_dateLabel"
        Reg_dateLabel.Size = New System.Drawing.Size(61, 17)
        Reg_dateLabel.TabIndex = 14
        Reg_dateLabel.Text = "reg date:"
        '
        'CommentLabel
        '
        CommentLabel.AutoSize = True
        CommentLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CommentLabel.Location = New System.Drawing.Point(209, 199)
        CommentLabel.Name = "CommentLabel"
        CommentLabel.Size = New System.Drawing.Size(65, 17)
        CommentLabel.TabIndex = 16
        CommentLabel.Text = "comment:"
        '
        'Sender_incomeLabel
        '
        Sender_incomeLabel.AutoSize = True
        Sender_incomeLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sender_incomeLabel.Location = New System.Drawing.Point(177, 230)
        Sender_incomeLabel.Name = "Sender_incomeLabel"
        Sender_incomeLabel.Size = New System.Drawing.Size(97, 17)
        Sender_incomeLabel.TabIndex = 18
        Sender_incomeLabel.Text = "sender income:"
        '
        'Sender_debtLabel
        '
        Sender_debtLabel.AutoSize = True
        Sender_debtLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Sender_debtLabel.Location = New System.Drawing.Point(192, 261)
        Sender_debtLabel.Name = "Sender_debtLabel"
        Sender_debtLabel.Size = New System.Drawing.Size(82, 17)
        Sender_debtLabel.TabIndex = 20
        Sender_debtLabel.Text = "sender debt:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Priority:"
        '
        'Priority_ComboBox1
        '
        Me.Priority_ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Priority_ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_infoBindingSource, "priority", True))
        Me.Priority_ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Customers_infoBindingSource, "priority_id", True))
        Me.Priority_ComboBox1.DataSource = Me.Priority_BindingSource1
        Me.Priority_ComboBox1.DisplayMember = "item_title"
        Me.Priority_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Priority_ComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Priority_ComboBox1.FormattingEnabled = True
        Me.Priority_ComboBox1.Location = New System.Drawing.Point(284, 134)
        Me.Priority_ComboBox1.Name = "Priority_ComboBox1"
        Me.Priority_ComboBox1.Size = New System.Drawing.Size(188, 25)
        Me.Priority_ComboBox1.TabIndex = 6
        Me.Priority_ComboBox1.ValueMember = "id"
        '
        'Customers_infoBindingSource
        '
        Me.Customers_infoBindingSource.DataMember = "customers_info"
        Me.Customers_infoBindingSource.DataSource = Me.Combo_ds
        '
        'Combo_ds
        '
        Me.Combo_ds.DataSetName = "combo_ds"
        Me.Combo_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Priority_BindingSource1
        '
        Me.Priority_BindingSource1.DataMember = "combo_items"
        Me.Priority_BindingSource1.DataSource = Me.Combo_ds
        Me.Priority_BindingSource1.Filter = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Sender:"
        '
        'Sender_ComboBox1
        '
        Me.Sender_ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sender_ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_infoBindingSource, "sender", True))
        Me.Sender_ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Customers_infoBindingSource, "sender_id", True))
        Me.Sender_ComboBox1.DataSource = Me.Sender_BindingSource
        Me.Sender_ComboBox1.DisplayMember = "item_title"
        Me.Sender_ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sender_ComboBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sender_ComboBox1.FormattingEnabled = True
        Me.Sender_ComboBox1.Location = New System.Drawing.Point(284, 103)
        Me.Sender_ComboBox1.Name = "Sender_ComboBox1"
        Me.Sender_ComboBox1.Size = New System.Drawing.Size(188, 25)
        Me.Sender_ComboBox1.TabIndex = 4
        Me.Sender_ComboBox1.ValueMember = "id"
        '
        'Sender_BindingSource
        '
        Me.Sender_BindingSource.DataMember = "combo_items"
        Me.Sender_BindingSource.DataSource = Me.Combo_ds
        Me.Sender_BindingSource.Filter = ""
        Me.Sender_BindingSource.Sort = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(220, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Gender:"
        '
        'Gender_ComboBox2
        '
        Me.Gender_ComboBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Gender_ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_infoBindingSource, "gender", True))
        Me.Gender_ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.Customers_infoBindingSource, "gender_id", True))
        Me.Gender_ComboBox2.DataSource = Me.Gender_BindingSource1
        Me.Gender_ComboBox2.DisplayMember = "item_title"
        Me.Gender_ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Gender_ComboBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender_ComboBox2.FormattingEnabled = True
        Me.Gender_ComboBox2.Location = New System.Drawing.Point(284, 165)
        Me.Gender_ComboBox2.Name = "Gender_ComboBox2"
        Me.Gender_ComboBox2.Size = New System.Drawing.Size(188, 25)
        Me.Gender_ComboBox2.TabIndex = 8
        Me.Gender_ComboBox2.ValueMember = "id"
        '
        'Gender_BindingSource1
        '
        Me.Gender_BindingSource1.DataMember = "combo_items"
        Me.Gender_BindingSource1.DataSource = Me.Combo_ds
        Me.Gender_BindingSource1.Filter = ""
        '
        'Combo_itemsTableAdapter
        '
        Me.Combo_itemsTableAdapter.ClearBeforeFill = True
        '
        'sender_add_Button1
        '
        Me.sender_add_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sender_add_Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sender_add_Button1.Location = New System.Drawing.Point(478, 103)
        Me.sender_add_Button1.Name = "sender_add_Button1"
        Me.sender_add_Button1.Size = New System.Drawing.Size(37, 25)
        Me.sender_add_Button1.TabIndex = 10
        Me.sender_add_Button1.Text = "+"
        Me.sender_add_Button1.UseVisualStyleBackColor = True
        '
        'priority_add_Button1
        '
        Me.priority_add_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.priority_add_Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.priority_add_Button1.Location = New System.Drawing.Point(478, 134)
        Me.priority_add_Button1.Name = "priority_add_Button1"
        Me.priority_add_Button1.Size = New System.Drawing.Size(37, 25)
        Me.priority_add_Button1.TabIndex = 11
        Me.priority_add_Button1.Text = "+"
        Me.priority_add_Button1.UseVisualStyleBackColor = True
        '
        'gender_Button2
        '
        Me.gender_Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.gender_Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gender_Button2.Location = New System.Drawing.Point(478, 165)
        Me.gender_Button2.Name = "gender_Button2"
        Me.gender_Button2.Size = New System.Drawing.Size(37, 25)
        Me.gender_Button2.TabIndex = 12
        Me.gender_Button2.Text = "+"
        Me.gender_Button2.UseVisualStyleBackColor = True
        '
        'Customers_infoTableAdapter
        '
        Me.Customers_infoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.combo_itemsTableAdapter = Me.Combo_itemsTableAdapter
        Me.TableAdapterManager.customers_infoTableAdapter = Me.Customers_infoTableAdapter
        Me.TableAdapterManager.UpdateOrder = combo_sql_project.combo_dsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Customers_infoDataGridView
        '
        Me.Customers_infoDataGridView.AutoGenerateColumns = False
        Me.Customers_infoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Customers_infoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.Customers_infoDataGridView.DataSource = Me.Customers_infoBindingSource
        Me.Customers_infoDataGridView.Location = New System.Drawing.Point(11, 363)
        Me.Customers_infoDataGridView.Name = "Customers_infoDataGridView"
        Me.Customers_infoDataGridView.Size = New System.Drawing.Size(784, 164)
        Me.Customers_infoDataGridView.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "subject"
        Me.DataGridViewTextBoxColumn2.HeaderText = "subject"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "reg_date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "reg_date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "sender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "sender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "sender_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "sender_id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "priority"
        Me.DataGridViewTextBoxColumn6.HeaderText = "priority"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "priority_id"
        Me.DataGridViewTextBoxColumn7.HeaderText = "priority_id"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "gender"
        Me.DataGridViewTextBoxColumn8.HeaderText = "gender"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "gender_id"
        Me.DataGridViewTextBoxColumn9.HeaderText = "gender_id"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "comment"
        Me.DataGridViewTextBoxColumn10.HeaderText = "comment"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "sender_income"
        Me.DataGridViewTextBoxColumn11.HeaderText = "sender_income"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "sender_debt"
        Me.DataGridViewTextBoxColumn12.HeaderText = "sender_debt"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_infoBindingSource, "id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(284, 19)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(231, 25)
        Me.IdTextBox.TabIndex = 13
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_infoBindingSource, "subject", True))
        Me.SubjectTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectTextBox.Location = New System.Drawing.Point(284, 47)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(231, 25)
        Me.SubjectTextBox.TabIndex = 14
        '
        'Reg_dateDateTimePicker
        '
        Me.Reg_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Customers_infoBindingSource, "reg_date", True))
        Me.Reg_dateDateTimePicker.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reg_dateDateTimePicker.Location = New System.Drawing.Point(284, 73)
        Me.Reg_dateDateTimePicker.Name = "Reg_dateDateTimePicker"
        Me.Reg_dateDateTimePicker.Size = New System.Drawing.Size(231, 25)
        Me.Reg_dateDateTimePicker.TabIndex = 15
        '
        'CommentTextBox
        '
        Me.CommentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_infoBindingSource, "comment", True))
        Me.CommentTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommentTextBox.Location = New System.Drawing.Point(284, 196)
        Me.CommentTextBox.Name = "CommentTextBox"
        Me.CommentTextBox.Size = New System.Drawing.Size(231, 25)
        Me.CommentTextBox.TabIndex = 17
        '
        'Sender_incomeTextBox
        '
        Me.Sender_incomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_infoBindingSource, "sender_income", True))
        Me.Sender_incomeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sender_incomeTextBox.Location = New System.Drawing.Point(284, 227)
        Me.Sender_incomeTextBox.Name = "Sender_incomeTextBox"
        Me.Sender_incomeTextBox.Size = New System.Drawing.Size(231, 25)
        Me.Sender_incomeTextBox.TabIndex = 19
        '
        'Sender_debtTextBox
        '
        Me.Sender_debtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Customers_infoBindingSource, "sender_debt", True))
        Me.Sender_debtTextBox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sender_debtTextBox.Location = New System.Drawing.Point(284, 258)
        Me.Sender_debtTextBox.Name = "Sender_debtTextBox"
        Me.Sender_debtTextBox.Size = New System.Drawing.Size(231, 25)
        Me.Sender_debtTextBox.TabIndex = 21
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Sender_debtLabel)
        Me.GroupBox1.Controls.Add(Me.Sender_debtTextBox)
        Me.GroupBox1.Controls.Add(Sender_incomeLabel)
        Me.GroupBox1.Controls.Add(Me.Sender_incomeTextBox)
        Me.GroupBox1.Controls.Add(CommentLabel)
        Me.GroupBox1.Controls.Add(Me.CommentTextBox)
        Me.GroupBox1.Controls.Add(Reg_dateLabel)
        Me.GroupBox1.Controls.Add(Me.Reg_dateDateTimePicker)
        Me.GroupBox1.Controls.Add(SubjectLabel)
        Me.GroupBox1.Controls.Add(Me.SubjectTextBox)
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(Me.gender_Button2)
        Me.GroupBox1.Controls.Add(Me.priority_add_Button1)
        Me.GroupBox1.Controls.Add(Me.sender_add_Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Gender_ComboBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Priority_ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Sender_ComboBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 306)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'save_Button1
        '
        Me.save_Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save_Button1.Location = New System.Drawing.Point(12, 12)
        Me.save_Button1.Name = "save_Button1"
        Me.save_Button1.Size = New System.Drawing.Size(98, 33)
        Me.save_Button1.TabIndex = 23
        Me.save_Button1.Text = "Save Changes"
        Me.save_Button1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(521, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 25)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "+ CRUD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(521, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 25)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "+ CRUD"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(521, 164)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 25)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "+ CRUD"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'adv_combo_frm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(807, 536)
        Me.Controls.Add(Me.save_Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Customers_infoDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "adv_combo_frm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adance ComboBox Form"
        CType(Me.Customers_infoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Combo_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Priority_BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sender_BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gender_BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Customers_infoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Priority_ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Sender_ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Gender_ComboBox2 As ComboBox
    Friend WithEvents Combo_ds As combo_ds
    Friend WithEvents Sender_BindingSource As BindingSource
    Friend WithEvents Combo_itemsTableAdapter As combo_dsTableAdapters.combo_itemsTableAdapter
    Friend WithEvents Priority_BindingSource1 As BindingSource
    Friend WithEvents Gender_BindingSource1 As BindingSource
    Friend WithEvents sender_add_Button1 As Button
    Friend WithEvents priority_add_Button1 As Button
    Friend WithEvents gender_Button2 As Button
    Friend WithEvents Customers_infoBindingSource As BindingSource
    Friend WithEvents Customers_infoTableAdapter As combo_dsTableAdapters.customers_infoTableAdapter
    Friend WithEvents TableAdapterManager As combo_dsTableAdapters.TableAdapterManager
    Friend WithEvents Customers_infoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents SubjectTextBox As TextBox
    Friend WithEvents Reg_dateDateTimePicker As DateTimePicker
    Friend WithEvents CommentTextBox As TextBox
    Friend WithEvents Sender_incomeTextBox As TextBox
    Friend WithEvents Sender_debtTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents save_Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
