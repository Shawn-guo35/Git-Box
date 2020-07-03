<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 场地管理
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
        Me.btnSelectVenue = New System.Windows.Forms.Button()
        Me.btnSelectVtype = New System.Windows.Forms.Button()
        Me.btnSelectLease = New System.Windows.Forms.Button()
        Me.btnInsertVenue = New System.Windows.Forms.Button()
        Me.btnInsertVtype = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelectVenue
        '
        Me.btnSelectVenue.Location = New System.Drawing.Point(63, 60)
        Me.btnSelectVenue.Name = "btnSelectVenue"
        Me.btnSelectVenue.Size = New System.Drawing.Size(150, 70)
        Me.btnSelectVenue.TabIndex = 0
        Me.btnSelectVenue.Text = "查询场地类型"
        Me.btnSelectVenue.UseVisualStyleBackColor = True
        '
        'btnSelectVtype
        '
        Me.btnSelectVtype.Location = New System.Drawing.Point(273, 60)
        Me.btnSelectVtype.Name = "btnSelectVtype"
        Me.btnSelectVtype.Size = New System.Drawing.Size(150, 70)
        Me.btnSelectVtype.TabIndex = 1
        Me.btnSelectVtype.Text = "查询场地信息"
        Me.btnSelectVtype.UseVisualStyleBackColor = True
        '
        'btnSelectLease
        '
        Me.btnSelectLease.Location = New System.Drawing.Point(489, 60)
        Me.btnSelectLease.Name = "btnSelectLease"
        Me.btnSelectLease.Size = New System.Drawing.Size(150, 70)
        Me.btnSelectLease.TabIndex = 2
        Me.btnSelectLease.Text = "查询场地租借情况"
        Me.btnSelectLease.UseVisualStyleBackColor = True
        '
        'btnInsertVenue
        '
        Me.btnInsertVenue.Location = New System.Drawing.Point(63, 209)
        Me.btnInsertVenue.Name = "btnInsertVenue"
        Me.btnInsertVenue.Size = New System.Drawing.Size(150, 70)
        Me.btnInsertVenue.TabIndex = 3
        Me.btnInsertVenue.Text = "添加场地类型"
        Me.btnInsertVenue.UseVisualStyleBackColor = True
        '
        'btnInsertVtype
        '
        Me.btnInsertVtype.Location = New System.Drawing.Point(273, 209)
        Me.btnInsertVtype.Name = "btnInsertVtype"
        Me.btnInsertVtype.Size = New System.Drawing.Size(150, 70)
        Me.btnInsertVtype.TabIndex = 4
        Me.btnInsertVtype.Text = "添加场地信息"
        Me.btnInsertVtype.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReturn)
        Me.GroupBox1.Controls.Add(Me.btnSelectVenue)
        Me.GroupBox1.Controls.Add(Me.btnSelectLease)
        Me.GroupBox1.Controls.Add(Me.btnInsertVtype)
        Me.GroupBox1.Controls.Add(Me.btnSelectVtype)
        Me.GroupBox1.Controls.Add(Me.btnInsertVenue)
        Me.GroupBox1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 369)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "场地管理系统"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(489, 209)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(150, 70)
        Me.btnReturn.TabIndex = 5
        Me.btnReturn.Text = "退出"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        '场地管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 380)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "场地管理"
        Me.Text = "场地管理"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelectVenue As Button
    Friend WithEvents btnSelectVtype As Button
    Friend WithEvents btnSelectLease As Button
    Friend WithEvents btnInsertVenue As Button
    Friend WithEvents btnInsertVtype As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnReturn As Button
End Class
