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
using System.Configuration;
using System.Data.OleDb;
using WindowsApp1;
using MySql.Data.MySqlClient;

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
        public static string conn = ConfigurationManager.ConnectionStrings["connstr"].ToString();
        MySqlConnection con;
        MySqlCommand cm;
        MySqlDataAdapter sqld;
        DataSet ds;
        ConDatabase ConDatabase = new ConDatabase();
        string sqlstr;
		
		public void btnSelIncome_Click(object sender, EventArgs e)
		{
            con = new MySqlConnection(conn);
            string time = cmbYear.Text + cmbMon.Text + cmbDay.Text;
            //sqlstr = "select Vramount from Vorder where Vrend >='" + cmbYear.Text + "-" + cmbMon.Text + "-" + cmbDay.Text + "00:00:00' And Vrend<='" + cmbYear.Text + "-" + cmbMon.Text + "-" + cmbDay.Text + "23:59:59'";
            //sqlstr = "select Vramount from Vorder where  Vrend(varchar(10),[add_time],111) = '" + cmbYear.Text + cmbMon.Text + cmbDay.Text + "'";
            sqlstr = "select Vramount from Vorder where Vrend >='" + time + "' And Vrend<='" + time + "'";
            sqld = new MySqlDataAdapter(sqlstr, con);
			dataset4.Reset();
			sqld.Fill(dataset4, "dfee");
			var dsum = 0;
			for (var i = 0; i <= dataset4.Tables["dfee"].Rows.Count - 1; i++)
			{
				dsum = dsum + Convert.ToInt32(dataset4.Tables["dfee"].Rows[i][0]);
            }
			txtDaySum.Text = System.Convert.ToString(dsum);
			
			sqlstr = "select Vramount from Vorder where Vrend>='" + cmbYear.Text + "/01/01' And Vrend<='" + cmbYear.Text + "/12/30'";
			sqld = new MySqlDataAdapter(sqlstr, con);
			dataset5.Reset();
			sqld.Fill(dataset5, "yfee");
			var ysum = 0;
			for (var i = 0; i <= dataset5.Tables["yfee"].Rows.Count - 1; i++)
			{
                ysum = ysum + Convert.ToInt32(dataset5.Tables["yfee"].Rows[i][0]);

            }
			txtYearSum.Text = System.Convert.ToString(ysum);
            


            sqlstr = "select Vramount from Vorder where Vrend>='" + cmbYear.Text + "/" + cmbMon.Text + "/01' And Vrend<='" + cmbYear.Text + "/" + cmbMon.Text + "/31'";
			sqld = new MySqlDataAdapter(sqlstr, con);
			dataset6.Reset();
			sqld.Fill(dataset6, "mfee");
			var msum = 0;
			for (var i = 0; i <= dataset6.Tables["mfee"].Rows.Count - 1; i++)
			{
				msum = msum + Convert.ToInt32(dataset6.Tables["mfee"].Rows[i][0]);
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
            ds = new DataSet();
            con = new MySqlConnection(conn);
            sqlstr = "select Vrid,Vrstart,Vramount from Vorder ";
            sqld = new MySqlDataAdapter(sqlstr, con);
			ds.Reset();
            sqld.Fill(objdataset, "income");
			dgwIncome.DataSource = objdataset.Tables["income"];
			dgwIncome.Columns[0].HeaderText = "订单号";
			
			string sql = "select  YEAR(Vrend)  from Vorder group by YEAR(Vrend)";
			dataset2.Reset();
            sqld = new MySqlDataAdapter(sql, con);
            sqld.Fill(dataset2, "y");
			cmbYear.DataSource = dataset2.Tables["y"];
			for (var i = 0; i <= dataset2.Tables["y"].Rows.Count - 1; i++)
			{
				cmbYear.ValueMember = dataset2.Tables["y"].Columns[0].ToString();
			}
			cmbYear.Text = "";
			sql = "select  day(Vrend)  from Vorder group by day(Vrend)";
			dataset3.Reset();
			sqld = new MySqlDataAdapter(sql, con);
			sqld.Fill(dataset3, "d");
			cmbDay.DataSource = dataset3.Tables["d"];
			for (var i = 0; i <= dataset3.Tables["d"].Rows.Count - 1; i++)
			{
				cmbDay.ValueMember = dataset3.Tables["d"].Columns[0].ToString();
			}
			cmbDay.Text = "";
			sql = "select  month(Vrend)  from Vorder group by month(Vrend)";
			dataset1.Reset();
			sqld = new MySqlDataAdapter(sql, con);
			sqld.Fill(dataset1, "m");
			cmbMon.DataSource = dataset1.Tables["m"];
			for (var i = 0; i <= dataset1.Tables["m"].Rows.Count - 1; i++)
			{
				cmbMon.ValueMember = dataset1.Tables["m"].Columns[0].ToString();
			}
			cmbMon.Text = "";
		}
		
		
	}
}
