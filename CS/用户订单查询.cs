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

using System.ComponentModel;
using System.Data.OleDb;
using WindowsApp1;

namespace WindowsApp1
{
	public partial class 用户订单查询
	{
		public 用户订单查询()
		{
			// VBConversions Note: Non-static class variable initialization is below.  Class variables cannot be initially assigned non-static values in C#.
			ID = 登录界面.Default.txtID.Text;
			
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static 用户订单查询 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static 用户订单查询 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new 用户订单查询();
					defaultInstance.FormClosed += new System.Windows.Forms.FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		OleDbConnection con = new OleDbConnection();
		OleDbDataAdapter ads = new OleDbDataAdapter();
		DataSet ds = new DataSet();
		OleDbCommand com = new OleDbCommand();
		public string ID; // VBConversions Note: Initial value cannot be assigned here since it is non-static.  Assignment has been moved to the class constructors.
		public DateTime data;
		public DateTime data2;
		public void Form1_Load(object sender, EventArgs e)
		{
			con.ConnectionString = Module1.str;
			//此处缺少将登录页面所输入的ID传递给此页面的字符串变量ID的语句
		}
		
		public void Button3_Click_1(object sender, EventArgs e)
		{
			data = DateTime.Parse(DateTimePicker1.Value.Date.ToShortDateString());
			data2 = data.AddDays(1);
			ds.Clear();
			
			//地点空
			if (ComboBox1.Text == "")
			{
				com.CommandText = "select Vname,Vno,Stime,Etime,LTime,Fee,Orderno,Remark from Orders where ID='" + ID + "'and Stime >= '" + System.Convert.ToString(data) + "'and Stime <= '" + System.Convert.ToString(data2) + "'  ";
				com.Connection = con;
				ads.SelectCommand = com;
				ads.Fill(ds, "Stable");
				this.DataGridView1.DataSource = ds.Tables[0];
			}
			//地点不空
			if (ComboBox1.Text != "")
			{
				com.CommandText = "select Vname,Vno,Stime,Etime,LTime,Fee,Orderno,Remark from Orders where ID='" + ID + "'and convert(varchar(10),Stime,120) = '" + System.Convert.ToString(data) + "'and Vname = '" + ComboBox1.Text + "'";
				com.Connection = con;
				ads.SelectCommand = com;
				ads.Fill(ds, "Stable");
				this.DataGridView1.DataSource = ds.Tables[0];
			}
			
		}
		
		public void Button1_Click(object sender, EventArgs e)
		{
			ds.Clear();
			com.CommandText = "select Vname,Vno,Stime,Etime,LTime,Fee,Orderno,Remark from Orders where ID='" + ID + "'";
			com.Connection = con;
			ads.SelectCommand = com;
			ads.Fill(ds, "Stable");
			this.DataGridView1.DataSource = ds.Tables[0];
		}
	}
	
}
