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
		public partial class 用户界面 : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(用户界面));
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAppointment = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancellation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcpanel = new System.Windows.Forms.Panel();
            this.reserve = new System.Windows.Forms.Button();
            this.Settingpanel = new System.Windows.Forms.Panel();
            this.equipmentMg = new System.Windows.Forms.Button();
            this.equipmentRent = new System.Windows.Forms.Button();
            this.changguanDataSet61 = new WindowsApp1.changguanDataSet6();
            this.groundTypeSearch = new System.Windows.Forms.Button();
            this.userMg = new System.Windows.Forms.Button();
            this.orderSearch = new System.Windows.Forms.Button();
            this.incomeStatistics = new System.Windows.Forms.Button();
            this.bulletin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groundInfoSearch = new System.Windows.Forms.Button();
            this.lentInfoSearch = new System.Windows.Forms.Button();
            this.addGroundType = new System.Windows.Forms.Button();
            this.addGroundNum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.updatePass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            this.funcpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changguanDataSet61)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MenuStrip1, "MenuStrip1");
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUser,
            this.tsmiAppointment,
            this.帮助tsmiHelp,
            this.tsmiClose});
            this.MenuStrip1.Name = "MenuStrip1";
            // 
            // tsmiUser
            // 
            this.tsmiUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUserPwd,
            this.tsmiUserOrders});
            this.tsmiUser.Name = "tsmiUser";
            resources.ApplyResources(this.tsmiUser, "tsmiUser");
            // 
            // tsmiUserPwd
            // 
            this.tsmiUserPwd.Name = "tsmiUserPwd";
            resources.ApplyResources(this.tsmiUserPwd, "tsmiUserPwd");
            this.tsmiUserPwd.Click += new System.EventHandler(this.tsmiUserPwd_Click);
            // 
            // tsmiUserOrders
            // 
            this.tsmiUserOrders.Name = "tsmiUserOrders";
            resources.ApplyResources(this.tsmiUserOrders, "tsmiUserOrders");
            this.tsmiUserOrders.Click += new System.EventHandler(this.tsmiUserOrders_Click);
            // 
            // tsmiAppointment
            // 
            this.tsmiAppointment.Name = "tsmiAppointment";
            resources.ApplyResources(this.tsmiAppointment, "tsmiAppointment");
            this.tsmiAppointment.Click += new System.EventHandler(this.tsmiAppointment_Click);
            // 
            // 帮助tsmiHelp
            // 
            this.帮助tsmiHelp.ForeColor = System.Drawing.Color.Black;
            this.帮助tsmiHelp.Name = "帮助tsmiHelp";
            resources.ApplyResources(this.帮助tsmiHelp, "帮助tsmiHelp");
            // 
            // tsmiClose
            // 
            this.tsmiClose.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCancellation,
            this.tsmiClose1});
            this.tsmiClose.Name = "tsmiClose";
            resources.ApplyResources(this.tsmiClose, "tsmiClose");
            // 
            // tsmiCancellation
            // 
            this.tsmiCancellation.Name = "tsmiCancellation";
            resources.ApplyResources(this.tsmiCancellation, "tsmiCancellation");
            this.tsmiCancellation.Click += new System.EventHandler(this.tsmiCancellation_Click);
            // 
            // tsmiClose1
            // 
            this.tsmiClose1.Name = "tsmiClose1";
            resources.ApplyResources(this.tsmiClose1, "tsmiClose1");
            this.tsmiClose1.Click += new System.EventHandler(this.tsmiClose1_Click);
            // 
            // funcpanel
            // 
            this.funcpanel.Controls.Add(this.label4);
            this.funcpanel.Controls.Add(this.label3);
            this.funcpanel.Controls.Add(this.updatePass);
            this.funcpanel.Controls.Add(this.label2);
            this.funcpanel.Controls.Add(this.addGroundNum);
            this.funcpanel.Controls.Add(this.addGroundType);
            this.funcpanel.Controls.Add(this.lentInfoSearch);
            this.funcpanel.Controls.Add(this.groundInfoSearch);
            this.funcpanel.Controls.Add(this.label1);
            this.funcpanel.Controls.Add(this.bulletin);
            this.funcpanel.Controls.Add(this.incomeStatistics);
            this.funcpanel.Controls.Add(this.orderSearch);
            this.funcpanel.Controls.Add(this.userMg);
            this.funcpanel.Controls.Add(this.groundTypeSearch);
            this.funcpanel.Controls.Add(this.equipmentMg);
            this.funcpanel.Controls.Add(this.reserve);
            this.funcpanel.Controls.Add(this.equipmentRent);
            resources.ApplyResources(this.funcpanel, "funcpanel");
            this.funcpanel.Name = "funcpanel";
            // 
            // reserve
            // 
            resources.ApplyResources(this.reserve, "reserve");
            this.reserve.Name = "reserve";
            this.reserve.UseVisualStyleBackColor = true;
            this.reserve.Click += new System.EventHandler(this.reserve_Click);
            // 
            // Settingpanel
            // 
            resources.ApplyResources(this.Settingpanel, "Settingpanel");
            this.Settingpanel.Name = "Settingpanel";
            // 
            // equipmentMg
            // 
            resources.ApplyResources(this.equipmentMg, "equipmentMg");
            this.equipmentMg.Name = "equipmentMg";
            this.equipmentMg.UseVisualStyleBackColor = true;
            this.equipmentMg.Click += new System.EventHandler(this.equipmentMg_Click);
            // 
            // equipmentRent
            // 
            resources.ApplyResources(this.equipmentRent, "equipmentRent");
            this.equipmentRent.Name = "equipmentRent";
            this.equipmentRent.UseVisualStyleBackColor = true;
            this.equipmentRent.Click += new System.EventHandler(this.equipmentRent_Click);
            // 
            // changguanDataSet61
            // 
            this.changguanDataSet61.DataSetName = "changguanDataSet6";
            this.changguanDataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groundTypeSearch
            // 
            resources.ApplyResources(this.groundTypeSearch, "groundTypeSearch");
            this.groundTypeSearch.Name = "groundTypeSearch";
            this.groundTypeSearch.UseVisualStyleBackColor = true;
            this.groundTypeSearch.Click += new System.EventHandler(this.groundTypeSearch_Click);
            // 
            // userMg
            // 
            resources.ApplyResources(this.userMg, "userMg");
            this.userMg.Name = "userMg";
            this.userMg.UseVisualStyleBackColor = true;
            this.userMg.Click += new System.EventHandler(this.userMg_Click);
            // 
            // orderSearch
            // 
            resources.ApplyResources(this.orderSearch, "orderSearch");
            this.orderSearch.Name = "orderSearch";
            this.orderSearch.UseVisualStyleBackColor = true;
            this.orderSearch.Click += new System.EventHandler(this.orderSearch_Click);
            // 
            // incomeStatistics
            // 
            resources.ApplyResources(this.incomeStatistics, "incomeStatistics");
            this.incomeStatistics.Name = "incomeStatistics";
            this.incomeStatistics.UseVisualStyleBackColor = true;
            this.incomeStatistics.Click += new System.EventHandler(this.incomeStatistics_Click);
            // 
            // bulletin
            // 
            resources.ApplyResources(this.bulletin, "bulletin");
            this.bulletin.Name = "bulletin";
            this.bulletin.UseVisualStyleBackColor = true;
            this.bulletin.Click += new System.EventHandler(this.bulletin_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groundInfoSearch
            // 
            resources.ApplyResources(this.groundInfoSearch, "groundInfoSearch");
            this.groundInfoSearch.Name = "groundInfoSearch";
            this.groundInfoSearch.UseVisualStyleBackColor = true;
            this.groundInfoSearch.Click += new System.EventHandler(this.groundInfoSearch_Click);
            // 
            // lentInfoSearch
            // 
            resources.ApplyResources(this.lentInfoSearch, "lentInfoSearch");
            this.lentInfoSearch.Name = "lentInfoSearch";
            this.lentInfoSearch.UseVisualStyleBackColor = true;
            this.lentInfoSearch.Click += new System.EventHandler(this.lentInfoSearch_Click);
            // 
            // addGroundType
            // 
            resources.ApplyResources(this.addGroundType, "addGroundType");
            this.addGroundType.Name = "addGroundType";
            this.addGroundType.UseVisualStyleBackColor = true;
            this.addGroundType.Click += new System.EventHandler(this.addGroundType_Click);
            // 
            // addGroundNum
            // 
            resources.ApplyResources(this.addGroundNum, "addGroundNum");
            this.addGroundNum.Name = "addGroundNum";
            this.addGroundNum.UseVisualStyleBackColor = true;
            this.addGroundNum.Click += new System.EventHandler(this.addGroundNum_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // updatePass
            // 
            resources.ApplyResources(this.updatePass, "updatePass");
            this.updatePass.Name = "updatePass";
            this.updatePass.UseVisualStyleBackColor = true;
            this.updatePass.Click += new System.EventHandler(this.updatePass_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // 用户界面
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::My.Resources.Resources.捕获1;
            this.Controls.Add(this.Settingpanel);
            this.Controls.Add(this.funcpanel);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.MaximizeBox = false;
            this.Name = "用户界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.funcpanel.ResumeLayout(false);
            this.funcpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changguanDataSet61)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		internal MenuStrip MenuStrip1;
		internal ToolStripMenuItem tsmiUser;
		internal ToolStripMenuItem tsmiUserPwd;
		internal ToolStripMenuItem tsmiAppointment;
		internal ToolStripMenuItem 帮助tsmiHelp;
		internal ToolStripMenuItem tsmiClose;
		internal ToolStripMenuItem tsmiCancellation;
		internal ToolStripMenuItem tsmiClose1;
		internal ToolStripMenuItem tsmiUserOrders;
        private Panel funcpanel;
        private Panel Settingpanel;
        private Button reserve;
        private Button equipmentMg;
        private Button equipmentRent;
        private changguanDataSet6 changguanDataSet61;
        private Button bulletin;
        private Button incomeStatistics;
        private Button orderSearch;
        private Button userMg;
        private Button groundTypeSearch;
        private Label label2;
        private Button addGroundNum;
        private Button addGroundType;
        private Button lentInfoSearch;
        private Button groundInfoSearch;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button updatePass;
    }
	
}
