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
	partial class Yuyue : System.Windows.Forms.Form
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
			this.btnPingpang = new System.Windows.Forms.Button();
			this.btnPingpang.Click += new System.EventHandler(this.btnPingpang_Click);
			base.Load += new System.EventHandler(Yuyue_Load);
			this.btnBadminton = new System.Windows.Forms.Button();
			this.btnBadminton.Click += new System.EventHandler(this.btnBadminton_Click);
			this.btnBasketball1 = new System.Windows.Forms.Button();
			this.btnBasketball1.Click += new System.EventHandler(this.btnBasketball1_Click);
			this.btnSoccer = new System.Windows.Forms.Button();
			this.btnSoccer.Click += new System.EventHandler(this.btnSoccer_Click);
			this.btnTennis = new System.Windows.Forms.Button();
			this.btnTennis.Click += new System.EventHandler(this.btnTennis_Click);
			this.btnBasketball = new System.Windows.Forms.Button();
			this.btnBasketball.Click += new System.EventHandler(this.btnBasketball_Click);
			this.lblResults1 = new System.Windows.Forms.Label();
			this.lblResults2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//btnPingpang
			//
			this.btnPingpang.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnPingpang.Location = new System.Drawing.Point(519, 272);
			this.btnPingpang.Name = "btnPingpang";
			this.btnPingpang.Size = new System.Drawing.Size(180, 80);
			this.btnPingpang.TabIndex = 4;
			this.btnPingpang.Text = "乒乓球馆";
			this.btnPingpang.UseVisualStyleBackColor = true;
			//
			//btnBadminton
			//
			this.btnBadminton.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnBadminton.Location = new System.Drawing.Point(306, 272);
			this.btnBadminton.Name = "btnBadminton";
			this.btnBadminton.Size = new System.Drawing.Size(180, 80);
			this.btnBadminton.TabIndex = 1;
			this.btnBadminton.Text = "羽毛球馆";
			this.btnBadminton.UseVisualStyleBackColor = true;
			//
			//btnBasketball1
			//
			this.btnBasketball1.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnBasketball1.Location = new System.Drawing.Point(91, 272);
			this.btnBasketball1.Name = "btnBasketball1";
			this.btnBasketball1.Size = new System.Drawing.Size(180, 80);
			this.btnBasketball1.TabIndex = 5;
			this.btnBasketball1.Text = "篮球馆";
			this.btnBasketball1.UseVisualStyleBackColor = true;
			//
			//btnSoccer
			//
			this.btnSoccer.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnSoccer.Location = new System.Drawing.Point(519, 166);
			this.btnSoccer.Name = "btnSoccer";
			this.btnSoccer.Size = new System.Drawing.Size(180, 80);
			this.btnSoccer.TabIndex = 2;
			this.btnSoccer.Text = "东足球场";
			this.btnSoccer.UseVisualStyleBackColor = true;
			//
			//btnTennis
			//
			this.btnTennis.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnTennis.Location = new System.Drawing.Point(306, 166);
			this.btnTennis.Name = "btnTennis";
			this.btnTennis.Size = new System.Drawing.Size(180, 80);
			this.btnTennis.TabIndex = 3;
			this.btnTennis.Text = "网球场";
			this.btnTennis.UseVisualStyleBackColor = true;
			//
			//btnBasketball
			//
			this.btnBasketball.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnBasketball.Location = new System.Drawing.Point(91, 166);
			this.btnBasketball.Name = "btnBasketball";
			this.btnBasketball.Size = new System.Drawing.Size(180, 80);
			this.btnBasketball.TabIndex = 0;
			this.btnBasketball.Text = "篮球场";
			this.btnBasketball.UseVisualStyleBackColor = true;
			//
			//lblResults1
			//
			this.lblResults1.AutoSize = true;
			this.lblResults1.Font = new System.Drawing.Font("黑体", (float) (15.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.lblResults1.Location = new System.Drawing.Point(86, 45);
			this.lblResults1.Name = "lblResults1";
			this.lblResults1.Size = new System.Drawing.Size(272, 25);
			this.lblResults1.TabIndex = 6;
			this.lblResults1.Text = "欢迎使用场馆预约系统";
			//
			//lblResults2
			//
			this.lblResults2.AutoSize = true;
			this.lblResults2.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.lblResults2.Location = new System.Drawing.Point(86, 118);
			this.lblResults2.Name = "lblResults2";
			this.lblResults2.Size = new System.Drawing.Size(272, 27);
			this.lblResults2.TabIndex = 7;
			this.lblResults2.Text = "请在下方选择您想预约的场地";
			//
			//Yuyue
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(781, 447);
			this.Controls.Add(this.lblResults2);
			this.Controls.Add(this.lblResults1);
			this.Controls.Add(this.btnBasketball1);
			this.Controls.Add(this.btnTennis);
			this.Controls.Add(this.btnPingpang);
			this.Controls.Add(this.btnBasketball);
			this.Controls.Add(this.btnSoccer);
			this.Controls.Add(this.btnBadminton);
			this.Name = "Yuyue";
			this.Text = "预约主界面";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Button btnPingpang;
		internal Button btnBadminton;
		internal Button btnBasketball1;
		internal Button btnSoccer;
		internal Button btnTennis;
		internal Button btnBasketball;
		internal Label lblResults1;
		internal Label lblResults2;
	}
	
}
