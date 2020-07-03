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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class 查询场地信息 : System.Windows.Forms.Form
	{
		
		//Form 重写 Dispose，以清理组件列表。
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
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
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(查询场地信息_Load);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			this.btnSelectVtype = new System.Windows.Forms.Button();
			this.btnSelectVtype.Click += new System.EventHandler(this.btnSelectVtype_Click);
			this.txtCondition = new System.Windows.Forms.TextBox();
			this.lblResults2 = new System.Windows.Forms.Label();
			this.cbmGym = new System.Windows.Forms.ComboBox();
			this.lblResults1 = new System.Windows.Forms.Label();
			this.btnDeleteVtype = new System.Windows.Forms.Button();
			this.btnDeleteVtype.Click += new System.EventHandler(this.btnDeleteVtype_Click);
			this.gvwVenue = new System.Windows.Forms.DataGridView();
			this.VnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VenueBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ChangguanDataSet5 = new WindowsApp1.changguanDataSet5();
			this.SqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.SqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.SqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.SqlInsertCommand = new System.Data.SqlClient.SqlCommand();
			this.SqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.SqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.ChangguanDataSet1 = new WindowsApp1.changguanDataSet();
			this.VenueTableAdapter = new WindowsApp1.changguanDataSet5TableAdapters.VenueTableAdapter();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gvwVenue).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VenueBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet5).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet1).BeginInit();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.btnReturn);
			this.GroupBox1.Controls.Add(this.btnSelectVtype);
			this.GroupBox1.Controls.Add(this.txtCondition);
			this.GroupBox1.Controls.Add(this.lblResults2);
			this.GroupBox1.Controls.Add(this.cbmGym);
			this.GroupBox1.Controls.Add(this.lblResults1);
			this.GroupBox1.Controls.Add(this.btnDeleteVtype);
			this.GroupBox1.Location = new System.Drawing.Point(1, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(799, 183);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "查询场地信息";
			//
			//btnReturn
			//
			this.btnReturn.Location = new System.Drawing.Point(652, 114);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(107, 51);
			this.btnReturn.TabIndex = 18;
			this.btnReturn.Text = "退出";
			this.btnReturn.UseVisualStyleBackColor = true;
			//
			//btnSelectVtype
			//
			this.btnSelectVtype.Location = new System.Drawing.Point(504, 114);
			this.btnSelectVtype.Name = "btnSelectVtype";
			this.btnSelectVtype.Size = new System.Drawing.Size(107, 51);
			this.btnSelectVtype.TabIndex = 17;
			this.btnSelectVtype.Text = "查询";
			this.btnSelectVtype.UseVisualStyleBackColor = true;
			//
			//txtCondition
			//
			this.txtCondition.Location = new System.Drawing.Point(304, 140);
			this.txtCondition.Multiline = true;
			this.txtCondition.Name = "txtCondition";
			this.txtCondition.Size = new System.Drawing.Size(135, 25);
			this.txtCondition.TabIndex = 16;
			//
			//lblResults2
			//
			this.lblResults2.AutoSize = true;
			this.lblResults2.Location = new System.Drawing.Point(335, 109);
			this.lblResults2.Name = "lblResults2";
			this.lblResults2.Size = new System.Drawing.Size(67, 15);
			this.lblResults2.TabIndex = 15;
			this.lblResults2.Text = "查询条件";
			//
			//cbmGym
			//
			this.cbmGym.FormattingEnabled = true;
			this.cbmGym.Items.AddRange(new object[] {"场地名称"});
			this.cbmGym.Location = new System.Drawing.Point(143, 142);
			this.cbmGym.Name = "cbmGym";
			this.cbmGym.Size = new System.Drawing.Size(121, 23);
			this.cbmGym.TabIndex = 14;
			this.cbmGym.Text = "场地名称";
			//
			//lblResults1
			//
			this.lblResults1.AutoSize = true;
			this.lblResults1.Location = new System.Drawing.Point(167, 109);
			this.lblResults1.Name = "lblResults1";
			this.lblResults1.Size = new System.Drawing.Size(67, 15);
			this.lblResults1.TabIndex = 13;
			this.lblResults1.Text = "查询方式";
			//
			//btnDeleteVtype
			//
			this.btnDeleteVtype.Location = new System.Drawing.Point(107, 44);
			this.btnDeleteVtype.Name = "btnDeleteVtype";
			this.btnDeleteVtype.Size = new System.Drawing.Size(55, 52);
			this.btnDeleteVtype.TabIndex = 12;
			this.btnDeleteVtype.Text = "删除";
			this.btnDeleteVtype.UseVisualStyleBackColor = true;
			//
			//gvwVenue
			//
			this.gvwVenue.AutoGenerateColumns = false;
			this.gvwVenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvwVenue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.VnameDataGridViewTextBoxColumn, this.VnoDataGridViewTextBoxColumn});
			this.gvwVenue.DataSource = this.VenueBindingSource;
			this.gvwVenue.Location = new System.Drawing.Point(0, 201);
			this.gvwVenue.Name = "gvwVenue";
			this.gvwVenue.RowTemplate.Height = 27;
			this.gvwVenue.Size = new System.Drawing.Size(799, 251);
			this.gvwVenue.TabIndex = 1;
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
			//VenueBindingSource
			//
			this.VenueBindingSource.DataMember = "Venue";
			this.VenueBindingSource.DataSource = this.ChangguanDataSet5;
			//
			//ChangguanDataSet5
			//
			this.ChangguanDataSet5.DataSetName = "changguanDataSet5";
			this.ChangguanDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//SqlDataAdapter1
			//
			this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
			this.SqlDataAdapter1.InsertCommand = this.SqlInsertCommand;
			this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
			this.SqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {new System.Data.Common.DataTableMapping("Table", "Venue", new System.Data.Common.DataColumnMapping[] {new System.Data.Common.DataColumnMapping("Vname", "Vname"), new System.Data.Common.DataColumnMapping("Vno", "Vno")})});
			this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
			//
			//SqlDeleteCommand1
			//
			this.SqlDeleteCommand1.CommandText = "DELETE FROM [Venue] WHERE (([Vname] = @Original_Vname) AND ([Vno] = @Original_Vno" +
				"))";
			this.SqlDeleteCommand1.Connection = this.SqlConnection1;
			this.SqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vname", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vno", System.Data.DataRowVersion.Original, null)});
			//
			//SqlConnection1
			//
			this.SqlConnection1.ConnectionString = "Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=c" +
				"hangguan;";
			this.SqlConnection1.FireInfoMessageEventOnUserErrors = false;
			//
			//SqlInsertCommand
			//
			this.SqlInsertCommand.CommandText = "INSERT INTO [Venue] ([Vname], [Vno]) VALUES (@Vname, @Vno);" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "SELECT Vname, Vno FR" +
				"OM Venue WHERE (Vname = @Vname) AND (Vno = @Vno)";
			this.SqlInsertCommand.Connection = this.SqlConnection1;
			this.SqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), new System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno")});
			//
			//SqlSelectCommand1
			//
			this.SqlSelectCommand1.CommandText = "SELECT Vname,  Vno  FROM Venue";
			this.SqlSelectCommand1.Connection = this.SqlConnection1;
			//
			//SqlUpdateCommand1
			//
			this.SqlUpdateCommand1.CommandText = "UPDATE [Venue] SET [Vname] = @Vname, [Vno] = @Vno WHERE (([Vname] = @Original_Vna" +
				"me) AND ([Vno] = @Original_Vno));" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "SELECT Vname, Vno FROM Venue WHERE (Vname = @" +
