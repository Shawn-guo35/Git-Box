<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class orderBasketball
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
        Me.btnGymorder = New System.Windows.Forms.Button()
        Me.btnTimeorder = New System.Windows.Forms.Button()
        Me.btnGymview = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvOrder = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit1 = New System.Windows.Forms.Button()
        Me.btnSubmit2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.odadSelBaseket = New System.Data.OleDb.OleDbDataAdapter()
        Me.dstBasketLease = New System.Data.DataSet()
        Me.odcmdInsLease = New System.Data.OleDb.OleDbCommand()
        Me.cmbBegintime = New System.Windows.Forms.ComboBox()
        Me.dtpTime = New System.Windows.Forms.DateTimePicker()
        Me.dstSelOrder = New System.Data.DataSet()
        Me.txtEndtime = New System.Windows.Forms.TextBox()
        Me.cbmGymnum = New System.Windows.Forms.ComboBox()
        Me.odcmdInsOrder = New System.Data.OleDb.OleDbCommand()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.odadSelOrder = New System.Data.OleDb.OleDbDataAdapter()
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstBasketLease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dstSelOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGymorder
        '
        Me.btnGymorder.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnGymorder.Location = New System.Drawing.Point(743, 183)
        Me.btnGymorder.Name = "btnGymorder"
        Me.btnGymorder.Size = New System.Drawing.Size(179, 38)
        Me.btnGymorder.TabIndex = 3
        Me.btnGymorder.Text = "选择场地进行预约"
        Me.btnGymorder.UseVisualStyleBackColor = True
        '
        'btnTimeorder
        '
        Me.btnTimeorder.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnTimeorder.Location = New System.Drawing.Point(743, 245)
        Me.btnTimeorder.Name = "btnTimeorder"
        Me.btnTimeorder.Size = New System.Drawing.Size(179, 38)
        Me.btnTimeorder.TabIndex = 4
        Me.btnTimeorder.Text = "选择时间进行预约"
        Me.btnTimeorder.UseVisualStyleBackColor = True
        '
        'btnGymview
        '
        Me.btnGymview.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnGymview.Location = New System.Drawing.Point(743, 76)
        Me.btnGymview.Name = "btnGymview"
        Me.btnGymview.Size = New System.Drawing.Size(179, 38)
        Me.btnGymview.TabIndex = 5
        Me.btnGymview.Text = "查看场地平面图"
        Me.btnGymview.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(145, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "场地号"
        '
        'dgvOrder
        '
        Me.dgvOrder.AllowUserToAddRows = False
        Me.dgvOrder.AllowUserToDeleteRows = False
        Me.dgvOrder.ColumnHeadersHeight = 40
        Me.dgvOrder.Location = New System.Drawing.Point(32, 57)
        Me.dgvOrder.MultiSelect = False
        Me.dgvOrder.Name = "dgvOrder"
        Me.dgvOrder.ReadOnly = True
        Me.dgvOrder.RowTemplate.Height = 27
        Me.dgvOrder.Size = New System.Drawing.Size(678, 281)
        Me.dgvOrder.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(375, 410)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "租借开始时间"
        '
        'btnSubmit1
        '
        Me.btnSubmit1.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnSubmit1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSubmit1.Location = New System.Drawing.Point(508, 361)
        Me.btnSubmit1.Name = "btnSubmit1"
        Me.btnSubmit1.Size = New System.Drawing.Size(75, 28)
        Me.btnSubmit1.TabIndex = 15
        Me.btnSubmit1.Text = "确定"
        Me.btnSubmit1.UseVisualStyleBackColor = True
        '
        'btnSubmit2
        '
        Me.btnSubmit2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnSubmit2.Location = New System.Drawing.Point(755, 432)
        Me.btnSubmit2.Name = "btnSubmit2"
        Me.btnSubmit2.Size = New System.Drawing.Size(75, 28)
        Me.btnSubmit2.TabIndex = 16
        Me.btnSubmit2.Text = "确定"
        Me.btnSubmit2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 452)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "租借结束时间"
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-DSP6URK\SQLEXPRESS;Integrated Security=SSP" &
    "I;Initial Catalog=changguan"
        '
        'odadSelBaseket
        '
        Me.odadSelBaseket.DeleteCommand = Me.OleDbDeleteCommand1
        Me.odadSelBaseket.InsertCommand = Me.OleDbInsertCommand1
        Me.odadSelBaseket.SelectCommand = Me.OleDbSelectCommand1
        Me.odadSelBaseket.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'dstBasketLease
        '
        Me.dstBasketLease.DataSetName = "NewDataSet"
        '
        'cmbBegintime
        '
        Me.cmbBegintime.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cmbBegintime.FormattingEnabled = True
        Me.cmbBegintime.Items.AddRange(New Object() {"12:00", "13:00", "18:00", "19:00"})
        Me.cmbBegintime.Location = New System.Drawing.Point(550, 413)
        Me.cmbBegintime.Name = "cmbBegintime"
        Me.cmbBegintime.Size = New System.Drawing.Size(121, 26)
        Me.cmbBegintime.TabIndex = 20
        Me.cmbBegintime.Text = "12:00"
        '
        'dtpTime
        '
        Me.dtpTime.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dtpTime.Location = New System.Drawing.Point(72, 413)
        Me.dtpTime.MinDate = New Date(2019, 7, 2, 0, 0, 0, 0)
        Me.dtpTime.Name = "dtpTime"
        Me.dtpTime.Size = New System.Drawing.Size(200, 28)
        Me.dtpTime.TabIndex = 22
        '
        'dstSelOrder
        '
        Me.dstSelOrder.DataSetName = "NewDataSet"
        '
        'txtEndtime
        '
        Me.txtEndtime.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtEndtime.Location = New System.Drawing.Point(550, 452)
        Me.txtEndtime.Name = "txtEndtime"
        Me.txtEndtime.Size = New System.Drawing.Size(121, 28)
        Me.txtEndtime.TabIndex = 23
        '
        'cbmGymnum
        '
        Me.cbmGymnum.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cbmGymnum.FormattingEnabled = True
        Me.cbmGymnum.Location = New System.Drawing.Point(305, 363)
        Me.cbmGymnum.Name = "cbmGymnum"
        Me.cbmGymnum.Size = New System.Drawing.Size(84, 26)
        Me.cbmGymnum.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "双击表中的场地号即可预订"
        Me.Label3.Visible = False
        '
        'odadSelOrder
        '
        Me.odadSelOrder.DeleteCommand = Me.OleDbDeleteCommand2
        Me.odadSelOrder.InsertCommand = Me.OleDbInsertCommand2
        Me.odadSelOrder.SelectCommand = Me.OleDbSelectCommand2
        Me.odadSelOrder.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'orderBasketball
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 540)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbmGymnum)
        Me.Controls.Add(Me.txtEndtime)
        Me.Controls.Add(Me.dtpTime)
        Me.Controls.Add(Me.cmbBegintime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSubmit2)
        Me.Controls.Add(Me.btnSubmit1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvOrder)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGymview)
        Me.Controls.Add(Me.btnTimeorder)
        Me.Controls.Add(Me.btnGymorder)
        Me.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Name = "orderBasketball"
        Me.Text = "篮球场预约"
        CType(Me.dgvOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstBasketLease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dstSelOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGymorder As Button
    Friend WithEvents btnTimeorder As Button
    Friend WithEvents btnGymview As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvOrder As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit1 As Button
    Friend WithEvents btnSubmit2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents odadSelBaseket As OleDb.OleDbDataAdapter
    Friend WithEvents dstBasketLease As DataSet
    Friend WithEvents odcmdInsLease As OleDb.OleDbCommand
    Friend WithEvents cmbBegintime As ComboBox
    Friend WithEvents dtpTime As DateTimePicker
    Friend WithEvents dstSelOrder As DataSet
    Friend WithEvents txtEndtime As TextBox
    Friend WithEvents cbmGymnum As ComboBox
    Friend WithEvents odcmdInsOrder As OleDb.OleDbCommand
    Friend WithEvents Label3 As Label
    Friend WithEvents OleDbSelectCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As OleDb.OleDbCommand
    Friend WithEvents odadSelOrder As OleDb.OleDbDataAdapter
End Class
