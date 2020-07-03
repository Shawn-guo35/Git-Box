<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 用户订单查询
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
        Me.gvwOrders = New System.Windows.Forms.DataGridView()
        Me.lblResults2 = New System.Windows.Forms.Label()
        Me.lblResults5 = New System.Windows.Forms.Label()
        Me.cbmGym = New System.Windows.Forms.ComboBox()
        Me.lblResults6 = New System.Windows.Forms.Label()
        Me.btnSubmit3 = New System.Windows.Forms.Button()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.btnSubmit1 = New System.Windows.Forms.Button()
        CType(Me.gvwOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvwOrders
        '
        Me.gvwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvwOrders.Location = New System.Drawing.Point(16, 52)
        Me.gvwOrders.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gvwOrders.Name = "gvwOrders"
        Me.gvwOrders.RowTemplate.Height = 27
        Me.gvwOrders.Size = New System.Drawing.Size(799, 182)
        Me.gvwOrders.TabIndex = 0
        '
        'lblResults2
        '
        Me.lblResults2.AutoSize = True
        Me.lblResults2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lblResults2.Location = New System.Drawing.Point(45, 270)
        Me.lblResults2.Name = "lblResults2"
        Me.lblResults2.Size = New System.Drawing.Size(109, 20)
        Me.lblResults2.TabIndex = 5
        Me.lblResults2.Text = "开始时间："
        '
        'lblResults5
        '
        Me.lblResults5.AutoSize = True
        Me.lblResults5.Font = New System.Drawing.Font("宋体", 24.0!)
        Me.lblResults5.Location = New System.Drawing.Point(304, 9)
        Me.lblResults5.Name = "lblResults5"
        Me.lblResults5.Size = New System.Drawing.Size(177, 40)
        Me.lblResults5.TabIndex = 11
        Me.lblResults5.Text = "订单查询"
        '
        'cbmGym
        '
        Me.cbmGym.FormattingEnabled = True
        Me.cbmGym.Items.AddRange(New Object() {"篮球场"})
        Me.cbmGym.Location = New System.Drawing.Point(474, 267)
        Me.cbmGym.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbmGym.Name = "cbmGym"
        Me.cbmGym.Size = New System.Drawing.Size(80, 23)
        Me.cbmGym.TabIndex = 13
        '
        'lblResults6
        '
        Me.lblResults6.AutoSize = True
        Me.lblResults6.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lblResults6.Location = New System.Drawing.Point(359, 270)
        Me.lblResults6.Name = "lblResults6"
        Me.lblResults6.Size = New System.Drawing.Size(109, 20)
        Me.lblResults6.TabIndex = 17
        Me.lblResults6.Text = "场地名称："
        '
        'btnSubmit3
        '
        Me.btnSubmit3.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.btnSubmit3.Location = New System.Drawing.Point(576, 258)
        Me.btnSubmit3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit3.Name = "btnSubmit3"
        Me.btnSubmit3.Size = New System.Drawing.Size(75, 32)
        Me.btnSubmit3.TabIndex = 18
        Me.btnSubmit3.Text = "搜索"
        Me.btnSubmit3.UseVisualStyleBackColor = True
        '
        'dtpTime
        '
        Me.dtpTime.Location = New System.Drawing.Point(142, 267)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(200, 25)
        Me.dtpTime.TabIndex = 19
        '
        'btnSubmit1
        '
        Me.btnSubmit1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.btnSubmit1.Location = New System.Drawing.Point(672, 258)
        Me.btnSubmit1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSubmit1.Name = "btnSubmit1"
        Me.btnSubmit1.Size = New System.Drawing.Size(115, 32)
        Me.btnSubmit1.TabIndex = 20
        Me.btnSubmit1.Text = "搜索全部"
        Me.btnSubmit1.UseVisualStyleBackColor = True
        '
        '用户订单查询
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(829, 367)
        Me.Controls.Add(Me.btnSubmit1)
        Me.Controls.Add(Me.dtpTime)
        Me.Controls.Add(Me.btnSubmit3)
        Me.Controls.Add(Me.cbmGym)
        Me.Controls.Add(Me.lblResults6)
        Me.Controls.Add(Me.lblResults5)
        Me.Controls.Add(Me.lblResults2)
        Me.Controls.Add(Me.gvwOrders)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "用户订单查询"
        Me.Text = "订单查询"
        CType(Me.gvwOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gvwOrders As DataGridView
    Friend WithEvents lblResults2 As Label
    Friend WithEvents lblResults5 As Label
    Friend WithEvents cbmGym As ComboBox
    Friend WithEvents lblResults6 As Label
    Friend WithEvents btnSubmit3 As Button
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents btnSubmit1 As Button
End Class
