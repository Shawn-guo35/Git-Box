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
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(注册界面_Load);
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.txtCpwd = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnRegister.Click += new System.EventHandler(this.Button1_Click);
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnReturn.Click += new System.EventHandler(this.Button2_Click);
			this.radInside = new System.Windows.Forms.RadioButton();
			this.radInside.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
			this.radOutside = new System.Windows.Forms.RadioButton();
			this.radOutside.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
			this.Label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label1.Location = new System.Drawing.Point(110, 148);
			this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(104, 16);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "请输入账号：";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label2.Location = new System.Drawing.Point(110, 206);
			this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(104, 16);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "请输入密码：";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label3.Location = new System.Drawing.Point(80, 262);
			this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(136, 16);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "请再次输入密码：";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("宋体", (float) (24.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label4.ForeColor = System.Drawing.SystemColors.Highlight;
			this.Label4.Location = new System.Drawing.Point(158, 20);
			this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(143, 33);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "用户注册";
			//
			//txtID
			//
			this.txtID.Location = new System.Drawing.Point(225, 144);
			this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(107, 21);
			this.txtID.TabIndex = 4;
			//
			//txtPwd
			//
			this.txtPwd.Location = new System.Drawing.Point(225, 202);
			this.txtPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			this.txtPwd.Size = new System.Drawing.Size(107, 21);
			this.txtPwd.TabIndex = 5;
			//
			//txtCpwd
			//
			this.txtCpwd.Location = new System.Drawing.Point(225, 258);
			this.txtCpwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtCpwd.Name = "txtCpwd";
			this.txtCpwd.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			this.txtCpwd.Size = new System.Drawing.Size(107, 21);
			this.txtCpwd.TabIndex = 6;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label5.Location = new System.Drawing.Point(80, 314);
			this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(136, 16);
			this.Label5.TabIndex = 7;
			this.Label5.Text = "请输入您的姓名：";
			//
			//txtName
			//
			this.txtName.Location = new System.Drawing.Point(225, 310);
			this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(107, 21);
			this.txtName.TabIndex = 8;
			//
			//btnRegister
			//
			this.btnRegister.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnRegister.Location = new System.Drawing.Point(83, 374);
			this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(70, 29);
			this.btnRegister.TabIndex = 9;
			this.btnRegister.Text = "注册";
			this.btnRegister.UseVisualStyleBackColor = true;
			//
			//btnReturn
			//
			this.btnReturn.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnReturn.Location = new System.Drawing.Point(283, 374);
			this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(73, 29);
			this.btnReturn.TabIndex = 10;
			this.btnReturn.Text = "返回";
			this.btnReturn.UseVisualStyleBackColor = true;
			//
			//radInside
			//
			this.radInside.AutoSize = true;
			this.radInside.Font = new System.Drawing.Font("宋体", (float) (10.8F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.radInside.Location = new System.Drawing.Point(104, 92);
			this.radInside.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.radInside.Name = "radInside";
			this.radInside.Size = new System.Drawing.Size(85, 19);
			this.radInside.TabIndex = 14;
			this.radInside.TabStop = true;
			this.radInside.Text = "校内人员";
			this.radInside.UseVisualStyleBackColor = true;
			//
			//radOutside
			//
			this.radOutside.AutoSize = true;
			this.radOutside.Font = new System.Drawing.Font("宋体", (float) (10.8F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.radOutside.Location = new System.Drawing.Point(259, 92);
			this.radOutside.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.radOutside.Name = "radOutside";
			this.radOutside.Size = new System.Drawing.Size(85, 19);
			this.radOutside.TabIndex = 15;
			this.radOutside.TabStop = true;
			this.radOutside.Text = "校外人员";
			this.radOutside.UseVisualStyleBackColor = true;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(356, 152);
			this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(0, 12);
			this.Label6.TabIndex = 16;
			//
			//注册界面
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (12.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(466, 438);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.radOutside);
			this.Controls.Add(this.radInside);
			this.Controls.Add(this.btnReturn);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.txtCpwd);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "注册界面";
			this.Text = "用户注册";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Label Label1;
		internal Label Label2;
		internal Label Label3;
		internal Label Label4;
		internal TextBox txtID;
		internal TextBox txtPwd;
		internal TextBox txtCpwd;
		internal Label Label5;
		internal TextBox txtName;
		internal Button btnRegister;
		internal Button btnReturn;
		internal RadioButton radInside;
		internal RadioButton radOutside;
		internal Label Label6;
	}
	
}
