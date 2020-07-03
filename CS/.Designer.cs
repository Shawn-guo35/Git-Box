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
	partial class 场地管理 : System.Windows.Forms.Form
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
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			base.Load += new System.EventHandler(Form1_Load);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Button5 = new System.Windows.Forms.Button();
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
			this.Button6 = new System.Windows.Forms.Button();
			this.Button6.Click += new System.EventHandler(this.Button6_Click);
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(63, 60);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(150, 70);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "查询场地类型";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Button2
			//
			this.Button2.Location = new System.Drawing.Point(273, 60);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(150, 70);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "查询场地信息";
			this.Button2.UseVisualStyleBackColor = true;
			//
			//Button3
			//
			this.Button3.Location = new System.Drawing.Point(489, 60);
			this.Button3.Name = "Button3";
			this.Button3.Size = new System.Drawing.Size(150, 70);
			this.Button3.TabIndex = 2;
			this.Button3.Text = "查询场地租借情况";
			this.Button3.UseVisualStyleBackColor = true;
			//
			//Button4
			//
			this.Button4.Location = new System.Drawing.Point(63, 209);
			this.Button4.Name = "Button4";
			this.Button4.Size = new System.Drawing.Size(150, 70);
			this.Button4.TabIndex = 3;
			this.Button4.Text = "添加场地类型";
			this.Button4.UseVisualStyleBackColor = true;
			//
			//Button5
			//
			this.Button5.Location = new System.Drawing.Point(273, 209);
			this.Button5.Name = "Button5";
			this.Button5.Size = new System.Drawing.Size(150, 70);
			this.Button5.TabIndex = 4;
			this.Button5.Text = "添加场地信息";
			this.Button5.UseVisualStyleBackColor = true;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Button6);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Button3);
			this.GroupBox1.Controls.Add(this.Button5);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Button4);
			this.GroupBox1.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.GroupBox1.Location = new System.Drawing.Point(-1, 14);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(742, 369);
			this.GroupBox1.TabIndex = 5;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "场地管理系统";
			//
			//Button6
			//
			this.Button6.Location = new System.Drawing.Point(489, 209);
			this.Button6.Name = "Button6";
			this.Button6.Size = new System.Drawing.Size(150, 70);
			this.Button6.TabIndex = 5;
			this.Button6.Text = "退出";
			this.Button6.UseVisualStyleBackColor = true;
			//
			//场地管理
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(741, 380);
			this.Controls.Add(this.GroupBox1);
			this.Name = "场地管理";
			this.Text = "场地管理";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		internal Button Button1;
		internal Button Button2;
		internal Button Button3;
		internal Button Button4;
		internal Button Button5;
		internal GroupBox GroupBox1;
		internal Button Button6;
	}
	
}
