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
        string sqlstr;

        private void 器材预约_Load(object sender, EventArgs e)
        {


            dtpTime.MinDate = DateTime.Now;
            dtpTime.MaxDate = DateTime.Now.AddDays(6); //只可预订一周的场地
            //ds = new DataSet();
            //using (con = new MySqlConnection(conn))//链接数据库
            //{
            //    sqld = new MySqlDataAdapter("select Eqremain from Equipment where Eqname = '篮球' ", con);//最后一个字符串为数据库的链接名
            //    sqld.Fill(ds, "ss");
            //}
            //odadSelBaseket = new System.Data.OleDb.OleDbDataAdapter(sql, OleDbConnection1);
            //odadSelBaseket.Fill(dstSelOrder, "ss");
            cm = ConDatabase.OpenDatabase("select Eqremain from Equipment where Eqname = '篮球'");
            con = ConDatabase.getCon();
            label5.Text = "最大数量为"+ Convert.ToInt32(cm.ExecuteScalar());
            ds = new DataSet();
            con = new MySqlConnection(conn);
            sqlstr = "select Eqseq as 序号,Eqname as 器材名称,Eqtotal as 器材总量,Eqrank as 租借价格,Eqdeposit as 押金金额,Eqremain as 器材余量,Eqremarks as 器材备注 from Equipment where Eqname = '篮球'";
            sqld = new MySqlDataAdapter(sqlstr, con);
            ds.Reset();
            sqld.Fill(ds, "income");
            dgvOrder.DataSource = ds.Tables["income"];


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnEqmorder_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit2_Click(object sender, EventArgs e)
        {
            if(txtEqmnum.Text == null)
            {
                MessageBox.Show("请输入租借器材数量！");
            }
            else if (txtOrderID.Text == null)
            {
                MessageBox.Show("请输入租借人账号！");
            }
            else
            {
                ds = new DataSet();
                string name = "select Uphone,Uname from v_users where Uid = '" + txtOrderID.Text + "'";
                cm = ConDatabase.OpenDatabase(name);
                sqld = new MySqlDataAdapter(cm);
                sqld.Fill(ds, "userinfo");
                string userPhone = ds.Tables["userinfo"].Rows[0][0].ToString();
                string username = ds.Tables["userinfo"].Rows[0][1].ToString();
                string Stime = dtpTime.Value.Date.ToString("yyyy-MM-dd") + " " + cmbEqintime.SelectedItem.ToString();
                string Etime = dtpTime.Value.Date.ToString("yyyy-MM-dd") + " " + txtEndtime.Text;
                userPhone = userPhone.Remove(3, 4);
                string disnum = userPhone + "1";
                string ordernum;
                Stime = dtpTime.Value.Date.ToString("yyyy-MM-dd") + " " + cmbEqintime.SelectedItem.ToString();
                Etime = dtpTime.Value.Date.ToString("yyyy-MM-dd") + " " + txtEndtime.Text;
                ds = new DataSet();
                string fees = "select Eqrank,Eqdeposit from Equipment where Eqname = '篮球'";
                cm = ConDatabase.OpenDatabase(fees);
                sqld = new MySqlDataAdapter(cm);
                sqld.Fill(ds, "userfee");
                string fee = ds.Tables["userfee"].Rows[0][0].ToString();
                string dfee = ds.Tables["userfee"].Rows[0][1].ToString();
                string str = "确定租借" + Stime + "到" + Etime + "的"+ txtEqmnum .Text+ "个篮球吗？";

                //ordernum = disnum + 2 + DateAndTime.Now.Year.ToString() + DateAndTime.Now.Month.ToString()
                //        + DateAndTime.Now.Day.ToString() + DateAndTime.Now.Hour.ToString() + DateAndTime.Now.Minute.ToString();
                if ((int)Interaction.MsgBox(str, Constants.vbOKCancel, null) == 1)
                {
                    if ((int)Interaction.MsgBox("本次押金为" + System.Convert.ToString(dfee) + "元", Constants.vbOKCancel, null) == 1)
                    {

                        string sql1 = "update Equipment set Eqremain =  Eqremain - '" + txtEqmnum.Text + "'  ";

                        string sql2 = "insert into Eqlease(Eqnamel,Elnum,Uidl,Unamel,Elstart,Elend,Elcharge,Eldcharge,Elremarks) values('篮球','" + txtEqmnum.Text + "','" +
                            txtOrderID.Text + "','" + username + "','" + Stime + "','" + Etime + "','" + fee + "','" + dfee + "','未完成')";


                        cm = ConDatabase.OpenDatabase(sql1);
                        cm.ExecuteNonQuery();
                        cm = ConDatabase.OpenDatabase(sql2);
                        cm.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("租借成功");
                    }
                }


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
