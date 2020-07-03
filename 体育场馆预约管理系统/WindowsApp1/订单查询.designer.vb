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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtStime = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.cmbPlaceName = New System.Windows.Forms.ComboBox()
        Me.cmbPlaceNo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSelOrder = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 42)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(599, 146)
        Me.DataGridView1.TabIndex = 0
        '
        'txtOrderNo
        '
        Me.txtOrderNo.Location = New System.Drawing.Point(260, 203)
        Me.txtOrderNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOrderNo.Name = "txtOrderNo"
        Me.txtOrderNo.Size = New System.Drawing.Size(76, 21)
        Me.txtOrderNo.TabIndex = 1
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.btnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSelect.Location = New System.Drawing.Point(178, 304)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(56, 26)
        Me.btnSelect.TabIndex = 2
        Me.btnSelect.Text = "查询"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnReturn
        '
        Me.btnReturn.AutoSize = True
        Me.btnReturn.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.btnReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnReturn.Location = New System.Drawing.Point(314, 304)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(56, 26)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "返回"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(189, 207)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "订单号："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(163, 265)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "开始时间："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(463, 264)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "场地编号："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(20, 264)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "用户编号："
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(99, 261)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(61, 21)
        Me.txtID.TabIndex = 8
        '
        'txtStime
        '
        Me.txtStime.Location = New System.Drawing.Point(243, 261)
        Me.txtStime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtStime.Name = "txtStime"
        Me.txtStime.Size = New System.Drawing.Size(61, 21)
        Me.txtStime.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 24.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(228, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 33)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "订单查询"
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
        Me.cmbPlaceName.Location = New System.Drawing.Point(392, 262)
        Me.cmbPlaceName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbPlaceName.Name = "cmbPlaceName"
        Me.cmbPlaceName.Size = New System.Drawing.Size(61, 20)
        Me.cmbPlaceName.TabIndex = 13
        '
        'cmbPlaceNo
        '
        Me.cmbPlaceNo.FormattingEnabled = True
        Me.cmbPlaceNo.Location = New System.Drawing.Point(543, 262)
        Me.cmbPlaceNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbPlaceNo.Name = "cmbPlaceNo"
        Me.cmbPlaceNo.Size = New System.Drawing.Size(61, 20)
        Me.cmbPlaceNo.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(211, 341)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 12)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "（输入任意一项即可查询）"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(308, 265)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "场地名称："
        '
        'btnSelOrder
        '
        Me.btnSelOrder.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.btnSelOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnSelOrder.Location = New System.Drawing.Point(372, 202)
        Me.btnSelOrder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSelOrder.Name = "btnSelOrder"
        Me.btnSelOrder.Size = New System.Drawing.Size(56, 26)
        Me.btnSelOrder.TabIndex = 18
        Me.btnSelOrder.Text = "搜索"
        Me.btnSelOrder.UseVisualStyleBackColor = True
        '
        '订单查询
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(622, 361)
        Me.Controls.Add(Me.btnSelOrder)
        Me.Controls.Add(Me.txtStime)
        Me.Controls.Add(Me.txtOrderNo)
        Me.Controls.Add(Me.cmbPlaceName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbPlaceNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.DataGridView1)
        Me.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtStime As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
    Friend WithEvents OleDbCommand1 As OleDb.OleDbCommand
    Friend WithEvents cmbPlaceName As ComboBox
    Friend WithEvents cmbPlaceNo As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSelOrder As Button
End Class
