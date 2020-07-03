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
		
		//Windows 窗体设计器所必需的
		private System.ComponentModel.Container components = null;
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]
			private void InitializeComponent()
			{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(用户管理系统_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(用户管理));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
			this.DataGridView2 = new System.Windows.Forms.DataGridView();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
			this.IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UidentityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ChangguanDataSet1 = new WindowsApp1.changguanDataSet1();
			this.SqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.SqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.SqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.SqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.SqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.ChangguanDataSet = new WindowsApp1.changguanDataSet();
			this.UsersTableAdapter = new WindowsApp1.changguanDataSet1TableAdapters.UsersTableAdapter();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.UsersBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet).BeginInit();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.DataGridView2);
			this.GroupBox1.Controls.Add(this.Button5);
			this.GroupBox1.Controls.Add(this.Button4);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Button3);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.GroupBox1.Location = new System.Drawing.Point(1, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(820, 220);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "用户管理系统";
			//
			//DataGridView2
			//
			this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView2.Location = new System.Drawing.Point(790, 190);
			this.DataGridView2.Name = "DataGridView2";
			this.DataGridView2.RowTemplate.Height = 27;
			this.DataGridView2.Size = new System.Drawing.Size(10, 10);
			this.DataGridView2.TabIndex = 2;
			//
			//Button5
			//
			this.Button5.Location = new System.Drawing.Point(666, 107);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(107, 51);
			this.Button5.TabIndex = 8;
			this.Button5.Text = "退出";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(518, 107);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(107, 51);
			this.Button4.TabIndex = 7;
			this.Button4.Text = "查询";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(340, 133);
			this.TextBox1.Multiline = true;
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(135, 25);
			this.TextBox1.TabIndex = 6;
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] {"帐号", "姓名", "身份"});
			this.ComboBox1.Location = new System.Drawing.Point(182, 130);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(121, 28);
			this.ComboBox1.TabIndex = 5;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(371, 101);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(89, 20);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "查询条件";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(203, 101);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(89, 20);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "查询方式";
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(142, 36);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(68, 41);
			this.Button3.TabIndex = 2;
			this.Button3.Text = "删除";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(29, 36);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(65, 41);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "修改";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//DataGridView1
			//
			this.DataGridView1.AutoGenerateColumns = false;
			this.DataGridView1.BackgroundColor = System.Drawing.Color.Silver;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.IDDataGridViewTextBoxColumn, this.UnameDataGridViewTextBoxColumn, this.UidentityDataGridViewTextBoxColumn});
			this.DataGridView1.DataSource = this.UsersBindingSource;
			this.DataGridView1.Location = new System.Drawing.Point(1, 208);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.RowTemplate.Height = 27;
			this.DataGridView1.Size = new System.Drawing.Size(800, 245);
			this.DataGridView1.TabIndex = 1;
			//
			//IDDataGridViewTextBoxColumn
			//
			this.IDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.IDDataGridViewTextBoxColumn.HeaderText = "账号";
			this.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn";
			//
			//UnameDataGridViewTextBoxColumn
			//
			this.UnameDataGridViewTextBoxColumn.DataPropertyName = "Uname";
			this.UnameDataGridViewTextBoxColumn.HeaderText = "姓名";
			this.UnameDataGridViewTextBoxColumn.Name = "UnameDataGridViewTextBoxColumn";
			//
			//UidentityDataGridViewTextBoxColumn
			//
			this.UidentityDataGridViewTextBoxColumn.DataPropertyName = "Uidentity";
			this.UidentityDataGridViewTextBoxColumn.HeaderText = "身份";
			this.UidentityDataGridViewTextBoxColumn.Name = "UidentityDataGridViewTextBoxColumn";
			//
			//UsersBindingSource
			//
			this.UsersBindingSource.DataMember = "Users";
			this.UsersBindingSource.DataSource = this.ChangguanDataSet1;
			//
			//ChangguanDataSet1
			//
			this.ChangguanDataSet1.DataSetName = "changguanDataSet1";
			this.ChangguanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//SqlConnection1
			//
			this.SqlConnection1.ConnectionString = "Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=c" +
				"hangguan;";
			this.SqlConnection1.FireInfoMessageEventOnUserErrors = false;
			//
			//SqlDataAdapter1
			//
			this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
			this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
			this.SqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {new System.Data.Common.DataTableMapping("Table", "Users", new System.Data.Common.DataColumnMapping[] {new System.Data.Common.DataColumnMapping("ID", "ID"), new System.Data.Common.DataColumnMapping("Uname", "Uname"), new System.Data.Common.DataColumnMapping("Uidentity", "Uidentity")})});
			this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
			//
			//SqlDeleteCommand1
			//
			this.SqlDeleteCommand1.CommandText = "DELETE FROM [Users] WHERE (([ID] = @Original_ID) AND ([Uname] = @Original_Uname) " +
				"AND ([Uidentity] = @Original_Uidentity))";
			this.SqlDeleteCommand1.Connection = this.SqlConnection1;
			this.SqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "ID", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Uname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Uname", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Uidentity", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Uidentity", System.Data.DataRowVersion.Original, null)});
			//
			//SqlSelectCommand1
			//
			this.SqlSelectCommand1.CommandText = "SELECT ID, Uname,  Uidentity FROM Users";
			this.SqlSelectCommand1.Connection = this.SqlConnection1;
			//
			//SqlUpdateCommand1
			//
			this.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText");
			this.SqlUpdateCommand1.Connection = this.SqlConnection1;
			this.SqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.VarChar, 0, "ID"), new System.Data.SqlClient.SqlParameter("@Uname", System.Data.SqlDbType.VarChar, 0, "Uname"), new System.Data.SqlClient.SqlParameter("@Uidentity", System.Data.SqlDbType.VarChar, 0, "Uidentity"), new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "ID", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Uname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Uname", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Uidentity", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Uidentity", System.Data.DataRowVersion.Original, null)});
			//
			//ChangguanDataSet
			//
			this.ChangguanDataSet.DataSetName = "changguanDataSet";
			this.ChangguanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//UsersTableAdapter
			//
			this.UsersTableAdapter.ClearBeforeFill = true;
			//
			//用户管理
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(821, 453);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.GroupBox1);
			this.Name = "用户管理";
			this.Text = "用户管理系统";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.UsersBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal GroupBox GroupBox1;
		internal Button Button3;
		internal Button Button2;
		internal Button Button5;
		internal Button Button4;
		internal TextBox TextBox1;
		internal ComboBox ComboBox1;
		internal Label Label2;
		internal Label Label1;
		internal DataGridView DataGridView1;
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
		internal DataGridViewTextBoxColumn IDDataGridViewTextBoxColumn;
		internal DataGridViewTextBoxColumn UnameDataGridViewTextBoxColumn;
		internal DataGridViewTextBoxColumn UidentityDataGridViewTextBoxColumn;
	}
	
}
