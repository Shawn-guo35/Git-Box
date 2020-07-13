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
            this.gvwOrders = new System.Windows.Forms.DataGridView();
            this.lblResults2 = new System.Windows.Forms.Label();
            this.lblResults5 = new System.Windows.Forms.Label();
            this.cbmGym = new System.Windows.Forms.ComboBox();
            this.lblResults6 = new System.Windows.Forms.Label();
            this.btnSelectOrders = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.btnSelectallOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvwOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // gvwOrders
            // 
            this.gvwOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gvwOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvwOrders.Location = new System.Drawing.Point(386, 298);
            this.gvwOrders.Margin = new System.Windows.Forms.Padding(2);
            this.gvwOrders.Name = "gvwOrders";
            this.gvwOrders.RowTemplate.Height = 27;
            this.gvwOrders.Size = new System.Drawing.Size(931, 436);
            this.gvwOrders.TabIndex = 0;
            // 
            // lblResults2
            // 
            this.lblResults2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResults2.AutoSize = true;
            this.lblResults2.Font = new System.Drawing.Font("宋体", 12F);
            this.lblResults2.Location = new System.Drawing.Point(564, 234);
            this.lblResults2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults2.Name = "lblResults2";
            this.lblResults2.Size = new System.Drawing.Size(88, 16);
            this.lblResults2.TabIndex = 5;
            this.lblResults2.Text = "开始时间：";
            // 
            // lblResults5
            // 
            this.lblResults5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResults5.AutoSize = true;
            this.lblResults5.Font = new System.Drawing.Font("宋体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults5.Location = new System.Drawing.Point(714, 78);
            this.lblResults5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults5.Name = "lblResults5";
            this.lblResults5.Size = new System.Drawing.Size(284, 64);
            this.lblResults5.TabIndex = 11;
            this.lblResults5.Text = "订单查询";
            // 
            // cbmGym
            // 
            this.cbmGym.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbmGym.FormattingEnabled = true;
            this.cbmGym.Items.AddRange(new object[] {
            "篮球场"});
            this.cbmGym.Location = new System.Drawing.Point(886, 232);
            this.cbmGym.Margin = new System.Windows.Forms.Padding(2);
            this.cbmGym.Name = "cbmGym";
            this.cbmGym.Size = new System.Drawing.Size(61, 20);
            this.cbmGym.TabIndex = 13;
            // 
            // lblResults6
            // 
            this.lblResults6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResults6.AutoSize = true;
            this.lblResults6.Font = new System.Drawing.Font("宋体", 12F);
            this.lblResults6.Location = new System.Drawing.Point(799, 234);
            this.lblResults6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults6.Name = "lblResults6";
            this.lblResults6.Size = new System.Drawing.Size(88, 16);
            this.lblResults6.TabIndex = 17;
            this.lblResults6.Text = "场地名称：";
            // 
            // btnSelectOrders
            // 
            this.btnSelectOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectOrders.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSelectOrders.Location = new System.Drawing.Point(962, 224);
            this.btnSelectOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectOrders.Name = "btnSelectOrders";
            this.btnSelectOrders.Size = new System.Drawing.Size(56, 26);
            this.btnSelectOrders.TabIndex = 18;
            this.btnSelectOrders.Text = "搜索";
            this.btnSelectOrders.UseVisualStyleBackColor = true;
            this.btnSelectOrders.Click += new System.EventHandler(this.btnSelectOrders_Click_1);
            // 
            // dtpTime
            // 
            this.dtpTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpTime.Location = new System.Drawing.Point(636, 232);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(151, 21);
            this.dtpTime.TabIndex = 19;
            // 
            // btnSelectallOrders
            // 
            this.btnSelectallOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectallOrders.Font = new System.Drawing.Font("宋体", 12F);
            this.btnSelectallOrders.Location = new System.Drawing.Point(1034, 224);
            this.btnSelectallOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectallOrders.Name = "btnSelectallOrders";
            this.btnSelectallOrders.Size = new System.Drawing.Size(86, 26);
            this.btnSelectallOrders.TabIndex = 20;
            this.btnSelectallOrders.Text = "搜索全部";
            this.btnSelectallOrders.UseVisualStyleBackColor = true;
            this.btnSelectallOrders.Click += new System.EventHandler(this.btnSelectallOrders_Click);
            // 
            // 用户订单查询
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.btnSelectallOrders);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btnSelectOrders);
            this.Controls.Add(this.cbmGym);
            this.Controls.Add(this.lblResults6);
            this.Controls.Add(this.lblResults5);
            this.Controls.Add(this.lblResults2);
            this.Controls.Add(this.gvwOrders);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "用户订单查询";
            this.Text = "订单查询";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvwOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		internal DataGridView gvwOrders;
		internal Label lblResults2;
		internal Label lblResults5;
		internal ComboBox cbmGym;
		internal Label lblResults6;
		internal Button btnSelectOrders;
		internal DateTimePicker dtpTime;
		internal Button btnSelectallOrders;
	}
	
}
