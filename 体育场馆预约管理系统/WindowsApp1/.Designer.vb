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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(63, 60)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 70)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "查询场地类型"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(273, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 70)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "查询场地信息"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(489, 60)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 70)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "查询场地租借情况"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(63, 209)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(150, 70)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "添加场地类型"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(273, 209)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(150, 70)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "添加场地信息"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 369)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "场地管理系统"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(489, 209)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(150, 70)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "退出"
        Me.Button6.UseVisualStyleBackColor = True
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

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button6 As Button
End Class
