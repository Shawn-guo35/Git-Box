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
	partial class 收入统计 : System.Windows.Forms.Form
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
            this.lblResults5 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblResults4 = new System.Windows.Forms.Label();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.cmbMon = new System.Windows.Forms.ComboBox();
            this.lblResults3 = new System.Windows.Forms.Label();
            this.lblResults2 = new System.Windows.Forms.Label();
            this.lblResults1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSelIncome = new System.Windows.Forms.Button();
            this.txtYearSum = new System.Windows.Forms.TextBox();
            this.txtMonSum = new System.Windows.Forms.TextBox();
            this.txtDaySum = new System.Windows.Forms.TextBox();
            this.dgwIncome = new System.Windows.Forms.DataGridView();
            this.OleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResults5
            // 
            this.lblResults5.AutoSize = true;
            this.lblResults5.Location = new System.Drawing.Point(510, 241);
            this.lblResults5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults5.Name = "lblResults5";
            this.lblResults5.Size = new System.Drawing.Size(89, 12);
            this.lblResults5.TabIndex = 27;
            this.lblResults5.Text = "（三项都要选）";
            // 
            // cmbYear
            // 
            this.cmbYear.Font = new System.Drawing.Font("宋体", 24F);
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "1月",
            "2月",
            "3月",
            "4月",
            "5月",
            "6月",
            "7月",
            "8月",
            "9月",
            "10月",
            "11月",
            "12月"});
            this.cmbYear.Location = new System.Drawing.Point(512, 420);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(63, 41);
            this.cmbYear.TabIndex = 26;
            // 
            // lblResults4
            // 
            this.lblResults4.AutoSize = true;
            this.lblResults4.Font = new System.Drawing.Font("宋体", 48F);
            this.lblResults4.Location = new System.Drawing.Point(726, 63);
            this.lblResults4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults4.Name = "lblResults4";
            this.lblResults4.Size = new System.Drawing.Size(284, 64);
            this.lblResults4.TabIndex = 25;
            this.lblResults4.Text = "收益统计";
            // 
            // cmbDay
            // 
            this.cmbDay.Font = new System.Drawing.Font("宋体", 24F);
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "1号",
            "2号",
            "3号",
            "4号",
            "5号",
            "6号",
            "7号",
            "8号",
            "9号",
            "10号",
            "11号",
            "12号",
            "13号",
            "14号",
            "15号",
            "16号",
            "17号",
            "18号",
            "19号",
            "20号",
            "21号",
            "22号",
            "23号",
            "24号",
            "25号",
            "26号",
            "27号",
            "28号",
            "29号",
            "30号",
            "31号"});
            this.cmbDay.Location = new System.Drawing.Point(512, 286);
            this.cmbDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(63, 41);
            this.cmbDay.TabIndex = 24;
            // 
            // cmbMon
            // 
            this.cmbMon.Font = new System.Drawing.Font("宋体", 24F);
            this.cmbMon.FormattingEnabled = true;
            this.cmbMon.Items.AddRange(new object[] {
            "1月",
            "2月",
            "3月",
            "4月",
            "5月",
            "6月",
            "7月",
            "8月",
            "9月",
            "10月",
            "11月",
            "12月"});
            this.cmbMon.Location = new System.Drawing.Point(512, 353);
            this.cmbMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMon.Name = "cmbMon";
            this.cmbMon.Size = new System.Drawing.Size(63, 41);
            this.cmbMon.TabIndex = 23;
            // 
            // lblResults3
            // 
            this.lblResults3.AutoSize = true;
            this.lblResults3.Font = new System.Drawing.Font("宋体", 24F);
            this.lblResults3.Location = new System.Drawing.Point(373, 356);
            this.lblResults3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults3.Name = "lblResults3";
            this.lblResults3.Size = new System.Drawing.Size(111, 33);
            this.lblResults3.TabIndex = 22;
            this.lblResults3.Text = "月收益";
            // 
            // lblResults2
            // 
            this.lblResults2.AutoSize = true;
            this.lblResults2.Font = new System.Drawing.Font("宋体", 24F);
            this.lblResults2.Location = new System.Drawing.Point(373, 423);
            this.lblResults2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults2.Name = "lblResults2";
            this.lblResults2.Size = new System.Drawing.Size(111, 33);
            this.lblResults2.TabIndex = 21;
            this.lblResults2.Text = "年收益";
            // 
            // lblResults1
            // 
            this.lblResults1.AutoSize = true;
            this.lblResults1.Font = new System.Drawing.Font("宋体", 24F);
            this.lblResults1.Location = new System.Drawing.Point(373, 286);
            this.lblResults1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults1.Name = "lblResults1";
            this.lblResults1.Size = new System.Drawing.Size(111, 33);
            this.lblResults1.TabIndex = 20;
            this.lblResults1.Text = "日收益";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("宋体", 24F);
            this.btnReturn.Location = new System.Drawing.Point(583, 512);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(95, 44);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSelIncome
            // 
            this.btnSelIncome.Font = new System.Drawing.Font("宋体", 24F);
            this.btnSelIncome.Location = new System.Drawing.Point(414, 512);
            this.btnSelIncome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelIncome.Name = "btnSelIncome";
            this.btnSelIncome.Size = new System.Drawing.Size(95, 44);
            this.btnSelIncome.TabIndex = 18;
            this.btnSelIncome.Text = "查询";
            this.btnSelIncome.UseVisualStyleBackColor = true;
            this.btnSelIncome.Click += new System.EventHandler(this.btnSelIncome_Click);
            // 
            // txtYearSum
            // 
            this.txtYearSum.Font = new System.Drawing.Font("宋体", 24F);
            this.txtYearSum.Location = new System.Drawing.Point(585, 420);
            this.txtYearSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtYearSum.Name = "txtYearSum";
            this.txtYearSum.Size = new System.Drawing.Size(93, 44);
            this.txtYearSum.TabIndex = 17;
            // 
            // txtMonSum
            // 
            this.txtMonSum.Font = new System.Drawing.Font("宋体", 24F);
            this.txtMonSum.Location = new System.Drawing.Point(585, 353);
            this.txtMonSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMonSum.Name = "txtMonSum";
            this.txtMonSum.Size = new System.Drawing.Size(93, 44);
            this.txtMonSum.TabIndex = 16;
            // 
            // txtDaySum
            // 
            this.txtDaySum.Font = new System.Drawing.Font("宋体", 24F);
            this.txtDaySum.Location = new System.Drawing.Point(585, 286);
            this.txtDaySum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDaySum.Name = "txtDaySum";
            this.txtDaySum.Size = new System.Drawing.Size(93, 44);
            this.txtDaySum.TabIndex = 15;
            // 
            // dgwIncome
            // 
            this.dgwIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIncome.Location = new System.Drawing.Point(737, 228);
            this.dgwIncome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgwIncome.Name = "dgwIncome";
            this.dgwIncome.RowTemplate.Height = 27;
            this.dgwIncome.Size = new System.Drawing.Size(714, 410);
            this.dgwIncome.TabIndex = 14;
            // 
            // OleDbConnection1
            // 
            this.OleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSP" +
    "I;Initial Catalog=changguan";
            // 
            // OleDbDataAdapter1
            // 
            this.OleDbDataAdapter1.DeleteCommand = this.OleDbDeleteCommand1;
            this.OleDbDataAdapter1.InsertCommand = this.OleDbInsertCommand1;
            this.OleDbDataAdapter1.SelectCommand = this.OleDbSelectCommand1;
            this.OleDbDataAdapter1.UpdateCommand = this.OleDbUpdateCommand1;
            // 
            // 收入统计
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.lblResults5);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblResults4);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.cmbMon);
            this.Controls.Add(this.lblResults3);
            this.Controls.Add(this.lblResults2);
            this.Controls.Add(this.lblResults1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSelIncome);
            this.Controls.Add(this.txtYearSum);
            this.Controls.Add(this.txtMonSum);
            this.Controls.Add(this.txtDaySum);
            this.Controls.Add(this.dgwIncome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "收入统计";
            this.Text = "收入统计";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		internal Label lblResults5;
		internal ComboBox cmbYear;
		internal Label lblResults4;
		internal ComboBox cmbDay;
		internal ComboBox cmbMon;
		internal Label lblResults3;
		internal Label lblResults2;
		internal Label lblResults1;
		internal Button btnReturn;
		internal Button btnSelIncome;
		internal TextBox txtYearSum;
		internal TextBox txtMonSum;
		internal TextBox txtDaySum;
		internal DataGridView dgwIncome;
		internal System.Data.OleDb.OleDbCommand OleDbCommand1;
		internal System.Data.OleDb.OleDbConnection OleDbConnection1;
		internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbInsertCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand1;
		internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;
	}
	
}
