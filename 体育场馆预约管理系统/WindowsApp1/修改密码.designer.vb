<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 修改密码
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
        Me.lblResults1 = New System.Windows.Forms.Label()
        Me.lblResults2 = New System.Windows.Forms.Label()
        Me.lblResults3 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtOldPwd = New System.Windows.Forms.TextBox()
        Me.txtNewPwd = New System.Windows.Forms.TextBox()
        Me.txtNewPwd1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblResults1
        '
        Me.lblResults1.AutoSize = True
        Me.lblResults1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults1.Location = New System.Drawing.Point(51, 96)
        Me.lblResults1.Name = "lblResults1"
        Me.lblResults1.Size = New System.Drawing.Size(129, 20)
        Me.lblResults1.TabIndex = 0
        Me.lblResults1.Text = "输入旧密码："
        '
        'lblResults2
        '
        Me.lblResults2.AutoSize = True
        Me.lblResults2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults2.Location = New System.Drawing.Point(51, 160)
        Me.lblResults2.Name = "lblResults2"
        Me.lblResults2.Size = New System.Drawing.Size(129, 20)
        Me.lblResults2.TabIndex = 1
        Me.lblResults2.Text = "输入新密码："
        '
        'lblResults3
        '
        Me.lblResults3.AutoSize = True
        Me.lblResults3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults3.Location = New System.Drawing.Point(51, 222)
        Me.lblResults3.Name = "lblResults3"
        Me.lblResults3.Size = New System.Drawing.Size(129, 20)
        Me.lblResults3.TabIndex = 2
        Me.lblResults3.Text = "确认新密码："
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(136, 276)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(101, 57)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "确认修改"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtOldPwd
        '
        Me.txtOldPwd.Location = New System.Drawing.Point(192, 91)
        Me.txtOldPwd.Name = "txtOldPwd"
        Me.txtOldPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPwd.Size = New System.Drawing.Size(146, 25)
        Me.txtOldPwd.TabIndex = 4
        '
        'txtNewPwd
        '
        Me.txtNewPwd.Location = New System.Drawing.Point(192, 160)
        Me.txtNewPwd.Name = "txtNewPwd"
        Me.txtNewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwd.Size = New System.Drawing.Size(146, 25)
        Me.txtNewPwd.TabIndex = 5
        '
        'txtNewPwd1
        '
        Me.txtNewPwd1.Location = New System.Drawing.Point(192, 217)
        Me.txtNewPwd1.Name = "txtNewPwd1"
        Me.txtNewPwd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwd1.Size = New System.Drawing.Size(146, 25)
        Me.txtNewPwd1.TabIndex = 6
        '
        '修改密码
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 374)
        Me.Controls.Add(Me.txtNewPwd1)
        Me.Controls.Add(Me.txtNewPwd)
        Me.Controls.Add(Me.txtOldPwd)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblResults3)
        Me.Controls.Add(Me.lblResults2)
        Me.Controls.Add(Me.lblResults1)
        Me.Name = "修改密码"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "修改密码"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResults1 As Label
    Friend WithEvents lblResults2 As Label
    Friend WithEvents lblResults3 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtOldPwd As TextBox
    Friend WithEvents txtNewPwd As TextBox
    Friend WithEvents txtNewPwd1 As TextBox
End Class
