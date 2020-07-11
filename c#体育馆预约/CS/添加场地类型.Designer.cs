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
	partial class 添加场地类型 : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(添加场地类型));
            this.lblResults1 = new System.Windows.Forms.Label();
            this.lblResults2 = new System.Windows.Forms.Label();
            this.lblResults3 = new System.Windows.Forms.Label();
            this.lblResults4 = new System.Windows.Forms.Label();
            this.txtGymName = new System.Windows.Forms.TextBox();
            this.txtGymInrent = new System.Windows.Forms.TextBox();
            this.txtGymOutrent = new System.Windows.Forms.TextBox();
            this.txtGymAddress = new System.Windows.Forms.TextBox();
            this.btnInsertVenue = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.SqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.SqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.starttime = new System.Windows.Forms.TextBox();
            this.stoptime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangguanDataSet1 = new WindowsApp1.changguanDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.groundType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChangguanDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResults1
            // 
            this.lblResults1.AutoSize = true;
            this.lblResults1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults1.Location = new System.Drawing.Point(659, 313);
            this.lblResults1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults1.Name = "lblResults1";
            this.lblResults1.Size = new System.Drawing.Size(82, 15);
            this.lblResults1.TabIndex = 0;
            this.lblResults1.Text = "场地名称：";
            // 
            // lblResults2
            // 
            this.lblResults2.AutoSize = true;
            this.lblResults2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults2.Location = new System.Drawing.Point(629, 364);
            this.lblResults2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults2.Name = "lblResults2";
            this.lblResults2.Size = new System.Drawing.Size(112, 15);
            this.lblResults2.TabIndex = 1;
            this.lblResults2.Text = "校内人员租金：";
            // 
            // lblResults3
            // 
            this.lblResults3.AutoSize = true;
            this.lblResults3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults3.Location = new System.Drawing.Point(629, 417);
            this.lblResults3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults3.Name = "lblResults3";
            this.lblResults3.Size = new System.Drawing.Size(112, 15);
            this.lblResults3.TabIndex = 2;
            this.lblResults3.Text = "校外人员租金：";
            // 
            // lblResults4
            // 
            this.lblResults4.AutoSize = true;
            this.lblResults4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults4.Location = new System.Drawing.Point(659, 466);
            this.lblResults4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults4.Name = "lblResults4";
            this.lblResults4.Size = new System.Drawing.Size(82, 15);
            this.lblResults4.TabIndex = 3;
            this.lblResults4.Text = "场地地址：";
            this.lblResults4.Click += new System.EventHandler(this.lblResults4_Click);
            // 
            // txtGymName
            // 
            this.txtGymName.Location = new System.Drawing.Point(777, 309);
            this.txtGymName.Margin = new System.Windows.Forms.Padding(2);
            this.txtGymName.Name = "txtGymName";
            this.txtGymName.Size = new System.Drawing.Size(76, 21);
            this.txtGymName.TabIndex = 5;
            // 
            // txtGymInrent
            // 
            this.txtGymInrent.Location = new System.Drawing.Point(777, 359);
            this.txtGymInrent.Margin = new System.Windows.Forms.Padding(2);
            this.txtGymInrent.Name = "txtGymInrent";
            this.txtGymInrent.Size = new System.Drawing.Size(76, 21);
            this.txtGymInrent.TabIndex = 6;
            // 
            // txtGymOutrent
            // 
            this.txtGymOutrent.Location = new System.Drawing.Point(777, 416);
            this.txtGymOutrent.Margin = new System.Windows.Forms.Padding(2);
            this.txtGymOutrent.Name = "txtGymOutrent";
            this.txtGymOutrent.Size = new System.Drawing.Size(76, 21);
            this.txtGymOutrent.TabIndex = 7;
            // 
            // txtGymAddress
            // 
            this.txtGymAddress.Location = new System.Drawing.Point(777, 465);
            this.txtGymAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtGymAddress.Name = "txtGymAddress";
            this.txtGymAddress.Size = new System.Drawing.Size(331, 21);
            this.txtGymAddress.TabIndex = 8;
            // 
            // btnInsertVenue
            // 
            this.btnInsertVenue.Location = new System.Drawing.Point(698, 526);
            this.btnInsertVenue.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertVenue.Name = "btnInsertVenue";
            this.btnInsertVenue.Size = new System.Drawing.Size(72, 41);
            this.btnInsertVenue.TabIndex = 16;
            this.btnInsertVenue.Text = "确认添加";
            this.btnInsertVenue.Click += new System.EventHandler(this.btnInsertVenue_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(854, 526);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 41);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "取消添加";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(992, 526);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(72, 41);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "退出";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            // starttime
            // 
            this.starttime.Location = new System.Drawing.Point(1032, 359);
            this.starttime.Margin = new System.Windows.Forms.Padding(2);
            this.starttime.Name = "starttime";
            this.starttime.Size = new System.Drawing.Size(76, 21);
            this.starttime.TabIndex = 19;
            // 
            // stoptime
            // 
            this.stoptime.Location = new System.Drawing.Point(1032, 416);
            this.stoptime.Margin = new System.Windows.Forms.Padding(2);
            this.stoptime.Name = "stoptime";
            this.stoptime.Size = new System.Drawing.Size(76, 21);
            this.stoptime.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(884, 364);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "开始开放时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(884, 417);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "结束开放时间：";
            // 
            // ChangguanDataSet1
            // 
            this.ChangguanDataSet1.DataSetName = "changguanDataSet";
            this.ChangguanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(884, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "场地类型编号：";
            // 
            // groundType
            // 
            this.groundType.Location = new System.Drawing.Point(1032, 309);
            this.groundType.Margin = new System.Windows.Forms.Padding(2);
            this.groundType.Name = "groundType";
            this.groundType.Size = new System.Drawing.Size(76, 21);
            this.groundType.TabIndex = 24;
            // 
            // 添加场地类型
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.groundType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stoptime);
            this.Controls.Add(this.starttime);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsertVenue);
            this.Controls.Add(this.txtGymAddress);
            this.Controls.Add(this.txtGymOutrent);
            this.Controls.Add(this.txtGymInrent);
            this.Controls.Add(this.txtGymName);
            this.Controls.Add(this.lblResults4);
            this.Controls.Add(this.lblResults3);
            this.Controls.Add(this.lblResults2);
            this.Controls.Add(this.lblResults1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "添加场地类型";
            this.Text = "添加场地类型";
            this.Load += new System.EventHandler(this.添加场地类型_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChangguanDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		internal Label lblResults1;
		internal Label lblResults2;
		internal Label lblResults3;
		internal Label lblResults4;
		internal TextBox txtGymName;
		internal TextBox txtGymInrent;
		internal TextBox txtGymOutrent;
		internal TextBox txtGymAddress;
		internal Button btnInsertVenue;
		internal Button btnCancel;
		internal Button btnReturn;
		internal System.Data.SqlClient.SqlDataAdapter SqlDataAdapter1;
		internal System.Data.SqlClient.SqlCommand SqlDeleteCommand1;
		internal System.Data.SqlClient.SqlConnection SqlConnection1;
		internal System.Data.SqlClient.SqlCommand SqlInsertCommand;
		internal System.Data.SqlClient.SqlCommand SqlSelectCommand1;
		internal System.Data.SqlClient.SqlCommand SqlUpdateCommand1;
		internal changguanDataSet ChangguanDataSet1;
        internal TextBox starttime;
        internal TextBox stoptime;
        internal Label label1;
        internal Label label2;
        internal Label label3;
        internal TextBox groundType;
    }
	
}
