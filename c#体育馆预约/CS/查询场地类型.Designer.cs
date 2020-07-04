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
	partial class 查询场地类型 : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(查询场地类型_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(查询场地类型));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			this.btnSelcetVenue = new System.Windows.Forms.Button();
			this.btnSelcetVenue.Click += new System.EventHandler(this.btnSelcetVenue_Click);
			this.txtCondition = new System.Windows.Forms.TextBox();
			this.lblResults2 = new System.Windows.Forms.Label();
			this.cbmGym = new System.Windows.Forms.ComboBox();
			this.lblResults1 = new System.Windows.Forms.Label();
			this.btnDeleteVenue = new System.Windows.Forms.Button();
			this.btnDeleteVenue.Click += new System.EventHandler(this.btnDeleteVenue_Click);
			this.btnUpdteVenue = new System.Windows.Forms.Button();
			this.btnUpdteVenue.Click += new System.EventHandler(this.btnUpdteVenue_Click);
			this.gvwVtype = new System.Windows.Forms.DataGridView();
			this.VnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.INrentalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OUTrentalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.VtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ChangguanDataSet3 = new WindowsApp1.changguanDataSet3();
			this.SqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.SqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
			this.SqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.SqlInsertCommand = new System.Data.SqlClient.SqlCommand();
			this.SqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.SqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
			this.ChangguanDataSet1 = new WindowsApp1.changguanDataSet();
			this.VtypeTableAdapter = new WindowsApp1.changguanDataSet3TableAdapters.VtypeTableAdapter();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.gvwVtype).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.VtypeBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet3).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet1).BeginInit();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.btnReturn);
			this.GroupBox1.Controls.Add(this.btnSelcetVenue);
			this.GroupBox1.Controls.Add(this.txtCondition);
			this.GroupBox1.Controls.Add(this.lblResults2);
			this.GroupBox1.Controls.Add(this.cbmGym);
			this.GroupBox1.Controls.Add(this.lblResults1);
			this.GroupBox1.Controls.Add(this.btnDeleteVenue);
			this.GroupBox1.Controls.Add(this.btnUpdteVenue);
			this.GroupBox1.Location = new System.Drawing.Point(3, 12);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(798, 177);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "查询场地类型";
			//
			//btnReturn
			//
			this.btnReturn.Location = new System.Drawing.Point(648, 106);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(107, 51);
			this.btnReturn.TabIndex = 10;
			this.btnReturn.Text = "退出";
			this.btnReturn.UseVisualStyleBackColor = true;
			//
			//btnSelcetVenue
			//
			this.btnSelcetVenue.Location = new System.Drawing.Point(500, 106);
			this.btnSelcetVenue.Name = "btnSelcetVenue";
			this.btnSelcetVenue.Size = new System.Drawing.Size(107, 51);
			this.btnSelcetVenue.TabIndex = 9;
			this.btnSelcetVenue.Text = "查询";
			this.btnSelcetVenue.UseVisualStyleBackColor = true;
			//
			//txtCondition
			//
			this.txtCondition.Location = new System.Drawing.Point(300, 132);
			this.txtCondition.Multiline = true;
			this.txtCondition.Name = "txtCondition";
			this.txtCondition.Size = new System.Drawing.Size(135, 25);
			this.txtCondition.TabIndex = 8;
			//
			//lblResults2
			//
			this.lblResults2.AutoSize = true;
			this.lblResults2.Location = new System.Drawing.Point(331, 101);
			this.lblResults2.Name = "lblResults2";
			this.lblResults2.Size = new System.Drawing.Size(67, 15);
			this.lblResults2.TabIndex = 7;
			this.lblResults2.Text = "查询条件";
			//
			//cbmGym
			//
			this.cbmGym.FormattingEnabled = true;
			this.cbmGym.Items.AddRange(new object[] {"场地名称"});
			this.cbmGym.Location = new System.Drawing.Point(139, 134);
			this.cbmGym.Name = "cbmGym";
			this.cbmGym.Size = new System.Drawing.Size(121, 23);
			this.cbmGym.TabIndex = 6;
			this.cbmGym.Text = "场地名称";
			//
			//lblResults1
			//
			this.lblResults1.AutoSize = true;
			this.lblResults1.Location = new System.Drawing.Point(163, 101);
			this.lblResults1.Name = "lblResults1";
			this.lblResults1.Size = new System.Drawing.Size(67, 15);
			this.lblResults1.TabIndex = 5;
			this.lblResults1.Text = "查询方式";
			//
			//btnDeleteVenue
			//
			this.btnDeleteVenue.Location = new System.Drawing.Point(103, 36);
			this.btnDeleteVenue.Name = "btnDeleteVenue";
			this.btnDeleteVenue.Size = new System.Drawing.Size(55, 52);
			this.btnDeleteVenue.TabIndex = 4;
			this.btnDeleteVenue.Text = "删除";
			this.btnDeleteVenue.UseVisualStyleBackColor = true;
			//
			//btnUpdteVenue
			//
			this.btnUpdteVenue.Location = new System.Drawing.Point(30, 36);
			this.btnUpdteVenue.Name = "btnUpdteVenue";
			this.btnUpdteVenue.Size = new System.Drawing.Size(55, 52);
			this.btnUpdteVenue.TabIndex = 3;
			this.btnUpdteVenue.Text = "修改";
			this.btnUpdteVenue.UseVisualStyleBackColor = true;
			//
			//gvwVtype
			//
			this.gvwVtype.AutoGenerateColumns = false;
			this.gvwVtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvwVtype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.VnameDataGridViewTextBoxColumn, this.INrentalDataGridViewTextBoxColumn, this.OUTrentalDataGridViewTextBoxColumn, this.VaddressDataGridViewTextBoxColumn});
			this.gvwVtype.DataSource = this.VtypeBindingSource;
			this.gvwVtype.Location = new System.Drawing.Point(3, 195);
			this.gvwVtype.Name = "gvwVtype";
			this.gvwVtype.RowTemplate.Height = 27;
			this.gvwVtype.Size = new System.Drawing.Size(798, 256);
			this.gvwVtype.TabIndex = 1;
			//
			//VnameDataGridViewTextBoxColumn
			//
			this.VnameDataGridViewTextBoxColumn.DataPropertyName = "Vname";
			this.VnameDataGridViewTextBoxColumn.HeaderText = "场地名称";
			this.VnameDataGridViewTextBoxColumn.Name = "VnameDataGridViewTextBoxColumn";
			this.VnameDataGridViewTextBoxColumn.Width = 150;
			//
			//INrentalDataGridViewTextBoxColumn
			//
			this.INrentalDataGridViewTextBoxColumn.DataPropertyName = "INrental";
			this.INrentalDataGridViewTextBoxColumn.HeaderText = "校内人员租金";
			this.INrentalDataGridViewTextBoxColumn.Name = "INrentalDataGridViewTextBoxColumn";
			this.INrentalDataGridViewTextBoxColumn.Width = 150;
			//
			//OUTrentalDataGridViewTextBoxColumn
			//
			this.OUTrentalDataGridViewTextBoxColumn.DataPropertyName = "OUTrental";
			this.OUTrentalDataGridViewTextBoxColumn.HeaderText = "校外人员租金";
			this.OUTrentalDataGridViewTextBoxColumn.Name = "OUTrentalDataGridViewTextBoxColumn";
			this.OUTrentalDataGridViewTextBoxColumn.Width = 150;
			//
			//VaddressDataGridViewTextBoxColumn
			//
			this.VaddressDataGridViewTextBoxColumn.DataPropertyName = "Vaddress";
			this.VaddressDataGridViewTextBoxColumn.HeaderText = "场地地址";
			this.VaddressDataGridViewTextBoxColumn.Name = "VaddressDataGridViewTextBoxColumn";
			this.VaddressDataGridViewTextBoxColumn.Width = 150;
			//
			//VtypeBindingSource
			//
			this.VtypeBindingSource.DataMember = "Vtype";
			this.VtypeBindingSource.DataSource = this.ChangguanDataSet3;
			//
			//ChangguanDataSet3
			//
			this.ChangguanDataSet3.DataSetName = "changguanDataSet3";
			this.ChangguanDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//SqlDataAdapter1
			//
			this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
			this.SqlDataAdapter1.InsertCommand = this.SqlInsertCommand;
			this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
			this.SqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {new System.Data.Common.DataTableMapping("Table", "Vtype", new System.Data.Common.DataColumnMapping[] {new System.Data.Common.DataColumnMapping("Vname", "Vname"), new System.Data.Common.DataColumnMapping("INrental", "INrental"), new System.Data.Common.DataColumnMapping("OUTrental", "OUTrental"), new System.Data.Common.DataColumnMapping("Vaddress", "Vaddress")})});
			this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
			//
			//SqlDeleteCommand1
			//
			this.SqlDeleteCommand1.CommandText = "DELETE FROM [Vtype] WHERE (([Vname] = @Original_Vname) AND ([INrental] = @Origina" +
				"l_INrental) AND ([OUTrental] = @Original_OUTrental) AND ([Vaddress] = @Original_" +
				"Vaddress))";
			this.SqlDeleteCommand1.Connection = this.SqlConnection1;
			this.SqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vname", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_INrental", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "INrental", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_OUTrental", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "OUTrental", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Vaddress", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vaddress", System.Data.DataRowVersion.Original, null)});
			//
			//SqlConnection1
			//
			this.SqlConnection1.ConnectionString = "Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=c" +
				"hangguan;";
			this.SqlConnection1.FireInfoMessageEventOnUserErrors = false;
			//
			//SqlInsertCommand
			//
			this.SqlInsertCommand.CommandText = "INSERT INTO [Vtype] ([Vname], [INrental], [OUTrental], [Vaddress]) VALUES (@Vname" +
				", @INrental, @OUTrental, @Vaddress);" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "SELECT Vname, INrental, OUTrental, Vaddres" +
				"s FROM Vtype WHERE (Vname = @Vname)";
			this.SqlInsertCommand.Connection = this.SqlConnection1;
			this.SqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), new System.Data.SqlClient.SqlParameter("@INrental", System.Data.SqlDbType.Real, 0, "INrental"), new System.Data.SqlClient.SqlParameter("@OUTrental", System.Data.SqlDbType.Real, 0, "OUTrental"), new System.Data.SqlClient.SqlParameter("@Vaddress", System.Data.SqlDbType.VarChar, 0, "Vaddress")});
			//
			//SqlSelectCommand1
			//
			this.SqlSelectCommand1.CommandText = "SELECT Vname,  INrental ,  OUTrental,  Vaddress FROM Vtype";
			this.SqlSelectCommand1.Connection = this.SqlConnection1;
			//
			//SqlUpdateCommand1
			//
			this.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText");
			this.SqlUpdateCommand1.Connection = this.SqlConnection1;
			this.SqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"), new System.Data.SqlClient.SqlParameter("@INrental", System.Data.SqlDbType.Real, 0, "INrental"), new System.Data.SqlClient.SqlParameter("@OUTrental", System.Data.SqlDbType.Real, 0, "OUTrental"), new System.Data.SqlClient.SqlParameter("@Vaddress", System.Data.SqlDbType.VarChar, 0, "Vaddress"), new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vname", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_INrental", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "INrental", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_OUTrental", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "OUTrental", System.Data.DataRowVersion.Original, null), new System.Data.SqlClient.SqlParameter("@Original_Vaddress", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, System.Convert.ToByte(0), System.Convert.ToByte(0), "Vaddress", System.Data.DataRowVersion.Original, null)});
			//
			//ChangguanDataSet1
			//
			this.ChangguanDataSet1.DataSetName = "changguanDataSet";
			this.ChangguanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			//
			//VtypeTableAdapter
			//
			this.VtypeTableAdapter.ClearBeforeFill = true;
			//
			//查询场地类型
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.gvwVtype);
			this.Controls.Add(this.GroupBox1);
			this.Name = "查询场地类型";
			this.Text = "查询场地类型";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.gvwVtype).EndInit();
			((System.ComponentModel.ISupportInitialize) this.VtypeBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet3).EndInit();
			((System.ComponentModel.ISupportInitialize) this.ChangguanDataSet1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal GroupBox GroupBox1;
		internal Button btnDeleteVenue;
		internal Button btnUpdteVenue;
		internal Label lblResults1;
		internal ComboBox cbmGym;
		internal Label lblResults2;
		internal TextBox txtCondition;
		internal Button btnReturn;
		internal Button btnSelcetVenue;
		internal DataGridView gvwVtype;
		internal System.Data.SqlClient.SqlDataAdapter SqlDataAdapter1;
		internal System.Data.SqlClient.SqlCommand SqlDeleteCommand1;
		internal System.Data.SqlClient.SqlConnection SqlConnection1;
		internal System.Data.SqlClient.SqlCommand SqlInsertCommand;
		internal System.Data.SqlClient.SqlCommand SqlSelectCommand1;
		internal System.Data.SqlClient.SqlCommand SqlUpdateCommand1;
		internal changguanDataSet ChangguanDataSet1;
		internal changguanDataSet3 ChangguanDataSet3;
		internal BindingSource VtypeBindingSource;
		internal changguanDataSet3TableAdapters.VtypeTableAdapter VtypeTableAdapter;
		internal DataGridViewTextBoxColumn VnameDataGridViewTextBoxColumn;
		internal DataGridViewTextBoxColumn INrentalDataGridViewTextBoxColumn;
		internal DataGridViewTextBoxColumn OUTrentalDataGridViewTextBoxColumn;
		internal DataGridViewTextBoxColumn VaddressDataGridViewTextBoxColumn;
	}
	
}
