<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmData2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btSave = New System.Windows.Forms.Button()
        Me.dtMainDate = New System.Windows.Forms.DateTimePicker()
        Me.txtEName = New System.Windows.Forms.TextBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Moccasin
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtReason)
        Me.Panel1.Controls.Add(Me.btSave)
        Me.Panel1.Controls.Add(Me.dtMainDate)
        Me.Panel1.Controls.Add(Me.txtEName)
        Me.Panel1.Location = New System.Drawing.Point(19, 20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(457, 427)
        Me.Panel1.TabIndex = 0
        '
        'btSave
        '
        Me.btSave.Location = New System.Drawing.Point(251, 25)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 27)
        Me.btSave.TabIndex = 2
        Me.btSave.Text = "儲存"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'dtMainDate
        '
        Me.dtMainDate.Location = New System.Drawing.Point(75, 58)
        Me.dtMainDate.Name = "dtMainDate"
        Me.dtMainDate.Size = New System.Drawing.Size(155, 27)
        Me.dtMainDate.TabIndex = 1
        '
        'txtEName
        '
        Me.txtEName.Location = New System.Drawing.Point(75, 25)
        Me.txtEName.Name = "txtEName"
        Me.txtEName.ReadOnly = True
        Me.txtEName.Size = New System.Drawing.Size(155, 27)
        Me.txtEName.TabIndex = 0
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(75, 91)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(361, 317)
        Me.txtReason.TabIndex = 3
        '
        'frmData2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 459)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmData2"
        Me.Text = "保養日期"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btSave As System.Windows.Forms.Button
    Friend WithEvents dtMainDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEName As System.Windows.Forms.TextBox
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
End Class
