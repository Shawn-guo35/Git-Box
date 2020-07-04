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

using System.Data.OleDb;
using WindowsApp1;

namespace WindowsApp1
{
	public partial class 订单查询
	{
		public 订单查询()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static 订单查询 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static 订单查询 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new 订单查询();
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
		DataSet objdataset = new DataSet();
		DataSet dataset1 = new DataSet();
		DataSet dataset2 = new DataSet();
		string constr;
		string sqlstr;
		
		public void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
			
		}
		
		public void btnSelect_Click(object sender, EventArgs e)
		{
			
			//三重查询
			if (cmbPlaceNo.Text == "")
			{
				sqlstr = "select * from orders where ID='" + txtID.Text + "' AND Stime='" + txtStime.Text + "' AND vname='" + cmbPlaceName.Text + "'";
				dispp(sqlstr);
			}
			
			if (txtID.Text == "")
			{
				sqlstr = "select * from orders where Stime='" + txtStime.Text + "' AND vname='" + cmbPlaceName.Text + "' AND vno='" + cmbPlaceNo.Text + "'";
				dispp(sqlstr);
			}
			if (txtStime.Text == "")
			{
				sqlstr = "select * from orders where ID='" + txtID.Text + "' AND vname='" + cmbPlaceName.Text + "' AND vno='" + cmbPlaceNo.Text + "'";
				dispp(sqlstr);
			}
			
			
			//双重
			if (txtStime.Text == "" && cmbPlaceNo.Text == "")
			{
				sqlstr = "select * from orders where ID='" + txtID.Text + "' AND vname='" + cmbPlaceName.Text + "'";
				dispp(sqlstr);
			}
			if (txtID.Text == "" && cmbPlaceNo.Text == "")
			{
				sqlstr = "select * from orders where Stime='" + txtStime.Text + "' AND vname='" + cmbPlaceName.Text + "'";
				dispp(sqlstr);
			}
			if (cmbPlaceNo.Text == "" && cmbPlaceName.Text == "")
			{
				sqlstr = "select * from orders where Stime='" + txtStime.Text + "' AND ID='" + txtID.Text + "'";
				dispp(sqlstr);
			}
			if (txtID.Text == "" && txtStime.Text == "")
			{
				sqlstr = "select * from orders where vname='" + cmbPlaceName.Text + "' AND vno='" + cmbPlaceNo.Text + "'";
				dispp(sqlstr);
			}
			
			//单次查询
			
			if (txtStime.Text == "" && cmbPlaceName.Text == "" && cmbPlaceNo.Text == "")
			{
				sqlstr = "select * from orders where ID='" + txtID.Text + "'";
				dispp(sqlstr);
			}
			if (txtID.Text == "" && cmbPlaceName.Text == "" && cmbPlaceNo.Text == "")
			{
				sqlstr = "select * from orders where Stime='" + txtStime.Text + "'";
				dispp(sqlstr);
			}
			if (txtID.Text == "" && txtStime.Text == "" && cmbPlaceNo.Text == "")
			{
				sqlstr = "select * from orders where vname='" + cmbPlaceName.Text + "'";
				dispp(sqlstr);
			}
			
		}
		public void dispp(dynamic sql)
		{
			OleDbDataAdapter1 = new OleDbDataAdapter(sqlstr, OleDbConnection1);
			objdataset.Reset();
			OleDbDataAdapter1.Fill(objdataset, "订单查询");
			DataGridView1.DataSource = objdataset.Tables["订单查询"];
		}
		
		
		//订单查找
		public void btnSelOrder_Click(object sender, EventArgs e)
		{
			sqlstr = "select * from orders where orderno='" + txtOrderNo.Text + "'";
			dispp(sqlstr);
		}
		//窗体加载
		public void Form1_Load(object sender, EventArgs e)
		{
			sqlstr = "select * from orders ";
			OleDbDataAdapter1 = new OleDbDataAdapter(sqlstr, OleDbConnection1);
			objdataset.Reset();
			OleDbDataAdapter1.Fill(objdataset, "订单");
			DataGridView1.DataSource = objdataset.Tables["订单"];
			DataGridView1.Columns[0].HeaderText = "编号";
			
			string sql = "select Vno from Venue ";
			dataset1.Reset();
			OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter(sql, OleDbConnection1);
			OleDbDataAdapter1.Fill(dataset1, "ss");
			cmbPlaceNo.DataSource = dataset1.Tables["ss"];
			for (var i = 0; i <= dataset1.Tables["ss"].Rows.Count - 1; i++)
			{
				cmbPlaceNo.ValueMember = dataset1.Tables["ss"].Columns[0].ToString();
			}
			cmbPlaceNo.Text = "";
			sql = "select distinct Vname from Venue ";
			dataset2.Reset();
			OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter(sql, OleDbConnection1);
			OleDbDataAdapter1.Fill(dataset2, "ss");
			cmbPlaceName.DataSource = dataset2.Tables["ss"];
			for (var i = 0; i <= dataset2.Tables["ss"].Rows.Count - 1; i++)
			{
				cmbPlaceName.ValueMember = dataset2.Tables["ss"].Columns[0].ToString();
			}
			cmbPlaceName.Text = "";
		}
	}
	
}
