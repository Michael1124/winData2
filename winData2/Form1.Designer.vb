<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意:  以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbEquip = New System.Windows.Forms.ComboBox()
        Me.cmbSystem = New System.Windows.Forms.ComboBox()
        Me.生產系統BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New winData2.DataSet1()
        Me.dgEquip = New System.Windows.Forms.DataGridView()
        Me.btAddData = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.識別碼DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.設備名稱DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.設備編號DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.系統DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.安裝日期DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.設備BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.生產系統TableAdapter = New winData2.DataSet1TableAdapters.生產系統TableAdapter()
        Me.設備TableAdapter = New winData2.DataSet1TableAdapters.設備TableAdapter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgMaintain = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.生產系統BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEquip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.設備BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgMaintain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Beige
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbEquip)
        Me.Panel1.Controls.Add(Me.cmbSystem)
        Me.Panel1.Location = New System.Drawing.Point(18, 16)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(944, 121)
        Me.Panel1.TabIndex = 0
        '
        'cmbEquip
        '
        Me.cmbEquip.FormattingEnabled = True
        Me.cmbEquip.Location = New System.Drawing.Point(119, 56)
        Me.cmbEquip.Name = "cmbEquip"
        Me.cmbEquip.Size = New System.Drawing.Size(234, 24)
        Me.cmbEquip.TabIndex = 1
        '
        'cmbSystem
        '
        Me.cmbSystem.DataSource = Me.生產系統BindingSource
        Me.cmbSystem.DisplayMember = "系統"
        Me.cmbSystem.FormattingEnabled = True
        Me.cmbSystem.Location = New System.Drawing.Point(119, 25)
        Me.cmbSystem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSystem.Name = "cmbSystem"
        Me.cmbSystem.Size = New System.Drawing.Size(234, 24)
        Me.cmbSystem.TabIndex = 0
        Me.cmbSystem.ValueMember = "系統"
        '
        '生產系統BindingSource
        '
        Me.生產系統BindingSource.DataMember = "生產系統"
        Me.生產系統BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgEquip
        '
        Me.dgEquip.AutoGenerateColumns = False
        Me.dgEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEquip.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.btAddData, Me.識別碼DataGridViewTextBoxColumn, Me.設備名稱DataGridViewTextBoxColumn, Me.設備編號DataGridViewTextBoxColumn, Me.系統DataGridViewTextBoxColumn, Me.安裝日期DataGridViewTextBoxColumn})
        Me.dgEquip.DataSource = Me.設備BindingSource
        Me.dgEquip.Location = New System.Drawing.Point(18, 145)
        Me.dgEquip.Margin = New System.Windows.Forms.Padding(4)
        Me.dgEquip.Name = "dgEquip"
        Me.dgEquip.RowTemplate.Height = 24
        Me.dgEquip.Size = New System.Drawing.Size(944, 95)
        Me.dgEquip.TabIndex = 1
        '
        'btAddData
        '
        Me.btAddData.DataPropertyName = "識別碼"
        Me.btAddData.HeaderText = "新增"
        Me.btAddData.Name = "btAddData"
        Me.btAddData.Text = "新增保養日期"
        Me.btAddData.UseColumnTextForButtonValue = True
        '
        '識別碼DataGridViewTextBoxColumn
        '
        Me.識別碼DataGridViewTextBoxColumn.DataPropertyName = "識別碼"
        Me.識別碼DataGridViewTextBoxColumn.HeaderText = "識別碼"
        Me.識別碼DataGridViewTextBoxColumn.Name = "識別碼DataGridViewTextBoxColumn"
        '
        '設備名稱DataGridViewTextBoxColumn
        '
        Me.設備名稱DataGridViewTextBoxColumn.DataPropertyName = "設備名稱"
        Me.設備名稱DataGridViewTextBoxColumn.HeaderText = "設備名稱"
        Me.設備名稱DataGridViewTextBoxColumn.Name = "設備名稱DataGridViewTextBoxColumn"
        '
        '設備編號DataGridViewTextBoxColumn
        '
        Me.設備編號DataGridViewTextBoxColumn.DataPropertyName = "設備編號"
        Me.設備編號DataGridViewTextBoxColumn.HeaderText = "設備編號"
        Me.設備編號DataGridViewTextBoxColumn.Name = "設備編號DataGridViewTextBoxColumn"
        '
        '系統DataGridViewTextBoxColumn
        '
        Me.系統DataGridViewTextBoxColumn.DataPropertyName = "系統"
        Me.系統DataGridViewTextBoxColumn.HeaderText = "系統"
        Me.系統DataGridViewTextBoxColumn.Name = "系統DataGridViewTextBoxColumn"
        '
        '安裝日期DataGridViewTextBoxColumn
        '
        Me.安裝日期DataGridViewTextBoxColumn.DataPropertyName = "安裝日期"
        Me.安裝日期DataGridViewTextBoxColumn.HeaderText = "安裝日期"
        Me.安裝日期DataGridViewTextBoxColumn.Name = "安裝日期DataGridViewTextBoxColumn"
        '
        '設備BindingSource
        '
        Me.設備BindingSource.DataMember = "設備"
        Me.設備BindingSource.DataSource = Me.DataSet1
        '
        '生產系統TableAdapter
        '
        Me.生產系統TableAdapter.ClearBeforeFill = True
        '
        '設備TableAdapter
        '
        Me.設備TableAdapter.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(22, 247)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(940, 324)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgMaintain)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(932, 294)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "保養日期"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgMaintain
        '
        Me.dgMaintain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMaintain.Location = New System.Drawing.Point(6, 12)
        Me.dgMaintain.Name = "dgMaintain"
        Me.dgMaintain.RowTemplate.Height = 24
        Me.dgMaintain.Size = New System.Drawing.Size(920, 276)
        Me.dgMaintain.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "系統："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "設備："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 598)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.dgEquip)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.生產系統BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEquip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.設備BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgMaintain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbSystem As System.Windows.Forms.ComboBox
    Friend WithEvents dgEquip As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As winData2.DataSet1
    Friend WithEvents 生產系統BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 生產系統TableAdapter As winData2.DataSet1TableAdapters.生產系統TableAdapter
    Friend WithEvents cmbEquip As System.Windows.Forms.ComboBox
    Friend WithEvents 設備BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 設備TableAdapter As winData2.DataSet1TableAdapters.設備TableAdapter
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents dgMaintain As System.Windows.Forms.DataGridView
    Friend WithEvents btAddData As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents 識別碼DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 設備名稱DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 設備編號DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 系統DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 安裝日期DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
