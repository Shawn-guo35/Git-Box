<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 用户界面
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(用户界面))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.注销ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.查询历史订单ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.注销ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.帮助ToolStripMenuItem, Me.退出ToolStripMenuItem1})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.注销ToolStripMenuItem, Me.查询历史订单ToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        '注销ToolStripMenuItem
        '
        Me.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem"
        resources.ApplyResources(Me.注销ToolStripMenuItem, "注销ToolStripMenuItem")
        '
        '查询历史订单ToolStripMenuItem
        '
        Me.查询历史订单ToolStripMenuItem.Name = "查询历史订单ToolStripMenuItem"
        resources.ApplyResources(Me.查询历史订单ToolStripMenuItem, "查询历史订单ToolStripMenuItem")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        resources.ApplyResources(Me.帮助ToolStripMenuItem, "帮助ToolStripMenuItem")
        '
        '退出ToolStripMenuItem1
        '
        Me.退出ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.注销ToolStripMenuItem1, Me.退出ToolStripMenuItem2})
        Me.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1"
        resources.ApplyResources(Me.退出ToolStripMenuItem1, "退出ToolStripMenuItem1")
        '
        '注销ToolStripMenuItem1
        '
        Me.注销ToolStripMenuItem1.Name = "注销ToolStripMenuItem1"
        resources.ApplyResources(Me.注销ToolStripMenuItem1, "注销ToolStripMenuItem1")
        '
        '退出ToolStripMenuItem2
        '
        Me.退出ToolStripMenuItem2.Name = "退出ToolStripMenuItem2"
        resources.ApplyResources(Me.退出ToolStripMenuItem2, "退出ToolStripMenuItem2")
        '
        '用户界面
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.捕获1
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "用户界面"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 注销ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 注销ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents 查询历史订单ToolStripMenuItem As ToolStripMenuItem
End Class
