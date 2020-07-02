<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 管理员界面
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.管理员功能ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询用户信息 = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询订单信息 = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询场地信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.统计收入信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.注销ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("楷体", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.管理员功能ToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '管理员功能ToolStripMenuItem
        '
        Me.管理员功能ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.查询用户信息, Me.查询订单信息, Me.查询场地信息ToolStripMenuItem, Me.统计收入信息ToolStripMenuItem})
        Me.管理员功能ToolStripMenuItem.Name = "管理员功能ToolStripMenuItem"
        Me.管理员功能ToolStripMenuItem.Size = New System.Drawing.Size(169, 32)
        Me.管理员功能ToolStripMenuItem.Text = "管理员功能"
        '
        '查询用户信息
        '
        Me.查询用户信息.Name = "查询用户信息"
        Me.查询用户信息.Size = New System.Drawing.Size(264, 32)
        Me.查询用户信息.Text = "查询用户信息"
        '
        '查询订单信息
        '
        Me.查询订单信息.Name = "查询订单信息"
        Me.查询订单信息.Size = New System.Drawing.Size(264, 32)
        Me.查询订单信息.Text = "查询订单信息"
        '
        '查询场地信息ToolStripMenuItem
        '
        Me.查询场地信息ToolStripMenuItem.Name = "查询场地信息ToolStripMenuItem"
        Me.查询场地信息ToolStripMenuItem.Size = New System.Drawing.Size(264, 32)
        Me.查询场地信息ToolStripMenuItem.Text = "查询场地信息"
        '
        '统计收入信息ToolStripMenuItem
        '
        Me.统计收入信息ToolStripMenuItem.Name = "统计收入信息ToolStripMenuItem"
        Me.统计收入信息ToolStripMenuItem.Size = New System.Drawing.Size(264, 32)
        Me.统计收入信息ToolStripMenuItem.Text = "统计收入信息"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(82, 32)
        Me.ToolStripMenuItem1.Text = "帮助"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.注销ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(82, 32)
        Me.ToolStripMenuItem2.Text = "退出"
        '
        '注销ToolStripMenuItem
        '
        Me.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem"
        Me.注销ToolStripMenuItem.Size = New System.Drawing.Size(148, 32)
        Me.注销ToolStripMenuItem.Text = "注销"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(148, 32)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '管理员界面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.捕获
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "管理员界面"
        Me.Text = "管理员界面"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 管理员功能ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 查询用户信息 As ToolStripMenuItem
    Friend WithEvents 查询订单信息 As ToolStripMenuItem
    Friend WithEvents 查询场地信息ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents 注销ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 统计收入信息ToolStripMenuItem As ToolStripMenuItem
End Class
