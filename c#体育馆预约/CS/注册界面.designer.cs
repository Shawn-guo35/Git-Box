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
            this.lblResults2 = new System.Windows.Forms.Label();
            this.lblResults3 = new System.Windows.Forms.Label();
            this.lblResults4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtCpwd = new System.Windows.Forms.TextBox();
            this.lblResults5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.radInside = new System.Windows.Forms.RadioButton();
            this.radOutside = new System.Windows.Forms.RadioButton();
            this.Label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResults1
            // 
            this.lblResults1.AutoSize = true;
            this.lblResults1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults1.Location = new System.Drawing.Point(70, 145);
            this.lblResults1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults1.Name = "lblResults1";
            this.lblResults1.Size = new System.Drawing.Size(104, 16);
            this.lblResults1.TabIndex = 0;
            this.lblResults1.Text = "请输入账号：";
            // 
            // lblResults2
            // 
            this.lblResults2.AutoSize = true;
            this.lblResults2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults2.Location = new System.Drawing.Point(70, 203);
            this.lblResults2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults2.Name = "lblResults2";
            this.lblResults2.Size = new System.Drawing.Size(104, 16);
            this.lblResults2.TabIndex = 1;
            this.lblResults2.Text = "请输入密码：";
            // 
            // lblResults3
            // 
            this.lblResults3.AutoSize = true;
            this.lblResults3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults3.Location = new System.Drawing.Point(40, 259);
            this.lblResults3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults3.Name = "lblResults3";
            this.lblResults3.Size = new System.Drawing.Size(136, 16);
            this.lblResults3.TabIndex = 2;
            this.lblResults3.Text = "请再次输入密码：";
            // 
            // lblResults4
            // 
            this.lblResults4.AutoSize = true;
            this.lblResults4.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResults4.Location = new System.Drawing.Point(118, 17);
            this.lblResults4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults4.Name = "lblResults4";
            this.lblResults4.Size = new System.Drawing.Size(143, 33);
            this.lblResults4.TabIndex = 3;
            this.lblResults4.Text = "用户注册";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(188, 141);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(107, 21);
            this.txtID.TabIndex = 4;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(188, 199);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(107, 21);
            this.txtPwd.TabIndex = 5;
            // 
            // txtCpwd
            // 
            this.txtCpwd.Location = new System.Drawing.Point(188, 255);
            this.txtCpwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCpwd.Name = "txtCpwd";
            this.txtCpwd.PasswordChar = '*';
            this.txtCpwd.Size = new System.Drawing.Size(107, 21);
            this.txtCpwd.TabIndex = 6;
            // 
            // lblResults5
            // 
            this.lblResults5.AutoSize = true;
            this.lblResults5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults5.Location = new System.Drawing.Point(40, 311);
            this.lblResults5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults5.Name = "lblResults5";
            this.lblResults5.Size = new System.Drawing.Size(136, 16);
            this.lblResults5.TabIndex = 7;
            this.lblResults5.Text = "请输入您的姓名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(188, 307);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(107, 21);
            this.txtName.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRegister.Location = new System.Drawing.Point(43, 371);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(70, 29);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReturn.Location = new System.Drawing.Point(243, 371);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(73, 29);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "返回";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // radInside
            // 
            this.radInside.AutoSize = true;
            this.radInside.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radInside.Location = new System.Drawing.Point(64, 89);
            this.radInside.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radInside.Name = "radInside";
            this.radInside.Size = new System.Drawing.Size(85, 19);
            this.radInside.TabIndex = 14;
            this.radInside.TabStop = true;
            this.radInside.Text = "校内人员";
            this.radInside.UseVisualStyleBackColor = true;
            this.radInside.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radOutside
            // 
            this.radOutside.AutoSize = true;
            this.radOutside.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radOutside.Location = new System.Drawing.Point(219, 89);
            this.radOutside.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radOutside.Name = "radOutside";
            this.radOutside.Size = new System.Drawing.Size(85, 19);
            this.radOutside.TabIndex = 15;
            this.radOutside.TabStop = true;
            this.radOutside.Text = "校外人员";
            this.radOutside.UseVisualStyleBackColor = true;
            this.radOutside.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(316, 149);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(0, 12);
            this.Label6.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResults3);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Controls.Add(this.lblResults1);
            this.groupBox1.Controls.Add(this.radOutside);
            this.groupBox1.Controls.Add(this.lblResults2);
            this.groupBox1.Controls.Add(this.radInside);
            this.groupBox1.Controls.Add(this.lblResults4);
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.txtPwd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtCpwd);
            this.groupBox1.Controls.Add(this.lblResults5);
            this.groupBox1.Location = new System.Drawing.Point(1320, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 421);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // 注册界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "注册界面";
            this.Text = "用户注册";
            this.Load += new System.EventHandler(this.注册界面_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private GroupBox groupBox1;
    }
	
}
