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
		public partial class 管理员界面 : System.Windows.Forms.Form
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
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			base.Load += new System.EventHandler(Form2_Load);
			this.tsmiAdmin = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAdmin.Click += new System.EventHandler(this.tsmiAdmin_Click);
			this.tsmiSelectUsers = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSelectUsers.Click += new System.EventHandler(this.tsmiSelectUsers_Click);
			this.tsmiSelectOrders = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSelectOrders.Click += new System.EventHandler(this.tsmiSelectOrders_Click);
			this.tsmiSelectVenue = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSelectVenue.Click += new System.EventHandler(this.tsmiSelectVenue_Click);
			this.tsmiSelectIncome = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSelectIncome.Click += new System.EventHandler(this.tsmiSelectIncome_Click);
			this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCancellation = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiCancellation.Click += new System.EventHandler(this.tsmiCancellation_Click);
			this.tsmiClose1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiClose1.Click += new System.EventHandler(this.tsmiClose1_Click);
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//MenuStrip1
			//
			this.MenuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.MenuStrip1.Font = new System.Drawing.Font("楷体", (float) (16.2F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.tsmiAdmin, this.tsmiHelp, this.tsmiClose});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(800, 36);
			this.MenuStrip1.TabIndex = 0;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//tsmiAdmin
			//
			this.tsmiAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.tsmiSelectUsers, this.tsmiSelectOrders, this.tsmiSelectVenue, this.tsmiSelectIncome});
			this.tsmiAdmin.Name = "tsmiAdmin";
			this.tsmiAdmin.Size = new System.Drawing.Size(169, 32);
			this.tsmiAdmin.Text = "管理员功能";
			//
			//tsmiSelectUsers
			//
			this.tsmiSelectUsers.Name = "tsmiSelectUsers";
			this.tsmiSelectUsers.Size = new System.Drawing.Size(264, 32);
			this.tsmiSelectUsers.Text = "查询用户信息";
			//
			//tsmiSelectOrders
			//
			this.tsmiSelectOrders.Name = "tsmiSelectOrders";
			this.tsmiSelectOrders.Size = new System.Drawing.Size(264, 32);
			this.tsmiSelectOrders.Text = "查询订单信息";
			//
			//tsmiSelectVenue
			//
			this.tsmiSelectVenue.Name = "tsmiSelectVenue";
			this.tsmiSelectVenue.Size = new System.Drawing.Size(264, 32);
			this.tsmiSelectVenue.Text = "查询场地信息";
			//
			//tsmiSelectIncome
			//
			this.tsmiSelectIncome.Name = "tsmiSelectIncome";
			this.tsmiSelectIncome.Size = new System.Drawing.Size(264, 32);
			this.tsmiSelectIncome.Text = "统计收入信息";
			//
			//tsmiHelp
			//
			this.tsmiHelp.Name = "tsmiHelp";
			this.tsmiHelp.Size = new System.Drawing.Size(82, 32);
			this.tsmiHelp.Text = "帮助";
			//
			//tsmiClose
			//
			this.tsmiClose.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.tsmiCancellation, this.tsmiClose1});
			this.tsmiClose.Name = "tsmiClose";
			this.tsmiClose.Size = new System.Drawing.Size(82, 32);
			this.tsmiClose.Text = "退出";
			//
			//tsmiCancellation
			//
			this.tsmiCancellation.Name = "tsmiCancellation";
			this.tsmiCancellation.Size = new System.Drawing.Size(148, 32);
			this.tsmiCancellation.Text = "注销";
			//
			//tsmiClose1
			//
			this.tsmiClose1.Name = "tsmiClose1";
			this.tsmiClose1.Size = new System.Drawing.Size(148, 32);
			this.tsmiClose1.Text = "退出";
			//
			//管理员界面
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::My.Resources.Resources.捕获;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.MenuStrip1);
			this.DoubleBuffered = true;
			this.MainMenuStrip = this.MenuStrip1;
			this.MaximizeBox = false;
			this.Name = "管理员界面";
			this.Text = "管理员界面";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal MenuStrip MenuStrip1;
		internal ToolStripMenuItem tsmiAdmin;
		internal ToolStripMenuItem tsmiSelectUsers;
		internal ToolStripMenuItem tsmiSelectOrders;
		internal ToolStripMenuItem tsmiSelectVenue;
		internal ToolStripMenuItem tsmiHelp;
		internal ToolStripMenuItem tsmiClose;
		internal ToolStripMenuItem tsmiCancellation;
		internal ToolStripMenuItem tsmiClose1;
		internal ToolStripMenuItem tsmiSelectIncome;
	}
	
}
