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
			this.Label1 = new System.Windows.Forms.Label();
			this.btnRegister = new System.Windows.Forms.Button();
			this.btnRegister.Click += new System.EventHandler(this.Button1_Click);
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnLogin.Click += new System.EventHandler(this.Button2_Click);
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
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
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("宋体", (float) (22.2F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label1.Location = new System.Drawing.Point(150, 52);
			this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(253, 30);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "体育场馆预约系统";
			//
			//btnRegister
			//
			this.btnRegister.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnRegister.Location = new System.Drawing.Point(310, 286);
			this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(71, 28);
			this.btnRegister.TabIndex = 1;
			this.btnRegister.Text = "注册";
			this.btnRegister.UseVisualStyleBackColor = true;
			//
			//btnLogin
			//
			this.btnLogin.BackColor = System.Drawing.Color.Transparent;
			this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnLogin.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.btnLogin.Location = new System.Drawing.Point(155, 286);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(71, 28);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "登录";
			this.btnLogin.UseVisualStyleBackColor = false;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label2.Location = new System.Drawing.Point(167, 126);
			this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(56, 16);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "账号：";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.Label3.Location = new System.Drawing.Point(167, 179);
			this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(56, 16);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "密码：";
			//
			//txtID
			//
			this.txtID.Location = new System.Drawing.Point(257, 122);
			this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(134, 21);
			this.txtID.TabIndex = 5;
			//
			//txtPwd
			//
			this.txtPwd.Location = new System.Drawing.Point(257, 175);
			this.txtPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = global::Microsoft.VisualBasic.Strings.ChrW(42);
			this.txtPwd.Size = new System.Drawing.Size(134, 21);
			this.txtPwd.TabIndex = 6;
			//
			//radUser
			//
			this.radUser.AutoSize = true;
			this.radUser.Location = new System.Drawing.Point(183, 234);
			this.radUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.radUser.Name = "radUser";
			this.radUser.Size = new System.Drawing.Size(47, 16);
			this.radUser.TabIndex = 7;
			this.radUser.TabStop = true;
			this.radUser.Text = "用户";
			this.radUser.UseVisualStyleBackColor = true;
			//
			//radAdmin
			//
			this.radAdmin.AutoSize = true;
			this.radAdmin.Location = new System.Drawing.Point(310, 234);
			this.radAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.radAdmin.Name = "radAdmin";
			this.radAdmin.Size = new System.Drawing.Size(59, 16);
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
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (12.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(540, 361);
			this.Controls.Add(this.radAdmin);
			this.Controls.Add(this.radUser);
			this.Controls.Add(this.txtPwd);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.Label1);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "登录界面";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "登录";
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal Label Label1;
		internal Button btnRegister;
		internal Button btnLogin;
		internal Label Label2;
		internal Label Label3;
		internal TextBox txtID;
		internal TextBox txtPwd;
		internal RadioButton radUser;
		internal RadioButton radAdmin;
		internal Timer Timer1;
		internal Timer Timer2;
	}
	
}
