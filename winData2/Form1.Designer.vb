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
        Me.生產系統TableAdapter = New winData2.DataSet1TableAdapters.生產系統TableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.生產系統BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgEquip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
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
        Me.cmbEquip.Location = New System.Drawing.Point(49, 56)
        Me.cmbEquip.Name = "cmbEquip"
        Me.cmbEquip.Size = New System.Drawing.Size(180, 24)
        Me.cmbEquip.TabIndex = 1
        '
        'cmbSystem
        '
        Me.cmbSystem.DataSource = Me.生產系統BindingSource
        Me.cmbSystem.DisplayMember = "系統"
        Me.cmbSystem.FormattingEnabled = True
        Me.cmbSystem.Location = New System.Drawing.Point(49, 25)
        Me.cmbSystem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSystem.Name = "cmbSystem"
        Me.cmbSystem.Size = New System.Drawing.Size(180, 24)
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
        Me.dgEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEquip.Location = New System.Drawing.Point(18, 145)
        Me.dgEquip.Margin = New System.Windows.Forms.Padding(4)
        Me.dgEquip.Name = "dgEquip"
        Me.dgEquip.RowTemplate.Height = 24
        Me.dgEquip.Size = New System.Drawing.Size(944, 385)
        Me.dgEquip.TabIndex = 1
        '
        '生產系統TableAdapter
        '
        Me.生產系統TableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 559)
        Me.Controls.Add(Me.dgEquip)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.生產系統BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgEquip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbSystem As System.Windows.Forms.ComboBox
    Friend WithEvents dgEquip As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As winData2.DataSet1
    Friend WithEvents 生產系統BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents 生產系統TableAdapter As winData2.DataSet1TableAdapters.生產系統TableAdapter
    Friend WithEvents cmbEquip As System.Windows.Forms.ComboBox

End Class
