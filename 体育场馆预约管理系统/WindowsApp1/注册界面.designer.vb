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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.txtCpwd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.radInside = New System.Windows.Forms.RadioButton()
        Me.radOutside = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 148)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "请输入账号："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 206)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "请输入密码："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 262)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "请再次输入密码："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(158, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 33)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "用户注册"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(225, 144)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(107, 21)
        Me.txtID.TabIndex = 4
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(225, 202)
        Me.txtPwd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPwd.Size = New System.Drawing.Size(107, 21)
        Me.txtPwd.TabIndex = 5
        '
        'txtCpwd
        '
        Me.txtCpwd.Location = New System.Drawing.Point(225, 258)
        Me.txtCpwd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCpwd.Name = "txtCpwd"
        Me.txtCpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCpwd.Size = New System.Drawing.Size(107, 21)
        Me.txtCpwd.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 314)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "请输入您的姓名："
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(225, 310)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(107, 21)
        Me.txtName.TabIndex = 8
        '
        'btnRegister
        '
        Me.btnRegister.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRegister.Location = New System.Drawing.Point(83, 374)
        Me.btnRegister.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(70, 29)
        Me.btnRegister.TabIndex = 9
        Me.btnRegister.Text = "注册"
        Me.btnRegister.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnReturn.Location = New System.Drawing.Point(283, 374)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(73, 29)
        Me.btnReturn.TabIndex = 10
        Me.btnReturn.Text = "返回"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'radInside
        '
        Me.radInside.AutoSize = True
        Me.radInside.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.radInside.Location = New System.Drawing.Point(104, 92)
        Me.radInside.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radInside.Name = "radInside"
        Me.radInside.Size = New System.Drawing.Size(85, 19)
        Me.radInside.TabIndex = 14
        Me.radInside.TabStop = True
        Me.radInside.Text = "校内人员"
        Me.radInside.UseVisualStyleBackColor = True
        '
        'radOutside
        '
        Me.radOutside.AutoSize = True
        Me.radOutside.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.radOutside.Location = New System.Drawing.Point(259, 92)
        Me.radOutside.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radOutside.Name = "radOutside"
        Me.radOutside.Size = New System.Drawing.Size(85, 19)
        Me.radOutside.TabIndex = 15
        Me.radOutside.TabStop = True
        Me.radOutside.Text = "校外人员"
        Me.radOutside.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(356, 152)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 12)
        Me.Label6.TabIndex = 16
        '
        '注册界面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(466, 438)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.radOutside)
        Me.Controls.Add(Me.radInside)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCpwd)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "注册界面"
        Me.Text = "用户注册"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents txtCpwd As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents radInside As RadioButton
    Friend WithEvents radOutside As RadioButton
    Friend WithEvents Label6 As Label
End Class
