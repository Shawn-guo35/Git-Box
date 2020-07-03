<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 用户管理
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(用户管理))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnSubmit5 = New System.Windows.Forms.Button()
        Me.btnSubmit4 = New System.Windows.Forms.Button()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.cbmGym = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit3 = New System.Windows.Forms.Button()
        Me.btnSubmit2 = New System.Windows.Forms.Button()
        Me.gvwUsers = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UidentityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ChangguanDataSet1 = New WindowsApp1.changguanDataSet1()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.ChangguanDataSet = New WindowsApp1.changguanDataSet()
        Me.UsersTableAdapter = New WindowsApp1.changguanDataSet1TableAdapters.UsersTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvwUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangguanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChangguanDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.btnSubmit5)
        Me.GroupBox1.Controls.Add(Me.btnSubmit4)
        Me.GroupBox1.Controls.Add(Me.txtCondition)
        Me.GroupBox1.Controls.Add(Me.cbmGym)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnSubmit3)
        Me.GroupBox1.Controls.Add(Me.btnSubmit2)
        Me.GroupBox1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(820, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "用户管理系统"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(790, 190)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 27
        Me.DataGridView2.Size = New System.Drawing.Size(10, 10)
        Me.DataGridView2.TabIndex = 2
        '
        'btnSubmit5
        '
        Me.btnSubmit5.Location = New System.Drawing.Point(666, 107)
        Me.btnSubmit5.Name = "btnSubmit5"
        Me.btnSubmit5.Size = New System.Drawing.Size(107, 51)
        Me.btnSubmit5.TabIndex = 8
        Me.btnSubmit5.Text = "退出"
        Me.btnSubmit5.UseVisualStyleBackColor = True
        '
        'btnSubmit4
        '
        Me.btnSubmit4.Location = New System.Drawing.Point(518, 107)
        Me.btnSubmit4.Name = "btnSubmit4"
        Me.btnSubmit4.Size = New System.Drawing.Size(107, 51)
        Me.btnSubmit4.TabIndex = 7
        Me.btnSubmit4.Text = "查询"
        Me.btnSubmit4.UseVisualStyleBackColor = True
        '
        'txtCondition
        '
        Me.txtCondition.Location = New System.Drawing.Point(340, 133)
        Me.txtCondition.Multiline = True
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(135, 25)
        Me.txtCondition.TabIndex = 6
        '
        'cbmGym
        '
        Me.cbmGym.FormattingEnabled = True
        Me.cbmGym.Items.AddRange(New Object() {"帐号", "姓名", "身份"})
        Me.cbmGym.Location = New System.Drawing.Point(182, 130)
        Me.cbmGym.Name = "cbmGym"
        Me.cbmGym.Size = New System.Drawing.Size(121, 28)
        Me.cbmGym.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "查询条件"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "查询方式"
        '
        'btnSubmit3
        '
        Me.btnSubmit3.Location = New System.Drawing.Point(142, 36)
        Me.btnSubmit3.Name = "btnSubmit3"
        Me.btnSubmit3.Size = New System.Drawing.Size(68, 41)
        Me.btnSubmit3.TabIndex = 2
        Me.btnSubmit3.Text = "删除"
        Me.btnSubmit3.UseVisualStyleBackColor = True
        '
        'btnSubmit2
        '
        Me.btnSubmit2.Location = New System.Drawing.Point(29, 36)
        Me.btnSubmit2.Name = "btnSubmit2"
        Me.btnSubmit2.Size = New System.Drawing.Size(65, 41)
        Me.btnSubmit2.TabIndex = 1
        Me.btnSubmit2.Text = "修改"
        Me.btnSubmit2.UseVisualStyleBackColor = True
        '
        'gvwUsers
        '
        Me.gvwUsers.AutoGenerateColumns = False
        Me.gvwUsers.BackgroundColor = System.Drawing.Color.Silver
        Me.gvwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvwUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UnameDataGridViewTextBoxColumn, Me.UidentityDataGridViewTextBoxColumn})
        Me.gvwUsers.DataSource = Me.UsersBindingSource
        Me.gvwUsers.Location = New System.Drawing.Point(1, 208)
        Me.gvwUsers.Name = "gvwUsers"
        Me.gvwUsers.RowTemplate.Height = 27
        Me.gvwUsers.Size = New System.Drawing.Size(800, 245)
        Me.gvwUsers.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "账号"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'UnameDataGridViewTextBoxColumn
        '
        Me.UnameDataGridViewTextBoxColumn.DataPropertyName = "Uname"
        Me.UnameDataGridViewTextBoxColumn.HeaderText = "姓名"
        Me.UnameDataGridViewTextBoxColumn.Name = "UnameDataGridViewTextBoxColumn"
        '
        'UidentityDataGridViewTextBoxColumn
        '
        Me.UidentityDataGridViewTextBoxColumn.DataPropertyName = "Uidentity"
        Me.UidentityDataGridViewTextBoxColumn.HeaderText = "身份"
        Me.UidentityDataGridViewTextBoxColumn.Name = "UidentityDataGridViewTextBoxColumn"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.ChangguanDataSet1
        '
        'ChangguanDataSet1
        '
        Me.ChangguanDataSet1.DataSetName = "changguanDataSet1"
        Me.ChangguanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=DESKTOP-DSP6URK\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=c" &
    "hangguan;"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Users", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID", "ID"), New System.Data.Common.DataColumnMapping("Uname", "Uname"), New System.Data.Common.DataColumnMapping("Uidentity", "Uidentity")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM [Users] WHERE (([ID] = @Original_ID) AND ([Uname] = @Original_Uname) " &
    "AND ([Uidentity] = @Original_Uidentity))"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Uname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Uname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Uidentity", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Uidentity", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ID, Uname,  Uidentity FROM Users"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.VarChar, 0, "ID"), New System.Data.SqlClient.SqlParameter("@Uname", System.Data.SqlDbType.VarChar, 0, "Uname"), New System.Data.SqlClient.SqlParameter("@Uidentity", System.Data.SqlDbType.VarChar, 0, "Uidentity"), New System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Uname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Uname", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Uidentity", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Uidentity", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ChangguanDataSet
        '
        Me.ChangguanDataSet.DataSetName = "changguanDataSet"
        Me.ChangguanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        '用户管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 453)
        Me.Controls.Add(Me.gvwUsers)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "用户管理"
        Me.Text = "用户管理系统"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvwUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChangguanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChangguanDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSubmit3 As Button
    Friend WithEvents btnSubmit2 As Button
    Friend WithEvents btnSubmit5 As Button
    Friend WithEvents btnSubmit4 As Button
    Friend WithEvents txtCondition As TextBox
    Friend WithEvents cbmGym As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gvwUsers As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents ChangguanDataSet As changguanDataSet
    Friend WithEvents ChangguanDataSet1 As changguanDataSet1
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents UsersTableAdapter As changguanDataSet1TableAdapters.UsersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UidentityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
