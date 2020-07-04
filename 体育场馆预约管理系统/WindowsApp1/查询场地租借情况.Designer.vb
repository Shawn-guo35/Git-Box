<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 查询场地租借情况
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(查询场地租借情况))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblResults14 = New System.Windows.Forms.Label()
        Me.lblResults13 = New System.Windows.Forms.Label()
        Me.txtGymNum = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnSelectLease = New System.Windows.Forms.Button()
        Me.txtGymName = New System.Windows.Forms.TextBox()
        Me.cbmGym = New System.Windows.Forms.ComboBox()
        Me.lblResults2 = New System.Windows.Forms.Label()
        Me.lblResults1 = New System.Windows.Forms.Label()
        Me.txtGymLease = New System.Windows.Forms.DataGridView()
        Me.VnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EtimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConditionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChangguanDataSet6 = New WindowsApp1.changguanDataSet6()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.ChangguanDataSet1 = New WindowsApp1.changguanDataSet()
        Me.LeaseTableAdapter = New WindowsApp1.changguanDataSet6TableAdapters.LeaseTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtGymLease, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangguanDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangguanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblResults14)
        Me.GroupBox1.Controls.Add(Me.lblResults13)
        Me.GroupBox1.Controls.Add(Me.txtGymNum)
        Me.GroupBox1.Controls.Add(Me.btnReturn)
        Me.GroupBox1.Controls.Add(Me.btnSelectLease)
        Me.GroupBox1.Controls.Add(Me.txtGymName)
        Me.GroupBox1.Controls.Add(Me.cbmGym)
        Me.GroupBox1.Controls.Add(Me.lblResults2)
        Me.GroupBox1.Controls.Add(Me.lblResults1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(798, 215)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询场地租借情况"
        '
        'lblResults14
        '
        Me.lblResults14.AutoSize = True
        Me.lblResults14.Location = New System.Drawing.Point(133, 140)
        Me.lblResults14.Name = "lblResults14"
        Me.lblResults14.Size = New System.Drawing.Size(67, 15)
        Me.lblResults14.TabIndex = 31
        Me.lblResults14.Text = "场地编号"
        Me.lblResults14.Visible = False
        '
        'lblResults13
        '
        Me.lblResults13.AutoSize = True
        Me.lblResults13.Location = New System.Drawing.Point(133, 84)
        Me.lblResults13.Name = "lblResults13"
        Me.lblResults13.Size = New System.Drawing.Size(67, 15)
        Me.lblResults13.TabIndex = 30
        Me.lblResults13.Text = "场地名称"
        '
        'txtGymNum
        '
        Me.txtGymNum.Location = New System.Drawing.Point(225, 140)
        Me.txtGymNum.Name = "txtGymNum"
        Me.txtGymNum.Size = New System.Drawing.Size(139, 25)
        Me.txtGymNum.TabIndex = 29
        Me.txtGymNum.Visible = False
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(637, 66)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(107, 51)
        Me.btnReturn.TabIndex = 28
        Me.btnReturn.Text = "退出"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnSelectLease
        '
        Me.btnSelectLease.Location = New System.Drawing.Point(473, 66)
        Me.btnSelectLease.Name = "btnSelectLease"
        Me.btnSelectLease.Size = New System.Drawing.Size(107, 51)
        Me.btnSelectLease.TabIndex = 27
        Me.btnSelectLease.Text = "查询"
        Me.btnSelectLease.UseVisualStyleBackColor = True
        '
        'txtGymName
        '
        Me.txtGymName.Location = New System.Drawing.Point(225, 81)
        Me.txtGymName.Name = "txtGymName"
        Me.txtGymName.Size = New System.Drawing.Size(139, 25)
        Me.txtGymName.TabIndex = 26
        '
        'cbmGym
        '
        Me.cbmGym.FormattingEnabled = True
        Me.cbmGym.Items.AddRange(New Object() {"场地名称", "场地名称&场地编号"})
        Me.cbmGym.Location = New System.Drawing.Point(225, 38)
        Me.cbmGym.Name = "cbmGym"
        Me.cbmGym.Size = New System.Drawing.Size(191, 23)
        Me.cbmGym.TabIndex = 25
        Me.cbmGym.Text = "场地名称"
        '
        'lblResults2
        '
        Me.lblResults2.Location = New System.Drawing.Point(31, 81)
        Me.lblResults2.Name = "lblResults2"
        Me.lblResults2.Size = New System.Drawing.Size(96, 20)
        Me.lblResults2.TabIndex = 24
        Me.lblResults2.Text = "查询条件："
        '
        'lblResults1
        '
        Me.lblResults1.Location = New System.Drawing.Point(31, 41)
        Me.lblResults1.Name = "lblResults1"
        Me.lblResults1.Size = New System.Drawing.Size(96, 20)
        Me.lblResults1.TabIndex = 23
        Me.lblResults1.Text = "查询方式："
        '
        'txtGymLease
        '
        Me.txtGymLease.AutoGenerateColumns = False
        Me.txtGymLease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.txtGymLease.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VnameDataGridViewTextBoxColumn, Me.VnoDataGridViewTextBoxColumn, Me.StimeDataGridViewTextBoxColumn, Me.EtimeDataGridViewTextBoxColumn, Me.ConditionDataGridViewTextBoxColumn})
        Me.txtGymLease.DataSource = Me.LeaseBindingSource
        Me.txtGymLease.Location = New System.Drawing.Point(2, 207)
        Me.txtGymLease.Name = "txtGymLease"
        Me.txtGymLease.ReadOnly = True
        Me.txtGymLease.RowTemplate.Height = 27
        Me.txtGymLease.Size = New System.Drawing.Size(798, 242)
        Me.txtGymLease.TabIndex = 1
        '
        'VnameDataGridViewTextBoxColumn
        '
        Me.VnameDataGridViewTextBoxColumn.DataPropertyName = "Vname"
        Me.VnameDataGridViewTextBoxColumn.HeaderText = "场地名称"
        Me.VnameDataGridViewTextBoxColumn.Name = "VnameDataGridViewTextBoxColumn"
        Me.VnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VnoDataGridViewTextBoxColumn
        '
        Me.VnoDataGridViewTextBoxColumn.DataPropertyName = "Vno"
        Me.VnoDataGridViewTextBoxColumn.HeaderText = "场地编号"
        Me.VnoDataGridViewTextBoxColumn.Name = "VnoDataGridViewTextBoxColumn"
        Me.VnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StimeDataGridViewTextBoxColumn
        '
        Me.StimeDataGridViewTextBoxColumn.DataPropertyName = "Stime"
        Me.StimeDataGridViewTextBoxColumn.HeaderText = "开始时间"
        Me.StimeDataGridViewTextBoxColumn.Name = "StimeDataGridViewTextBoxColumn"
        Me.StimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EtimeDataGridViewTextBoxColumn
        '
        Me.EtimeDataGridViewTextBoxColumn.DataPropertyName = "Etime"
        Me.EtimeDataGridViewTextBoxColumn.HeaderText = "结束时间"
        Me.EtimeDataGridViewTextBoxColumn.Name = "EtimeDataGridViewTextBoxColumn"
        Me.EtimeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ConditionDataGridViewTextBoxColumn
        '
        Me.ConditionDataGridViewTextBoxColumn.DataPropertyName = "Condition"
        Me.ConditionDataGridViewTextBoxColumn.HeaderText = "场地状态"
        Me.ConditionDataGridViewTextBoxColumn.Name = "ConditionDataGridViewTextBoxColumn"
        Me.ConditionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LeaseBindingSource
        '
        Me.LeaseBindingSource.DataMember = "Lease"
        Me.LeaseBindingSource.DataSource = Me.ChangguanDataSet6
        '
        'ChangguanDataSet6
        '
        Me.ChangguanDataSet6.DataSetName = "changguanDataSet6"
        Me.ChangguanDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Lease", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Vname", "Vname"), New System.Data.Common.DataColumnMapping("Vno", "Vno"), New System.Data.Common.DataColumnMapping("Stime", "Stime"), New System.Data.Common.DataColumnMapping("Etime", "Etime"), New System.Data.Common.DataColumnMapping("Condition", "Condition")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Lease] WHERE (([Vname] = @Original_Vname) AND ([Vno] = @Original_Vno" &
    ") AND ([Stime] = @Original_Stime) AND ([Etime] = @Original_Etime) AND ([Conditio" &
    "n] = @Original_Condition))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vno", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Stime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stime", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Etime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Etime", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Condition", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Condition", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=DESKTOP-DSP6URK\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=c" &
    "hangguan;"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText")
        Me.SqlInsertCommand.Connection = Me.SqlConnection1
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), New System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno"), New System.Data.SqlClient.SqlParameter("@Stime", System.Data.SqlDbType.DateTime, 0, "Stime"), New System.Data.SqlClient.SqlParameter("@Etime", System.Data.SqlDbType.DateTime, 0, "Etime"), New System.Data.SqlClient.SqlParameter("@Condition", System.Data.SqlDbType.VarChar, 0, "Condition")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Vname, Vno, Stime,  Etime,  Condition FROM Lease"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), New System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno"), New System.Data.SqlClient.SqlParameter("@Stime", System.Data.SqlDbType.DateTime, 0, "Stime"), New System.Data.SqlClient.SqlParameter("@Etime", System.Data.SqlDbType.DateTime, 0, "Etime"), New System.Data.SqlClient.SqlParameter("@Condition", System.Data.SqlDbType.VarChar, 0, "Condition"), New System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vno", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Stime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Stime", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Etime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Etime", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Condition", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Condition", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ChangguanDataSet1
        '
        Me.ChangguanDataSet1.DataSetName = "changguanDataSet"
        Me.ChangguanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LeaseTableAdapter
        '
        Me.LeaseTableAdapter.ClearBeforeFill = True
        '
        '查询场地租借情况
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtGymLease)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "查询场地租借情况"
        Me.Text = "查询场地租借情况"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtGymLease, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChangguanDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChangguanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblResults2 As Label
    Friend WithEvents lblResults1 As Label
    Friend WithEvents txtGymName As TextBox
    Friend WithEvents cbmGym As ComboBox
    Friend WithEvents btnSelectLease As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents txtGymLease As DataGridView
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand As SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents txtGymNum As TextBox
    Friend WithEvents lblResults14 As Label
    Friend WithEvents lblResults13 As Label
    Friend WithEvents ChangguanDataSet1 As changguanDataSet
    Friend WithEvents ChangguanDataSet6 As changguanDataSet6
    Friend WithEvents LeaseBindingSource As BindingSource
    Friend WithEvents LeaseTableAdapter As changguanDataSet6TableAdapters.LeaseTableAdapter
    Friend WithEvents VnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EtimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ConditionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
