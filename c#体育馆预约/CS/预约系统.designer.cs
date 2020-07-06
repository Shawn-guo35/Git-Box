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
            this.btnBadminton = new System.Windows.Forms.Button();
            this.btnBasketball1 = new System.Windows.Forms.Button();
            this.btnSoccer = new System.Windows.Forms.Button();
            this.btnTennis = new System.Windows.Forms.Button();
            this.btnBasketball = new System.Windows.Forms.Button();
            this.lblResults1 = new System.Windows.Forms.Label();
            this.lblResults2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPingpang
            // 
            this.btnPingpang.FlatAppearance.BorderSize = 0;
            this.btnPingpang.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPingpang.Location = new System.Drawing.Point(944, 531);
            this.btnPingpang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPingpang.Name = "btnPingpang";
            this.btnPingpang.Size = new System.Drawing.Size(254, 160);
            this.btnPingpang.TabIndex = 4;
            this.btnPingpang.Text = "乒乓球馆";
            this.btnPingpang.UseVisualStyleBackColor = true;
            this.btnPingpang.Click += new System.EventHandler(this.btnPingpang_Click);
            // 
            // btnBadminton
            // 
            this.btnBadminton.FlatAppearance.BorderSize = 0;
            this.btnBadminton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBadminton.Location = new System.Drawing.Point(693, 531);
            this.btnBadminton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBadminton.Name = "btnBadminton";
            this.btnBadminton.Size = new System.Drawing.Size(254, 160);
            this.btnBadminton.TabIndex = 8;
            this.btnBadminton.Text = "羽毛球馆";
            this.btnBadminton.UseVisualStyleBackColor = true;
            this.btnBadminton.Click += new System.EventHandler(this.btnBadminton_Click);
            // 
            // btnBasketball1
            // 
            this.btnBasketball1.FlatAppearance.BorderSize = 0;
            this.btnBasketball1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBasketball1.Location = new System.Drawing.Point(441, 531);
            this.btnBasketball1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBasketball1.Name = "btnBasketball1";
            this.btnBasketball1.Size = new System.Drawing.Size(254, 160);
            this.btnBasketball1.TabIndex = 5;
            this.btnBasketball1.Text = "篮球馆";
            this.btnBasketball1.UseVisualStyleBackColor = true;
            this.btnBasketball1.Click += new System.EventHandler(this.btnBasketball1_Click);
            // 
            // btnSoccer
            // 
            this.btnSoccer.FlatAppearance.BorderSize = 0;
            this.btnSoccer.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSoccer.Location = new System.Drawing.Point(945, 373);
            this.btnSoccer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSoccer.Name = "btnSoccer";
            this.btnSoccer.Size = new System.Drawing.Size(254, 160);
            this.btnSoccer.TabIndex = 2;
            this.btnSoccer.Text = "东足球场";
            this.btnSoccer.UseVisualStyleBackColor = true;
            this.btnSoccer.Click += new System.EventHandler(this.btnSoccer_Click);
            // 
            // btnTennis
            // 
            this.btnTennis.FlatAppearance.BorderSize = 0;
            this.btnTennis.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTennis.Location = new System.Drawing.Point(693, 373);
            this.btnTennis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTennis.Name = "btnTennis";
            this.btnTennis.Size = new System.Drawing.Size(254, 160);
            this.btnTennis.TabIndex = 3;
            this.btnTennis.Text = "网球场";
            this.btnTennis.UseVisualStyleBackColor = true;
            this.btnTennis.Click += new System.EventHandler(this.btnTennis_Click);
            // 
            // btnBasketball
            // 
            this.btnBasketball.FlatAppearance.BorderSize = 0;
            this.btnBasketball.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBasketball.Location = new System.Drawing.Point(441, 373);
            this.btnBasketball.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBasketball.Name = "btnBasketball";
            this.btnBasketball.Size = new System.Drawing.Size(254, 160);
            this.btnBasketball.TabIndex = 9;
            this.btnBasketball.Text = "篮球场";
            this.btnBasketball.UseVisualStyleBackColor = true;
            this.btnBasketball.Click += new System.EventHandler(this.btnBasketball_Click);
            // 
            // lblResults1
            // 
            this.lblResults1.AutoSize = true;
            this.lblResults1.Font = new System.Drawing.Font("黑体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults1.Location = new System.Drawing.Point(193, 145);
            this.lblResults1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults1.Name = "lblResults1";
            this.lblResults1.Size = new System.Drawing.Size(584, 56);
            this.lblResults1.TabIndex = 1;
            this.lblResults1.Text = "欢迎使用场馆预约系统";
            // 
            // lblResults2
            // 
            this.lblResults2.AutoSize = true;
            this.lblResults2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults2.Location = new System.Drawing.Point(292, 245);
            this.lblResults2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults2.Name = "lblResults2";
            this.lblResults2.Size = new System.Drawing.Size(394, 38);
            this.lblResults2.TabIndex = 7;
            this.lblResults2.Text = "请在下方选择您想预约的场地";
            // 
            // Yuyue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.lblResults2);
            this.Controls.Add(this.lblResults1);
            this.Controls.Add(this.btnBasketball1);
            this.Controls.Add(this.btnTennis);
            this.Controls.Add(this.btnPingpang);
            this.Controls.Add(this.btnBasketball);
            this.Controls.Add(this.btnSoccer);
            this.Controls.Add(this.btnBadminton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Yuyue";
            this.Text = "预约主界面";
            this.Load += new System.EventHandler(this.Yuyue_Load);
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
