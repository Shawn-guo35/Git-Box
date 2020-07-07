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
		public partial class viewBasketball : System.Windows.Forms.Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewBasketball));
            this.lblResults1 = new System.Windows.Forms.Label();
            this.lblResults2 = new System.Windows.Forms.Label();
            this.lblResults3 = new System.Windows.Forms.Label();
            this.lblResults4 = new System.Windows.Forms.Label();
            this.lblResults5 = new System.Windows.Forms.Label();
            this.lblResults6 = new System.Windows.Forms.Label();
            this.lblResults7 = new System.Windows.Forms.Label();
            this.lblResults8 = new System.Windows.Forms.Label();
            this.lblResults9 = new System.Windows.Forms.Label();
            this.lblResults10 = new System.Windows.Forms.Label();
            this.lblResults11 = new System.Windows.Forms.Label();
            this.lblResults12 = new System.Windows.Forms.Label();
            this.lblResults13 = new System.Windows.Forms.Label();
            this.lblResults14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
            this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.DataSet1 = new System.Data.DataSet();
            this.picBasketball14 = new System.Windows.Forms.PictureBox();
            this.picBasketball13 = new System.Windows.Forms.PictureBox();
            this.picBasketball12 = new System.Windows.Forms.PictureBox();
            this.picBasketball11 = new System.Windows.Forms.PictureBox();
            this.picBasketball10 = new System.Windows.Forms.PictureBox();
            this.picBasketball9 = new System.Windows.Forms.PictureBox();
            this.picBasketball8 = new System.Windows.Forms.PictureBox();
            this.picBasketball7 = new System.Windows.Forms.PictureBox();
            this.picBasketball6 = new System.Windows.Forms.PictureBox();
            this.picBasketball5 = new System.Windows.Forms.PictureBox();
            this.picBasketball3 = new System.Windows.Forms.PictureBox();
            this.picBasketball2 = new System.Windows.Forms.PictureBox();
            this.picBasketball4 = new System.Windows.Forms.PictureBox();
            this.picBasketball1 = new System.Windows.Forms.PictureBox();
            this.lblResults16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResults1
            // 
            this.lblResults1.AutoSize = true;
            this.lblResults1.Location = new System.Drawing.Point(259, 212);
            this.lblResults1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults1.Name = "lblResults1";
            this.lblResults1.Size = new System.Drawing.Size(17, 12);
            this.lblResults1.TabIndex = 22;
            this.lblResults1.Text = "01";
            // 
            // lblResults2
            // 
            this.lblResults2.AutoSize = true;
            this.lblResults2.Location = new System.Drawing.Point(438, 212);
            this.lblResults2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults2.Name = "lblResults2";
            this.lblResults2.Size = new System.Drawing.Size(17, 12);
            this.lblResults2.TabIndex = 23;
            this.lblResults2.Text = "02";
            // 
            // lblResults3
            // 
            this.lblResults3.AutoSize = true;
            this.lblResults3.Location = new System.Drawing.Point(617, 212);
            this.lblResults3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults3.Name = "lblResults3";
            this.lblResults3.Size = new System.Drawing.Size(17, 12);
            this.lblResults3.TabIndex = 24;
            this.lblResults3.Text = "03";
            // 
            // lblResults4
            // 
            this.lblResults4.AutoSize = true;
            this.lblResults4.Location = new System.Drawing.Point(813, 212);
            this.lblResults4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults4.Name = "lblResults4";
            this.lblResults4.Size = new System.Drawing.Size(17, 12);
            this.lblResults4.TabIndex = 25;
            this.lblResults4.Text = "04";
            // 
            // lblResults5
            // 
            this.lblResults5.AutoSize = true;
            this.lblResults5.Location = new System.Drawing.Point(926, 212);
            this.lblResults5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults5.Name = "lblResults5";
            this.lblResults5.Size = new System.Drawing.Size(17, 12);
            this.lblResults5.TabIndex = 26;
            this.lblResults5.Text = "05";
            // 
            // lblResults6
            // 
            this.lblResults6.AutoSize = true;
            this.lblResults6.Location = new System.Drawing.Point(1050, 212);
            this.lblResults6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults6.Name = "lblResults6";
            this.lblResults6.Size = new System.Drawing.Size(17, 12);
            this.lblResults6.TabIndex = 27;
            this.lblResults6.Text = "06";
            // 
            // lblResults7
            // 
            this.lblResults7.AutoSize = true;
            this.lblResults7.Location = new System.Drawing.Point(1174, 212);
            this.lblResults7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults7.Name = "lblResults7";
            this.lblResults7.Size = new System.Drawing.Size(17, 12);
            this.lblResults7.TabIndex = 28;
            this.lblResults7.Text = "07";
            // 
            // lblResults8
            // 
            this.lblResults8.AutoSize = true;
            this.lblResults8.Location = new System.Drawing.Point(1298, 212);
            this.lblResults8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults8.Name = "lblResults8";
            this.lblResults8.Size = new System.Drawing.Size(17, 12);
            this.lblResults8.TabIndex = 29;
            this.lblResults8.Text = "08";
            // 
            // lblResults9
            // 
            this.lblResults9.AutoSize = true;
            this.lblResults9.Location = new System.Drawing.Point(1422, 212);
            this.lblResults9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults9.Name = "lblResults9";
            this.lblResults9.Size = new System.Drawing.Size(17, 12);
            this.lblResults9.TabIndex = 30;
            this.lblResults9.Text = "09";
            // 
            // lblResults10
            // 
            this.lblResults10.AutoSize = true;
            this.lblResults10.Location = new System.Drawing.Point(926, 599);
            this.lblResults10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults10.Name = "lblResults10";
            this.lblResults10.Size = new System.Drawing.Size(17, 12);
            this.lblResults10.TabIndex = 31;
            this.lblResults10.Text = "10";
            // 
            // lblResults11
            // 
            this.lblResults11.AutoSize = true;
            this.lblResults11.Location = new System.Drawing.Point(1050, 599);
            this.lblResults11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults11.Name = "lblResults11";
            this.lblResults11.Size = new System.Drawing.Size(17, 12);
            this.lblResults11.TabIndex = 32;
            this.lblResults11.Text = "11";
            // 
            // lblResults12
            // 
            this.lblResults12.AutoSize = true;
            this.lblResults12.Location = new System.Drawing.Point(1174, 599);
            this.lblResults12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults12.Name = "lblResults12";
            this.lblResults12.Size = new System.Drawing.Size(17, 12);
            this.lblResults12.TabIndex = 33;
            this.lblResults12.Text = "12";
            // 
            // lblResults13
            // 
            this.lblResults13.AutoSize = true;
            this.lblResults13.Location = new System.Drawing.Point(1298, 599);
            this.lblResults13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults13.Name = "lblResults13";
            this.lblResults13.Size = new System.Drawing.Size(17, 12);
            this.lblResults13.TabIndex = 34;
            this.lblResults13.Text = "13";
            // 
            // lblResults14
            // 
            this.lblResults14.AutoSize = true;
            this.lblResults14.Location = new System.Drawing.Point(1422, 599);
            this.lblResults14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults14.Name = "lblResults14";
            this.lblResults14.Size = new System.Drawing.Size(17, 12);
            this.lblResults14.TabIndex = 35;
            this.lblResults14.Text = "14";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(200, 341);
            this.Label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(41, 12);
            this.Label15.TabIndex = 36;
            this.Label15.Text = "入  口";
            // 
            // OleDbConnection1
            // 
            this.OleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSP" +
    "I;Initial Catalog=changguan";
            // 
            // OleDbSelectCommand1
            // 
            this.OleDbSelectCommand1.CommandText = "SELECT  Vaddress, INrental, OUTrental\r\nFROM      Vtype\r\nWHERE   (Vname = \'篮球场\')";
            // 
            // OleDbDataAdapter1
            // 
            this.OleDbDataAdapter1.SelectCommand = this.OleDbSelectCommand1;
            this.OleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Vtype", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Vaddress", "Vaddress"),
                        new System.Data.Common.DataColumnMapping("INrental", "INrental"),
                        new System.Data.Common.DataColumnMapping("OUTrental", "OUTrental")})});
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "NewDataSet";
            // 
            // picBasketball14
            // 
            this.picBasketball14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball14.BackgroundImage")));
            this.picBasketball14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball14.Location = new System.Drawing.Point(1424, 412);
            this.picBasketball14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball14.Name = "picBasketball14";
            this.picBasketball14.Size = new System.Drawing.Size(120, 175);
            this.picBasketball14.TabIndex = 21;
            this.picBasketball14.TabStop = false;
            // 
            // picBasketball13
            // 
            this.picBasketball13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball13.BackgroundImage")));
            this.picBasketball13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball13.Location = new System.Drawing.Point(1424, 233);
            this.picBasketball13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball13.Name = "picBasketball13";
            this.picBasketball13.Size = new System.Drawing.Size(120, 175);
            this.picBasketball13.TabIndex = 20;
            this.picBasketball13.TabStop = false;
            // 
            // picBasketball12
            // 
            this.picBasketball12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball12.BackgroundImage")));
            this.picBasketball12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball12.Location = new System.Drawing.Point(1300, 411);
            this.picBasketball12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball12.Name = "picBasketball12";
            this.picBasketball12.Size = new System.Drawing.Size(120, 175);
            this.picBasketball12.TabIndex = 19;
            this.picBasketball12.TabStop = false;
            // 
            // picBasketball11
            // 
            this.picBasketball11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball11.BackgroundImage")));
            this.picBasketball11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball11.Location = new System.Drawing.Point(1300, 233);
            this.picBasketball11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball11.Name = "picBasketball11";
            this.picBasketball11.Size = new System.Drawing.Size(120, 175);
            this.picBasketball11.TabIndex = 18;
            this.picBasketball11.TabStop = false;
            // 
            // picBasketball10
            // 
            this.picBasketball10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball10.BackgroundImage")));
            this.picBasketball10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball10.Location = new System.Drawing.Point(1176, 412);
            this.picBasketball10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball10.Name = "picBasketball10";
            this.picBasketball10.Size = new System.Drawing.Size(120, 175);
            this.picBasketball10.TabIndex = 17;
            this.picBasketball10.TabStop = false;
            // 
            // picBasketball9
            // 
            this.picBasketball9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball9.BackgroundImage")));
            this.picBasketball9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball9.Location = new System.Drawing.Point(1176, 233);
            this.picBasketball9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball9.Name = "picBasketball9";
            this.picBasketball9.Size = new System.Drawing.Size(120, 175);
            this.picBasketball9.TabIndex = 16;
            this.picBasketball9.TabStop = false;
            // 
            // picBasketball8
            // 
            this.picBasketball8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball8.BackgroundImage")));
            this.picBasketball8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball8.Location = new System.Drawing.Point(1052, 412);
            this.picBasketball8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball8.Name = "picBasketball8";
            this.picBasketball8.Size = new System.Drawing.Size(120, 175);
            this.picBasketball8.TabIndex = 15;
            this.picBasketball8.TabStop = false;
            // 
            // picBasketball7
            // 
            this.picBasketball7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball7.BackgroundImage")));
            this.picBasketball7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball7.Location = new System.Drawing.Point(1052, 233);
            this.picBasketball7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball7.Name = "picBasketball7";
            this.picBasketball7.Size = new System.Drawing.Size(120, 175);
            this.picBasketball7.TabIndex = 14;
            this.picBasketball7.TabStop = false;
            // 
            // picBasketball6
            // 
            this.picBasketball6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball6.BackgroundImage")));
            this.picBasketball6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball6.Location = new System.Drawing.Point(928, 412);
            this.picBasketball6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball6.Name = "picBasketball6";
            this.picBasketball6.Size = new System.Drawing.Size(120, 175);
            this.picBasketball6.TabIndex = 13;
            this.picBasketball6.TabStop = false;
            // 
            // picBasketball5
            // 
            this.picBasketball5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball5.BackgroundImage")));
            this.picBasketball5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball5.Location = new System.Drawing.Point(928, 233);
            this.picBasketball5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball5.Name = "picBasketball5";
            this.picBasketball5.Size = new System.Drawing.Size(120, 175);
            this.picBasketball5.TabIndex = 12;
            this.picBasketball5.TabStop = false;
            // 
            // picBasketball3
            // 
            this.picBasketball3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball3.BackgroundImage")));
            this.picBasketball3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball3.Location = new System.Drawing.Point(619, 233);
            this.picBasketball3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball3.Name = "picBasketball3";
            this.picBasketball3.Size = new System.Drawing.Size(175, 120);
            this.picBasketball3.TabIndex = 11;
            this.picBasketball3.TabStop = false;
            // 
            // picBasketball2
            // 
            this.picBasketball2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball2.BackgroundImage")));
            this.picBasketball2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball2.Location = new System.Drawing.Point(440, 233);
            this.picBasketball2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball2.Name = "picBasketball2";
            this.picBasketball2.Size = new System.Drawing.Size(175, 120);
            this.picBasketball2.TabIndex = 10;
            this.picBasketball2.TabStop = false;
            // 
            // picBasketball4
            // 
            this.picBasketball4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball4.BackgroundImage")));
            this.picBasketball4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball4.Location = new System.Drawing.Point(804, 233);
            this.picBasketball4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball4.Name = "picBasketball4";
            this.picBasketball4.Size = new System.Drawing.Size(120, 175);
            this.picBasketball4.TabIndex = 9;
            this.picBasketball4.TabStop = false;
            // 
            // picBasketball1
            // 
            this.picBasketball1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBasketball1.BackgroundImage")));
            this.picBasketball1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBasketball1.Location = new System.Drawing.Point(261, 233);
            this.picBasketball1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBasketball1.Name = "picBasketball1";
            this.picBasketball1.Size = new System.Drawing.Size(175, 120);
            this.picBasketball1.TabIndex = 7;
            this.picBasketball1.TabStop = false;
            // 
            // lblResults16
            // 
            this.lblResults16.AutoSize = true;
            this.lblResults16.Location = new System.Drawing.Point(200, 377);
            this.lblResults16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResults16.Name = "lblResults16";
            this.lblResults16.Size = new System.Drawing.Size(53, 12);
            this.lblResults16.TabIndex = 37;
            this.lblResults16.Text = "lblInfor";
            // 
            // viewBasketball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 862);
            this.Controls.Add(this.lblResults16);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.lblResults14);
            this.Controls.Add(this.lblResults13);
            this.Controls.Add(this.lblResults12);
            this.Controls.Add(this.lblResults11);
            this.Controls.Add(this.lblResults10);
            this.Controls.Add(this.lblResults9);
            this.Controls.Add(this.lblResults8);
            this.Controls.Add(this.lblResults7);
            this.Controls.Add(this.lblResults6);
            this.Controls.Add(this.lblResults5);
            this.Controls.Add(this.lblResults4);
            this.Controls.Add(this.lblResults3);
            this.Controls.Add(this.lblResults2);
            this.Controls.Add(this.lblResults1);
            this.Controls.Add(this.picBasketball14);
            this.Controls.Add(this.picBasketball13);
            this.Controls.Add(this.picBasketball12);
            this.Controls.Add(this.picBasketball11);
            this.Controls.Add(this.picBasketball10);
            this.Controls.Add(this.picBasketball9);
            this.Controls.Add(this.picBasketball8);
            this.Controls.Add(this.picBasketball7);
            this.Controls.Add(this.picBasketball6);
            this.Controls.Add(this.picBasketball5);
            this.Controls.Add(this.picBasketball3);
            this.Controls.Add(this.picBasketball2);
            this.Controls.Add(this.picBasketball4);
            this.Controls.Add(this.picBasketball1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "viewBasketball";
            this.Text = "篮球场";
            this.Load += new System.EventHandler(this.viewBasketball_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasketball1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		internal PictureBox picBasketball1;
		internal PictureBox picBasketball4;
		internal PictureBox picBasketball2;
		internal PictureBox picBasketball3;
		internal PictureBox picBasketball5;
		internal PictureBox picBasketball6;
		internal PictureBox picBasketball7;
		internal PictureBox picBasketball8;
		internal PictureBox picBasketball9;
		internal PictureBox picBasketball10;
		internal PictureBox picBasketball11;
		internal PictureBox picBasketball12;
		internal PictureBox picBasketball13;
		internal PictureBox picBasketball14;
		internal Label lblResults1;
		internal Label lblResults2;
		internal Label lblResults3;
		internal Label lblResults4;
		internal Label lblResults5;
		internal Label lblResults6;
		internal Label lblResults7;
		internal Label lblResults8;
		internal Label lblResults9;
		internal Label lblResults10;
		internal Label lblResults11;
		internal Label lblResults12;
		internal Label lblResults13;
		internal Label lblResults14;
		internal Label Label15;
		internal System.Data.OleDb.OleDbConnection OleDbConnection1;
		internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;
		internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;
		internal DataSet DataSet1;
		internal Label lblResults16;
	}
	
}
