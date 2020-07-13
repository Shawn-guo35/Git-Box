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
                sqld = new MySqlDataAdapter("select Eqseq as 序号,Eqname as 器材名称,Eqtotal as 器材总量,Eqrank as 租借价格,Eqdeposit as 押金金额,Eqremain as 器材余量,Eqremarks as 器材备注 from Equipment", con);//最后一个字符串为数据库的链接名
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

        private void btnInsertVenue_Click_1(object sender, EventArgs e)
        {
            Form form = new 添加器材();
            form.Show();
        }

        private void btnInsertVtype_Click_1(object sender, EventArgs e)
        {
            Form form = new 修改器械信息();
            form.Show();
        }

        private void btnSelectLease_Click_1(object sender, EventArgs e)
        {
            Form form = new 查询器材租借();
            form.Show();
        }
    }
}
