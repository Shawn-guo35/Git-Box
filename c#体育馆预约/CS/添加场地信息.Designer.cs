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
	partial class 添加场地信息 : System.Windows.Forms.Form
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
            this.lblResults1 = new System.Windows.Forms.Label();
            this.lblResults2 = new System.Windows.Forms.Label();
            this.txtGymName = new System.Windows.Forms.TextBox();
            this.txtGymNum = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsertVtype = new System.Windows.Forms.Button();
            this.SqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.SqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.SqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.ChangguanDataSet1 = new WindowsApp1.changguanDataSet();
            this.lblResults3 = new System.Windows.Forms.Label();
            this.txtGymTypeID = new System.Windows.Forms.TextBox();
            this.lblResults4 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ChangguanDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResults1
            // 
            this.lblResults1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResults1.AutoSize = true;
            this.lblResults1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults1.Location = new System.Drawing.Point(738, 206);
            this.lblResults1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults1.Name = "lblResults1";
            this.lblResults1.Size = new System.Drawing.Size(82, 15);
            this.lblResults1.TabIndex = 0;
            this.lblResults1.Text = "场地名称：";
            // 
            // lblResults2
            // 
            this.lblResults2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResults2.AutoSize = true;
            this.lblResults2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults2.Location = new System.Drawing.Point(738, 258);
            this.lblResults2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults2.Name = "lblResults2";
            this.lblResults2.Size = new System.Drawing.Size(82, 15);
            this.lblResults2.TabIndex = 1;
            this.lblResults2.Text = "场地编号：";
            this.lblResults2.Click += new System.EventHandler(this.lblResults2_Click);
            // 
            // txtGymName
            // 
            this.txtGymName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGymName.Location = new System.Drawing.Point(856, 204);
            this.txtGymName.Margin = new System.Windows.Forms.Padding(2);
            this.txtGymName.Name = "txtGymName";
            this.txtGymName.Size = new System.Drawing.Size(100, 21);
            this.txtGymName.TabIndex = 2;
            // 
            // txtGymNum
            // 
            this.txtGymNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGymNum.Location = new System.Drawing.Point(856, 258);
            this.txtGymNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtGymNum.Name = "txtGymNum";
            this.txtGymNum.Size = new System.Drawing.Size(100, 21);
            this.txtGymNum.TabIndex = 3;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturn.Location = new System.Drawing.Point(915, 457);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(72, 41);
            this.btnReturn.TabIndex = 21;
            this.btnReturn.Text = "退出";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Location = new System.Drawing.Point(809, 457);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 41);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "取消添加";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsertVtype
            // 
            this.btnInsertVtype.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsertVtype.Location = new System.Drawing.Point(698, 457);
            this.btnInsertVtype.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertVtype.Name = "btnInsertVtype";
            this.btnInsertVtype.Size = new System.Drawing.Size(72, 41);
            this.btnInsertVtype.TabIndex = 19;
            this.btnInsertVtype.Text = "确认添加";
            this.btnInsertVtype.Click += new System.EventHandler(this.btnInsertVtype_Click);
            // 
            // SqlDataAdapter1
            // 
            this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
            this.SqlDataAdapter1.InsertCommand = this.SqlInsertCommand;
            this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
            this.SqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Venue", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Vname", "Vname"),
                        new System.Data.Common.DataColumnMapping("Vno", "Vno")})});
            this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
            // 
            // SqlDeleteCommand1
            // 
            this.SqlDeleteCommand1.CommandText = "DELETE FROM [Venue] WHERE (([Vname] = @Original_Vname) AND ([Vno] = @Original_Vno" +
    "))";
            this.SqlDeleteCommand1.Connection = this.SqlConnection1;
            this.SqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vno", System.Data.DataRowVersion.Original, null)});
            // 
            // SqlConnection1
            // 
            this.SqlConnection1.ConnectionString = "Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=c" +
    "hangguan;";
            this.SqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // SqlInsertCommand
            // 
            this.SqlInsertCommand.CommandText = "INSERT INTO [Venue] ([Vname], [Vno]) VALUES (@Vname, @Vno);\r\nSELECT Vname, Vno FR" +
    "OM Venue WHERE (Vname = @Vname) AND (Vno = @Vno)";
            this.SqlInsertCommand.Connection = this.SqlConnection1;
            this.SqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"),
            new System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno")});
            // 
            // SqlSelectCommand1
            // 
            this.SqlSelectCommand1.CommandText = "SELECT    Vname, Vno  FROM  Venue";
            this.SqlSelectCommand1.Connection = this.SqlConnection1;
            // 
            // SqlUpdateCommand1
            // 
            this.SqlUpdateCommand1.CommandText = "UPDATE [Venue] SET [Vname] = @Vname, [Vno] = @Vno WHERE (([Vname] = @Original_Vna" +
    "me) AND ([Vno] = @Original_Vno));\r\nSELECT Vname, Vno FROM Venue WHERE (Vname = @" +
    "Vname) AND (Vno = @Vno)";
            this.SqlUpdateCommand1.Connection = this.SqlConnection1;
            this.SqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"),
            new System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno"),
            new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vno", System.Data.DataRowVersion.Original, null)});
            // 
            // ChangguanDataSet1
            // 
            this.ChangguanDataSet1.DataSetName = "changguanDataSet";
            this.ChangguanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblResults3
            // 
            this.lblResults3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResults3.AutoSize = true;
            this.lblResults3.Font = new System.Drawing.Font("宋体", 10.8F);
            this.lblResults3.Location = new System.Drawing.Point(738, 310);
            this.lblResults3.Name = "lblResults3";
            this.lblResults3.Size = new System.Drawing.Size(112, 15);
            this.lblResults3.TabIndex = 22;
            this.lblResults3.Text = "场地类型编号：";
            // 
            // txtGymTypeID
            // 
            this.txtGymTypeID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGymTypeID.Location = new System.Drawing.Point(856, 310);
            this.txtGymTypeID.Name = "txtGymTypeID";
            this.txtGymTypeID.Size = new System.Drawing.Size(100, 21);
            this.txtGymTypeID.TabIndex = 23;
            // 
            // lblResults4
            // 
            this.lblResults4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResults4.AutoSize = true;
            this.lblResults4.Font = new System.Drawing.Font("宋体", 10.8F);
            this.lblResults4.Location = new System.Drawing.Point(738, 357);
            this.lblResults4.Name = "lblResults4";
            this.lblResults4.Size = new System.Drawing.Size(82, 15);
            this.lblResults4.TabIndex = 24;
            this.lblResults4.Text = "场地状态：";
            // 
            // txtState
            // 
            this.txtState.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtState.Location = new System.Drawing.Point(856, 351);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 21);
            this.txtState.TabIndex = 25;
            // 
            // 添加场地信息
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblResults4);
            this.Controls.Add(this.txtGymTypeID);
            this.Controls.Add(this.lblResults3);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsertVtype);
            this.Controls.Add(this.txtGymNum);
            this.Controls.Add(this.txtGymName);
            this.Controls.Add(this.lblResults2);
            this.Controls.Add(this.lblResults1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "添加场地信息";
            this.Text = "添加场地信息";
            this.Load += new System.EventHandler(this.添加场地信息_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChangguanDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		internal Label lblResults1;
		internal Label lblResults2;
		internal TextBox txtGymName;
		internal TextBox txtGymNum;
		internal Button btnReturn;
		internal Button btnCancel;
		internal Button btnInsertVtype;
		internal System.Data.SqlClient.SqlDataAdapter SqlDataAdapter1;
		internal System.Data.SqlClient.SqlCommand SqlDeleteCommand1;
		internal System.Data.SqlClient.SqlCommand SqlInsertCommand;
		internal System.Data.SqlClient.SqlCommand SqlSelectCommand1;
		internal System.Data.SqlClient.SqlCommand SqlUpdateCommand1;
		internal System.Data.SqlClient.SqlConnection SqlConnection1;
		internal changguanDataSet ChangguanDataSet1;
        private Label lblResults3;
        private TextBox txtGymTypeID;
        private Label lblResults4;
        private TextBox txtState;
    }
	
}
