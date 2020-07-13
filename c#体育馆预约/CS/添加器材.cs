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
    public partial class 添加器材 : Form
    {
        public 添加器材()
        {
            InitializeComponent();
        }
        public static string conn = ConfigurationManager.ConnectionStrings["connstr"].ToString();
        MySqlConnection con;
        MySqlCommand cm;
        MySqlDataAdapter sqld;
        DataSet ds;
        ConDatabase ConDatabase = new ConDatabase();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtEqname.Text == null)
            {
                MessageBox.Show("请输入器材名称！");
            }
            else if(txtEqtotal.Text == null)
            {
                MessageBox.Show("请输入器材总量！");
            }
            else if(txtEqrank.Text == null)
            {
                MessageBox.Show("请输入租借价格！");
            }
            else if(txtEqdeposit.Text == null)
            {
                MessageBox.Show("请输入押金金额！");
            }
            else
            {
                con = new MySqlConnection(conn);
                con.Open();
                cm = new MySqlCommand("select * from Equipment where Eqname='" + txtEqname.Text + "'", con);
                var num1 = Convert.ToInt32(cm.ExecuteScalar());
                if (num1 == 0)
                {

                    string sqlstr = "insert into  Equipment(Eqname,Eqtotal,Eqrank,Eqdeposit,Eqremain,Eqremarks)  values('" + txtEqname.Text + "','" + txtEqtotal.Text + "','" + txtEqrank.Text + "','" + txtEqdeposit.Text + "','" + txtEqtotal.Text + "','" + txtEqramk.Text + "')";
                    cm = new MySqlCommand(sqlstr, con);
                    cm.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    登录界面.Default.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("该器材已存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void 添加器材_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            using (con = new MySqlConnection(conn))//链接数据库
            {
                sqld = new MySqlDataAdapter("select Eqseq as 序号,Eqname as 器材名称,Eqtotal as 器材总量,Eqrank as 租借价格,Eqdeposit as 押金金额,Eqremain as 器材余量,Eqremarks as 器材备注 from Equipment", con);//最后一个字符串为数据库的链接名
                sqld.Fill(ds, "eq");
            }
            gvwEq.DataSource = ds.Tables["eq"].DefaultView;
        }
    }
}
