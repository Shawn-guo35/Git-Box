<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 订单查询
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtOrderNo = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.lblResults1 = New System.Windows.Forms.Label()
        Me.lblResults2 = New System.Windows.Forms.Label()
        Me.lblResults3 = New System.Windows.Forms.Label()
        Me.lblResults4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtStime = New System.Windows.Forms.TextBox()
        Me.lblResults5 = New System.Windows.Forms.Label()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.cmbPlaceName = New System.Windows.Forms.ComboBox()
        Me.cmbPlaceNo = New System.Windows.Forms.ComboBox()
        Me.lblResults7 = New System.Windows.Forms.Label()
        Me.lblResults6 = New System.Windows.Forms.Label()
        Me.btnSelOrder = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 52)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(799, 182)
        Me.DataGridView1.TabIndex = 0
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(347, 254)
        Me.txtOrderNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(100, 25)
        Me.txtOrderNo.TabIndex = 1
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.btnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSelect.Location = New System.Drawing.Point(237, 380)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(75, 32)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "查询"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.AutoSize = True
        Me.btnReturn.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.btnReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnReturn.Location = New System.Drawing.Point(419, 380)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(75, 32)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "返回"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'lblResults1
        '
        Me.lblResults1.AutoSize = True
        Me.lblResults1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lblResults1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResults1.Location = New System.Drawing.Point(252, 259)
        Me.lblResults1.Name = "lblResults1"
        Me.lblResults1.Size = New System.Drawing.Size(89, 20)
        Me.lblResults1.TabIndex = 4
        Me.lblResults1.Text = "订单号："
        '
        'lblResults2
        '
        Me.lblResults2.AutoSize = True
        Me.lblResults2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lblResults2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResults2.Location = New System.Drawing.Point(217, 331)
        Me.lblResults2.Name = "lblResults2"
        Me.lblResults2.Size = New System.Drawing.Size(109, 20)
        Me.lblResults2.TabIndex = 5
        Me.lblResults2.Text = "开始时间："
        '
        'lblResults3
        '
        Me.lblResults3.AutoSize = True
        Me.lblResults3.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lblResults3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResults3.Location = New System.Drawing.Point(617, 330)
        Me.lblResults3.Name = "lblResults3"
        Me.lblResults3.Size = New System.Drawing.Size(109, 20)
        Me.lblResults3.TabIndex = 6
        Me.lblResults3.Text = "场地编号："
        '
        'lblResults4
        '
        Me.lblResults4.AutoSize = True
        Me.lblResults4.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lblResults4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResults4.Location = New System.Drawing.Point(27, 330)
        Me.lblResults4.Name = "lblResults4"
        Me.lblResults4.Size = New System.Drawing.Size(109, 20)
        Me.lblResults4.TabIndex = 7
        Me.lblResults4.Text = "用户编号："
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(132, 326)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(80, 25)
        Me.txtID.TabIndex = 8
        '
        'txtStime
        '
        Me.txtStime.Location = New System.Drawing.Point(324, 326)
        Me.txtStime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtStime.Name = "txtStime"
        Me.txtStime.Size = New System.Drawing.Size(80, 25)
        Me.txtStime.TabIndex = 9
        '
        'lblResults5
        '
        Me.lblResults5.AutoSize = True
        Me.lblResults5.Font = New System.Drawing.Font("宋体", 24.0!)
        Me.lblResults5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResults5.Location = New System.Drawing.Point(304, 9)
        Me.lblResults5.Name = "lblResults5"
        Me.lblResults5.Size = New System.Drawing.Size(177, 40)
        Me.lblResults5.TabIndex = 11
        Me.lblResults5.Text = "订单查询"
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-DSP6URK\SQLEXPRESS;Integrated Security=SSP" &
    "I;Initial Catalog=changguan"
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'cmbPlaceName
        '
        Me.cmbPlaceName.FormattingEnabled = True
        Me.cmbPlaceName.Location = New System.Drawing.Point(523, 328)
        Me.cmbPlaceName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbPlaceName.Name = "cmbPlaceName"
        Me.cmbPlaceName.Size = New System.Drawing.Size(80, 23)
        Me.cmbPlaceName.TabIndex = 13
        '
        'cmbPlaceNo
        '
        Me.cmbPlaceNo.FormattingEnabled = True
        Me.cmbPlaceNo.Location = New System.Drawing.Point(724, 328)
        Me.cmbPlaceNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbPlaceNo.Name = "cmbPlaceNo"
        Me.cmbPlaceNo.Size = New System.Drawing.Size(80, 23)
        Me.cmbPlaceNo.TabIndex = 14
        '
        'lblResults7
        '
        Me.lblResults7.AutoSize = True
        Me.lblResults7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResults7.Location = New System.Drawing.Point(281, 426)
        Me.lblResults7.Name = "lblResults7"
        Me.lblResults7.Size = New System.Drawing.Size(187, 15)
        Me.lblResults7.TabIndex = 16
        Me.lblResults7.Text = "（输入任意一项即可查询）"
        '
        'lblResults6
        '
        Me.lblResults6.AutoSize = True
        Me.lblResults6.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.lblResults6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblResults6.Location = New System.Drawing.Point(411, 331)
        Me.lblResults6.Name = "lblResults6"
        Me.lblResults6.Size = New System.Drawing.Size(109, 20)
        Me.lblResults6.TabIndex = 17
        Me.lblResults6.Text = "场地名称："
        '
        'btnSelOrder
        '
        Me.btnSelOrder.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.btnSelOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSelOrder.Location = New System.Drawing.Point(496, 252)
        Me.btnSelOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSelOrder.Name = "btnSelOrder"
        Me.btnSelOrder.Size = New System.Drawing.Size(75, 32)
        Me.btnSelOrder.TabIndex = 18
        Me.btnSelOrder.Text = "搜索"
        Me.btnSelOrder.UseVisualStyleBackColor = True
        '
        '订单查询
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(829, 451)
        Me.Controls.Add(Me.btnSelOrder)
        Me.Controls.Add(Me.txtStime)
        Me.Controls.Add(Me.txtOrderNo)
        Me.Controls.Add(Me.cmbPlaceName)
        Me.Controls.Add(Me.lblResults6)
        Me.Controls.Add(Me.lblResults7)
        Me.Controls.Add(Me.cmbPlaceNo)
        Me.Controls.Add(Me.lblResults5)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblResults4)
        Me.Controls.Add(Me.lblResults3)
        Me.Controls.Add(Me.lblResults2)
        Me.Controls.Add(Me.lblResults1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "订单查询"
        Me.Text = "订单查询"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtOrderNo As TextBox
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents lblResults1 As Label
    Friend WithEvents lblResults2 As Label
    Friend WithEvents lblResults3 As Label
    Friend WithEvents lblResults4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtStime As TextBox
    Friend WithEvents lblResults5 As Label
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As OleDb.OleDbCommand
    Friend WithEvents cmbPlaceName As ComboBox
    Friend WithEvents cmbPlaceNo As ComboBox
    Friend WithEvents lblResults7 As Label
    Friend WithEvents lblResults6 As Label
    Friend WithEvents btnSelOrder As Button
End Class
