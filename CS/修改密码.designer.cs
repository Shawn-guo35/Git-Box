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
	partial class 修改密码 : System.Windows.Forms.Form
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
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(Form3_Load);
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.TextBox1 = new System.Windows.Forms.TextBox();
			this.TextBox2 = new System.Windows.Forms.TextBox();
			this.TextBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label1.Location = new System.Drawing.Point(51, 96);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(129, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "输入旧密码：";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label2.Location = new System.Drawing.Point(51, 160);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(129, 20);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "输入新密码：";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label3.Location = new System.Drawing.Point(51, 222);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(129, 20);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "确认新密码：";
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(136, 276);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(101, 57);
			this.Button1.TabIndex = 3;
			this.Button1.Text = "确认修改";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//TextBox1
			//
			this.TextBox1.Location = new System.Drawing.Point(192, 91);
			this.TextBox1.Name = "TextBox1";
			this.TextBox1.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			this.TextBox1.Size = new System.Drawing.Size(146, 25);
			this.TextBox1.TabIndex = 4;
			//
			//TextBox2
			//
			this.TextBox2.Location = new System.Drawing.Point(192, 160);
			this.TextBox2.Name = "TextBox2";
			this.TextBox2.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			this.TextBox2.Size = new System.Drawing.Size(146, 25);
			this.TextBox2.TabIndex = 5;
			//
			//TextBox3
			//
			this.TextBox3.Location = new System.Drawing.Point(192, 217);
			this.TextBox3.Name = "TextBox3";
			this.TextBox3.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			this.TextBox3.Size = new System.Drawing.Size(146, 25);
			this.TextBox3.TabIndex = 6;
			//
			//修改密码
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(397, 374);
			this.Controls.Add(this.TextBox3);
			this.Controls.Add(this.TextBox2);
			this.Controls.Add(this.TextBox1);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Name = "修改密码";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "修改密码";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Label Label1;
		internal Label Label2;
		internal Label Label3;
		internal Button Button1;
		internal TextBox TextBox1;
		internal TextBox TextBox2;
		internal TextBox TextBox3;
	}
	
}