"Vname) AND (Vno = @Vno)";
			this.SqlUpdateCommand1.Connection = this.SqlConnection1;
			this.SqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), new System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno"), new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vname", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vno", System.Data.DataRowVersion.Original, null)});
			//
			//ChangguanDataSet1
			//
			this.ChangguanDataSet1.DataSetName = "changguanDataSet";
			this.ChangguanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VenueTableAdapter
			//
			this.VenueTableAdapter.ClearBeforeFill = true;
			//
			//查询场地信息
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gvwVenue);
			this.Controls.Add(this.GroupBox1);
			this.Name = "查询场地信息";
			this.Text = "查询场地信息";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.gvwVenue).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VenueBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet5).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal GroupBox GroupBox1;
		internal Button btnReturn;
		internal Button btnSelectVtype;
		internal TextBox txtCondition;
		internal Label lblResults2;
		internal ComboBox cbmGym;
		internal Label lblResults1;
		internal Button btnDeleteVtype;
		internal DataGridView gvwVenue;
		internal System.Data.SqlClient.SqlDataAdapter SqlDataAdapter1;
		internal System.Data.SqlClient.SqlCommand SqlDeleteCommand1;
		internal System.Data.SqlClient.SqlConnection SqlConnection1;
		internal System.Data.SqlClient.SqlCommand SqlInsertCommand;
		internal System.Data.SqlClient.SqlCommand SqlSelectCommand1;
		internal System.Data.SqlClient.SqlCommand SqlUpdateCommand1;
		internal changguanDataSet ChangguanDataSet1;
		internal changguanDataSet5 ChangguanDataSet5;
		internal BindingSource VenueBindingSource;
		internal changguanDataSet5TableAdapters.VenueTableAdapter VenueTableAdapter;
		internal DataGridViewTextBoxColumn VnameDataGridViewTextBoxColumn;
		internal DataGridViewTextBoxColumn VnoDataGridViewTextBoxColumn;
	}
	
}
