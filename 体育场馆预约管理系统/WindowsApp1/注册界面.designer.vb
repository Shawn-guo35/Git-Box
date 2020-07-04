<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 注册界面
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
        Me.lblResults4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtCpwd = New System.Windows.Forms.TextBox()
        Me.lblResults5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.radInside = New System.Windows.Forms.RadioButton()
        Me.radOutside = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblResults1
        '
        Me.lblResults1.AutoSize = True
        Me.lblResults1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults1.Location = New System.Drawing.Point(147, 185)
        Me.lblResults1.Name = "lblResults1"
        Me.lblResults1.Size = New System.Drawing.Size(129, 20)
        Me.lblResults1.TabIndex = 0
        Me.lblResults1.Text = "请输入账号："
        '
        'lblResults2
        '
        Me.lblResults2.AutoSize = True
        Me.lblResults2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults2.Location = New System.Drawing.Point(147, 258)
        Me.lblResults2.Name = "lblResults2"
        Me.lblResults2.Size = New System.Drawing.Size(129, 20)
        Me.lblResults2.TabIndex = 1
        Me.lblResults2.Text = "请输入密码："
        '
        'lblResults3
        '
        Me.lblResults3.AutoSize = True
        Me.lblResults3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults3.Location = New System.Drawing.Point(107, 328)
        Me.lblResults3.Name = "lblResults3"
        Me.lblResults3.Size = New System.Drawing.Size(169, 20)
        Me.lblResults3.TabIndex = 2
        Me.lblResults3.Text = "请再次输入密码："
        '
        'lblResults4
        '
        Me.lblResults4.AutoSize = True
        Me.lblResults4.Font = New System.Drawing.Font("宋体", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblResults4.Location = New System.Drawing.Point(211, 25)
        Me.lblResults4.Name = "lblResults4"
        Me.lblResults4.Size = New System.Drawing.Size(177, 40)
        Me.lblResults4.TabIndex = 3
        Me.lblResults4.Text = "用户注册"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(300, 180)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(141, 25)
        Me.txtID.TabIndex = 4
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(300, 252)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(141, 25)
        Me.txtPwd.TabIndex = 5
        '
        'txtCpwd
        '
        Me.txtCpwd.Location = New System.Drawing.Point(300, 322)
        Me.txtCpwd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCpwd.Name = "txtCpwd"
        Me.txtCpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCpwd.Size = New System.Drawing.Size(141, 25)
        Me.txtCpwd.TabIndex = 6
        '
        'lblResults5
        '
        Me.lblResults5.AutoSize = True
        Me.lblResults5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults5.Location = New System.Drawing.Point(107, 392)
        Me.lblResults5.Name = "lblResults5"
        Me.lblResults5.Size = New System.Drawing.Size(169, 20)
        Me.lblResults5.TabIndex = 7
        Me.lblResults5.Text = "请输入您的姓名："
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(300, 388)
        Me.txtName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(141, 25)
        Me.txtName.TabIndex = 8
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(111, 468)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(93, 36)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "注册"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(377, 468)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(97, 36)
        Me.btnReturn.TabIndex = 10
        Me.btnReturn.Text = "返回"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'radInside
        '
        Me.radInside.AutoSize = True
        Me.radInside.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.radInside.Location = New System.Drawing.Point(139, 115)
        Me.radInside.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radInside.Name = "radInside"
        Me.radInside.Size = New System.Drawing.Size(106, 23)
        Me.radInside.TabIndex = 14
        Me.radInside.TabStop = True
        Me.radInside.Text = "校内人员"
        Me.radInside.UseVisualStyleBackColor = True
        '
        'radOutside
        '
        Me.radOutside.AutoSize = True
        Me.radOutside.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.radOutside.Location = New System.Drawing.Point(345, 115)
        Me.radOutside.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.radOutside.Name = "radOutside"
        Me.radOutside.Size = New System.Drawing.Size(106, 23)
        Me.radOutside.TabIndex = 15
        Me.radOutside.TabStop = True
        Me.radOutside.Text = "校外人员"
        Me.radOutside.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(475, 190)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 15)
        Me.Label6.TabIndex = 16
        '
        '注册界面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(621, 548)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.radOutside)
        Me.Controls.Add(Me.radInside)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblResults5)
        Me.Controls.Add(Me.txtCpwd)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblResults4)
        Me.Controls.Add(Me.lblResults3)
        Me.Controls.Add(Me.lblResults2)
        Me.Controls.Add(Me.lblResults1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "注册界面"
        Me.Text = "用户注册"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResults1 As Label
    Friend WithEvents lblResults2 As Label
    Friend WithEvents lblResults3 As Label
    Friend WithEvents lblResults4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents txtCpwd As TextBox
    Friend WithEvents lblResults5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents radInside As RadioButton
    Friend WithEvents radOutside As RadioButton
    Friend WithEvents Label6 As Label
End Class
