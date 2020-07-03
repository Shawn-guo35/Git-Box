<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 欢迎界面
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblResults1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'lblResults1
        '
        Me.lblResults1.AutoSize = True
        Me.lblResults1.BackColor = System.Drawing.Color.Transparent
        Me.lblResults1.Font = New System.Drawing.Font("宋体", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults1.ForeColor = System.Drawing.Color.Black
        Me.lblResults1.Location = New System.Drawing.Point(195, 136)
        Me.lblResults1.Name = "lblResults1"
        Me.lblResults1.Size = New System.Drawing.Size(345, 40)
        Me.lblResults1.TabIndex = 0
        Me.lblResults1.Text = "体育场馆预约系统"
        '
        '欢迎界面
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources._0ff610843ca2f431_05d415b9ec93c33a_2ee29b314b579c64fa255b15bdf3643b
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(730, 451)
        Me.Controls.Add(Me.lblResults1)
        Me.DoubleBuffered = True
        Me.Name = "欢迎界面"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "欢迎使用"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblResults1 As Label
End Class
