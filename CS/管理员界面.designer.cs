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
			this.管理员功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.查询用户信息 = new System.Windows.Forms.ToolStripMenuItem();
			this.查询用户信息.Click += new System.EventHandler(this.查询订单信息ToolStripMenuItem_Click);
			this.查询订单信息 = new System.Windows.Forms.ToolStripMenuItem();
			this.查询订单信息.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
			this.查询场地信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.查询场地信息ToolStripMenuItem.Click += new System.EventHandler(this.查询场地信息ToolStripMenuItem_Click);
			this.统计收入信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.统计收入信息ToolStripMenuItem.Click += new System.EventHandler(this.统计订单信息ToolStripMenuItem_Click);
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
			this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
			this.MenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//MenuStrip1
			//
			this.MenuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.MenuStrip1.Font = new System.Drawing.Font("楷体", (float) (16.2F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.管理员功能ToolStripMenuItem, this.ToolStripMenuItem1, this.ToolStripMenuItem2});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.Size = new System.Drawing.Size(800, 36);
			this.MenuStrip1.TabIndex = 0;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//管理员功能ToolStripMenuItem
			//
			this.管理员功能ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.查询用户信息, this.查询订单信息, this.查询场地信息ToolStripMenuItem, this.统计收入信息ToolStripMenuItem});
			this.管理员功能ToolStripMenuItem.Name = "管理员功能ToolStripMenuItem";
			this.管理员功能ToolStripMenuItem.Size = new System.Drawing.Size(169, 32);
			this.管理员功能ToolStripMenuItem.Text = "管理员功能";
			//
			//查询用户信息
			//
			this.查询用户信息.Name = "查询用户信息";
			this.查询用户信息.Size = new System.Drawing.Size(264, 32);
			this.查询用户信息.Text = "查询用户信息";
			//
			//查询订单信息
			//
			this.查询订单信息.Name = "查询订单信息";
			this.查询订单信息.Size = new System.Drawing.Size(264, 32);
			this.查询订单信息.Text = "查询订单信息";
			//
			//查询场地信息ToolStripMenuItem
			//
			this.查询场地信息ToolStripMenuItem.Name = "查询场地信息ToolStripMenuItem";
			this.查询场地信息ToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
			this.查询场地信息ToolStripMenuItem.Text = "查询场地信息";
			//
			//统计收入信息ToolStripMenuItem
			//
			this.统计收入信息ToolStripMenuItem.Name = "统计收入信息ToolStripMenuItem";
			this.统计收入信息ToolStripMenuItem.Size = new System.Drawing.Size(264, 32);
			this.统计收入信息ToolStripMenuItem.Text = "统计收入信息";
			//
			//ToolStripMenuItem1
			//
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(82, 32);
			this.ToolStripMenuItem1.Text = "帮助";
			//
			//ToolStripMenuItem2
			//
			this.ToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.注销ToolStripMenuItem, this.退出ToolStripMenuItem});
			this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
			this.ToolStripMenuItem2.Size = new System.Drawing.Size(82, 32);
			this.ToolStripMenuItem2.Text = "退出";
			//
			//注销ToolStripMenuItem
			//
			this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
			this.注销ToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
			this.注销ToolStripMenuItem.Text = "注销";
			//
			//退出ToolStripMenuItem
			//
			this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
			this.退出ToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
			this.退出ToolStripMenuItem.Text = "退出";
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
		internal ToolStripMenuItem 管理员功能ToolStripMenuItem;
		internal ToolStripMenuItem 查询用户信息;
		internal ToolStripMenuItem 查询订单信息;
		internal ToolStripMenuItem 查询场地信息ToolStripMenuItem;
		internal ToolStripMenuItem ToolStripMenuItem1;
		internal ToolStripMenuItem ToolStripMenuItem2;
		internal ToolStripMenuItem 注销ToolStripMenuItem;
		internal ToolStripMenuItem 退出ToolStripMenuItem;
		internal ToolStripMenuItem 统计收入信息ToolStripMenuItem;
	}
	
}
