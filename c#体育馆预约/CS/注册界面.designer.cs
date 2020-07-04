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
	partial class 注册界面 : System.Windows.Forms.Form
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
			this.lblResults1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(注册界面_Load);
			this.lblResults2 = new System.Windows.Forms.Label();
			this.lblResults3 = new System.Windows.Forms.Label();
			this.lblResults4 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.txtCpwd = new System.Windows.Forms.TextBox();
			this.lblResults5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			this.radInside = new System.Windows.Forms.RadioButton();
			this.radInside.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
			this.radOutside = new System.Windows.Forms.RadioButton();
			this.radOutside.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
			this.Label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//lblResults1
			//
			this.lblResults1.AutoSize = true;
			this.lblResults1.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.lblResults1.Location = new System.Drawing.Point(147, 185);
			this.lblResults1.Name = "lblResults1";
			this.lblResults1.Size = new System.Drawing.Size(129, 20);
			this.lblResults1.TabIndex = 0;
			this.lblResults1.Text = "请输入账号：";
			//
			//lblResults2
			//
			this.lblResults2.AutoSize = true;
			this.lblResults2.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.lblResults2.Location = new System.Drawing.Point(147, 258);
			this.lblResults2.Name = "lblResults2";
			this.lblResults2.Size = new System.Drawing.Size(129, 20);
			this.lblResults2.TabIndex = 1;
			this.lblResults2.Text = "请输入密码：";
			//
			//lblResults3
			//
			this.lblResults3.AutoSize = true;
			this.lblResults3.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.lblResults3.Location = new System.Drawing.Point(107, 328);
			this.lblResults3.Name = "lblResults3";
			this.lblResults3.Size = new System.Drawing.Size(169, 20);
			this.lblResults3.TabIndex = 2;
			this.lblResults3.Text = "请再次输入密码：";
			//
			//lblResults4
			//
			this.lblResults4.AutoSize = true;
			this.lblResults4.Font = new System.Drawing.Font("宋体", (float) (24.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.lblResults4.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblResults4.Location = new System.Drawing.Point(211, 25);
			this.lblResults4.Name = "lblResults4";
			this.lblResults4.Size = new System.Drawing.Size(177, 40);
			this.lblResults4.TabIndex = 3;
			this.lblResults4.Text = "用户注册";
			//
			//txtID
			//
			this.txtID.Location = new System.Drawing.Point(300, 180);
			this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(141, 25);
			this.txtID.TabIndex = 4;
			//
			//txtPwd
			//
			this.txtPwd.Location = new System.Drawing.Point(300, 252);
			this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			this.txtPwd.Size = new System.Drawing.Size(141, 25);
			this.txtPwd.TabIndex = 5;
			//
			//txtCpwd
			//
			this.txtCpwd.Location = new System.Drawing.Point(300, 322);
			this.txtCpwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCpwd.Name = "txtCpwd";
			this.txtCpwd.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			this.txtCpwd.Size = new System.Drawing.Size(141, 25);
			this.txtCpwd.TabIndex = 6;
			//
			//lblResults5
			//
			this.lblResults5.AutoSize = true;
			this.lblResults5.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.lblResults5.Location = new System.Drawing.Point(107, 392);
			this.lblResults5.Name = "lblResults5";
			this.lblResults5.Size = new System.Drawing.Size(169, 20);
			this.lblResults5.TabIndex = 7;
			this.lblResults5.Text = "请输入您的姓名：";
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(300, 388);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(141, 25);
			this.txtName.TabIndex = 8;
			//
			//btnRegister
			//
			this.btnRegister.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnRegister.Location = new System.Drawing.Point(111, 468);
			this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(93, 36);
			this.btnRegister.TabIndex = 9;
			this.btnRegister.Text = "注册";
			this.btnRegister.UseVisualStyleBackColor = true;
			//
			//btnReturn
			//
			this.btnReturn.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnReturn.Location = new System.Drawing.Point(377, 468);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(97, 36);
			this.btnReturn.TabIndex = 10;
			this.btnReturn.Text = "返回";
			this.btnReturn.UseVisualStyleBackColor = true;
			//
			//radInside
			//
			this.radInside.AutoSize = true;
			this.radInside.Font = new System.Drawing.Font("宋体", (float) (10.8F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.radInside.Location = new System.Drawing.Point(139, 115);
			this.radInside.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.radInside.Name = "radInside";
			this.radInside.Size = new System.Drawing.Size(106, 23);
			this.radInside.TabIndex = 14;
			this.radInside.TabStop = true;
			this.radInside.Text = "校内人员";
			this.radInside.UseVisualStyleBackColor = true;
			//
			//radOutside
			//
			this.radOutside.AutoSize = true;
			this.radOutside.Font = new System.Drawing.Font("宋体", (float) (10.8F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.radOutside.Location = new System.Drawing.Point(345, 115);
			this.radOutside.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.radOutside.Name = "radOutside";
			this.radOutside.Size = new System.Drawing.Size(106, 23);
			this.radOutside.TabIndex = 15;
			this.radOutside.TabStop = true;
			this.radOutside.Text = "校外人员";
			this.radOutside.UseVisualStyleBackColor = true;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(475, 190);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(0, 15);
			this.Label6.TabIndex = 16;
			//
			//注册界面
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(621, 548);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.radOutside);
			this.Controls.Add(this.radInside);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lblResults5);
			this.Controls.Add(this.txtCpwd);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.lblResults4);
			this.Controls.Add(this.lblResults3);
			this.Controls.Add(this.lblResults2);
			this.Controls.Add(this.lblResults1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "注册界面";
			this.Text = "用户注册";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Label lblResults1;
		internal Label lblResults2;
		internal Label lblResults3;
		internal Label lblResults4;
		internal TextBox txtID;
		internal TextBox txtPwd;
		internal TextBox txtCpwd;
		internal Label lblResults5;
		internal TextBox txtName;
		internal Button btnRegister;
		internal Button btnReturn;
		internal RadioButton radInside;
		internal RadioButton radOutside;
		internal Label Label6;
	}
	
}
