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
        public static string conn = ConfigurationManager.ConnectionStrings["connstr"].ToString();
        MySqlConnection con;
        MySqlCommand cm;
        MySqlDataAdapter sqld;
        DataSet ds;
        DataSet ds1;
        DataSet ds2;
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
				sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Uidr='" + txtID.Text + "' AND Vrstart='" + txtStime.Text + "' AND Vtnamer='" + cmbPlaceName.Text + "'";
				dispp(sqlstr);
			}
			
			if (txtID.Text == "")
			{
				sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Vrstart='" + txtStime.Text + "' AND Vtnamer='" + cmbPlaceName.Text + "' AND Vnidr='" + cmbPlaceNo.Text + "'";
				dispp(sqlstr);
			}
			if (txtStime.Text == "")
			{
				sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Uidr='" + txtID.Text + "' AND Vtnamer='" + cmbPlaceName.Text + "' AND Vnidr='" + cmbPlaceNo.Text + "'";
				dispp(sqlstr);
			}
            if (cmbPlaceName.Text == "")
            {
                sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Uidr='" + txtID.Text + "' AND Vrstart='" + txtStime.Text + "' AND Vnidr='" + cmbPlaceNo.Text + "'";
                dispp(sqlstr);
            }


            //双重
            if (txtStime.Text == "" && cmbPlaceNo.Text == "")
			{
				sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Uidr='" + txtID.Text + "' AND Vtnamer='" + cmbPlaceName.Text + "'";
				dispp(sqlstr);
			}
			if (txtID.Text == "" && cmbPlaceNo.Text == "")
			{
				sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Vrstart='" + txtStime.Text + "' AND Vtnamer='" + cmbPlaceName.Text + "'";
				dispp(sqlstr);
			}
			if (cmbPlaceNo.Text == "" && cmbPlaceName.Text == "")
			{
				sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Vrstart='" + txtStime.Text + "' AND Uidr='" + txtID.Text + "'";
				dispp(sqlstr);
			}
			if (txtID.Text == "" && txtStime.Text == "")
			{
				sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Vtnamer='" + cmbPlaceName.Text + "' AND Vnidr='" + cmbPlaceNo.Text + "'";
				dispp(sqlstr);
			}
            if (txtID.Text == "" && cmbPlaceName.Text == "")
            {
                sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Vrstart='" + txtStime.Text + "' AND Vnidr='" + cmbPlaceNo.Text + "'";
                dispp(sqlstr);
            }
            if (txtStime.Text == "" && cmbPlaceName.Text == "")
            {
                sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Uidr='" + txtID.Text + "' AND Vnidr='" + cmbPlaceNo.Text + "'";
                dispp(sqlstr);
            }


            //单次查询

            if (txtStime.Text == "" && cmbPlaceName.Text == "" && cmbPlaceNo.Text == "")
			{
				sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Uidr='" + txtID.Text + "'";
				dispp(sqlstr);
			}
			if (txtID.Text == "" && cmbPlaceName.Text == "" && cmbPlaceNo.Text == "")
			{
				sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Vrstart='" + txtStime.Text + "'";
				dispp(sqlstr);
			}
			if (txtID.Text == "" && txtStime.Text == "" && cmbPlaceNo.Text == "")
			{
				sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Vtnamer='" + cmbPlaceName.Text + "'";
				dispp(sqlstr);
			}
            if (txtID.Text == "" && txtStime.Text == "" && cmbPlaceName.Text == "")
            {
                sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Vnidr='" + cmbPlaceNo.Text + "'";
                dispp(sqlstr);
            }

        }
		public void dispp(dynamic sql)
		{
            ds = new DataSet();
            con = new MySqlConnection(conn);
            sqld = new MySqlDataAdapter(sqlstr, con);
			sqld.Fill(ds, "orders");
			gvwOrders.DataSource = ds.Tables["orders"];
		}
		
		
		//订单查找
		public void btnSelOrder_Click(object sender, EventArgs e)
		{
			sqlstr = "select select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder where Vrid='" + txtOrderNo.Text + "'";
			dispp(sqlstr);
		}
		//窗体加载
		public void Form1_Load(object sender, EventArgs e)
		{
            //sqlstr = "select * from orders ";
            //OleDbDataAdapter1 = new OleDbDataAdapter(sqlstr, OleDbConnection1);
            //objdataset.Reset();
            //OleDbDataAdapter1.Fill(objdataset, "订单");
            //DataGridView1.DataSource = objdataset.Tables["订单"];
            //DataGridView1.Columns[0].HeaderText = "编号";
            ds = new DataSet();
            using (con = new MySqlConnection(conn))//链接数据库
            {
                sqld = new MySqlDataAdapter("select Vrseq as 序号,Vrid as 编号,Uidr as 用户账号,Unamer as 用户姓名,Vramount as 订单金额,Vtnamer as 场地名称,Vnidr as 场地编号,Vrstart as 开始时间,Vrend as 结束时间,Vrstate as 订单状态,Vrremarks as 订单备注 from Vorder", con);//最后一个字符串为数据库的链接名
                sqld.Fill(ds, "orderm");
            }
            gvwOrders.DataSource = ds.Tables["orderm"].DefaultView;

            ds1 = new DataSet();
            sqlstr = "select Vnidr from Vorder ";
            ds1.Reset();
            sqld = new MySqlDataAdapter(sqlstr, con);
            sqld.Fill(ds1, "Vno");
            cmbPlaceNo.DataSource = ds1.Tables["Vno"];
            for (var i = 0; i <= ds1.Tables["Vno"].Rows.Count - 1; i++)
            {
                cmbPlaceNo.ValueMember = ds1.Tables["Vno"].Columns[0].ToString();
            }
            cmbPlaceNo.Text = "";

            ds2 = new DataSet();
            sqlstr = "select distinct Vtnamer from Vorder ";
            ds2.Reset();
            sqld = new MySqlDataAdapter(sqlstr, con);
            sqld.Fill(ds2, "Vname");
            cmbPlaceName.DataSource = ds2.Tables["Vname"];
            for (var i = 0; i <= ds2.Tables["Vname"].Rows.Count - 1; i++)
            {
                cmbPlaceName.ValueMember = ds2.Tables["Vname"].Columns[0].ToString();
            }
            cmbPlaceName.Text = "";
        }
	}
	
}
