﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.tsmiAdmin = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSelect1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSelect2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSelect3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSelect4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCancellation = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiClose1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("楷体", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiAdmin, Me.tsmiHelp, Me.tsmiClose})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmiAdmin
        '
        Me.tsmiAdmin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiSelect1, Me.tsmiSelect2, Me.tsmiSelect3, Me.tsmiSelect4})
        Me.tsmiAdmin.Name = "tsmiAdmin"
        Me.tsmiAdmin.Size = New System.Drawing.Size(169, 32)
        Me.tsmiAdmin.Text = "管理员功能"
        '
        'tsmiSelect1
        '
        Me.tsmiSelect1.Name = "tsmiSelect1"
        Me.tsmiSelect1.Size = New System.Drawing.Size(264, 32)
        Me.tsmiSelect1.Text = "查询用户信息"
        '
        'tsmiSelect2
        '
        Me.tsmiSelect2.Name = "tsmiSelect2"
        Me.tsmiSelect2.Size = New System.Drawing.Size(264, 32)
        Me.tsmiSelect2.Text = "查询订单信息"
        '
        'tsmiSelect3
        '
        Me.tsmiSelect3.Name = "tsmiSelect3"
        Me.tsmiSelect3.Size = New System.Drawing.Size(264, 32)
        Me.tsmiSelect3.Text = "查询场地信息"
        '
        'tsmiSelect4
        '
        Me.tsmiSelect4.Name = "tsmiSelect4"
        Me.tsmiSelect4.Size = New System.Drawing.Size(264, 32)
        Me.tsmiSelect4.Text = "统计收入信息"
        '
        'tsmiHelp
        '
        Me.tsmiHelp.Name = "tsmiHelp"
        Me.tsmiHelp.Size = New System.Drawing.Size(82, 32)
        Me.tsmiHelp.Text = "帮助"
        '
        'tsmiClose
        '
        Me.tsmiClose.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCancellation, Me.tsmiClose1})
        Me.tsmiClose.Name = "tsmiClose"
        Me.tsmiClose.Size = New System.Drawing.Size(82, 32)
        Me.tsmiClose.Text = "退出"
        '
        'tsmiCancellation
        '
        Me.tsmiCancellation.Name = "tsmiCancellation"
        Me.tsmiCancellation.Size = New System.Drawing.Size(216, 32)
        Me.tsmiCancellation.Text = "注销"
        '
        'tsmiClose1
        '
        Me.tsmiClose1.Name = "tsmiClose1"
        Me.tsmiClose1.Size = New System.Drawing.Size(216, 32)
        Me.tsmiClose1.Text = "退出"
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
    Friend WithEvents tsmiAdmin As ToolStripMenuItem
    Friend WithEvents tsmiSelect1 As ToolStripMenuItem
    Friend WithEvents tsmiSelect2 As ToolStripMenuItem
    Friend WithEvents tsmiSelect3 As ToolStripMenuItem
    Friend WithEvents tsmiHelp As ToolStripMenuItem
    Friend WithEvents tsmiClose As ToolStripMenuItem
    Friend WithEvents tsmiCancellation As ToolStripMenuItem
    Friend WithEvents tsmiClose1 As ToolStripMenuItem
    Friend WithEvents tsmiSelect4 As ToolStripMenuItem
End Class
