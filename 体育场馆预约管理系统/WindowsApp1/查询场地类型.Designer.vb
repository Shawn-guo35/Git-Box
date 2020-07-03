<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 查询场地类型
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(查询场地类型))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSubmit5 = New System.Windows.Forms.Button()
        Me.btnSubmit4 = New System.Windows.Forms.Button()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.lblResults2 = New System.Windows.Forms.Label()
        Me.cbmGym = New System.Windows.Forms.ComboBox()
        Me.lblResults1 = New System.Windows.Forms.Label()
        Me.btnSubmit3 = New System.Windows.Forms.Button()
        Me.btnSubmit2 = New System.Windows.Forms.Button()
        Me.gvwVtype = New System.Windows.Forms.DataGridView()
        Me.VnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INrentalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OUTrentalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VtypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChangguanDataSet3 = New WindowsApp1.changguanDataSet3()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.ChangguanDataSet1 = New WindowsApp1.changguanDataSet()
        Me.VtypeTableAdapter = New WindowsApp1.changguanDataSet3TableAdapters.VtypeTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gvwVtype, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VtypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangguanDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangguanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSubmit5)
        Me.GroupBox1.Controls.Add(Me.btnSubmit4)
        Me.GroupBox1.Controls.Add(Me.txtCondition)
        Me.GroupBox1.Controls.Add(Me.lblResults2)
        Me.GroupBox1.Controls.Add(Me.cbmGym)
        Me.GroupBox1.Controls.Add(Me.lblResults1)
        Me.GroupBox1.Controls.Add(Me.btnSubmit3)
        Me.GroupBox1.Controls.Add(Me.btnSubmit2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(798, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询场地类型"
        '
        'btnSubmit5
        '
        Me.btnSubmit5.Location = New System.Drawing.Point(648, 106)
        Me.btnSubmit5.Name = "btnSubmit5"
        Me.btnSubmit5.Size = New System.Drawing.Size(107, 51)
        Me.btnSubmit5.TabIndex = 10
        Me.btnSubmit5.Text = "退出"
        Me.btnSubmit5.UseVisualStyleBackColor = True
        '
        'btnSubmit4
        '
        Me.btnSubmit4.Location = New System.Drawing.Point(500, 106)
        Me.btnSubmit4.Name = "btnSubmit4"
        Me.btnSubmit4.Size = New System.Drawing.Size(107, 51)
        Me.btnSubmit4.TabIndex = 9
        Me.btnSubmit4.Text = "查询"
        Me.btnSubmit4.UseVisualStyleBackColor = True
        '
        'txtCondition
        '
        Me.txtCondition.Location = New System.Drawing.Point(300, 132)
        Me.txtCondition.Multiline = True
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(135, 25)
        Me.txtCondition.TabIndex = 8
        '
        'lblResults2
        '
        Me.lblResults2.AutoSize = True
        Me.lblResults2.Location = New System.Drawing.Point(331, 101)
        Me.lblResults2.Name = "lblResults2"
        Me.lblResults2.Size = New System.Drawing.Size(67, 15)
        Me.lblResults2.TabIndex = 7
        Me.lblResults2.Text = "查询条件"
        '
        'cbmGym
        '
        Me.cbmGym.FormattingEnabled = True
        Me.cbmGym.Items.AddRange(New Object() {"场地名称"})
        Me.cbmGym.Location = New System.Drawing.Point(139, 134)
        Me.cbmGym.Name = "cbmGym"
        Me.cbmGym.Size = New System.Drawing.Size(121, 23)
        Me.cbmGym.TabIndex = 6
        Me.cbmGym.Text = "场地名称"
        '
        'lblResults1
        '
        Me.lblResults1.AutoSize = True
        Me.lblResults1.Location = New System.Drawing.Point(163, 101)
        Me.lblResults1.Name = "lblResults1"
        Me.lblResults1.Size = New System.Drawing.Size(67, 15)
        Me.lblResults1.TabIndex = 5
        Me.lblResults1.Text = "查询方式"
        '
        'btnSubmit3
        '
        Me.btnSubmit3.Location = New System.Drawing.Point(103, 36)
        Me.btnSubmit3.Name = "btnSubmit3"
        Me.btnSubmit3.Size = New System.Drawing.Size(55, 52)
        Me.btnSubmit3.TabIndex = 4
        Me.btnSubmit3.Text = "删除"
        Me.btnSubmit3.UseVisualStyleBackColor = True
        '
        'btnSubmit2
        '
        Me.btnSubmit2.Location = New System.Drawing.Point(30, 36)
        Me.btnSubmit2.Name = "btnSubmit2"
        Me.btnSubmit2.Size = New System.Drawing.Size(55, 52)
        Me.btnSubmit2.TabIndex = 3
        Me.btnSubmit2.Text = "修改"
        Me.btnSubmit2.UseVisualStyleBackColor = True
        '
        'gvwVtype
        '
        Me.gvwVtype.AutoGenerateColumns = False
        Me.gvwVtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvwVtype.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VnameDataGridViewTextBoxColumn, Me.INrentalDataGridViewTextBoxColumn, Me.OUTrentalDataGridViewTextBoxColumn, Me.VaddressDataGridViewTextBoxColumn})
        Me.gvwVtype.DataSource = Me.VtypeBindingSource
        Me.gvwVtype.Location = New System.Drawing.Point(3, 195)
        Me.gvwVtype.Name = "gvwVtype"
        Me.gvwVtype.RowTemplate.Height = 27
        Me.gvwVtype.Size = New System.Drawing.Size(798, 256)
        Me.gvwVtype.TabIndex = 1
        '
        'VnameDataGridViewTextBoxColumn
        '
        Me.VnameDataGridViewTextBoxColumn.DataPropertyName = "Vname"
        Me.VnameDataGridViewTextBoxColumn.HeaderText = "场地名称"
        Me.VnameDataGridViewTextBoxColumn.Name = "VnameDataGridViewTextBoxColumn"
        Me.VnameDataGridViewTextBoxColumn.Width = 150
        '
        'INrentalDataGridViewTextBoxColumn
        '
        Me.INrentalDataGridViewTextBoxColumn.DataPropertyName = "INrental"
        Me.INrentalDataGridViewTextBoxColumn.HeaderText = "校内人员租金"
        Me.INrentalDataGridViewTextBoxColumn.Name = "INrentalDataGridViewTextBoxColumn"
        Me.INrentalDataGridViewTextBoxColumn.Width = 150
        '
        'OUTrentalDataGridViewTextBoxColumn
        '
        Me.OUTrentalDataGridViewTextBoxColumn.DataPropertyName = "OUTrental"
        Me.OUTrentalDataGridViewTextBoxColumn.HeaderText = "校外人员租金"
        Me.OUTrentalDataGridViewTextBoxColumn.Name = "OUTrentalDataGridViewTextBoxColumn"
        Me.OUTrentalDataGridViewTextBoxColumn.Width = 150
        '
        'VaddressDataGridViewTextBoxColumn
        '
        Me.VaddressDataGridViewTextBoxColumn.DataPropertyName = "Vaddress"
        Me.VaddressDataGridViewTextBoxColumn.HeaderText = "场地地址"
        Me.VaddressDataGridViewTextBoxColumn.Name = "VaddressDataGridViewTextBoxColumn"
        Me.VaddressDataGridViewTextBoxColumn.Width = 150
        '
        'VtypeBindingSource
        '
        Me.VtypeBindingSource.DataMember = "Vtype"
        Me.VtypeBindingSource.DataSource = Me.ChangguanDataSet3
        '
        'ChangguanDataSet3
        '
        Me.ChangguanDataSet3.DataSetName = "changguanDataSet3"
        Me.ChangguanDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Vtype", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Vname", "Vname"), New System.Data.Common.DataColumnMapping("INrental", "INrental"), New System.Data.Common.DataColumnMapping("OUTrental", "OUTrental"), New System.Data.Common.DataColumnMapping("Vaddress", "Vaddress")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Vtype] WHERE (([Vname] = @Original_Vname) AND ([INrental] = @Origina" &
    "l_INrental) AND ([OUTrental] = @Original_OUTrental) AND ([Vaddress] = @Original_" &
    "Vaddress))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_INrental", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "INrental", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OUTrental", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OUTrental", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vaddress", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vaddress", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=DESKTOP-DSP6URK\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=c" &
    "hangguan;"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.CommandText = "INSERT INTO [Vtype] ([Vname], [INrental], [OUTrental], [Vaddress]) VALUES (@Vname" &
    ", @INrental, @OUTrental, @Vaddress);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT Vname, INrental, OUTrental, Vaddres" &
    "s FROM Vtype WHERE (Vname = @Vname)"
        Me.SqlInsertCommand.Connection = Me.SqlConnection1
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), New System.Data.SqlClient.SqlParameter("@INrental", System.Data.SqlDbType.Real, 0, "INrental"), New System.Data.SqlClient.SqlParameter("@OUTrental", System.Data.SqlDbType.Real, 0, "OUTrental"), New System.Data.SqlClient.SqlParameter("@Vaddress", System.Data.SqlDbType.VarChar, 0, "Vaddress")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Vname,  INrental ,  OUTrental,  Vaddress FROM Vtype"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), New System.Data.SqlClient.SqlParameter("@INrental", System.Data.SqlDbType.Real, 0, "INrental"), New System.Data.SqlClient.SqlParameter("@OUTrental", System.Data.SqlDbType.Real, 0, "OUTrental"), New System.Data.SqlClient.SqlParameter("@Vaddress", System.Data.SqlDbType.VarChar, 0, "Vaddress"), New System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_INrental", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "INrental", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_OUTrental", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OUTrental", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vaddress", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vaddress", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ChangguanDataSet1
        '
        Me.ChangguanDataSet1.DataSetName = "changguanDataSet"
        Me.ChangguanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VtypeTableAdapter
        '
        Me.VtypeTableAdapter.ClearBeforeFill = True
        '
        '查询场地类型
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gvwVtype)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "查询场地类型"
        Me.Text = "查询场地类型"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gvwVtype, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VtypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChangguanDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChangguanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSubmit3 As Button
    Friend WithEvents btnSubmit2 As Button
    Friend WithEvents lblResults1 As Label
    Friend WithEvents cbmGym As ComboBox
    Friend WithEvents lblResults2 As Label
    Friend WithEvents txtCondition As TextBox
    Friend WithEvents btnSubmit5 As Button
    Friend WithEvents btnSubmit4 As Button
    Friend WithEvents gvwVtype As DataGridView
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand As SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents ChangguanDataSet1 As changguanDataSet
    Friend WithEvents ChangguanDataSet3 As changguanDataSet3
    Friend WithEvents VtypeBindingSource As BindingSource
    Friend WithEvents VtypeTableAdapter As changguanDataSet3TableAdapters.VtypeTableAdapter
    Friend WithEvents VnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents INrentalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OUTrentalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
