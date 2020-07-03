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
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtStime = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.OleDbCommand1 = new System.Data.OleDb.OleDbCommand();
			this.cmbPlaceName = new System.Windows.Forms.ComboBox();
			this.cmbPlaceNo = new System.Windows.Forms.ComboBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.btnSelOrder = new System.Windows.Forms.Button();
			this.btnSelOrder.Click += new System.EventHandler(this.btnSelOrder_Click);
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//DataGridView1
			//
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(12, 42);
			this.DataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.RowTemplate.Height = 27;
			this.DataGridView1.Size = new System.Drawing.Size(599, 146);
			this.DataGridView1.TabIndex = 0;
			//
			//txtOrderNo
			//
			this.txtOrderNo.Location = new System.Drawing.Point(260, 203);
			this.txtOrderNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtOrderNo.Name = "txtOrderNo";
			this.txtOrderNo.Size = new System.Drawing.Size(76, 21);
			this.txtOrderNo.TabIndex = 1;
			//
			//btnSelect
			//
			this.btnSelect.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.btnSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnSelect.Location = new System.Drawing.Point(178, 304);
			this.btnSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(56, 26);
			this.btnSelect.TabIndex = 2;
			this.btnSelect.Text = "查询";
			this.btnSelect.UseVisualStyleBackColor = true;
			//
			//btnReturn
			//
			this.btnReturn.AutoSize = true;
			this.btnReturn.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.btnReturn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnReturn.Location = new System.Drawing.Point(314, 304);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(56, 26);
			this.btnReturn.TabIndex = 3;
			this.btnReturn.Text = "返回";
			this.btnReturn.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Label1.Location = new System.Drawing.Point(189, 207);
			this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(72, 16);
			this.Label1.TabIndex = 4;
			this.Label1.Text = "订单号：";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Label2.Location = new System.Drawing.Point(163, 265);
			this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(88, 16);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "开始时间：";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Label3.Location = new System.Drawing.Point(463, 264);
			this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(88, 16);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "场地编号：";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Label4.Location = new System.Drawing.Point(20, 264);
			this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(88, 16);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "用户编号：";
			//
			//txtID
			//
			this.txtID.Location = new System.Drawing.Point(99, 261);
			this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(61, 21);
			this.txtID.TabIndex = 8;
			//
			//txtStime
			//
			this.txtStime.Location = new System.Drawing.Point(243, 261);
			this.txtStime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtStime.Name = "txtStime";
			this.txtStime.Size = new System.Drawing.Size(61, 21);
			this.txtStime.TabIndex = 9;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("宋体", (float) (24.0F));
			this.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Label5.Location = new System.Drawing.Point(228, 7);
			this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(143, 33);
			this.Label5.TabIndex = 11;
			this.Label5.Text = "订单查询";
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
			this.cmbPlaceName.Location = new System.Drawing.Point(392, 262);
			this.cmbPlaceName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmbPlaceName.Name = "cmbPlaceName";
			this.cmbPlaceName.Size = new System.Drawing.Size(61, 20);
			this.cmbPlaceName.TabIndex = 13;
			//
			//cmbPlaceNo
			//
			this.cmbPlaceNo.FormattingEnabled = true;
			this.cmbPlaceNo.Location = new System.Drawing.Point(543, 262);
			this.cmbPlaceNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmbPlaceNo.Name = "cmbPlaceNo";
			this.cmbPlaceNo.Size = new System.Drawing.Size(61, 20);
			this.cmbPlaceNo.TabIndex = 14;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Label7.Location = new System.Drawing.Point(211, 341);
			this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(149, 12);
			this.Label7.TabIndex = 16;
			this.Label7.Text = "（输入任意一项即可查询）";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Label6.Location = new System.Drawing.Point(308, 265);
			this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(88, 16);
			this.Label6.TabIndex = 17;
			this.Label6.Text = "场地名称：";
			//
			//btnSelOrder
			//
			this.btnSelOrder.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.btnSelOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnSelOrder.Location = new System.Drawing.Point(372, 202);
			this.btnSelOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSelOrder.Name = "btnSelOrder";
			this.btnSelOrder.Size = new System.Drawing.Size(56, 26);
			this.btnSelOrder.TabIndex = 18;
			this.btnSelOrder.Text = "搜索";
			this.btnSelOrder.UseVisualStyleBackColor = true;
			//
			//订单查询
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (12.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(622, 361);
			this.Controls.Add(this.btnSelOrder);
			this.Controls.Add(this.txtStime);
			this.Controls.Add(this.txtOrderNo);
			this.Controls.Add(this.cmbPlaceName);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.cmbPlaceNo);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.DataGridView1);
			this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
		internal Label Label1;
		internal Label Label2;
		internal Label Label3;
		internal Label Label4;
		internal TextBox txtID;
		internal TextBox txtStime;
		internal Label Label5;
		internal System.Data.OleDb.OleDbConnection OleDbConnection1;
		internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbInsertCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand1;
		internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;
		internal System.Data.OleDb.OleDbCommand OleDbCommand1;
		internal ComboBox cmbPlaceName;
		internal ComboBox cmbPlaceNo;
		internal Label Label7;
		internal Label Label6;
		internal Button btnSelOrder;
	}
	
}
