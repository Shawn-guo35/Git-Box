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
		public partial class 订单查询 : System.Windows.Forms.Form
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
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			base.Load += new System.EventHandler(Form1_Load);
			this.txtOrderNo = new System.Windows.Forms.TextBox();
			this.btnSelect = new System.Windows.Forms.Button();
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			this.lblResults1 = new System.Windows.Forms.Label();
			this.lblResults2 = new System.Windows.Forms.Label();
			this.lblResults3 = new System.Windows.Forms.Label();
			this.lblResults4 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtStime = new System.Windows.Forms.TextBox();
			this.lblResults5 = new System.Windows.Forms.Label();
			this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.OleDbCommand1 = new System.Data.OleDb.OleDbCommand();
			this.cmbPlaceName = new System.Windows.Forms.ComboBox();
			this.cmbPlaceNo = new System.Windows.Forms.ComboBox();
			this.lblResults7 = new System.Windows.Forms.Label();
			this.lblResults6 = new System.Windows.Forms.Label();
			this.btnSelOrder = new System.Windows.Forms.Button();
			this.btnSelOrder.Click += new System.EventHandler(this.btnSelOrder_Click);
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//DataGridView1
			//
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(16, 52);
			this.DataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.RowTemplate.Height = 27;
			this.DataGridView1.Size = new System.Drawing.Size(799, 182);
			this.DataGridView1.TabIndex = 0;
			//
			//txtOrderNo
			//
			this.txtOrderNo.Location = new System.Drawing.Point(347, 254);
			this.txtOrderNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtOrderNo.Name = "txtOrderNo";
			this.txtOrderNo.Size = new System.Drawing.Size(100, 25);
			this.txtOrderNo.TabIndex = 1;
			//
			//btnSelect
			//
			this.btnSelect.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.btnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnSelect.Location = new System.Drawing.Point(237, 380);
			this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(75, 32);
			this.btnSelect.TabIndex = 2;
			this.btnSelect.Text = "查询";
			this.btnSelect.UseVisualStyleBackColor = true;
			//
			//btnReturn
			//
			this.btnReturn.AutoSize = true;
			this.btnReturn.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.btnReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnReturn.Location = new System.Drawing.Point(419, 380);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(75, 32);
			this.btnReturn.TabIndex = 3;
			this.btnReturn.Text = "返回";
			this.btnReturn.UseVisualStyleBackColor = true;
			//
			//lblResults1
			//
			this.lblResults1.AutoSize = true;
			this.lblResults1.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.lblResults1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblResults1.Location = new System.Drawing.Point(252, 259);
			this.lblResults1.Name = "lblResults1";
			this.lblResults1.Size = new System.Drawing.Size(89, 20);
			this.lblResults1.TabIndex = 4;
			this.lblResults1.Text = "订单号：";
			//
			//lblResults2
			//
			this.lblResults2.AutoSize = true;
			this.lblResults2.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.lblResults2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblResults2.Location = new System.Drawing.Point(217, 331);
			this.lblResults2.Name = "lblResults2";
			this.lblResults2.Size = new System.Drawing.Size(109, 20);
			this.lblResults2.TabIndex = 5;
			this.lblResults2.Text = "开始时间：";
			//
			//lblResults3
			//
			this.lblResults3.AutoSize = true;
			this.lblResults3.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.lblResults3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblResults3.Location = new System.Drawing.Point(617, 330);
			this.lblResults3.Name = "lblResults3";
			this.lblResults3.Size = new System.Drawing.Size(109, 20);
			this.lblResults3.TabIndex = 6;
			this.lblResults3.Text = "场地编号：";
			//
			//lblResults4
			//
			this.lblResults4.AutoSize = true;
			this.lblResults4.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.lblResults4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblResults4.Location = new System.Drawing.Point(27, 330);
			this.lblResults4.Name = "lblResults4";
			this.lblResults4.Size = new System.Drawing.Size(109, 20);
			this.lblResults4.TabIndex = 7;
			this.lblResults4.Text = "用户编号：";
			//
			//txtID
			//
			this.txtID.Location = new System.Drawing.Point(132, 326);
			this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(80, 25);
			this.txtID.TabIndex = 8;
			//
			//txtStime
			//
			this.txtStime.Location = new System.Drawing.Point(324, 326);
			this.txtStime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtStime.Name = "txtStime";
			this.txtStime.Size = new System.Drawing.Size(80, 25);
			this.txtStime.TabIndex = 9;
			//
			//lblResults5
			//
			this.lblResults5.AutoSize = true;
			this.lblResults5.Font = new System.Drawing.Font("宋体", (float) (24.0F));
			this.lblResults5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblResults5.Location = new System.Drawing.Point(304, 9);
			this.lblResults5.Name = "lblResults5";
			this.lblResults5.Size = new System.Drawing.Size(177, 40);
			this.lblResults5.TabIndex = 11;
			this.lblResults5.Text = "订单查询";
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
			//cmbPlaceName
			//
			this.cmbPlaceName.FormattingEnabled = true;
			this.cmbPlaceName.Location = new System.Drawing.Point(523, 328);
			this.cmbPlaceName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbPlaceName.Name = "cmbPlaceName";
			this.cmbPlaceName.Size = new System.Drawing.Size(80, 23);
			this.cmbPlaceName.TabIndex = 13;
			//
			//cmbPlaceNo
			//
			this.cmbPlaceNo.FormattingEnabled = true;
			this.cmbPlaceNo.Location = new System.Drawing.Point(724, 328);
			this.cmbPlaceNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbPlaceNo.Name = "cmbPlaceNo";
			this.cmbPlaceNo.Size = new System.Drawing.Size(80, 23);
			this.cmbPlaceNo.TabIndex = 14;
			//
			//lblResults7
			//
			this.lblResults7.AutoSize = true;
			this.lblResults7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblResults7.Location = new System.Drawing.Point(281, 426);
			this.lblResults7.Name = "lblResults7";
			this.lblResults7.Size = new System.Drawing.Size(187, 15);
			this.lblResults7.TabIndex = 16;
			this.lblResults7.Text = "（输入任意一项即可查询）";
			//
			//lblResults6
			//
			this.lblResults6.AutoSize = true;
			this.lblResults6.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.lblResults6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lblResults6.Location = new System.Drawing.Point(411, 331);
			this.lblResults6.Name = "lblResults6";
			this.lblResults6.Size = new System.Drawing.Size(109, 20);
			this.lblResults6.TabIndex = 17;
			this.lblResults6.Text = "场地名称：";
			//
			//btnSelOrder
			//
			this.btnSelOrder.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.btnSelOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnSelOrder.Location = new System.Drawing.Point(496, 252);
			this.btnSelOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSelOrder.Name = "btnSelOrder";
			this.btnSelOrder.Size = new System.Drawing.Size(75, 32);
			this.btnSelOrder.TabIndex = 18;
			this.btnSelOrder.Text = "搜索";
			this.btnSelOrder.UseVisualStyleBackColor = true;
			//
			//订单查询
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(829, 451);
			this.Controls.Add(this.btnSelOrder);
			this.Controls.Add(this.txtStime);
			this.Controls.Add(this.txtOrderNo);
			this.Controls.Add(this.cmbPlaceName);
			this.Controls.Add(this.lblResults6);
			this.Controls.Add(this.lblResults7);
			this.Controls.Add(this.cmbPlaceNo);
			this.Controls.Add(this.lblResults5);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.lblResults4);
			this.Controls.Add(this.lblResults3);
			this.Controls.Add(this.lblResults2);
			this.Controls.Add(this.lblResults1);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.DataGridView1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "订单查询";
			this.Text = "订单查询";
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DataGridView DataGridView1;
		internal TextBox txtOrderNo;
		internal Button btnSelect;
		internal Button btnReturn;
		internal Label lblResults1;
		internal Label lblResults2;
		internal Label lblResults3;
		internal Label lblResults4;
		internal TextBox txtID;
		internal TextBox txtStime;
		internal Label lblResults5;
		internal System.Data.OleDb.OleDbConnection OleDbConnection1;
		internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbInsertCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand1;
		internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;
		internal System.Data.OleDb.OleDbCommand OleDbCommand1;
		internal ComboBox cmbPlaceName;
		internal ComboBox cmbPlaceNo;
		internal Label lblResults7;
		internal Label lblResults6;
		internal Button btnSelOrder;
	}
	
}
