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
            this.btnSelectVtype = new System.Windows.Forms.Button();
            this.btnSelectLease = new System.Windows.Forms.Button();
            this.btnInsertVenue = new System.Windows.Forms.Button();
            this.btnInsertVtype = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectVenue
            // 
            this.btnSelectVenue.Location = new System.Drawing.Point(75, 90);
            this.btnSelectVenue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectVenue.Name = "btnSelectVenue";
            this.btnSelectVenue.Size = new System.Drawing.Size(160, 80);
            this.btnSelectVenue.TabIndex = 0;
            this.btnSelectVenue.Text = "查询场地类型";
            this.btnSelectVenue.UseVisualStyleBackColor = true;
            this.btnSelectVenue.Click += new System.EventHandler(this.btnSelectVenue_Click);
            // 
            // btnSelectVtype
            // 
            this.btnSelectVtype.Location = new System.Drawing.Point(239, 90);
            this.btnSelectVtype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectVtype.Name = "btnSelectVtype";
            this.btnSelectVtype.Size = new System.Drawing.Size(160, 80);
            this.btnSelectVtype.TabIndex = 1;
            this.btnSelectVtype.Text = "查询场地信息";
            this.btnSelectVtype.UseVisualStyleBackColor = true;
            this.btnSelectVtype.Click += new System.EventHandler(this.btnSelectVtype_Click);
            // 
            // btnSelectLease
            // 
            this.btnSelectLease.Location = new System.Drawing.Point(403, 90);
            this.btnSelectLease.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectLease.Name = "btnSelectLease";
            this.btnSelectLease.Size = new System.Drawing.Size(160, 80);
            this.btnSelectLease.TabIndex = 2;
            this.btnSelectLease.Text = "查询场地租借情况";
            this.btnSelectLease.UseVisualStyleBackColor = true;
            this.btnSelectLease.Click += new System.EventHandler(this.btnSelectLease_Click);
            // 
            // btnInsertVenue
            // 
            this.btnInsertVenue.Location = new System.Drawing.Point(75, 190);
            this.btnInsertVenue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertVenue.Name = "btnInsertVenue";
            this.btnInsertVenue.Size = new System.Drawing.Size(160, 80);
            this.btnInsertVenue.TabIndex = 3;
            this.btnInsertVenue.Text = "添加场地类型";
            this.btnInsertVenue.UseVisualStyleBackColor = true;
            this.btnInsertVenue.Click += new System.EventHandler(this.btnInsertVenue_Click);
            // 
            // btnInsertVtype
            // 
            this.btnInsertVtype.Location = new System.Drawing.Point(239, 190);
            this.btnInsertVtype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertVtype.Name = "btnInsertVtype";
            this.btnInsertVtype.Size = new System.Drawing.Size(160, 80);
            this.btnInsertVtype.TabIndex = 4;
            this.btnInsertVtype.Text = "添加场地信息";
            this.btnInsertVtype.UseVisualStyleBackColor = true;
            this.btnInsertVtype.Click += new System.EventHandler(this.btnSubmit5_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnReturn);
            this.GroupBox1.Controls.Add(this.btnSelectVenue);
            this.GroupBox1.Controls.Add(this.btnSelectLease);
            this.GroupBox1.Controls.Add(this.btnInsertVtype);
            this.GroupBox1.Controls.Add(this.btnSelectVtype);
            this.GroupBox1.Controls.Add(this.btnInsertVenue);
            this.GroupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupBox1.Location = new System.Drawing.Point(573, 269);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GroupBox1.Size = new System.Drawing.Size(623, 336);
            this.GroupBox1.TabIndex = 5;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "场地管理系统";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(403, 190);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(160, 80);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "退出";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // 场地管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "场地管理";
            this.Text = "场地管理";
            this.Load += new System.EventHandler(this.Form1_Load);
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
