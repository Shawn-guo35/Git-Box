<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 登录界面
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblResults1 = New System.Windows.Forms.Label()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblResults2 = New System.Windows.Forms.Label()
        Me.lblResults3 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.radUser = New System.Windows.Forms.RadioButton()
        Me.radAdmin = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblResults1
        '
        Me.lblResults1.AutoSize = True
        Me.lblResults1.BackColor = System.Drawing.Color.Transparent
        Me.lblResults1.Font = New System.Drawing.Font("宋体", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults1.Location = New System.Drawing.Point(200, 65)
        Me.lblResults1.Name = "lblResults1"
        Me.lblResults1.Size = New System.Drawing.Size(321, 38)
        Me.lblResults1.TabIndex = 0
        Me.lblResults1.Text = "体育场馆预约系统"
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(413, 358)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(95, 35)
        Me.btnRegister.TabIndex = 1
        Me.btnRegister.Text = "注册"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(207, 358)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(95, 35)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "登录"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblResults2
        '
        Me.lblResults2.AutoSize = True
        Me.lblResults2.BackColor = System.Drawing.SystemColors.Control
        Me.lblResults2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults2.Location = New System.Drawing.Point(223, 158)
        Me.lblResults2.Name = "lblResults2"
        Me.lblResults2.Size = New System.Drawing.Size(69, 20)
        Me.lblResults2.TabIndex = 3
        Me.lblResults2.Text = "账号："
        '
        'lblResults3
        '
        Me.lblResults3.AutoSize = True
        Me.lblResults3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults3.Location = New System.Drawing.Point(223, 224)
        Me.lblResults3.Name = "lblResults3"
        Me.lblResults3.Size = New System.Drawing.Size(69, 20)
        Me.lblResults3.TabIndex = 4
        Me.lblResults3.Text = "密码："
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(343, 152)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(177, 25)
        Me.txtID.TabIndex = 5
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(343, 219)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(177, 25)
        Me.txtPwd.TabIndex = 6
        '
        'radUser
        '
        Me.radUser.AutoSize = True
        Me.radUser.Location = New System.Drawing.Point(244, 292)
        Me.radUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radUser.Name = "radUser"
        Me.radUser.Size = New System.Drawing.Size(58, 19)
        Me.radUser.TabIndex = 7
        Me.radUser.TabStop = True
        Me.radUser.Text = "用户"
        Me.radUser.UseVisualStyleBackColor = True
        '
        'radAdmin
        '
        Me.radAdmin.AutoSize = True
        Me.radAdmin.Location = New System.Drawing.Point(413, 292)
        Me.radAdmin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radAdmin.Name = "radAdmin"
        Me.radAdmin.Size = New System.Drawing.Size(73, 19)
        Me.radAdmin.TabIndex = 8
        Me.radAdmin.TabStop = True
        Me.radAdmin.Text = "管理员"
        Me.radAdmin.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        '登录界面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 451)
        Me.Controls.Add(Me.radAdmin)
        Me.Controls.Add(Me.radUser)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblResults3)
        Me.Controls.Add(Me.lblResults2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.lblResults1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "登录界面"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "登录"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResults1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblResults2 As Label
    Friend WithEvents lblResults3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents radUser As RadioButton
    Friend WithEvents radAdmin As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Protected WithEvents btnRegister As Button
End Class
