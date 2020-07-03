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
		public partial class 用户订单查询 : System.Windows.Forms.Form
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
			this.Label2 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click_1);
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
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
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.Label2.Location = new System.Drawing.Point(45, 270);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(109, 20);
			this.Label2.TabIndex = 5;
			this.Label2.Text = "开始时间：";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("宋体", (float) (24.0F));
			this.Label5.Location = new System.Drawing.Point(304, 9);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(177, 40);
			this.Label5.TabIndex = 11;
			this.Label5.Text = "订单查询";
			//
			//ComboBox1
			//
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] {"篮球场"});
			this.ComboBox1.Location = new System.Drawing.Point(474, 267);
			this.ComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(80, 23);
			this.ComboBox1.TabIndex = 13;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.Label6.Location = new System.Drawing.Point(359, 270);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(109, 20);
			this.Label6.TabIndex = 17;
			this.Label6.Text = "场地名称：";
			//
			//Button3
			//
			this.Button3.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.Button3.Location = new System.Drawing.Point(576, 258);
			this.Button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(75, 32);
			this.Button3.TabIndex = 18;
			this.Button3.Text = "搜索";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//DateTimePicker1
			//
			this.DateTimePicker1.Location = new System.Drawing.Point(142, 267);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.Size = new System.Drawing.Size(200, 25);
			this.DateTimePicker1.TabIndex = 19;
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("宋体", (float) (12.0F));
			this.Button1.Location = new System.Drawing.Point(672, 258);
			this.Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(115, 32);
			this.Button1.TabIndex = 20;
			this.Button1.Text = "搜索全部";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//用户订单查询
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(829, 367);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.DateTimePicker1);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.DataGridView1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "用户订单查询";
			this.Text = "订单查询";
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal DataGridView DataGridView1;
		internal Label Label2;
		internal Label Label5;
		internal ComboBox ComboBox1;
		internal Label Label6;
		internal Button Button3;
		internal DateTimePicker DateTimePicker1;
		internal Button Button1;
	}
	
}
