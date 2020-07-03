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
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
			this.查询历史订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.查询历史订单ToolStripMenuItem.Click += new System.EventHandler(this.查询历史订单ToolStripMenuItem_Click);
			this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
			this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem1_Click);
			this.注销ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.注销ToolStripMenuItem1.Click += new System.EventHandler(this.注销ToolStripMenuItem1_Click);
			this.退出ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem2.Click += new System.EventHandler(this.退出ToolStripMenuItem2_Click);
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//MenuStrip1
			//
			this.MenuStrip1.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.MenuStrip1, "MenuStrip1");
			this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ToolStripMenuItem1, this.ToolStripMenuItem2, this.帮助ToolStripMenuItem, this.退出ToolStripMenuItem1});
			this.MenuStrip1.Name = "MenuStrip1";
			//
			//ToolStripMenuItem1
			//
			this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.注销ToolStripMenuItem, this.查询历史订单ToolStripMenuItem});
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			resources.ApplyResources(this.ToolStripMenuItem1, "ToolStripMenuItem1");
			//
			//注销ToolStripMenuItem
			//
			this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
			resources.ApplyResources(this.注销ToolStripMenuItem, "注销ToolStripMenuItem");
			//
			//查询历史订单ToolStripMenuItem
			//
			this.查询历史订单ToolStripMenuItem.Name = "查询历史订单ToolStripMenuItem";
			resources.ApplyResources(this.查询历史订单ToolStripMenuItem, "查询历史订单ToolStripMenuItem");
			//
			//ToolStripMenuItem2
			//
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			resources.ApplyResources(this.ToolStripMenuItem2, "ToolStripMenuItem2");
			//
			//帮助ToolStripMenuItem
			//
			this.帮助ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
			this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
			resources.ApplyResources(this.帮助ToolStripMenuItem, "帮助ToolStripMenuItem");
			//
			//退出ToolStripMenuItem1
			//
			this.退出ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.注销ToolStripMenuItem1, this.退出ToolStripMenuItem2});
			this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
			resources.ApplyResources(this.退出ToolStripMenuItem1, "退出ToolStripMenuItem1");
			//
			//注销ToolStripMenuItem1
			//
			this.注销ToolStripMenuItem1.Name = "注销ToolStripMenuItem1";
			resources.ApplyResources(this.注销ToolStripMenuItem1, "注销ToolStripMenuItem1");
			//
			//退出ToolStripMenuItem2
			//
			this.退出ToolStripMenuItem2.Name = "退出ToolStripMenuItem2";
			resources.ApplyResources(this.退出ToolStripMenuItem2, "退出ToolStripMenuItem2");
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
		internal ToolStripMenuItem ToolStripMenuItem1;
		internal ToolStripMenuItem 注销ToolStripMenuItem;
		internal ToolStripMenuItem ToolStripMenuItem2;
		internal ToolStripMenuItem 帮助ToolStripMenuItem;
		internal ToolStripMenuItem 退出ToolStripMenuItem1;
		internal ToolStripMenuItem 注销ToolStripMenuItem1;
		internal ToolStripMenuItem 退出ToolStripMenuItem2;
		internal ToolStripMenuItem 查询历史订单ToolStripMenuItem;
	}
	
}
