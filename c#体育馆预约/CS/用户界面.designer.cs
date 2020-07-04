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
		public partial class 用户界面 : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(用户界面));
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			base.Load += new System.EventHandler(Form1_Load);
			this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiUserPwd = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiUserPwd.Click += new System.EventHandler(this.tsmiUserPwd_Click);
			this.tsmiUserOrders = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiUserOrders.Click += new System.EventHandler(this.tsmiUserOrders_Click);
			this.tsmiAppointment = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAppointment.Click += new System.EventHandler(this.tsmiAppointment_Click);
			this.帮助tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
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
			resources.ApplyResources(this.MenuStrip1, "MenuStrip1");
			this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.tsmiUser, this.tsmiAppointment, this.帮助tsmiHelp, this.tsmiClose});
			this.MenuStrip1.Name = "MenuStrip1";
			//
			//tsmiUser
			//
			this.tsmiUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.tsmiUserPwd, this.tsmiUserOrders});
			this.tsmiUser.Name = "tsmiUser";
			resources.ApplyResources(this.tsmiUser, "tsmiUser");
			//
			//tsmiUserPwd
			//
			this.tsmiUserPwd.Name = "tsmiUserPwd";
			resources.ApplyResources(this.tsmiUserPwd, "tsmiUserPwd");
			//
			//tsmiUserOrders
			//
			this.tsmiUserOrders.Name = "tsmiUserOrders";
			resources.ApplyResources(this.tsmiUserOrders, "tsmiUserOrders");
			//
			//tsmiAppointment
			//
			this.tsmiAppointment.Name = "tsmiAppointment";
			resources.ApplyResources(this.tsmiAppointment, "tsmiAppointment");
			//
			//帮助tsmiHelp
			//
			this.帮助tsmiHelp.ForeColor = System.Drawing.Color.Black;
			this.帮助tsmiHelp.Name = "帮助tsmiHelp";
			resources.ApplyResources(this.帮助tsmiHelp, "帮助tsmiHelp");
			//
			//tsmiClose
			//
			this.tsmiClose.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.tsmiCancellation, this.tsmiClose1});
			this.tsmiClose.Name = "tsmiClose";
			resources.ApplyResources(this.tsmiClose, "tsmiClose");
			//
			//tsmiCancellation
			//
			this.tsmiCancellation.Name = "tsmiCancellation";
			resources.ApplyResources(this.tsmiCancellation, "tsmiCancellation");
			//
			//tsmiClose1
			//
			this.tsmiClose1.Name = "tsmiClose1";
			resources.ApplyResources(this.tsmiClose1, "tsmiClose1");
			//
			//用户界面
			//
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::My.Resources.Resources.捕获1;
			this.Controls.Add(this.MenuStrip1);
			this.MainMenuStrip = this.MenuStrip1;
			this.MaximizeBox = false;
			this.Name = "用户界面";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal MenuStrip MenuStrip1;
		internal ToolStripMenuItem tsmiUser;
		internal ToolStripMenuItem tsmiUserPwd;
		internal ToolStripMenuItem tsmiAppointment;
		internal ToolStripMenuItem 帮助tsmiHelp;
		internal ToolStripMenuItem tsmiClose;
		internal ToolStripMenuItem tsmiCancellation;
		internal ToolStripMenuItem tsmiClose1;
		internal ToolStripMenuItem tsmiUserOrders;
	}
	
}
