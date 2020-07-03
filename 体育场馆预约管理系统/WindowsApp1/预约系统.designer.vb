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
        Me.btnPingpang = New System.Windows.Forms.Button()
        Me.btnBadminton = New System.Windows.Forms.Button()
        Me.btnBasketball1 = New System.Windows.Forms.Button()
        Me.btnSoccer = New System.Windows.Forms.Button()
        Me.btnTennis = New System.Windows.Forms.Button()
        Me.btnBasketball = New System.Windows.Forms.Button()
        Me.lblResults1 = New System.Windows.Forms.Label()
        Me.lblResults2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPingpang
        '
        Me.btnPingpang.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnPingpang.Location = New System.Drawing.Point(519, 272)
        Me.btnPingpang.Name = "btnPingpang"
        Me.btnPingpang.Size = New System.Drawing.Size(180, 80)
        Me.btnPingpang.TabIndex = 4
        Me.btnPingpang.Text = "乒乓球馆"
        Me.btnPingpang.UseVisualStyleBackColor = True
        '
        'btnBadminton
        '
        Me.btnBadminton.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnBadminton.Location = New System.Drawing.Point(306, 272)
        Me.btnBadminton.Name = "btnBadminton"
        Me.btnBadminton.Size = New System.Drawing.Size(180, 80)
        Me.btnBadminton.TabIndex = 1
        Me.btnBadminton.Text = "羽毛球馆"
        Me.btnBadminton.UseVisualStyleBackColor = True
        '
        'btnBasketball1
        '
        Me.btnBasketball1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnBasketball1.Location = New System.Drawing.Point(91, 272)
        Me.btnBasketball1.Name = "btnBasketball1"
        Me.btnBasketball1.Size = New System.Drawing.Size(180, 80)
        Me.btnBasketball1.TabIndex = 5
        Me.btnBasketball1.Text = "篮球馆"
        Me.btnBasketball1.UseVisualStyleBackColor = True
        '
        'btnSoccer
        '
        Me.btnSoccer.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSoccer.Location = New System.Drawing.Point(519, 166)
        Me.btnSoccer.Name = "btnSoccer"
        Me.btnSoccer.Size = New System.Drawing.Size(180, 80)
        Me.btnSoccer.TabIndex = 2
        Me.btnSoccer.Text = "东足球场"
        Me.btnSoccer.UseVisualStyleBackColor = True
        '
        'btnTennis
        '
        Me.btnTennis.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnTennis.Location = New System.Drawing.Point(306, 166)
        Me.btnTennis.Name = "btnTennis"
        Me.btnTennis.Size = New System.Drawing.Size(180, 80)
        Me.btnTennis.TabIndex = 3
        Me.btnTennis.Text = "网球场"
        Me.btnTennis.UseVisualStyleBackColor = True
        '
        'btnBasketball
        '
        Me.btnBasketball.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnBasketball.Location = New System.Drawing.Point(91, 166)
        Me.btnBasketball.Name = "btnBasketball"
        Me.btnBasketball.Size = New System.Drawing.Size(180, 80)
        Me.btnBasketball.TabIndex = 0
        Me.btnBasketball.Text = "篮球场"
        Me.btnBasketball.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.btnBasketball1)
        Me.Controls.Add(Me.btnTennis)
        Me.Controls.Add(Me.btnPingpang)
        Me.Controls.Add(Me.btnBasketball)
        Me.Controls.Add(Me.btnSoccer)
        Me.Controls.Add(Me.btnBadminton)
        Me.Name = "Yuyue"
        Me.Text = "预约主界面"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPingpang As Button
    Friend WithEvents btnBadminton As Button
    Friend WithEvents btnBasketball1 As Button
    Friend WithEvents btnSoccer As Button
    Friend WithEvents btnTennis As Button
    Friend WithEvents btnBasketball As Button
    Friend WithEvents lblResults1 As Label
    Friend WithEvents lblResults2 As Label
End Class
