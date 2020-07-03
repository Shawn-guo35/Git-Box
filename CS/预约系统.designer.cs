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
			this.Button5 = new System.Windows.Forms.Button();
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button6 = new System.Windows.Forms.Button();
			this.Button6.Click += new System.EventHandler(this.Button6_Click);
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Button5
			//
			this.Button5.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Button5.Location = new System.Drawing.Point(519, 272);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(180, 80);
			this.Button5.TabIndex = 4;
			this.Button5.Text = "乒乓球馆";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Button2.Location = new System.Drawing.Point(306, 272);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(180, 80);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "羽毛球馆";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button6
			//
			this.Button6.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Button6.Location = new System.Drawing.Point(91, 272);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(180, 80);
			this.Button6.TabIndex = 5;
			this.Button6.Text = "篮球馆";
			this.Button6.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Button3.Location = new System.Drawing.Point(519, 166);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(180, 80);
			this.Button3.TabIndex = 2;
			this.Button3.Text = "东足球场";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Button4.Location = new System.Drawing.Point(306, 166);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(180, 80);
			this.Button4.TabIndex = 3;
			this.Button4.Text = "网球场";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Button1
			//
			this.Button1.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Button1.Location = new System.Drawing.Point(91, 166);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(180, 80);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "篮球场";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("黑体", (float) (15.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label1.Location = new System.Drawing.Point(86, 45);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(272, 25);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "欢迎使用场馆预约系统";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("微软雅黑", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label2.Location = new System.Drawing.Point(86, 118);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(272, 27);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "请在下方选择您想预约的场地";
			//
			//Yuyue
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(781, 447);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Button6);
			this.Controls.Add(this.Button4);
			this.Controls.Add(this.Button5);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Button3);
			this.Controls.Add(this.Button2);
			this.Name = "Yuyue";
			this.Text = "预约主界面";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Button Button5;
		internal Button Button2;
		internal Button Button6;
		internal Button Button3;
		internal Button Button4;
		internal Button Button1;
		internal Label Label1;
		internal Label Label2;
	}
	
}
