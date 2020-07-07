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
            this.lblResults1 = new System.Windows.Forms.Label();
            this.lblResults2 = new System.Windows.Forms.Label();
            this.lblResults3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtOldPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd = new System.Windows.Forms.TextBox();
            this.txtNewPwd1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResults1
            // 
            this.lblResults1.AutoSize = true;
            this.lblResults1.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResults1.Location = new System.Drawing.Point(576, 249);
            this.lblResults1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults1.Name = "lblResults1";
            this.lblResults1.Size = new System.Drawing.Size(207, 33);
            this.lblResults1.TabIndex = 0;
            this.lblResults1.Text = "输入旧密码：";
            // 
            // lblResults2
            // 
            this.lblResults2.AutoSize = true;
            this.lblResults2.Font = new System.Drawing.Font("宋体", 24F);
            this.lblResults2.Location = new System.Drawing.Point(576, 333);
            this.lblResults2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults2.Name = "lblResults2";
            this.lblResults2.Size = new System.Drawing.Size(207, 33);
            this.lblResults2.TabIndex = 1;
            this.lblResults2.Text = "输入新密码：";
            // 
            // lblResults3
            // 
            this.lblResults3.AutoSize = true;
            this.lblResults3.Font = new System.Drawing.Font("宋体", 24F);
            this.lblResults3.Location = new System.Drawing.Point(579, 422);
            this.lblResults3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults3.Name = "lblResults3";
            this.lblResults3.Size = new System.Drawing.Size(207, 33);
            this.lblResults3.TabIndex = 2;
            this.lblResults3.Text = "确认新密码：";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("宋体", 24F);
            this.btnSubmit.Location = new System.Drawing.Point(794, 561);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(158, 46);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "确认修改";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOldPwd.Location = new System.Drawing.Point(827, 246);
            this.txtOldPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '*';
            this.txtOldPwd.Size = new System.Drawing.Size(300, 44);
            this.txtOldPwd.TabIndex = 4;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Font = new System.Drawing.Font("宋体", 24F);
            this.txtNewPwd.Location = new System.Drawing.Point(827, 333);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '*';
            this.txtNewPwd.Size = new System.Drawing.Size(300, 44);
            this.txtNewPwd.TabIndex = 5;
            // 
            // txtNewPwd1
            // 
            this.txtNewPwd1.Font = new System.Drawing.Font("宋体", 24F);
            this.txtNewPwd1.Location = new System.Drawing.Point(827, 422);
            this.txtNewPwd1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNewPwd1.Name = "txtNewPwd1";
            this.txtNewPwd1.PasswordChar = '*';
            this.txtNewPwd1.Size = new System.Drawing.Size(300, 44);
            this.txtNewPwd1.TabIndex = 6;
            // 
            // 修改密码
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.txtNewPwd1);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblResults3);
            this.Controls.Add(this.lblResults2);
            this.Controls.Add(this.lblResults1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "修改密码";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		internal Label lblResults1;
		internal Label lblResults2;
		internal Label lblResults3;
		internal Button btnSubmit;
		internal TextBox txtOldPwd;
		internal TextBox txtNewPwd;
		internal TextBox txtNewPwd1;
	}
	
}
