<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Yuyue
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
        Me.btnSubmit5 = New System.Windows.Forms.Button()
        Me.btnSubmit2 = New System.Windows.Forms.Button()
        Me.btnSubmit6 = New System.Windows.Forms.Button()
        Me.btnSubmit3 = New System.Windows.Forms.Button()
        Me.btnSubmit4 = New System.Windows.Forms.Button()
        Me.btnSubmit1 = New System.Windows.Forms.Button()
        Me.lblResults1 = New System.Windows.Forms.Label()
        Me.lblResults2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSubmit5
        '
        Me.btnSubmit5.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSubmit5.Location = New System.Drawing.Point(519, 272)
        Me.btnSubmit5.Name = "btnSubmit5"
        Me.btnSubmit5.Size = New System.Drawing.Size(180, 80)
        Me.btnSubmit5.TabIndex = 4
        Me.btnSubmit5.Text = "乒乓球馆"
        Me.btnSubmit5.UseVisualStyleBackColor = True
        '
        'btnSubmit2
        '
        Me.btnSubmit2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSubmit2.Location = New System.Drawing.Point(306, 272)
        Me.btnSubmit2.Name = "btnSubmit2"
        Me.btnSubmit2.Size = New System.Drawing.Size(180, 80)
        Me.btnSubmit2.TabIndex = 1
        Me.btnSubmit2.Text = "羽毛球馆"
        Me.btnSubmit2.UseVisualStyleBackColor = True
        '
        'btnSubmit6
        '
        Me.btnSubmit6.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSubmit6.Location = New System.Drawing.Point(91, 272)
        Me.btnSubmit6.Name = "btnSubmit6"
        Me.btnSubmit6.Size = New System.Drawing.Size(180, 80)
        Me.btnSubmit6.TabIndex = 5
        Me.btnSubmit6.Text = "篮球馆"
        Me.btnSubmit6.UseVisualStyleBackColor = True
        '
        'btnSubmit3
        '
        Me.btnSubmit3.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSubmit3.Location = New System.Drawing.Point(519, 166)
        Me.btnSubmit3.Name = "btnSubmit3"
        Me.btnSubmit3.Size = New System.Drawing.Size(180, 80)
        Me.btnSubmit3.TabIndex = 2
        Me.btnSubmit3.Text = "东足球场"
        Me.btnSubmit3.UseVisualStyleBackColor = True
        '
        'btnSubmit4
        '
        Me.btnSubmit4.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSubmit4.Location = New System.Drawing.Point(306, 166)
        Me.btnSubmit4.Name = "btnSubmit4"
        Me.btnSubmit4.Size = New System.Drawing.Size(180, 80)
        Me.btnSubmit4.TabIndex = 3
        Me.btnSubmit4.Text = "网球场"
        Me.btnSubmit4.UseVisualStyleBackColor = True
        '
        'btnSubmit1
        '
        Me.btnSubmit1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSubmit1.Location = New System.Drawing.Point(91, 166)
        Me.btnSubmit1.Name = "btnSubmit1"
        Me.btnSubmit1.Size = New System.Drawing.Size(180, 80)
        Me.btnSubmit1.TabIndex = 0
        Me.btnSubmit1.Text = "篮球场"
        Me.btnSubmit1.UseVisualStyleBackColor = True
        '
        'lblResults1
        '
        Me.lblResults1.AutoSize = True
        Me.lblResults1.Font = New System.Drawing.Font("黑体", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults1.Location = New System.Drawing.Point(86, 45)
        Me.lblResults1.Name = "lblResults1"
        Me.lblResults1.Size = New System.Drawing.Size(272, 25)
        Me.lblResults1.TabIndex = 6
        Me.lblResults1.Text = "欢迎使用场馆预约系统"
        '
        'lblResults2
        '
        Me.lblResults2.AutoSize = True
        Me.lblResults2.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults2.Location = New System.Drawing.Point(86, 118)
        Me.lblResults2.Name = "lblResults2"
        Me.lblResults2.Size = New System.Drawing.Size(272, 27)
        Me.lblResults2.TabIndex = 7
        Me.lblResults2.Text = "请在下方选择您想预约的场地"
        '
        'Yuyue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 447)
        Me.Controls.Add(Me.lblResults2)
        Me.Controls.Add(Me.lblResults1)
        Me.Controls.Add(Me.btnSubmit6)
        Me.Controls.Add(Me.btnSubmit4)
        Me.Controls.Add(Me.btnSubmit5)
        Me.Controls.Add(Me.btnSubmit1)
        Me.Controls.Add(Me.btnSubmit3)
        Me.Controls.Add(Me.btnSubmit2)
        Me.Name = "Yuyue"
        Me.Text = "预约主界面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSubmit5 As Button
    Friend WithEvents btnSubmit2 As Button
    Friend WithEvents btnSubmit6 As Button
    Friend WithEvents btnSubmit3 As Button
    Friend WithEvents btnSubmit4 As Button
    Friend WithEvents btnSubmit1 As Button
    Friend WithEvents lblResults1 As Label
    Friend WithEvents lblResults2 As Label
End Class
