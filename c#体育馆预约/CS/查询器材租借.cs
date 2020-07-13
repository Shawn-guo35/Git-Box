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
    public partial class 查询器材租借 : Form
    {
        public 查询器材租借()
        {
            InitializeComponent();
        }
        public static string conn = ConfigurationManager.ConnectionStrings["connstr"].ToString();
        MySqlConnection con;
        MySqlCommand cm;
        MySqlDataAdapter sqld;
        DataSet ds;
        ConDatabase ConDatabase = new ConDatabase();
        private void 查询器材租借_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            using (con = new MySqlConnection(conn))//链接数据库
            {
                sqld = new MySqlDataAdapter("select Elseq as 序号,Eqnamel as 器材名称,Elnum as 租借数量,Uidl as 用户账号,Unamel as 用户姓名,Elstart as 开始时间,Elend as 结束时间,Elcharge as 租借收费,Eldcharge as 押金收费,Elremarks as 订单备注 from  Eqlease", con);//最后一个字符串为数据库的链接名
                sqld.Fill(ds, "Eql");
            }
            gvwEql.DataSource = ds.Tables["Eql"].DefaultView;
        }

        private void btnUpdateUsers_Click(object sender, EventArgs e)
        {
            MySqlCommandBuilder scb = new MySqlCommandBuilder(sqld);
            sqld.Update(ds.Tables["Eql"]);


            Interaction.MsgBox("数据已修改", MsgBoxStyle.Information, "恭喜");
        }

        private void btnInsertEql_Click(object sender, EventArgs e)
        {
            string s = "";
            if (txtCondition.Text == "")
            {
                Interaction.MsgBox("请输入器材名称", MsgBoxStyle.Exclamation, "警告");
                return;
            }
            else
            {
                ds.Tables["Eql"].Clear();
                s = "select  Elseq as 序号,Eqnamel as 器材名称,Elnum as 租借数量,Uidl as 用户账号,Unamel as 用户姓名,Elstart as 开始时间,Elend as 结束时间,Elcharge as 租借收费,Eldcharge as 押金收费,Elremarks as 订单备注  from  Eqlease  where  Eqnamel ='" + txtCondition.Text + "'";
                sqld.SelectCommand.CommandText = s;
                sqld.Fill(ds, "Eql");
                gvwEql.DataSource = ds.Tables["Eql"];
            }
        }
    }
}
