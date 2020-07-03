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
        Me.tsmiUser = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiUser1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiUser2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiAppointment = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助tsmiHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCancellation = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClose1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiUser, Me.tsmiAppointment, Me.帮助tsmiHelp, Me.tsmiClose})
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'tsmiUser
        '
        Me.tsmiUser.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiUser1, Me.tsmiUser2})
        Me.tsmiUser.Name = "tsmiUser"
        resources.ApplyResources(Me.tsmiUser, "tsmiUser")
        '
        'tsmiUser1
        '
        Me.tsmiUser1.Name = "tsmiUser1"
        resources.ApplyResources(Me.tsmiUser1, "tsmiUser1")
        '
        'tsmiUser2
        '
        Me.tsmiUser2.Name = "tsmiUser2"
        resources.ApplyResources(Me.tsmiUser2, "tsmiUser2")
        '
        'tsmiAppointment
        '
        Me.tsmiAppointment.Name = "tsmiAppointment"
        resources.ApplyResources(Me.tsmiAppointment, "tsmiAppointment")
        '
        '帮助tsmiHelp
        '
        Me.帮助tsmiHelp.ForeColor = System.Drawing.Color.Black
        Me.帮助tsmiHelp.Name = "帮助tsmiHelp"
        resources.ApplyResources(Me.帮助tsmiHelp, "帮助tsmiHelp")
        '
        'tsmiClose
        '
        Me.tsmiClose.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCancellation, Me.tsmiClose1})
        Me.tsmiClose.Name = "tsmiClose"
        resources.ApplyResources(Me.tsmiClose, "tsmiClose")
        '
        'tsmiCancellation
        '
        Me.tsmiCancellation.Name = "tsmiCancellation"
        resources.ApplyResources(Me.tsmiCancellation, "tsmiCancellation")
        '
        'tsmiClose1
        '
        Me.tsmiClose1.Name = "tsmiClose1"
        resources.ApplyResources(Me.tsmiClose1, "tsmiClose1")
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
    Friend WithEvents tsmiUser As ToolStripMenuItem
    Friend WithEvents tsmiUser1 As ToolStripMenuItem
    Friend WithEvents tsmiAppointment As ToolStripMenuItem
    Friend WithEvents 帮助tsmiHelp As ToolStripMenuItem
    Friend WithEvents tsmiClose As ToolStripMenuItem
    Friend WithEvents tsmiCancellation As ToolStripMenuItem
    Friend WithEvents tsmiClose1 As ToolStripMenuItem
    Friend WithEvents tsmiUser2 As ToolStripMenuItem
End Class
