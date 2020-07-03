<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 添加场地信息
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
        Me.lblResults1 = New System.Windows.Forms.Label()
        Me.lblResults2 = New System.Windows.Forms.Label()
        Me.txtGymName = New System.Windows.Forms.TextBox()
        Me.txtGymNum = New System.Windows.Forms.TextBox()
        Me.btnSubmit3 = New System.Windows.Forms.Button()
        Me.btnSubmit2 = New System.Windows.Forms.Button()
        Me.btnSubmit1 = New System.Windows.Forms.Button()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.ChangguanDataSet1 = New WindowsApp1.changguanDataSet()
        CType(Me.ChangguanDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResults1
        '
        Me.lblResults1.AutoSize = True
        Me.lblResults1.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults1.Location = New System.Drawing.Point(106, 64)
        Me.lblResults1.Name = "lblResults1"
        Me.lblResults1.Size = New System.Drawing.Size(104, 19)
        Me.lblResults1.TabIndex = 0
        Me.lblResults1.Text = "场地名称："
        '
        'lblResults2
        '
        Me.lblResults2.AutoSize = True
        Me.lblResults2.Font = New System.Drawing.Font("宋体", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblResults2.Location = New System.Drawing.Point(106, 164)
        Me.lblResults2.Name = "lblResults2"
        Me.lblResults2.Size = New System.Drawing.Size(104, 19)
        Me.lblResults2.TabIndex = 1
        Me.lblResults2.Text = "场地编号："
        '
        'txtGymName
        '
        Me.txtGymName.Location = New System.Drawing.Point(264, 61)
        Me.txtGymName.Name = "txtGymName"
        Me.txtGymName.Size = New System.Drawing.Size(100, 25)
        Me.txtGymName.TabIndex = 2
        '
        'txtGymNum
        '
        Me.txtGymNum.Location = New System.Drawing.Point(264, 161)
        Me.txtGymNum.Name = "txtGymNum"
        Me.txtGymNum.Size = New System.Drawing.Size(100, 25)
        Me.txtGymNum.TabIndex = 3
        '
        'btnSubmit3
        '
        Me.btnSubmit3.Location = New System.Drawing.Point(322, 278)
        Me.btnSubmit3.Name = "btnSubmit3"
        Me.btnSubmit3.Size = New System.Drawing.Size(96, 51)
        Me.btnSubmit3.TabIndex = 21
        Me.btnSubmit3.Text = "退出"
        '
        'btnSubmit2
        '
        Me.btnSubmit2.Location = New System.Drawing.Point(181, 278)
        Me.btnSubmit2.Name = "btnSubmit2"
        Me.btnSubmit2.Size = New System.Drawing.Size(96, 51)
        Me.btnSubmit2.TabIndex = 20
        Me.btnSubmit2.Text = "取消添加"
        '
        'btnSubmit1
        '
        Me.btnSubmit1.Location = New System.Drawing.Point(33, 278)
        Me.btnSubmit1.Name = "btnSubmit1"
        Me.btnSubmit1.Size = New System.Drawing.Size(96, 51)
        Me.btnSubmit1.TabIndex = 19
        Me.btnSubmit1.Text = "确认添加"
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
        Me.SqlSelectCommand1.CommandText = "SELECT    Vname, Vno  FROM  Venue"
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
        '添加场地信息
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 362)
        Me.Controls.Add(Me.btnSubmit3)
        Me.Controls.Add(Me.btnSubmit2)
        Me.Controls.Add(Me.btnSubmit1)
        Me.Controls.Add(Me.txtGymNum)
        Me.Controls.Add(Me.txtGymName)
        Me.Controls.Add(Me.lblResults2)
        Me.Controls.Add(Me.lblResults1)
        Me.Name = "添加场地信息"
        Me.Text = "添加场地信息"
        CType(Me.ChangguanDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResults1 As Label
    Friend WithEvents lblResults2 As Label
    Friend WithEvents txtGymName As TextBox
    Friend WithEvents txtGymNum As TextBox
    Friend WithEvents btnSubmit3 As Button
    Friend WithEvents btnSubmit2 As Button
    Friend WithEvents btnSubmit1 As Button
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand As SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents ChangguanDataSet1 As changguanDataSet
End Class
