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
		public partial class 欢迎界面 : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(Form1_Load);
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this.lblResults1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Timer1
			//
			//
			//lblResults1
			//
			this.lblResults1.AutoSize = true;
			this.lblResults1.BackColor = System.Drawing.Color.Transparent;
			this.lblResults1.Font = new System.Drawing.Font("宋体", (float) (24.0F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.lblResults1.ForeColor = System.Drawing.Color.Black;
			this.lblResults1.Location = new System.Drawing.Point(195, 136);
			this.lblResults1.Name = "lblResults1";
			this.lblResults1.Size = new System.Drawing.Size(345, 40);
			this.lblResults1.TabIndex = 0;
			this.lblResults1.Text = "体育场馆预约系统";
			//
			//欢迎界面
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::My.Resources.Resources._0ff610843ca2f431_05d415b9ec93c33a_2ee29b314b579c64fa255b15bdf3643b;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(730, 451);
			this.Controls.Add(this.lblResults1);
			this.DoubleBuffered = true;
			this.Name = "欢迎界面";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "欢迎使用";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Timer Timer1;
		internal Label lblResults1;
	}
	
}
