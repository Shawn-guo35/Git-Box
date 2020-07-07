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
		public partial class 登录界面 : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(登陆界面_Load);
			this.lblResults1 = new System.Windows.Forms.Label();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnLogin.Click += new System.EventHandler(this.btnLogin2_Click);
			this.lblResults2 = new System.Windows.Forms.Label();
			this.lblResults3 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.radUser = new System.Windows.Forms.RadioButton();
			this.radAdmin = new System.Windows.Forms.RadioButton();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this.Timer2 = new System.Windows.Forms.Timer(this.components);
			this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
			this.SuspendLayout();
			//
			//lblResults1
			//
			this.lblResults1.AutoSize = true;
			this.lblResults1.BackColor = System.Drawing.Color.Transparent;
			this.lblResults1.Font = new System.Drawing.Font("宋体", (float) (22.2F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.lblResults1.Location = new System.Drawing.Point(200, 65);
			this.lblResults1.Name = "lblResults1";
			this.lblResults1.Size = new System.Drawing.Size(321, 38);
			this.lblResults1.TabIndex = 0;
			this.lblResults1.Text = "体育场馆预约系统";
			//
			//btnRegister
			//
			this.btnRegister.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnRegister.Location = new System.Drawing.Point(413, 358);
			this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(95, 35);
			this.btnRegister.TabIndex = 1;
			this.btnRegister.Text = "注册";
			this.btnRegister.UseVisualStyleBackColor = true;
			//
			//btnLogin
			//
			this.btnLogin.BackColor = System.Drawing.Color.Transparent;
			this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLogin.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnLogin.Location = new System.Drawing.Point(207, 358);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(95, 35);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "登录";
			this.btnLogin.UseVisualStyleBackColor = false;
			//
			//lblResults2
			//
			this.lblResults2.AutoSize = true;
			this.lblResults2.BackColor = System.Drawing.SystemColors.Control;
			this.lblResults2.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.lblResults2.Location = new System.Drawing.Point(223, 158);
			this.lblResults2.Name = "lblResults2";
			this.lblResults2.Size = new System.Drawing.Size(69, 20);
			this.lblResults2.TabIndex = 3;
			this.lblResults2.Text = "账号：";
			//
			//lblResults3
			//
			this.lblResults3.AutoSize = true;
			this.lblResults3.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.lblResults3.Location = new System.Drawing.Point(223, 224);
			this.lblResults3.Name = "lblResults3";
			this.lblResults3.Size = new System.Drawing.Size(69, 20);
			this.lblResults3.TabIndex = 4;
			this.lblResults3.Text = "密码：";
			//
			//txtID
			//
			this.txtID.Location = new System.Drawing.Point(343, 152);
			this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(177, 25);
			this.txtID.TabIndex = 5;
			//
			//txtPwd
			//
			this.txtPwd.Location = new System.Drawing.Point(343, 219);
			this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			this.txtPwd.Size = new System.Drawing.Size(177, 25);
			this.txtPwd.TabIndex = 6;
			//
			//radUser
			//
			this.radUser.AutoSize = true;
			this.radUser.Location = new System.Drawing.Point(244, 292);
			this.radUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.radUser.Name = "radUser";
			this.radUser.Size = new System.Drawing.Size(58, 19);
			this.radUser.TabIndex = 7;
			this.radUser.TabStop = true;
			this.radUser.Text = "用户";
			this.radUser.UseVisualStyleBackColor = true;
			//
			//radAdmin
			//
			this.radAdmin.AutoSize = true;
			this.radAdmin.Location = new System.Drawing.Point(413, 292);
			this.radAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.radAdmin.Name = "radAdmin";
			this.radAdmin.Size = new System.Drawing.Size(73, 19);
			this.radAdmin.TabIndex = 8;
			this.radAdmin.TabStop = true;
			this.radAdmin.Text = "管理员";
			this.radAdmin.UseVisualStyleBackColor = true;
			//
			//Timer1
			//
			//
			//Timer2
			//
			//
			//登录界面
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(720, 451);
			this.Controls.Add(this.radAdmin);
			this.Controls.Add(this.radUser);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.lblResults3);
			this.Controls.Add(this.lblResults2);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.lblResults1);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "登录界面";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "登录";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Label lblResults1;
		internal Button btnLogin;
		internal Label lblResults2;
		internal Label lblResults3;
		internal TextBox txtID;
		internal TextBox txtPwd;
		internal RadioButton radUser;
		internal RadioButton radAdmin;
		internal Timer Timer1;
		internal Timer Timer2;
		protected Button btnRegister;
	}
	
}
