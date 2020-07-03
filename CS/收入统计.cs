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
	public partial class 收入统计
	{
		public 收入统计()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static 收入统计 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static 收入统计 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new 收入统计();
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
		DataSet dataset3 = new DataSet();
		DataSet dataset4 = new DataSet();
		DataSet dataset5 = new DataSet();
		DataSet dataset6 = new DataSet();
		object constr;
		object sqlstr;
		
		public void btnSelIncome_Click(object sender, EventArgs e)
		{
			sqlstr = "select fee from orders where stime='" + cmbYear.Text + "/" + cmbMon.Text + "/" + cmbDay.Text + "'";
			OleDbDataAdapter1 = new OleDbDataAdapter(System.Convert.ToString(sqlstr), OleDbConnection1);
			dataset4.Reset();
			OleDbDataAdapter1.Fill(dataset4, "dfee");
			var dsum = 0;
			for (var i = 0; i <= dataset4.Tables["dfee"].Rows.Count - 1; i++)
			{
				dsum = dsum + dataset4.Tables["dfee"].Rows[i][0];
			}
			txtDaySum.Text = System.Convert.ToString(dsum);
			
			sqlstr = "select fee from orders where stime>='" + cmbYear.Text + "/01/01' And stime<='" + cmbYear.Text + "/12/30'";
			OleDbDataAdapter1 = new OleDbDataAdapter(System.Convert.ToString(sqlstr), OleDbConnection1);
			dataset5.Reset();
			OleDbDataAdapter1.Fill(dataset5, "mfee");
			var ysum = 0;
			for (var i = 0; i <= dataset5.Tables["mfee"].Rows.Count - 1; i++)
			{
				ysum = ysum + dataset5.Tables["mfee"].Rows[i][0];
			}
			txtYearSum.Text = System.Convert.ToString(ysum);
			
			
			sqlstr = "select fee from orders where stime>='" + cmbYear.Text + "/" + cmbMon.Text + "/01' And stime<='" + cmbYear.Text + "/" + cmbMon.Text + "/30'";
			OleDbDataAdapter1 = new OleDbDataAdapter(System.Convert.ToString(sqlstr), OleDbConnection1);
			dataset6.Reset();
			OleDbDataAdapter1.Fill(dataset6, "mfee");
			var msum = 0;
			for (var i = 0; i <= dataset6.Tables["mfee"].Rows.Count - 1; i++)
			{
				msum = msum + dataset6.Tables["mfee"].Rows[i][0];
			}
			txtMonSum.Text = System.Convert.ToString(msum);
			
			
		}
		
		public void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		//窗体加载
		public void Form2_Load(object sender, EventArgs e)
		{
			sqlstr = "select orderno,stime,fee from orders ";
			OleDbDataAdapter1 = new OleDbDataAdapter(System.Convert.ToString(sqlstr), OleDbConnection1);
			objdataset.Reset();
			OleDbDataAdapter1.Fill(objdataset, "收益");
			DataGridView1.DataSource = objdataset.Tables["收益"];
			DataGridView1.Columns[0].HeaderText = "订单号";
			
			string sql = "select distinct datename(yy,stime) as year from orders ";
			dataset2.Reset();
			OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter(sql, OleDbConnection1);
			OleDbDataAdapter1.Fill(dataset2, "y");
			cmbYear.DataSource = dataset2.Tables["y"];
			for (var i = 0; i <= dataset2.Tables["y"].Rows.Count - 1; i++)
			{
				cmbYear.ValueMember = dataset2.Tables["y"].Columns[0].ToString();
			}
			cmbYear.Text = "";
			sql = "select distinct datename(dd,stime) as year from orders ";
			dataset3.Reset();
			OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter(sql, OleDbConnection1);
			OleDbDataAdapter1.Fill(dataset3, "d");
			cmbDay.DataSource = dataset3.Tables["d"];
			for (var i = 0; i <= dataset3.Tables["d"].Rows.Count - 1; i++)
			{
				cmbDay.ValueMember = dataset3.Tables["d"].Columns[0].ToString();
			}
			cmbDay.Text = "";
			sql = "select distinct datename(mm,stime) as year from orders ";
			dataset1.Reset();
			OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter(sql, OleDbConnection1);
			OleDbDataAdapter1.Fill(dataset1, "m");
			cmbMon.DataSource = dataset1.Tables["m"];
			for (var i = 0; i <= dataset1.Tables["m"].Rows.Count - 1; i++)
			{
				cmbMon.ValueMember = dataset1.Tables["m"].Columns[0].ToString();
			}
			cmbMon.Text = "";
		}
		
		
	}
}
