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
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(查询场地类型));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSelcetVenue = new System.Windows.Forms.Button();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.lblResults2 = new System.Windows.Forms.Label();
            this.cbmGym = new System.Windows.Forms.ComboBox();
            this.lblResults1 = new System.Windows.Forms.Label();
            this.btnDeleteVenue = new System.Windows.Forms.Button();
            this.btnUpdteVenue = new System.Windows.Forms.Button();
            this.gvwVtype = new System.Windows.Forms.DataGridView();
            this.VtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.SqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.SqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.VtypeTableAdapter = new WindowsApp1.changguanDataSet3TableAdapters.VtypeTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwVtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VtypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupBox1.AutoSize = true;
            this.GroupBox1.Controls.Add(this.btnReturn);
            this.GroupBox1.Controls.Add(this.btnSelcetVenue);
            this.GroupBox1.Controls.Add(this.txtCondition);
            this.GroupBox1.Controls.Add(this.lblResults2);
            this.GroupBox1.Controls.Add(this.cbmGym);
            this.GroupBox1.Controls.Add(this.lblResults1);
            this.GroupBox1.Controls.Add(this.btnDeleteVenue);
            this.GroupBox1.Controls.Add(this.btnUpdteVenue);
            this.GroupBox1.Location = new System.Drawing.Point(348, 150);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(839, 156);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "查询场地类型";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(728, 97);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(80, 41);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "退出";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSelcetVenue
            // 
            this.btnSelcetVenue.Location = new System.Drawing.Point(728, 21);
            this.btnSelcetVenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelcetVenue.Name = "btnSelcetVenue";
            this.btnSelcetVenue.Size = new System.Drawing.Size(80, 41);
            this.btnSelcetVenue.TabIndex = 9;
            this.btnSelcetVenue.Text = "查询";
            this.btnSelcetVenue.UseVisualStyleBackColor = true;
            this.btnSelcetVenue.Click += new System.EventHandler(this.btnSelcetVenue_Click);
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(503, 75);
            this.txtCondition.Margin = new System.Windows.Forms.Padding(2);
            this.txtCondition.Multiline = true;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(102, 21);
            this.txtCondition.TabIndex = 8;
            // 
            // lblResults2
            // 
            this.lblResults2.AutoSize = true;
            this.lblResults2.Location = new System.Drawing.Point(526, 50);
            this.lblResults2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults2.Name = "lblResults2";
            this.lblResults2.Size = new System.Drawing.Size(53, 12);
            this.lblResults2.TabIndex = 7;
            this.lblResults2.Text = "查询条件";
            // 
            // cbmGym
            // 
            this.cbmGym.FormattingEnabled = true;
            this.cbmGym.Items.AddRange(new object[] {
            "场地名称"});
            this.cbmGym.Location = new System.Drawing.Point(321, 80);
            this.cbmGym.Margin = new System.Windows.Forms.Padding(2);
            this.cbmGym.Name = "cbmGym";
            this.cbmGym.Size = new System.Drawing.Size(92, 20);
            this.cbmGym.TabIndex = 6;
            this.cbmGym.Text = "场地名称";
            // 
            // lblResults1
            // 
            this.lblResults1.AutoSize = true;
            this.lblResults1.Location = new System.Drawing.Point(330, 48);
            this.lblResults1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults1.Name = "lblResults1";
            this.lblResults1.Size = new System.Drawing.Size(53, 12);
            this.lblResults1.TabIndex = 5;
            this.lblResults1.Text = "查询方式";
            // 
            // btnDeleteVenue
            // 
            this.btnDeleteVenue.Location = new System.Drawing.Point(177, 54);
            this.btnDeleteVenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteVenue.Name = "btnDeleteVenue";
            this.btnDeleteVenue.Size = new System.Drawing.Size(41, 42);
            this.btnDeleteVenue.TabIndex = 4;
            this.btnDeleteVenue.Text = "删除";
            this.btnDeleteVenue.UseVisualStyleBackColor = true;
            this.btnDeleteVenue.Click += new System.EventHandler(this.btnDeleteVenue_Click);
            // 
            // btnUpdteVenue
            // 
            this.btnUpdteVenue.Location = new System.Drawing.Point(85, 54);
            this.btnUpdteVenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdteVenue.Name = "btnUpdteVenue";
            this.btnUpdteVenue.Size = new System.Drawing.Size(41, 42);
            this.btnUpdteVenue.TabIndex = 3;
            this.btnUpdteVenue.Text = "修改";
            this.btnUpdteVenue.UseVisualStyleBackColor = true;
            this.btnUpdteVenue.Click += new System.EventHandler(this.btnUpdteVenue_Click);
            // 
            // gvwVtype
            // 
            this.gvwVtype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gvwVtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwVtype.Location = new System.Drawing.Point(482, 352);
            this.gvwVtype.Margin = new System.Windows.Forms.Padding(2);
            this.gvwVtype.Name = "gvwVtype";
            this.gvwVtype.RowTemplate.Height = 27;
            this.gvwVtype.Size = new System.Drawing.Size(598, 205);
            this.gvwVtype.TabIndex = 1;
            // 
            // SqlDataAdapter1
            // 
            this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
            this.SqlDataAdapter1.InsertCommand = this.SqlInsertCommand;
            this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
            this.SqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Vtype", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Vname", "Vname"),
                        new System.Data.Common.DataColumnMapping("INrental", "INrental"),
                        new System.Data.Common.DataColumnMapping("OUTrental", "OUTrental"),
                        new System.Data.Common.DataColumnMapping("Vaddress", "Vaddress")})});
            this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
            // 
            // SqlDeleteCommand1
            // 
            this.SqlDeleteCommand1.CommandText = "DELETE FROM [Vtype] WHERE (([Vname] = @Original_Vname) AND ([INrental] = @Origina" +
    "l_INrental) AND ([OUTrental] = @Original_OUTrental) AND ([Vaddress] = @Original_" +
    "Vaddress))";
            this.SqlDeleteCommand1.Connection = this.SqlConnection1;
            this.SqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_INrental", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "INrental", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_OUTrental", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OUTrental", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Vaddress", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vaddress", System.Data.DataRowVersion.Original, null)});
            // 
            // SqlConnection1
            // 
            this.SqlConnection1.ConnectionString = "Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=c" +
    "hangguan;";
            this.SqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // SqlInsertCommand
            // 
            this.SqlInsertCommand.CommandText = "INSERT INTO [Vtype] ([Vname], [INrental], [OUTrental], [Vaddress]) VALUES (@Vname" +
    ", @INrental, @OUTrental, @Vaddress);\r\nSELECT Vname, INrental, OUTrental, Vaddres" +
    "s FROM Vtype WHERE (Vname = @Vname)";
            this.SqlInsertCommand.Connection = this.SqlConnection1;
            this.SqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"),
            new System.Data.SqlClient.SqlParameter("@INrental", System.Data.SqlDbType.Real, 0, "INrental"),
            new System.Data.SqlClient.SqlParameter("@OUTrental", System.Data.SqlDbType.Real, 0, "OUTrental"),
            new System.Data.SqlClient.SqlParameter("@Vaddress", System.Data.SqlDbType.VarChar, 0, "Vaddress")});
            // 
            // SqlSelectCommand1
            // 
            this.SqlSelectCommand1.CommandText = "SELECT Vname,  INrental ,  OUTrental,  Vaddress FROM Vtype";
            this.SqlSelectCommand1.Connection = this.SqlConnection1;
            // 
            // SqlUpdateCommand1
            // 
            this.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText");
            this.SqlUpdateCommand1.Connection = this.SqlConnection1;
            this.SqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"),
            new System.Data.SqlClient.SqlParameter("@INrental", System.Data.SqlDbType.Real, 0, "INrental"),
            new System.Data.SqlClient.SqlParameter("@OUTrental", System.Data.SqlDbType.Real, 0, "OUTrental"),
            new System.Data.SqlClient.SqlParameter("@Vaddress", System.Data.SqlDbType.VarChar, 0, "Vaddress"),
            new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_INrental", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "INrental", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_OUTrental", System.Data.SqlDbType.Real, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "OUTrental", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Vaddress", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vaddress", System.Data.DataRowVersion.Original, null)});
            // 
            // VtypeTableAdapter
            // 
            this.VtypeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1539, 843);
            this.panel1.TabIndex = 2;
            // 
            // 查询场地类型
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.gvwVtype);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "查询场地类型";
            this.Text = "查询场地类型";
            this.Load += new System.EventHandler(this.查询场地类型_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvwVtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VtypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
		internal BindingSource VtypeBindingSource;
		internal changguanDataSet3TableAdapters.VtypeTableAdapter VtypeTableAdapter;
        private System.ComponentModel.IContainer components;
        private Panel panel1;
    }
	
}
