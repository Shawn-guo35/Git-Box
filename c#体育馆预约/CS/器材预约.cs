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
using System.Configuration;
using System.Windows.Forms;
// End of VB project level imports

using static System.String;
using WindowsApp1;
using MySql.Data.MySqlClient;




namespace WindowsApp1
{
    public partial class 器材预约 : Form
    {
        public 器材预约()
        {
            InitializeComponent();
            //Added to support default instance behavour in C#

        }
        public static string conn = ConfigurationManager.ConnectionStrings["connstr"].ToString();
        MySqlConnection con;
        MySqlCommand cm;
        MySqlDataAdapter sqld;
        DataSet ds;
        ConDatabase ConDatabase = new ConDatabase();

        private void 器材预约_Load(object sender, EventArgs e)
        {

            btnSubmit1.Visible = false;
            Label4.Visible = false;
            cbmEqmnum.Visible = false;
            dtpTime.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            txtEndtime.Visible = false;
            cmbEqintime.Visible = false;
            btnSubmit2.Visible = false;
            Label3.Visible = true;
            dtpTime.MinDate = DateTime.Now;
            dtpTime.MaxDate = DateTime.Now.AddDays(6); //只可预订一周的场地
            ds = new DataSet();
            using (con = new MySqlConnection(conn))//链接数据库
            {
                sqld = new MySqlDataAdapter("select Eqremain from Equipment where Eqname = '篮球' ", con);//最后一个字符串为数据库的链接名
                sqld.Fill(ds, "ss");
            }
            //odadSelBaseket = new System.Data.OleDb.OleDbDataAdapter(sql, OleDbConnection1);
            //odadSelBaseket.Fill(dstSelOrder, "ss");
            //cbmEqmnum.DataSource = ds.Tables["ss"];
            for (var i = 0; i <= ds.Tables["ss"].Rows.Count - 1; i++)
            {
                int x = 0;
                x = x + 1;
                cbmEqmnum.ValueMember = Convert.ToString(x); //填充下拉栏里的场地号
            }
        }
    }
}
