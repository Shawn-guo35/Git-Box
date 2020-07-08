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
			this.btnSelectVenue = new System.Windows.Forms.Button();
			this.btnSelectVenue.Click += new System.EventHandler(this.btnSelectVenue_Click);
			base.Load += new System.EventHandler(Form1_Load);
			this.btnSelectVtype = new System.Windows.Forms.Button();
			this.btnSelectVtype.Click += new System.EventHandler(this.btnSelectVtype_Click);
			this.btnSelectLease = new System.Windows.Forms.Button();
			this.btnSelectLease.Click += new System.EventHandler(this.btnSelectLease_Click);
			this.btnInsertVenue = new System.Windows.Forms.Button();
			this.btnInsertVenue.Click += new System.EventHandler(this.btnInsertVenue_Click);
			this.btnInsertVtype = new System.Windows.Forms.Button();
			this.btnInsertVtype.Click += new System.EventHandler(this.btnSubmit5_Click);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
			this.btnReturn = new System.Windows.Forms.Button();
			this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//btnSelectVenue
			//
			this.btnSelectVenue.Location = new System.Drawing.Point(63, 60);
			this.btnSelectVenue.Name = "btnSelectVenue";
			this.btnSelectVenue.Size = new System.Drawing.Size(150, 70);
			this.btnSelectVenue.TabIndex = 0;
			this.btnSelectVenue.Text = "查询场地类型";
			this.btnSelectVenue.UseVisualStyleBackColor = true;
			//
			//btnSelectVtype
			//
			this.btnSelectVtype.Location = new System.Drawing.Point(273, 60);
			this.btnSelectVtype.Name = "btnSelectVtype";
			this.btnSelectVtype.Size = new System.Drawing.Size(150, 70);
			this.btnSelectVtype.TabIndex = 1;
			this.btnSelectVtype.Text = "查询场地信息";
			this.btnSelectVtype.UseVisualStyleBackColor = true;
			//
			//btnSelectLease
			//
			this.btnSelectLease.Location = new System.Drawing.Point(489, 60);
			this.btnSelectLease.Name = "btnSelectLease";
			this.btnSelectLease.Size = new System.Drawing.Size(150, 70);
			this.btnSelectLease.TabIndex = 2;
			this.btnSelectLease.Text = "查询场地租借情况";
			this.btnSelectLease.UseVisualStyleBackColor = true;
			//
			//btnInsertVenue
			//
			this.btnInsertVenue.Location = new System.Drawing.Point(63, 209);
			this.btnInsertVenue.Name = "btnInsertVenue";
			this.btnInsertVenue.Size = new System.Drawing.Size(150, 70);
			this.btnInsertVenue.TabIndex = 3;
			this.btnInsertVenue.Text = "添加场地类型";
			this.btnInsertVenue.UseVisualStyleBackColor = true;
			//
			//btnInsertVtype
			//
			this.btnInsertVtype.Location = new System.Drawing.Point(273, 209);
			this.btnInsertVtype.Name = "btnInsertVtype";
			this.btnInsertVtype.Size = new System.Drawing.Size(150, 70);
			this.btnInsertVtype.TabIndex = 4;
			this.btnInsertVtype.Text = "添加场地信息";
			this.btnInsertVtype.UseVisualStyleBackColor = true;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.btnReturn);
			this.GroupBox1.Controls.Add(this.btnSelectVenue);
			this.GroupBox1.Controls.Add(this.btnSelectLease);
			this.GroupBox1.Controls.Add(this.btnInsertVtype);
			this.GroupBox1.Controls.Add(this.btnSelectVtype);
			this.GroupBox1.Controls.Add(this.btnInsertVenue);
			this.GroupBox1.Font = new System.Drawing.Font("宋体", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(134));
			this.GroupBox1.Location = new System.Drawing.Point(-1, 14);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(742, 369);
			this.GroupBox1.TabIndex = 5;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "场地管理系统";
			//
			//btnReturn
			//
			this.btnReturn.Location = new System.Drawing.Point(489, 209);
			this.btnReturn.Name = "btnReturn";
			this.btnReturn.Size = new System.Drawing.Size(150, 70);
			this.btnReturn.TabIndex = 5;
			this.btnReturn.Text = "退出";
			this.btnReturn.UseVisualStyleBackColor = true;
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
		
		internal Button btnSelectVenue;
		internal Button btnSelectVtype;
		internal Button btnSelectLease;
		internal Button btnInsertVenue;
		internal Button btnInsertVtype;
		internal GroupBox GroupBox1;
		internal Button btnReturn;
	}
	
}
