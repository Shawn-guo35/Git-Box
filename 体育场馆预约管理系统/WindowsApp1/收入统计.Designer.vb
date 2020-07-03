<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 收入统计
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.cmbMon = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnSelIncome = New System.Windows.Forms.Button()
        Me.txtYearSum = New System.Windows.Forms.TextBox()
        Me.txtMonSum = New System.Windows.Forms.TextBox()
        Me.txtDaySum = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.OleDbCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(219, 54)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 12)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "（三项都要选）"
        '
        'cmbYear
        '
        Me.cmbYear.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月"})
        Me.cmbYear.Location = New System.Drawing.Point(111, 231)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(63, 24)
        Me.cmbYear.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 24.0!)
        Me.Label4.Location = New System.Drawing.Point(87, 37)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 33)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "收益统计"
        '
        'cmbDay
        '
        Me.cmbDay.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Items.AddRange(New Object() {"1号", "2号", "3号", "4号", "5号", "6号", "7号", "8号", "9号", "10号", "11号", "12号", "13号", "14号", "15号", "16号", "17号", "18号", "19号", "20号", "21号", "22号", "23号", "24号", "25号", "26号", "27号", "28号", "29号", "30号", "31号"})
        Me.cmbDay.Location = New System.Drawing.Point(111, 101)
        Me.cmbDay.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(63, 24)
        Me.cmbDay.TabIndex = 24
        '
        'cmbMon
        '
        Me.cmbMon.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.cmbMon.FormattingEnabled = True
        Me.cmbMon.Items.AddRange(New Object() {"1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月"})
        Me.cmbMon.Location = New System.Drawing.Point(111, 164)
        Me.cmbMon.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbMon.Name = "cmbMon"
        Me.cmbMon.Size = New System.Drawing.Size(63, 24)
        Me.cmbMon.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(27, 168)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "月收益"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(27, 235)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "年收益"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(27, 106)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "日收益"
        '
        'btnReturn
        '
        Me.btnReturn.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.btnReturn.Location = New System.Drawing.Point(308, 306)
        Me.btnReturn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(56, 26)
        Me.btnReturn.TabIndex = 19
        Me.btnReturn.Text = "返回"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnSelIncome
        '
        Me.btnSelIncome.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.btnSelIncome.Location = New System.Drawing.Point(186, 306)
        Me.btnSelIncome.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSelIncome.Name = "btnSelIncome"
        Me.btnSelIncome.Size = New System.Drawing.Size(56, 26)
        Me.btnSelIncome.TabIndex = 18
        Me.btnSelIncome.Text = "查询"
        Me.btnSelIncome.UseVisualStyleBackColor = True
        '
        'txtYearSum
        '
        Me.txtYearSum.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.txtYearSum.Location = New System.Drawing.Point(184, 231)
        Me.txtYearSum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtYearSum.Name = "txtYearSum"
        Me.txtYearSum.Size = New System.Drawing.Size(76, 26)
        Me.txtYearSum.TabIndex = 17
        '
        'txtMonSum
        '
        Me.txtMonSum.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.txtMonSum.Location = New System.Drawing.Point(184, 164)
        Me.txtMonSum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMonSum.Name = "txtMonSum"
        Me.txtMonSum.Size = New System.Drawing.Size(76, 26)
        Me.txtMonSum.TabIndex = 16
        '
        'txtDaySum
        '
        Me.txtDaySum.Font = New System.Drawing.Font("宋体", 12.0!)
        Me.txtDaySum.Location = New System.Drawing.Point(184, 101)
        Me.txtDaySum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDaySum.Name = "txtDaySum"
        Me.txtDaySum.Size = New System.Drawing.Size(76, 26)
        Me.txtDaySum.TabIndex = 15
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(308, 29)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(266, 230)
        Me.DataGridView1.TabIndex = 14
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
        '收入统计
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 360)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbDay)
        Me.Controls.Add(Me.cmbMon)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.btnSelIncome)
        Me.Controls.Add(Me.txtYearSum)
        Me.Controls.Add(Me.txtMonSum)
        Me.Controls.Add(Me.txtDaySum)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "收入统计"
        Me.Text = "收入统计"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbDay As ComboBox
    Friend WithEvents cmbMon As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnSelIncome As Button
    Friend WithEvents txtYearSum As TextBox
    Friend WithEvents txtMonSum As TextBox
    Friend WithEvents txtDaySum As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents OleDbCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As OleDb.OleDbConnection
    Friend WithEvents OleDbSelectCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As OleDb.OleDbDataAdapter
End Class
