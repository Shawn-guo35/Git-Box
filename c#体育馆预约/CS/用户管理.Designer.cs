// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports

using WindowsApp1;

namespace WindowsApp1
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
		public partial class 用户管理 : System.Windows.Forms.Form
		{
		
		//Form 重写 Dispose，以清理组件列表。
		[System.Diagnostics.DebuggerNonUserCode()]
			protected override void Dispose(bool disposing)
			{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]
			private void InitializeComponent()
			{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(用户管理));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInsertUsers = new System.Windows.Forms.Button();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.cbmGym = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnDeleteUsers = new System.Windows.Forms.Button();
            this.btnUpdateUsers = new System.Windows.Forms.Button();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.gvwUsers = new System.Windows.Forms.DataGridView();
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChangguanDataSet1 = new WindowsApp1.changguanDataSet1();
            this.SqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.SqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.UsersTableAdapter = new WindowsApp1.changguanDataSet1TableAdapters.UsersTableAdapter();
            this.ChangguanDataSet = new WindowsApp1.changguanDataSet();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangguanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangguanDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupBox1.AutoSize = true;
            this.GroupBox1.Controls.Add(this.btnClose);
            this.GroupBox1.Controls.Add(this.btnInsertUsers);
            this.GroupBox1.Controls.Add(this.txtCondition);
            this.GroupBox1.Controls.Add(this.cbmGym);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.btnDeleteUsers);
            this.GroupBox1.Controls.Add(this.btnUpdateUsers);
            this.GroupBox1.Controls.Add(this.DataGridView2);
            this.GroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox1.Location = new System.Drawing.Point(526, 65);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(615, 183);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "用户管理系统";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(500, 86);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 41);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInsertUsers
            // 
            this.btnInsertUsers.Location = new System.Drawing.Point(388, 86);
            this.btnInsertUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertUsers.Name = "btnInsertUsers";
            this.btnInsertUsers.Size = new System.Drawing.Size(80, 41);
            this.btnInsertUsers.TabIndex = 7;
            this.btnInsertUsers.Text = "查询";
            this.btnInsertUsers.UseVisualStyleBackColor = true;
            this.btnInsertUsers.Click += new System.EventHandler(this.btnInsertUsers_Click);
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(255, 106);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(2);
            this.txtCondition.Multiline = true;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(102, 21);
            this.txtCondition.TabIndex = 6;
            // 
            // cbmGym
            // 
            this.cbmGym.FormattingEnabled = true;
            this.cbmGym.Items.AddRange(new object[] {
            "帐号",
            "姓名",
            "身份"});
            this.cbmGym.Location = new System.Drawing.Point(136, 104);
            this.cbmGym.Margin = new System.Windows.Forms.Padding(2);
            this.cbmGym.Name = "cbmGym";
            this.cbmGym.Size = new System.Drawing.Size(92, 24);
            this.cbmGym.TabIndex = 5;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(278, 81);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 16);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "查询条件";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(152, 81);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 16);
            this.Label1.TabIndex = 3;
            this.Label1.Text = "查询方式";
            // 
            // btnDeleteUsers
            // 
            this.btnDeleteUsers.Location = new System.Drawing.Point(106, 29);
            this.btnDeleteUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteUsers.Name = "btnDeleteUsers";
            this.btnDeleteUsers.Size = new System.Drawing.Size(51, 33);
            this.btnDeleteUsers.TabIndex = 2;
            this.btnDeleteUsers.Text = "删除";
            this.btnDeleteUsers.UseVisualStyleBackColor = true;
            this.btnDeleteUsers.Click += new System.EventHandler(this.btnDeleteUsers_Click);
            // 
            // btnUpdateUsers
            // 
            this.btnUpdateUsers.Location = new System.Drawing.Point(10, 29);
            this.btnUpdateUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateUsers.Name = "btnUpdateUsers";
            this.btnUpdateUsers.Size = new System.Drawing.Size(49, 33);
            this.btnUpdateUsers.TabIndex = 1;
            this.btnUpdateUsers.Text = "修改";
            this.btnUpdateUsers.UseVisualStyleBackColor = true;
            this.btnUpdateUsers.Click += new System.EventHandler(this.btnUpdateUsers_Click);
            // 
            // DataGridView2
            // 
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Location = new System.Drawing.Point(592, 152);
            this.DataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.RowTemplate.Height = 27;
            this.DataGridView2.Size = new System.Drawing.Size(8, 8);
            this.DataGridView2.TabIndex = 2;
            // 
            // gvwUsers
            // 
            this.gvwUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gvwUsers.BackgroundColor = System.Drawing.Color.Silver;
            this.gvwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwUsers.Location = new System.Drawing.Point(473, 265);
            this.gvwUsers.Margin = new System.Windows.Forms.Padding(2);
            this.gvwUsers.Name = "gvwUsers";
            this.gvwUsers.RowTemplate.Height = 27;
            this.gvwUsers.Size = new System.Drawing.Size(732, 468);
            this.gvwUsers.TabIndex = 1;
            this.gvwUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvwUsers_CellContentClick);
            // 
            // UsersBindingSource
            // 
            this.UsersBindingSource.DataMember = "Users";
            this.UsersBindingSource.DataSource = this.ChangguanDataSet1;
            // 
            // ChangguanDataSet1
            // 
            this.ChangguanDataSet1.DataSetName = "changguanDataSet1";
            this.ChangguanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SqlConnection1
            // 
            this.SqlConnection1.ConnectionString = "Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=c" +
    "hangguan;";
            this.SqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // SqlDataAdapter1
            // 
            this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
            this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
            this.SqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Users", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("Uname", "Uname"),
                        new System.Data.Common.DataColumnMapping("Uidentity", "Uidentity")})});
            this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
            // 
            // SqlDeleteCommand1
            // 
            this.SqlDeleteCommand1.CommandText = "DELETE FROM [Users] WHERE (([ID] = @Original_ID) AND ([Uname] = @Original_Uname) " +
    "AND ([Uidentity] = @Original_Uidentity))";
            this.SqlDeleteCommand1.Connection = this.SqlConnection1;
            this.SqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Uname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Uname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Uidentity", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Uidentity", System.Data.DataRowVersion.Original, null)});
            // 
            // SqlSelectCommand1
            // 
            this.SqlSelectCommand1.CommandText = "SELECT ID, Uname,  Uidentity FROM Users";
            this.SqlSelectCommand1.Connection = this.SqlConnection1;
            // 
            // SqlUpdateCommand1
            // 
            this.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText");
            this.SqlUpdateCommand1.Connection = this.SqlConnection1;
            this.SqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.VarChar, 0, "ID"),
            new System.Data.SqlClient.SqlParameter("@Uname", System.Data.SqlDbType.VarChar, 0, "Uname"),
            new System.Data.SqlClient.SqlParameter("@Uidentity", System.Data.SqlDbType.VarChar, 0, "Uidentity"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Uname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Uname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Uidentity", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Uidentity", System.Data.DataRowVersion.Original, null)});
            // 
            // UsersTableAdapter
            // 
            this.UsersTableAdapter.ClearBeforeFill = true;
            // 
            // ChangguanDataSet
            // 
            this.ChangguanDataSet.DataSetName = "changguanDataSet";
            this.ChangguanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 用户管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gvwUsers);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "用户管理";
            this.Text = "用户管理系统";
            this.Load += new System.EventHandler(this.用户管理系统_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvwUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangguanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangguanDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		internal GroupBox GroupBox1;
		internal Button btnDeleteUsers;
		internal Button btnUpdateUsers;
		internal Button btnClose;
		internal Button btnInsertUsers;
		internal TextBox txtCondition;
		internal ComboBox cbmGym;
		internal Label Label2;
		internal Label Label1;
		internal DataGridView gvwUsers;
		internal DataGridView DataGridView2;
		internal System.Data.SqlClient.SqlConnection SqlConnection1;
		internal System.Data.SqlClient.SqlDataAdapter SqlDataAdapter1;
		internal System.Data.SqlClient.SqlCommand SqlDeleteCommand1;
		internal System.Data.SqlClient.SqlCommand SqlSelectCommand1;
		internal System.Data.SqlClient.SqlCommand SqlUpdateCommand1;
		internal changguanDataSet ChangguanDataSet;
		internal changguanDataSet1 ChangguanDataSet1;
		internal BindingSource UsersBindingSource;
		internal changguanDataSet1TableAdapters.UsersTableAdapter UsersTableAdapter;
        private System.ComponentModel.IContainer components;
    }
	
}
