<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 查询场地信息
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnSelectVtype = New System.Windows.Forms.Button()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.lblResults2 = New System.Windows.Forms.Label()
        Me.cbmGym = New System.Windows.Forms.ComboBox()
        Me.lblResults1 = New System.Windows.Forms.Label()
        Me.btnDeleteVtype = New System.Windows.Forms.Button()
        Me.gvwVenue = New System.Windows.Forms.DataGridView()
        Me.VnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VenueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChangguanDataSet5 = New WindowsApp1.changguanDataSet5()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.ChangguanDataSet1 = New WindowsApp1.changguanDataSet()
        Me.VenueTableAdapter = New WindowsApp1.changguanDataSet5TableAdapters.VenueTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.gvwVenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VenueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangguanDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangguanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReturn)
        Me.GroupBox1.Controls.Add(Me.btnSelectVtype)
        Me.GroupBox1.Controls.Add(Me.txtCondition)
        Me.GroupBox1.Controls.Add(Me.lblResults2)
        Me.GroupBox1.Controls.Add(Me.cbmGym)
        Me.GroupBox1.Controls.Add(Me.lblResults1)
        Me.GroupBox1.Controls.Add(Me.btnDeleteVtype)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(799, 183)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询场地信息"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(652, 114)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(107, 51)
        Me.btnReturn.TabIndex = 18
        Me.btnReturn.Text = "退出"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'btnSelectVtype
        '
        Me.btnSelectVtype.Location = New System.Drawing.Point(504, 114)
        Me.btnSelectVtype.Name = "btnSelectVtype"
        Me.btnSelectVtype.Size = New System.Drawing.Size(107, 51)
        Me.btnSelectVtype.TabIndex = 17
        Me.btnSelectVtype.Text = "查询"
        Me.btnSelectVtype.UseVisualStyleBackColor = True
        '
        'txtCondition
        '
        Me.txtCondition.Location = New System.Drawing.Point(304, 140)
        Me.txtCondition.Multiline = True
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(135, 25)
        Me.txtCondition.TabIndex = 16
        '
        'lblResults2
        '
        Me.lblResults2.AutoSize = True
        Me.lblResults2.Location = New System.Drawing.Point(335, 109)
        Me.lblResults2.Name = "lblResults2"
        Me.lblResults2.Size = New System.Drawing.Size(67, 15)
        Me.lblResults2.TabIndex = 15
        Me.lblResults2.Text = "查询条件"
        '
        'cbmGym
        '
        Me.cbmGym.FormattingEnabled = True
        Me.cbmGym.Items.AddRange(New Object() {"场地名称"})
        Me.cbmGym.Location = New System.Drawing.Point(143, 142)
        Me.cbmGym.Name = "cbmGym"
        Me.cbmGym.Size = New System.Drawing.Size(121, 23)
        Me.cbmGym.TabIndex = 14
        Me.cbmGym.Text = "场地名称"
        '
        'lblResults1
        '
        Me.lblResults1.AutoSize = True
        Me.lblResults1.Location = New System.Drawing.Point(167, 109)
        Me.lblResults1.Name = "lblResults1"
        Me.lblResults1.Size = New System.Drawing.Size(67, 15)
        Me.lblResults1.TabIndex = 13
        Me.lblResults1.Text = "查询方式"
        '
        'btnDeleteVtype
        '
        Me.btnDeleteVtype.Location = New System.Drawing.Point(107, 44)
        Me.btnDeleteVtype.Name = "btnDeleteVtype"
        Me.btnDeleteVtype.Size = New System.Drawing.Size(55, 52)
        Me.btnDeleteVtype.TabIndex = 12
        Me.btnDeleteVtype.Text = "删除"
        Me.btnDeleteVtype.UseVisualStyleBackColor = True
        '
        'gvwVenue
        '
        Me.gvwVenue.AutoGenerateColumns = False
        Me.gvwVenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvwVenue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VnameDataGridViewTextBoxColumn, Me.VnoDataGridViewTextBoxColumn})
        Me.gvwVenue.DataSource = Me.VenueBindingSource
        Me.gvwVenue.Location = New System.Drawing.Point(0, 201)
        Me.gvwVenue.Name = "gvwVenue"
        Me.gvwVenue.RowTemplate.Height = 27
        Me.gvwVenue.Size = New System.Drawing.Size(799, 251)
        Me.gvwVenue.TabIndex = 1
        '
        'VnameDataGridViewTextBoxColumn
        '
        Me.VnameDataGridViewTextBoxColumn.DataPropertyName = "Vname"
        Me.VnameDataGridViewTextBoxColumn.HeaderText = "场地名称"
        Me.VnameDataGridViewTextBoxColumn.Name = "VnameDataGridViewTextBoxColumn"
        '
        'VnoDataGridViewTextBoxColumn
        '
        Me.VnoDataGridViewTextBoxColumn.DataPropertyName = "Vno"
        Me.VnoDataGridViewTextBoxColumn.HeaderText = "场地编号"
        Me.VnoDataGridViewTextBoxColumn.Name = "VnoDataGridViewTextBoxColumn"
        '
        'VenueBindingSource
        '
        Me.VenueBindingSource.DataMember = "Venue"
        Me.VenueBindingSource.DataSource = Me.ChangguanDataSet5
        '
        'ChangguanDataSet5
        '
        Me.ChangguanDataSet5.DataSetName = "changguanDataSet5"
        Me.ChangguanDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Venue", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Vname", "Vname"), New System.Data.Common.DataColumnMapping("Vno", "Vno")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Venue] WHERE (([Vname] = @Original_Vname) AND ([Vno] = @Original_Vno" &
    "))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vno", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=DESKTOP-DSP6URK\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=c" &
    "hangguan;"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand
        '
        Me.SqlInsertCommand.CommandText = "INSERT INTO [Venue] ([Vname], [Vno]) VALUES (@Vname, @Vno);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT Vname, Vno FR" &
    "OM Venue WHERE (Vname = @Vname) AND (Vno = @Vno)"
        Me.SqlInsertCommand.Connection = Me.SqlConnection1
        Me.SqlInsertCommand.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), New System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Vname,  Vno  FROM Venue"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE [Venue] SET [Vname] = @Vname, [Vno] = @Vno WHERE (([Vname] = @Original_Vna" &
    "me) AND ([Vno] = @Original_Vno));" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT Vname, Vno FROM Venue WHERE (Vname = @" &
    "Vname) AND (Vno = @Vno)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), New System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno"), New System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Vno", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ChangguanDataSet1
        '
        Me.ChangguanDataSet1.DataSetName = "changguanDataSet"
        Me.ChangguanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VenueTableAdapter
        '
        Me.VenueTableAdapter.ClearBeforeFill = True
        '
        '查询场地信息
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gvwVenue)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "查询场地信息"
        Me.Text = "查询场地信息"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.gvwVenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VenueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChangguanDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChangguanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnSelectVtype As Button
    Friend WithEvents txtCondition As TextBox
    Friend WithEvents lblResults2 As Label
    Friend WithEvents cbmGym As ComboBox
    Friend WithEvents lblResults1 As Label
    Friend WithEvents btnDeleteVtype As Button
    Friend WithEvents gvwVenue As DataGridView
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand As SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents ChangguanDataSet1 As changguanDataSet
    Friend WithEvents ChangguanDataSet5 As changguanDataSet5
    Friend WithEvents VenueBindingSource As BindingSource
    Friend WithEvents VenueTableAdapter As changguanDataSet5TableAdapters.VenueTableAdapter
    Friend WithEvents VnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
