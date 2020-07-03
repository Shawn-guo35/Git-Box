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
			this.Label5 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(Form2_Load);
			this.cmbYear = new System.Windows.Forms.ComboBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.cmbDay = new System.Windows.Forms.ComboBox();
			this.cmbMon = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			this.btnSelIncome = new System.Windows.Forms.Button();
			this.btnSelIncome.Click += new System.EventHandler(this.btnSelIncome_Click);
			this.txtYearSum = new System.Windows.Forms.TextBox();
			this.txtMonSum = new System.Windows.Forms.TextBox();
			this.txtDaySum = new System.Windows.Forms.TextBox();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.OleDbCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(219, 54);
			this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(89, 12);
			this.Label5.TabIndex = 27;
			this.Label5.Text = "（三项都要选）";
			//
			//cmbYear
			//
			this.cmbYear.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.cmbYear.FormattingEnabled = true;
			this.cmbYear.Items.AddRange(new object[] {"1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月"});
			this.cmbYear.Location = new System.Drawing.Point(111, 231);
			this.cmbYear.Margin = new System.Windows.Forms.Padding(2);
			this.cmbYear.Name = "cmbYear";
			this.cmbYear.Size = new System.Drawing.Size(63, 24);
			this.cmbYear.TabIndex = 26;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("宋体", (float) (24.0F));
			this.Label4.Location = new System.Drawing.Point(87, 37);
			this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(143, 33);
			this.Label4.TabIndex = 25;
			this.Label4.Text = "收益统计";
			//
			//cmbDay
			//
			this.cmbDay.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.cmbDay.FormattingEnabled = true;
			this.cmbDay.Items.AddRange(new object[] {"1号", "2号", "3号", "4号", "5号", "6号", "7号", "8号", "9号", "10号", "11号", "12号", "13号", "14号", "15号", "16号", "17号", "18号", "19号", "20号", "21号", "22号", "23号", "24号", "25号", "26号", "27号", "28号", "29号", "30号", "31号"});
			this.cmbDay.Location = new System.Drawing.Point(111, 101);
			this.cmbDay.Margin = new System.Windows.Forms.Padding(2);
			this.cmbDay.Name = "cmbDay";
			this.cmbDay.Size = new System.Drawing.Size(63, 24);
			this.cmbDay.TabIndex = 24;
			//
			//cmbMon
			//
			this.cmbMon.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.cmbMon.FormattingEnabled = true;
			this.cmbMon.Items.AddRange(new object[] {"1月", "2月", "3月", "4月", "5月", "6月", "7月", "8月", "9月", "10月", "11月", "12月"});
			this.cmbMon.Location = new System.Drawing.Point(111, 164);
			this.cmbMon.Margin = new System.Windows.Forms.Padding(2);
			this.cmbMon.Name = "cmbMon";
			this.cmbMon.Size = new System.Drawing.Size(63, 24);
			this.cmbMon.TabIndex = 23;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.Label3.Location = new System.Drawing.Point(27, 168);
			this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(56, 16);
			this.Label3.TabIndex = 22;
			this.Label3.Text = "月收益";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.Label2.Location = new System.Drawing.Point(27, 235);
			this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(56, 16);
			this.Label2.TabIndex = 21;
			this.Label2.Text = "年收益";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.Label1.Location = new System.Drawing.Point(27, 106);
			this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(56, 16);
			this.Label1.TabIndex = 20;
			this.Label1.Text = "日收益";
			//
			//btnReturn
			//
			this.btnReturn.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.btnReturn.Location = new System.Drawing.Point(308, 306);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(56, 26);
			this.btnReturn.TabIndex = 19;
			this.btnReturn.Text = "返回";
			this.btnReturn.UseVisualStyleBackColor = true;
			//
			//btnSelIncome
			//
			this.btnSelIncome.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.btnSelIncome.Location = new System.Drawing.Point(186, 306);
			this.btnSelIncome.Margin = new System.Windows.Forms.Padding(2);
			this.btnSelIncome.Name = "btnSelIncome";
			this.btnSelIncome.Size = new System.Drawing.Size(56, 26);
			this.btnSelIncome.TabIndex = 18;
			this.btnSelIncome.Text = "查询";
			this.btnSelIncome.UseVisualStyleBackColor = true;
			//
			//txtYearSum
			//
			this.txtYearSum.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.txtYearSum.Location = new System.Drawing.Point(184, 231);
			this.txtYearSum.Margin = new System.Windows.Forms.Padding(2);
			this.txtYearSum.Name = "txtYearSum";
			this.txtYearSum.Size = new System.Drawing.Size(76, 26);
			this.txtYearSum.TabIndex = 17;
			//
			//txtMonSum
			//
			this.txtMonSum.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.txtMonSum.Location = new System.Drawing.Point(184, 164);
			this.txtMonSum.Margin = new System.Windows.Forms.Padding(2);
			this.txtMonSum.Name = "txtMonSum";
			this.txtMonSum.Size = new System.Drawing.Size(76, 26);
			this.txtMonSum.TabIndex = 16;
			//
			//txtDaySum
			//
			this.txtDaySum.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.txtDaySum.Location = new System.Drawing.Point(184, 101);
			this.txtDaySum.Margin = new System.Windows.Forms.Padding(2);
			this.txtDaySum.Name = "txtDaySum";
			this.txtDaySum.Size = new System.Drawing.Size(76, 26);
			this.txtDaySum.TabIndex = 15;
			//
			//DataGridView1
			//
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(308, 29);
			this.DataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.RowTemplate.Height = 27;
			this.DataGridView1.Size = new System.Drawing.Size(266, 230);
			this.DataGridView1.TabIndex = 14;
			//
			//OleDbConnection1
			//
			this.OleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSP" +
				"I;Initial Catalog=changguan";
			//
			//OleDbDataAdapter1
			//
			this.OleDbDataAdapter1.DeleteCommand = this.OleDbDeleteCommand1;
			this.OleDbDataAdapter1.InsertCommand = this.OleDbInsertCommand1;
			this.OleDbDataAdapter1.SelectCommand = this.OleDbSelectCommand1;
			this.OleDbDataAdapter1.UpdateCommand = this.OleDbUpdateCommand1;
			//
			//收入统计
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (12.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 360);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.cmbYear);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.cmbDay);
			this.Controls.Add(this.cmbMon);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnSelIncome);
			this.Controls.Add(this.txtYearSum);
			this.Controls.Add(this.txtMonSum);
			this.Controls.Add(this.txtDaySum);
			this.Controls.Add(this.DataGridView1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "收入统计";
			this.Text = "收入统计";
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Label Label5;
		internal ComboBox cmbYear;
		internal Label Label4;
		internal ComboBox cmbDay;
		internal ComboBox cmbMon;
		internal Label Label3;
		internal Label Label2;
		internal Label Label1;
		internal Button btnReturn;
		internal Button btnSelIncome;
		internal TextBox txtYearSum;
		internal TextBox txtMonSum;
		internal TextBox txtDaySum;
		internal DataGridView DataGridView1;
		internal System.Data.OleDb.OleDbCommand OleDbCommand1;
		internal System.Data.OleDb.OleDbConnection OleDbConnection1;
		internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbInsertCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand1;
		internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;
	}
	
}
