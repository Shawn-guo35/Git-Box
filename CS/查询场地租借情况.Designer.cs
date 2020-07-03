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
		public partial class 查询场地租借情况 : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(场地管理系统_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(查询场地租借情况));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
			this.Label2 = new System.Windows.Forms.Label();
			this.Label2.Click += new System.EventHandler(this.Label2_Click);
			this.Label1 = new System.Windows.Forms.Label();
			this.Label1.Click += new System.EventHandler(this.Label1_Click);
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.SqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.SqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.SqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.SqlInsertCommand = new System.Data.SqlClient.SqlCommand();
			this.SqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.SqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.ChangguanDataSet1 = new WindowsApp1.changguanDataSet();
			this.ChangguanDataSet6 = new WindowsApp1.changguanDataSet6();
			this.LeaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.LeaseTableAdapter = new WindowsApp1.changguanDataSet6TableAdapters.LeaseTableAdapter();
			this.VnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ConditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet6).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.LeaseBindingSource).BeginInit();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.TextBox2);
			this.GroupBox1.Controls.Add(this.Button5);
			this.GroupBox1.Controls.Add(this.Button4);
			this.GroupBox1.Controls.Add(this.TextBox1);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Location = new System.Drawing.Point(2, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(798, 215);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "查询场地租借情况";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(133, 140);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(67, 15);
			this.Label4.TabIndex = 31;
			this.Label4.Text = "场地编号";
			this.Label4.Visible = false;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(133, 84);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(67, 15);
			this.Label3.TabIndex = 30;
			this.Label3.Text = "场地名称";
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(225, 140);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.Size = new System.Drawing.Size(139, 25);
			this.TextBox2.TabIndex = 29;
			this.TextBox2.Visible = false;
			//
			//Button5
			//
			this.Button5.Location = new System.Drawing.Point(637, 66);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(107, 51);
			this.Button5.TabIndex = 28;
			this.Button5.Text = "退出";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(473, 66);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(107, 51);
			this.Button4.TabIndex = 27;
			this.Button4.Text = "查询";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(225, 81);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.Size = new System.Drawing.Size(139, 25);
			this.TextBox1.TabIndex = 26;
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] {"场地名称", "场地名称&场地编号"});
			this.ComboBox1.Location = new System.Drawing.Point(225, 38);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(191, 23);
			this.ComboBox1.TabIndex = 25;
			this.ComboBox1.Text = "场地名称";
			//
			//Label2
			//
			this.Label2.Location = new System.Drawing.Point(31, 81);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(96, 20);
			this.Label2.TabIndex = 24;
			this.Label2.Text = "查询条件：";
			//
			//Label1
			//
			this.Label1.Location = new System.Drawing.Point(31, 41);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(96, 20);
			this.Label1.TabIndex = 23;
			this.Label1.Text = "查询方式：";
			//
			//DataGridView1
			//
			this.DataGridView1.AutoGenerateColumns = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.VnameDataGridViewTextBoxColumn, this.VnoDataGridViewTextBoxColumn, this.StimeDataGridViewTextBoxColumn, this.EtimeDataGridViewTextBoxColumn, this.ConditionDataGridViewTextBoxColumn});
			this.DataGridView1.DataSource = this.LeaseBindingSource;
			this.DataGridView1.Location = new System.Drawing.Point(2, 207);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.RowTemplate.Height = 27;
			this.DataGridView1.Size = new System.Drawing.Size(798, 242);
			this.DataGridView1.TabIndex = 1;
			//
			//SqlDataAdapter1
			//
			this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
			this.SqlDataAdapter1.InsertCommand = this.SqlInsertCommand;
			this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
			this.SqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {new System.Data.Common.DataTableMapping("Table", "Lease", new System.Data.Common.DataColumnMapping[] {new System.Data.Common.DataColumnMapping("Vname", "Vname"), new System.Data.Common.DataColumnMapping("Vno", "Vno"), new System.Data.Common.DataColumnMapping("Stime", "Stime"), new System.Data.Common.DataColumnMapping("Etime", "Etime"), new System.Data.Common.DataColumnMapping("Condition", "Condition")})});
			this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
			//
			//SqlDeleteCommand1
			//
			this.SqlDeleteCommand1.CommandText = "DELETE FROM [Lease] WHERE (([Vname] = @Original_Vname) AND ([Vno] = @Original_Vno" +
				") AND ([Stime] = @Original_Stime) AND ([Etime] = @Original_Etime) AND ([Conditio" +
				"n] = @Original_Condition))";
			this.SqlDeleteCommand1.Connection = this.SqlConnection1;
			this.SqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vname", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vno", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Stime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Stime", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Etime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Etime", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Condition", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Condition", System.Data.DataRowVersion.Original, null)});
			//
			//SqlConnection1
			//
			this.SqlConnection1.ConnectionString = "Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=c" +
				"hangguan;";
			this.SqlConnection1.FireInfoMessageEventOnUserErrors = false;
			//
			//SqlInsertCommand
			//
			this.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText");
			this.SqlInsertCommand.Connection = this.SqlConnection1;
			this.SqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), new System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno"), new System.Data.SqlClient.SqlParameter("@Stime", System.Data.SqlDbType.DateTime, 0, "Stime"), new System.Data.SqlClient.SqlParameter("@Etime", System.Data.SqlDbType.DateTime, 0, "Etime"), new System.Data.SqlClient.SqlParameter("@Condition", System.Data.SqlDbType.VarChar, 0, "Condition")});
			//
			//SqlSelectCommand1
			//
			this.SqlSelectCommand1.CommandText = "SELECT Vname, Vno, Stime,  Etime,  Condition FROM Lease";
			this.SqlSelectCommand1.Connection = this.SqlConnection1;
			//
			//SqlUpdateCommand1
			//
			this.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText");
			this.SqlUpdateCommand1.Connection = this.SqlConnection1;
			this.SqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), new System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno"), new System.Data.SqlClient.SqlParameter("@Stime", System.Data.SqlDbType.DateTime, 0, "Stime"), new System.Data.SqlClient.SqlParameter("@Etime", System.Data.SqlDbType.DateTime, 0, "Etime"), new System.Data.SqlClient.SqlParameter("@Condition", System.Data.SqlDbType.VarChar, 0, "Condition"), new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vname", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vno", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Stime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Stime", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Etime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Etime", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Condition", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Condition", System.Data.DataRowVersion.Original, null)});
			//
			//ChangguanDataSet1
			//
			this.ChangguanDataSet1.DataSetName = "changguanDataSet";
			this.ChangguanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//ChangguanDataSet6
			//
			this.ChangguanDataSet6.DataSetName = "changguanDataSet6";
			this.ChangguanDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//LeaseBindingSource
			//
			this.LeaseBindingSource.DataMember = "Lease";
			this.LeaseBindingSource.DataSource = this.ChangguanDataSet6;
			//
			//LeaseTableAdapter
			//
			this.LeaseTableAdapter.ClearBeforeFill = true;
			//
			//VnameDataGridViewTextBoxColumn
			//
			this.VnameDataGridViewTextBoxColumn.DataPropertyName = "Vname";
			this.VnameDataGridViewTextBoxColumn.HeaderText = "场地名称";
			this.VnameDataGridViewTextBoxColumn.Name = "VnameDataGridViewTextBoxColumn";
			//
			//VnoDataGridViewTextBoxColumn
			//
			this.VnoDataGridViewTextBoxColumn.DataPropertyName = "Vno";
			this.VnoDataGridViewTextBoxColumn.HeaderText = "场地编号";
			this.VnoDataGridViewTextBoxColumn.Name = "VnoDataGridViewTextBoxColumn";
			//
			//StimeDataGridViewTextBoxColumn
			//
			this.StimeDataGridViewTextBoxColumn.DataPropertyName = "Stime";
			this.StimeDataGridViewTextBoxColumn.HeaderText = "开始时间";
			this.StimeDataGridViewTextBoxColumn.Name = "StimeDataGridViewTextBoxColumn";
			//
			//EtimeDataGridViewTextBoxColumn
			//
			this.EtimeDataGridViewTextBoxColumn.DataPropertyName = "Etime";
			this.EtimeDataGridViewTextBoxColumn.HeaderText = "结束时间";
			this.EtimeDataGridViewTextBoxColumn.Name = "EtimeDataGridViewTextBoxColumn";
			//
			//ConditionDataGridViewTextBoxColumn
			//
			this.ConditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
			this.ConditionDataGridViewTextBoxColumn.HeaderText = "场地状态";
			this.ConditionDataGridViewTextBoxColumn.Name = "ConditionDataGridViewTextBoxColumn";
			//
			//查询场地租借情况
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.GroupBox1);
			this.Name = "查询场地租借情况";
			this.Text = "查询场地租借情况";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet6).EndInit();
			((System.ComponentModel.ISupportInitialize) this.LeaseBindingSource).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal GroupBox GroupBox1;
		internal Label Label2;
		internal Label Label1;
		internal TextBox TextBox1;
		internal ComboBox ComboBox1;
		internal Button Button4;
		internal Button Button5;
		internal DataGridView DataGridView1;
		internal System.Data.SqlClient.SqlDataAdapter SqlDataAdapter1;
		internal System.Data.SqlClient.SqlCommand SqlDeleteCommand1;
		internal System.Data.SqlClient.SqlConnection SqlConnection1;
		internal System.Data.SqlClient.SqlCommand SqlInsertCommand;
		internal System.Data.SqlClient.SqlCommand SqlSelectCommand1;
		internal System.Data.SqlClient.SqlCommand SqlUpdateCommand1;
		internal TextBox TextBox2;
		internal Label Label4;
		internal Label Label3;
		internal changguanDataSet ChangguanDataSet1;
		internal changguanDataSet6 ChangguanDataSet6;
		internal BindingSource LeaseBindingSource;
		internal changguanDataSet6TableAdapters.LeaseTableAdapter LeaseTableAdapter;
		internal DataGridViewTextBoxColumn VnameDataGridViewTextBoxColumn;
		internal DataGridViewTextBoxColumn VnoDataGridViewTextBoxColumn;
		internal DataGridViewTextBoxColumn StimeDataGridViewTextBoxColumn;
		internal DataGridViewTextBoxColumn EtimeDataGridViewTextBoxColumn;
		internal DataGridViewTextBoxColumn ConditionDataGridViewTextBoxColumn;
	}
	
}
