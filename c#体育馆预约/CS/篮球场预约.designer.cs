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
		public partial class orderBasketball : System.Windows.Forms.Form
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
            this.btnGymorder = new System.Windows.Forms.Button();
            this.btnTimeorder = new System.Windows.Forms.Button();
            this.btnGymview = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnSubmit1 = new System.Windows.Forms.Button();
            this.btnSubmit2 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.odadSelBaseket = new System.Data.OleDb.OleDbDataAdapter();
            this.dstBasketLease = new System.Data.DataSet();
            this.odcmdInsLease = new System.Data.OleDb.OleDbCommand();
            this.cmbBegintime = new System.Windows.Forms.ComboBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.dstSelOrder = new System.Data.DataSet();
            this.txtEndtime = new System.Windows.Forms.TextBox();
            this.cbmGymnum = new System.Windows.Forms.ComboBox();
            this.odcmdInsOrder = new System.Data.OleDb.OleDbCommand();
            this.Label3 = new System.Windows.Forms.Label();
            this.OleDbSelectCommand2 = new System.Data.OleDb.OleDbCommand();
            this.OleDbInsertCommand2 = new System.Data.OleDb.OleDbCommand();
            this.OleDbUpdateCommand2 = new System.Data.OleDb.OleDbCommand();
            this.OleDbDeleteCommand2 = new System.Data.OleDb.OleDbCommand();
            this.odadSelOrder = new System.Data.OleDb.OleDbDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstBasketLease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstSelOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGymorder
            // 
            this.btnGymorder.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGymorder.Location = new System.Drawing.Point(1039, 290);
            this.btnGymorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGymorder.Name = "btnGymorder";
            this.btnGymorder.Size = new System.Drawing.Size(134, 30);
            this.btnGymorder.TabIndex = 3;
            this.btnGymorder.Text = "选择场地进行预约";
            this.btnGymorder.UseVisualStyleBackColor = true;
            this.btnGymorder.Click += new System.EventHandler(this.btnGymorder_Click);
            // 
            // btnTimeorder
            // 
            this.btnTimeorder.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTimeorder.Location = new System.Drawing.Point(1039, 375);
            this.btnTimeorder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimeorder.Name = "btnTimeorder";
            this.btnTimeorder.Size = new System.Drawing.Size(134, 30);
            this.btnTimeorder.TabIndex = 4;
            this.btnTimeorder.Text = "选择时间进行预约";
            this.btnTimeorder.UseVisualStyleBackColor = true;
            this.btnTimeorder.Click += new System.EventHandler(this.btnTimeorder_Click);
            // 
            // btnGymview
            // 
            this.btnGymview.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGymview.Location = new System.Drawing.Point(1039, 205);
            this.btnGymview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGymview.Name = "btnGymview";
            this.btnGymview.Size = new System.Drawing.Size(134, 30);
            this.btnGymview.TabIndex = 5;
            this.btnGymview.Text = "查看场地平面图";
            this.btnGymview.UseVisualStyleBackColor = true;
            this.btnGymview.Click += new System.EventHandler(this.btnGymview_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label4.Location = new System.Drawing.Point(557, 470);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(54, 20);
            this.Label4.TabIndex = 10;
            this.Label4.Text = "场地号";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.ColumnHeadersHeight = 40;
            this.dgvOrder.Location = new System.Drawing.Point(506, 190);
            this.dgvOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowTemplate.Height = 27;
            this.dgvOrder.Size = new System.Drawing.Size(508, 225);
            this.dgvOrder.TabIndex = 12;
            this.dgvOrder.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellContentDoubleClick);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label1.Location = new System.Drawing.Point(638, 575);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(99, 20);
            this.Label1.TabIndex = 13;
            this.Label1.Text = "租借开始时间";
            // 
            // btnSubmit1
            // 
            this.btnSubmit1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnSubmit1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit1.Location = new System.Drawing.Point(807, 471);
            this.btnSubmit1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit1.Name = "btnSubmit1";
            this.btnSubmit1.Size = new System.Drawing.Size(56, 22);
            this.btnSubmit1.TabIndex = 15;
            this.btnSubmit1.Text = "确定";
            this.btnSubmit1.UseVisualStyleBackColor = true;
            this.btnSubmit1.Click += new System.EventHandler(this.btnSubmit1_Click);
            // 
            // btnSubmit2
            // 
            this.btnSubmit2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit2.Location = new System.Drawing.Point(1022, 591);
            this.btnSubmit2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubmit2.Name = "btnSubmit2";
            this.btnSubmit2.Size = new System.Drawing.Size(56, 22);
            this.btnSubmit2.TabIndex = 16;
            this.btnSubmit2.Text = "确定";
            this.btnSubmit2.UseVisualStyleBackColor = true;
            this.btnSubmit2.Click += new System.EventHandler(this.btnSubmit2_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label2.Location = new System.Drawing.Point(638, 609);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(99, 20);
            this.Label2.TabIndex = 17;
            this.Label2.Text = "租借结束时间";
            // 
            // OleDbConnection1
            // 
            this.OleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSP" +
    "I;Initial Catalog=changguan";
            // 
            // odadSelBaseket
            // 
            this.odadSelBaseket.DeleteCommand = this.OleDbDeleteCommand1;
            this.odadSelBaseket.InsertCommand = this.OleDbInsertCommand1;
            this.odadSelBaseket.SelectCommand = this.OleDbSelectCommand1;
            this.odadSelBaseket.UpdateCommand = this.OleDbUpdateCommand1;
            // 
            // dstBasketLease
            // 
            this.dstBasketLease.DataSetName = "NewDataSet";
            // 
            // cmbBegintime
            // 
            this.cmbBegintime.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbBegintime.FormattingEnabled = true;
            this.cmbBegintime.Items.AddRange(new object[] {
            "12:00",
            "13:00",
            "18:00",
            "19:00"});
            this.cmbBegintime.Location = new System.Drawing.Point(826, 573);
            this.cmbBegintime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBegintime.Name = "cmbBegintime";
            this.cmbBegintime.Size = new System.Drawing.Size(92, 22);
            this.cmbBegintime.TabIndex = 20;
            this.cmbBegintime.Text = "12:00";
            this.cmbBegintime.SelectedIndexChanged += new System.EventHandler(this.cmbBegintime_SelectedIndexChanged_1);
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtpTime.Location = new System.Drawing.Point(416, 591);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpTime.MinDate = new System.DateTime(2019, 7, 2, 0, 0, 0, 0);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(151, 24);
            this.dtpTime.TabIndex = 22;
            // 
            // dstSelOrder
            // 
            this.dstSelOrder.DataSetName = "NewDataSet";
            // 
            // txtEndtime
            // 
            this.txtEndtime.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtEndtime.Location = new System.Drawing.Point(826, 605);
            this.txtEndtime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEndtime.Name = "txtEndtime";
            this.txtEndtime.Size = new System.Drawing.Size(92, 24);
            this.txtEndtime.TabIndex = 23;
            // 
            // cbmGymnum
            // 
            this.cbmGymnum.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbmGymnum.FormattingEnabled = true;
            this.cbmGymnum.Location = new System.Drawing.Point(673, 470);
            this.cbmGymnum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbmGymnum.Name = "cbmGymnum";
            this.cbmGymnum.Size = new System.Drawing.Size(64, 22);
            this.cbmGymnum.TabIndex = 24;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label3.Location = new System.Drawing.Point(432, 145);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(264, 28);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "双击表中的场地号即可预订";
            this.Label3.Visible = false;
            // 
            // odadSelOrder
            // 
            this.odadSelOrder.DeleteCommand = this.OleDbDeleteCommand2;
            this.odadSelOrder.InsertCommand = this.OleDbInsertCommand2;
            this.odadSelOrder.SelectCommand = this.OleDbSelectCommand2;
            this.odadSelOrder.UpdateCommand = this.OleDbUpdateCommand2;
            // 
            // orderBasketball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cbmGymnum);
            this.Controls.Add(this.txtEndtime);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.cmbBegintime);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnSubmit2);
            this.Controls.Add(this.btnSubmit1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnGymview);
            this.Controls.Add(this.btnTimeorder);
            this.Controls.Add(this.btnGymorder);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "orderBasketball";
            this.Text = "篮球场预约";
            this.Load += new System.EventHandler(this.orderBasketball_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstBasketLease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstSelOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal Button btnGymorder;
		internal Button btnTimeorder;
		internal Button btnGymview;
		internal Label Label4;
		internal DataGridView dgvOrder;
		internal Label Label1;
		internal Button btnSubmit1;
		internal Button btnSubmit2;
		internal Label Label2;
		internal System.Data.OleDb.OleDbConnection OleDbConnection1;
		internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbInsertCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand1;
		internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand1;
		internal System.Data.OleDb.OleDbDataAdapter odadSelBaseket;
		internal DataSet dstBasketLease;
		internal System.Data.OleDb.OleDbCommand odcmdInsLease;
		internal ComboBox cmbBegintime;
		internal DateTimePicker dtpTime;
		internal DataSet dstSelOrder;
		internal TextBox txtEndtime;
		internal ComboBox cbmGymnum;
		internal System.Data.OleDb.OleDbCommand odcmdInsOrder;
		internal Label Label3;
		internal System.Data.OleDb.OleDbCommand OleDbSelectCommand2;
		internal System.Data.OleDb.OleDbCommand OleDbInsertCommand2;
		internal System.Data.OleDb.OleDbCommand OleDbUpdateCommand2;
		internal System.Data.OleDb.OleDbCommand OleDbDeleteCommand2;
		internal System.Data.OleDb.OleDbDataAdapter odadSelOrder;
	}
	
}
