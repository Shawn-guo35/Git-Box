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
		
		//注意: 以下过程是 Windows 窗体设计器所必需的
		//可以使用 Windows 窗体设计器修改它。
		//不要使用代码编辑器修改它。
		[System.Diagnostics.DebuggerStepThrough()]
			private void InitializeComponent()
			{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(查询场地租借情况));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResults14 = new System.Windows.Forms.Label();
            this.lblResults13 = new System.Windows.Forms.Label();
            this.txtGymNum = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSelectLease = new System.Windows.Forms.Button();
            this.txtGymName = new System.Windows.Forms.TextBox();
            this.cbmGym = new System.Windows.Forms.ComboBox();
            this.lblResults2 = new System.Windows.Forms.Label();
            this.lblResults1 = new System.Windows.Forms.Label();
            this.txtGymLease = new System.Windows.Forms.DataGridView();
            this.LeaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ChangguanDataSet6 = new WindowsApp1.changguanDataSet6();
            this.SqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.SqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.SqlInsertCommand = new System.Data.SqlClient.SqlCommand();
            this.SqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.SqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.ChangguanDataSet1 = new WindowsApp1.changguanDataSet();
            this.LeaseTableAdapter = new WindowsApp1.changguanDataSet6TableAdapters.LeaseTableAdapter();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGymLease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangguanDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangguanDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GroupBox1.Controls.Add(this.lblResults14);
            this.GroupBox1.Controls.Add(this.lblResults13);
            this.GroupBox1.Controls.Add(this.txtGymNum);
            this.GroupBox1.Controls.Add(this.btnReturn);
            this.GroupBox1.Controls.Add(this.btnSelectLease);
            this.GroupBox1.Controls.Add(this.txtGymName);
            this.GroupBox1.Controls.Add(this.cbmGym);
            this.GroupBox1.Controls.Add(this.lblResults2);
            this.GroupBox1.Controls.Add(this.lblResults1);
            this.GroupBox1.Location = new System.Drawing.Point(473, 149);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(796, 172);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "查询场地租借情况";
            // 
            // lblResults14
            // 
            this.lblResults14.AutoSize = true;
            this.lblResults14.Location = new System.Drawing.Point(423, 112);
            this.lblResults14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults14.Name = "lblResults14";
            this.lblResults14.Size = new System.Drawing.Size(53, 12);
            this.lblResults14.TabIndex = 31;
            this.lblResults14.Text = "场地编号";
            this.lblResults14.Visible = false;
            // 
            // lblResults13
            // 
            this.lblResults13.AutoSize = true;
            this.lblResults13.Location = new System.Drawing.Point(423, 67);
            this.lblResults13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults13.Name = "lblResults13";
            this.lblResults13.Size = new System.Drawing.Size(53, 12);
            this.lblResults13.TabIndex = 30;
            this.lblResults13.Text = "场地名称";
            // 
            // txtGymNum
            // 
            this.txtGymNum.Location = new System.Drawing.Point(492, 112);
            this.txtGymNum.Margin = new System.Windows.Forms.Padding(2);
            this.txtGymNum.Name = "txtGymNum";
            this.txtGymNum.Size = new System.Drawing.Size(105, 21);
            this.txtGymNum.TabIndex = 29;
            this.txtGymNum.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(684, 112);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(80, 41);
            this.btnReturn.TabIndex = 28;
            this.btnReturn.Text = "退出";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSelectLease
            // 
            this.btnSelectLease.Location = new System.Drawing.Point(684, 30);
            this.btnSelectLease.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectLease.Name = "btnSelectLease";
            this.btnSelectLease.Size = new System.Drawing.Size(80, 41);
            this.btnSelectLease.TabIndex = 27;
            this.btnSelectLease.Text = "查询";
            this.btnSelectLease.UseVisualStyleBackColor = true;
            this.btnSelectLease.Click += new System.EventHandler(this.btnSelectLease_Click);
            // 
            // txtGymName
            // 
            this.txtGymName.Location = new System.Drawing.Point(492, 65);
            this.txtGymName.Margin = new System.Windows.Forms.Padding(2);
            this.txtGymName.Name = "txtGymName";
            this.txtGymName.Size = new System.Drawing.Size(105, 21);
            this.txtGymName.TabIndex = 26;
            // 
            // cbmGym
            // 
            this.cbmGym.FormattingEnabled = true;
            this.cbmGym.Items.AddRange(new object[] {
            "场地名称",
            "场地名称&场地编号"});
            this.cbmGym.Location = new System.Drawing.Point(164, 67);
            this.cbmGym.Margin = new System.Windows.Forms.Padding(2);
            this.cbmGym.Name = "cbmGym";
            this.cbmGym.Size = new System.Drawing.Size(144, 20);
            this.cbmGym.TabIndex = 25;
            this.cbmGym.Text = "场地名称";
            this.cbmGym.SelectedIndexChanged += new System.EventHandler(this.cbmGym_SelectedIndexChanged);
            // 
            // lblResults2
            // 
            this.lblResults2.Location = new System.Drawing.Point(346, 65);
            this.lblResults2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults2.Name = "lblResults2";
            this.lblResults2.Size = new System.Drawing.Size(72, 16);
            this.lblResults2.TabIndex = 24;
            this.lblResults2.Text = "查询条件：";
            // 
            // lblResults1
            // 
            this.lblResults1.Location = new System.Drawing.Point(18, 70);
            this.lblResults1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults1.Name = "lblResults1";
            this.lblResults1.Size = new System.Drawing.Size(72, 16);
            this.lblResults1.TabIndex = 23;
            this.lblResults1.Text = "查询方式：";
            // 
            // txtGymLease
            // 
            this.txtGymLease.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGymLease.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txtGymLease.Location = new System.Drawing.Point(564, 373);
            this.txtGymLease.Margin = new System.Windows.Forms.Padding(2);
            this.txtGymLease.Name = "txtGymLease";
            this.txtGymLease.ReadOnly = true;
            this.txtGymLease.RowTemplate.Height = 27;
            this.txtGymLease.Size = new System.Drawing.Size(598, 194);
            this.txtGymLease.TabIndex = 1;
            // 
            // LeaseBindingSource
            // 
            this.LeaseBindingSource.DataMember = "Lease";
            this.LeaseBindingSource.DataSource = this.ChangguanDataSet6;
            // 
            // ChangguanDataSet6
            // 
            this.ChangguanDataSet6.DataSetName = "changguanDataSet6";
            this.ChangguanDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SqlDataAdapter1
            // 
            this.SqlDataAdapter1.DeleteCommand = this.SqlDeleteCommand1;
            this.SqlDataAdapter1.InsertCommand = this.SqlInsertCommand;
            this.SqlDataAdapter1.SelectCommand = this.SqlSelectCommand1;
            this.SqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Lease", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Vname", "Vname"),
                        new System.Data.Common.DataColumnMapping("Vno", "Vno"),
                        new System.Data.Common.DataColumnMapping("Stime", "Stime"),
                        new System.Data.Common.DataColumnMapping("Etime", "Etime"),
                        new System.Data.Common.DataColumnMapping("Condition", "Condition")})});
            this.SqlDataAdapter1.UpdateCommand = this.SqlUpdateCommand1;
            // 
            // SqlDeleteCommand1
            // 
            this.SqlDeleteCommand1.CommandText = "DELETE FROM [Lease] WHERE (([Vname] = @Original_Vname) AND ([Vno] = @Original_Vno" +
    ") AND ([Stime] = @Original_Stime) AND ([Etime] = @Original_Etime) AND ([Conditio" +
    "n] = @Original_Condition))";
            this.SqlDeleteCommand1.Connection = this.SqlConnection1;
            this.SqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vno", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Stime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Stime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Etime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Etime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Condition", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Condition", System.Data.DataRowVersion.Original, null)});
            // 
            // SqlConnection1
            // 
            this.SqlConnection1.ConnectionString = "Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=c" +
    "hangguan;";
            this.SqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // SqlInsertCommand
            // 
            this.SqlInsertCommand.CommandText = resources.GetString("SqlInsertCommand.CommandText");
            this.SqlInsertCommand.Connection = this.SqlConnection1;
            this.SqlInsertCommand.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"),
            new System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno"),
            new System.Data.SqlClient.SqlParameter("@Stime", System.Data.SqlDbType.DateTime, 0, "Stime"),
            new System.Data.SqlClient.SqlParameter("@Etime", System.Data.SqlDbType.DateTime, 0, "Etime"),
            new System.Data.SqlClient.SqlParameter("@Condition", System.Data.SqlDbType.VarChar, 0, "Condition")});
            // 
            // SqlSelectCommand1
            // 
            this.SqlSelectCommand1.CommandText = "SELECT Vname, Vno, Stime,  Etime,  Condition FROM Lease";
            this.SqlSelectCommand1.Connection = this.SqlConnection1;
            // 
            // SqlUpdateCommand1
            // 
            this.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText");
            this.SqlUpdateCommand1.Connection = this.SqlConnection1;
            this.SqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Vname", System.Data.SqlDbType.VarChar, 0, "Vname"),
            new System.Data.SqlClient.SqlParameter("@Vno", System.Data.SqlDbType.VarChar, 0, "Vno"),
            new System.Data.SqlClient.SqlParameter("@Stime", System.Data.SqlDbType.DateTime, 0, "Stime"),
            new System.Data.SqlClient.SqlParameter("@Etime", System.Data.SqlDbType.DateTime, 0, "Etime"),
            new System.Data.SqlClient.SqlParameter("@Condition", System.Data.SqlDbType.VarChar, 0, "Condition"),
            new System.Data.SqlClient.SqlParameter("@Original_Vname", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vname", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Vno", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Vno", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Stime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Stime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Etime", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Etime", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Condition", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Condition", System.Data.DataRowVersion.Original, null)});
            // 
            // ChangguanDataSet1
            // 
            this.ChangguanDataSet1.DataSetName = "changguanDataSet";
            this.ChangguanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LeaseTableAdapter
            // 
            this.LeaseTableAdapter.ClearBeforeFill = true;
            // 
            // 查询场地租借情况
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.txtGymLease);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "查询场地租借情况";
            this.Text = "查询场地租借情况";
            this.Load += new System.EventHandler(this.场地管理系统_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGymLease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangguanDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChangguanDataSet1)).EndInit();
            this.ResumeLayout(false);

		}
		
		internal GroupBox GroupBox1;
		internal Label lblResults2;
		internal Label lblResults1;
		internal TextBox txtGymName;
		internal ComboBox cbmGym;
		internal Button btnSelectLease;
		internal Button btnReturn;
		internal DataGridView txtGymLease;
		internal System.Data.SqlClient.SqlDataAdapter SqlDataAdapter1;
		internal System.Data.SqlClient.SqlCommand SqlDeleteCommand1;
		internal System.Data.SqlClient.SqlConnection SqlConnection1;
		internal System.Data.SqlClient.SqlCommand SqlInsertCommand;
		internal System.Data.SqlClient.SqlCommand SqlSelectCommand1;
		internal System.Data.SqlClient.SqlCommand SqlUpdateCommand1;
		internal TextBox txtGymNum;
		internal Label lblResults14;
		internal Label lblResults13;
		internal changguanDataSet ChangguanDataSet1;
		internal changguanDataSet6 ChangguanDataSet6;
		internal BindingSource LeaseBindingSource;
		internal changguanDataSet6TableAdapters.LeaseTableAdapter LeaseTableAdapter;
        private System.ComponentModel.IContainer components;
    }
	
}
