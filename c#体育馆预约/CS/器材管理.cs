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
using MySql.Data.MySqlClient;
using WindowsApp1;
using System.Configuration;

namespace WindowsApp1
{
    public partial class 器材管理 : Form
    {
        public 器材管理()
        {
            InitializeComponent();
        }
        public static string conn = ConfigurationManager.ConnectionStrings["connstr"].ToString();
        MySqlConnection con;
        MySqlCommand cm;
        MySqlDataAdapter sqld;
        DataSet ds;
        ConDatabase ConDatabase = new ConDatabase();
        private void 器材管理_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            using (con = new MySqlConnection(conn))//链接数据库
            {
                sqld = new MySqlDataAdapter("select * from Equipment", con);//最后一个字符串为数据库的链接名
                sqld.Fill(ds, "Equipment");
            }
            dataGridView1.DataSource = ds.Tables["Equipment"].DefaultView;
        }

        private void btnInsertVenue_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertVtype_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectLease_Click(object sender, EventArgs e)
        {

        }
    }
}
