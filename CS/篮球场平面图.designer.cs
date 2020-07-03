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
			this.Label1 = new System.Windows.Forms.Label();
			base.Load += new System.EventHandler(viewBasketball_Load);
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.OleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.OleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.DataSet1 = new System.Data.DataSet();
			this.PictureBox14 = new System.Windows.Forms.PictureBox();
			this.PictureBox13 = new System.Windows.Forms.PictureBox();
			this.PictureBox12 = new System.Windows.Forms.PictureBox();
			this.PictureBox11 = new System.Windows.Forms.PictureBox();
			this.PictureBox10 = new System.Windows.Forms.PictureBox();
			this.PictureBox9 = new System.Windows.Forms.PictureBox();
			this.PictureBox8 = new System.Windows.Forms.PictureBox();
			this.PictureBox7 = new System.Windows.Forms.PictureBox();
			this.PictureBox6 = new System.Windows.Forms.PictureBox();
			this.PictureBox5 = new System.Windows.Forms.PictureBox();
			this.PictureBox3 = new System.Windows.Forms.PictureBox();
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			this.PictureBox4 = new System.Windows.Forms.PictureBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.Label16 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.DataSet1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox14).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox13).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox12).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox11).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox10).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox7).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox6).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox5).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox4).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(93, 66);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(23, 15);
			this.Label1.TabIndex = 22;
			this.Label1.Text = "01";
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(250, 66);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(23, 15);
			this.Label2.TabIndex = 23;
			this.Label2.Text = "02";
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(405, 66);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(23, 15);
			this.Label3.TabIndex = 24;
			this.Label3.Text = "03";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(543, 66);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(23, 15);
			this.Label4.TabIndex = 25;
			this.Label4.Text = "04";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(641, 66);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(23, 15);
			this.Label5.TabIndex = 26;
			this.Label5.Text = "05";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(641, 434);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(23, 15);
			this.Label6.TabIndex = 27;
			this.Label6.Text = "06";
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(738, 66);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(23, 15);
			this.Label7.TabIndex = 28;
			this.Label7.Text = "07";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(738, 434);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(23, 15);
			this.Label8.TabIndex = 29;
			this.Label8.Text = "08";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(838, 66);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(23, 15);
			this.Label9.TabIndex = 30;
			this.Label9.Text = "09";
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(838, 434);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(23, 15);
			this.Label10.TabIndex = 31;
			this.Label10.Text = "10";
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(932, 66);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(23, 15);
			this.Label11.TabIndex = 32;
			this.Label11.Text = "11";
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(932, 434);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(23, 15);
			this.Label12.TabIndex = 33;
			this.Label12.Text = "12";
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Location = new System.Drawing.Point(1035, 66);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(23, 15);
			this.Label13.TabIndex = 34;
			this.Label13.Text = "13";
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Location = new System.Drawing.Point(1035, 434);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(23, 15);
			this.Label14.TabIndex = 35;
			this.Label14.Text = "14";
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Location = new System.Drawing.Point(75, 212);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(53, 15);
			this.Label15.TabIndex = 36;
			this.Label15.Text = "入  口";
			//
			//OleDbConnection1
			//
			this.OleDbConnection1.ConnectionString = "Provider=SQLNCLI11;Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSP" +
				"I;Initial Catalog=changguan";
			//
			//OleDbSelectCommand1
			//
			this.OleDbSelectCommand1.CommandText = "SELECT  Vaddress, INrental, OUTrental" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "FROM      Vtype" + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(13)) + System.Convert.ToString(global::Microsoft.VisualBasic.Strings.ChrW(10)) + "WHERE   (Vname = '篮球场')";
			//
			//odadSelBaseket
			//
			this.OleDbDataAdapter1.SelectCommand = this.OleDbSelectCommand1;
			this.OleDbDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {new System.Data.Common.DataTableMapping("Table", "Vtype", new System.Data.Common.DataColumnMapping[] {new System.Data.Common.DataColumnMapping("Vaddress", "Vaddress"), new System.Data.Common.DataColumnMapping("INrental", "INrental"), new System.Data.Common.DataColumnMapping("OUTrental", "OUTrental")})});
			//
			//DataSet1
			//
			this.DataSet1.DataSetName = "NewDataSet";
			//
			//PictureBox14
			//
			this.PictureBox14.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox14.BackgroundImage"));
			this.PictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox14.Location = new System.Drawing.Point(994, 259);
			this.PictureBox14.Name = "PictureBox14";
			this.PictureBox14.Size = new System.Drawing.Size(100, 160);
			this.PictureBox14.TabIndex = 21;
			this.PictureBox14.TabStop = false;
			//
			//PictureBox13
			//
			this.PictureBox13.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox13.BackgroundImage"));
			this.PictureBox13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox13.Location = new System.Drawing.Point(994, 93);
			this.PictureBox13.Name = "PictureBox13";
			this.PictureBox13.Size = new System.Drawing.Size(100, 160);
			this.PictureBox13.TabIndex = 20;
			this.PictureBox13.TabStop = false;
			//
			//PictureBox12
			//
			this.PictureBox12.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox12.BackgroundImage"));
			this.PictureBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox12.Location = new System.Drawing.Point(897, 259);
			this.PictureBox12.Name = "PictureBox12";
			this.PictureBox12.Size = new System.Drawing.Size(100, 160);
			this.PictureBox12.TabIndex = 19;
			this.PictureBox12.TabStop = false;
			//
			//PictureBox11
			//
			this.PictureBox11.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox11.BackgroundImage"));
			this.PictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox11.Location = new System.Drawing.Point(897, 93);
			this.PictureBox11.Name = "PictureBox11";
			this.PictureBox11.Size = new System.Drawing.Size(100, 160);
			this.PictureBox11.TabIndex = 18;
			this.PictureBox11.TabStop = false;
			//
			//PictureBox10
			//
			this.PictureBox10.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox10.BackgroundImage"));
			this.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox10.Location = new System.Drawing.Point(800, 259);
			this.PictureBox10.Name = "PictureBox10";
			this.PictureBox10.Size = new System.Drawing.Size(100, 160);
			this.PictureBox10.TabIndex = 17;
			this.PictureBox10.TabStop = false;
			//
			//PictureBox9
			//
			this.PictureBox9.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox9.BackgroundImage"));
			this.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox9.Location = new System.Drawing.Point(800, 93);
			this.PictureBox9.Name = "PictureBox9";
			this.PictureBox9.Size = new System.Drawing.Size(100, 160);
			this.PictureBox9.TabIndex = 16;
			this.PictureBox9.TabStop = false;
			//
			//PictureBox8
			//
			this.PictureBox8.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox8.BackgroundImage"));
			this.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox8.Location = new System.Drawing.Point(703, 259);
			this.PictureBox8.Name = "PictureBox8";
			this.PictureBox8.Size = new System.Drawing.Size(100, 160);
			this.PictureBox8.TabIndex = 15;
			this.PictureBox8.TabStop = false;
			//
			//PictureBox7
			//
			this.PictureBox7.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox7.BackgroundImage"));
			this.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox7.Location = new System.Drawing.Point(703, 93);
			this.PictureBox7.Name = "PictureBox7";
			this.PictureBox7.Size = new System.Drawing.Size(100, 160);
			this.PictureBox7.TabIndex = 14;
			this.PictureBox7.TabStop = false;
			//
			//PictureBox6
			//
			this.PictureBox6.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox6.BackgroundImage"));
			this.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox6.Location = new System.Drawing.Point(603, 259);
			this.PictureBox6.Name = "PictureBox6";
			this.PictureBox6.Size = new System.Drawing.Size(100, 160);
			this.PictureBox6.TabIndex = 13;
			this.PictureBox6.TabStop = false;
			//
			//PictureBox5
			//
			this.PictureBox5.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox5.BackgroundImage"));
			this.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox5.Location = new System.Drawing.Point(603, 93);
			this.PictureBox5.Name = "PictureBox5";
			this.PictureBox5.Size = new System.Drawing.Size(100, 160);
			this.PictureBox5.TabIndex = 12;
			this.PictureBox5.TabStop = false;
			//
			//PictureBox3
			//
			this.PictureBox3.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox3.BackgroundImage"));
			this.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox3.Location = new System.Drawing.Point(337, 93);
			this.PictureBox3.Name = "PictureBox3";
			this.PictureBox3.Size = new System.Drawing.Size(160, 100);
			this.PictureBox3.TabIndex = 11;
			this.PictureBox3.TabStop = false;
			//
			//PictureBox2
			//
			this.PictureBox2.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox2.BackgroundImage"));
			this.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox2.Location = new System.Drawing.Point(180, 93);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new System.Drawing.Size(160, 100);
			this.PictureBox2.TabIndex = 10;
			this.PictureBox2.TabStop = false;
			//
			//PictureBox4
			//
			this.PictureBox4.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox4.BackgroundImage"));
			this.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox4.Location = new System.Drawing.Point(503, 93);
			this.PictureBox4.Name = "PictureBox4";
			this.PictureBox4.Size = new System.Drawing.Size(100, 160);
			this.PictureBox4.TabIndex = 9;
			this.PictureBox4.TabStop = false;
			//
			//PictureBox1
			//
			this.PictureBox1.BackgroundImage = (System.Drawing.Image) (resources.GetObject("PictureBox1.BackgroundImage"));
			this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox1.Location = new System.Drawing.Point(23, 93);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(160, 100);
			this.PictureBox1.TabIndex = 7;
			this.PictureBox1.TabStop = false;
			//
			//Label16
			//
			this.Label16.AutoSize = true;
			this.Label16.Location = new System.Drawing.Point(78, 315);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(71, 15);
			this.Label16.TabIndex = 37;
			this.Label16.Text = "lblInfor";
			//
			//viewBasketball
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (8.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1121, 497);
			this.Controls.Add(this.Label16);
			this.Controls.Add(this.Label15);
			this.Controls.Add(this.Label14);
			this.Controls.Add(this.Label13);
			this.Controls.Add(this.Label12);
			this.Controls.Add(this.Label11);
			this.Controls.Add(this.Label10);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.PictureBox14);
			this.Controls.Add(this.PictureBox13);
			this.Controls.Add(this.PictureBox12);
			this.Controls.Add(this.PictureBox11);
			this.Controls.Add(this.PictureBox10);
			this.Controls.Add(this.PictureBox9);
			this.Controls.Add(this.PictureBox8);
			this.Controls.Add(this.PictureBox7);
			this.Controls.Add(this.PictureBox6);
			this.Controls.Add(this.PictureBox5);
			this.Controls.Add(this.PictureBox3);
			this.Controls.Add(this.PictureBox2);
			this.Controls.Add(this.PictureBox4);
			this.Controls.Add(this.PictureBox1);
			this.Name = "viewBasketball";
			this.Text = "篮球场";
			((System.ComponentModel.ISupportInitialize) this.DataSet1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox14).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox13).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox12).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox11).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox10).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox9).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox8).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox7).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox6).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox5).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox4).EndInit();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal PictureBox PictureBox1;
		internal PictureBox PictureBox4;
		internal PictureBox PictureBox2;
		internal PictureBox PictureBox3;
		internal PictureBox PictureBox5;
		internal PictureBox PictureBox6;
		internal PictureBox PictureBox7;
		internal PictureBox PictureBox8;
		internal PictureBox PictureBox9;
		internal PictureBox PictureBox10;
		internal PictureBox PictureBox11;
		internal PictureBox PictureBox12;
		internal PictureBox PictureBox13;
		internal PictureBox PictureBox14;
		internal Label Label1;
		internal Label Label2;
		internal Label Label3;
		internal Label Label4;
		internal Label Label5;
		internal Label Label6;
		internal Label Label7;
		internal Label Label8;
		internal Label Label9;
		internal Label Label10;
		internal Label Label11;
		internal Label Label12;
		internal Label Label13;
		internal Label Label14;
		internal Label Label15;
		internal System.Data.OleDb.OleDbConnection OleDbConnection1;
		internal System.Data.OleDb.OleDbCommand OleDbSelectCommand1;
		internal System.Data.OleDb.OleDbDataAdapter OleDbDataAdapter1;
		internal DataSet DataSet1;
		internal Label Label16;
	}
	
}
