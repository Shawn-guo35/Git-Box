<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 场地管理
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSubmit1 = New System.Windows.Forms.Button()
        Me.btnSubmit2 = New System.Windows.Forms.Button()
        Me.btnSubmit3 = New System.Windows.Forms.Button()
        Me.btnSubmit4 = New System.Windows.Forms.Button()
        Me.btnSubmit5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSubmit6 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmit1
        '
        Me.btnSubmit1.Location = New System.Drawing.Point(63, 60)
        Me.btnSubmit1.Name = "btnSubmit1"
        Me.btnSubmit1.Size = New System.Drawing.Size(150, 70)
        Me.btnSubmit1.TabIndex = 0
        Me.btnSubmit1.Text = "查询场地类型"
        Me.btnSubmit1.UseVisualStyleBackColor = True
        '
        'btnSubmit2
        '
        Me.btnSubmit2.Location = New System.Drawing.Point(273, 60)
        Me.btnSubmit2.Name = "btnSubmit2"
        Me.btnSubmit2.Size = New System.Drawing.Size(150, 70)
        Me.btnSubmit2.TabIndex = 1
        Me.btnSubmit2.Text = "查询场地信息"
        Me.btnSubmit2.UseVisualStyleBackColor = True
        '
        'btnSubmit3
        '
        Me.btnSubmit3.Location = New System.Drawing.Point(489, 60)
        Me.btnSubmit3.Name = "btnSubmit3"
        Me.btnSubmit3.Size = New System.Drawing.Size(150, 70)
        Me.btnSubmit3.TabIndex = 2
        Me.btnSubmit3.Text = "查询场地租借情况"
        Me.btnSubmit3.UseVisualStyleBackColor = True
        '
        'btnSubmit4
        '
        Me.btnSubmit4.Location = New System.Drawing.Point(63, 209)
        Me.btnSubmit4.Name = "btnSubmit4"
        Me.btnSubmit4.Size = New System.Drawing.Size(150, 70)
        Me.btnSubmit4.TabIndex = 3
        Me.btnSubmit4.Text = "添加场地类型"
        Me.btnSubmit4.UseVisualStyleBackColor = True
        '
        'btnSubmit5
        '
        Me.btnSubmit5.Location = New System.Drawing.Point(273, 209)
        Me.btnSubmit5.Name = "btnSubmit5"
        Me.btnSubmit5.Size = New System.Drawing.Size(150, 70)
        Me.btnSubmit5.TabIndex = 4
        Me.btnSubmit5.Text = "添加场地信息"
        Me.btnSubmit5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSubmit6)
        Me.GroupBox1.Controls.Add(Me.btnSubmit1)
        Me.GroupBox1.Controls.Add(Me.btnSubmit3)
        Me.GroupBox1.Controls.Add(Me.btnSubmit5)
        Me.GroupBox1.Controls.Add(Me.btnSubmit2)
        Me.GroupBox1.Controls.Add(Me.btnSubmit4)
        Me.GroupBox1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 369)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "场地管理系统"
        '
        'btnSubmit6
        '
        Me.btnSubmit6.Location = New System.Drawing.Point(489, 209)
        Me.btnSubmit6.Name = "btnSubmit6"
        Me.btnSubmit6.Size = New System.Drawing.Size(150, 70)
        Me.btnSubmit6.TabIndex = 5
        Me.btnSubmit6.Text = "退出"
        Me.btnSubmit6.UseVisualStyleBackColor = True
        '
        '场地管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 380)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "场地管理"
        Me.Text = "场地管理"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSubmit1 As Button
    Friend WithEvents btnSubmit2 As Button
    Friend WithEvents btnSubmit3 As Button
    Friend WithEvents btnSubmit4 As Button
    Friend WithEvents btnSubmit5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSubmit6 As Button
End Class
