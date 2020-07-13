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
using CCWin;

namespace WindowsApp1
{
    public partial class 修改器械信息 : Skin_VS
    {
        public 修改器械信息()
        {
            InitializeComponent();
        }

        public static string conn = ConfigurationManager.ConnectionStrings["connstr"].ToString();
        MySqlConnection con;
        MySqlCommand cm;
        MySqlDataAdapter sqld;
        DataSet ds;
        ConDatabase ConDatabase = new ConDatabase();

        private void 修改器械信息_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            using (con = new MySqlConnection(conn))//链接数据库
            {
                sqld = new MySqlDataAdapter("select Eqseq as 序号,Eqname as 器材名称,Eqtotal as 器材总量,Eqrank as 租借价格,Eqdeposit as 押金金额,Eqremain as 器材余量,Eqremarks as 器材备注 from Equipment", con);//最后一个字符串为数据库的链接名
                sqld.Fill(ds, "Eq");
            }
            gvwEq.DataSource = ds.Tables["Eq"].DefaultView;
        }

        private void btnUpdateEq_Click(object sender, EventArgs e)
        {
            MySqlCommandBuilder scb = new MySqlCommandBuilder(sqld);
            sqld.Update(ds.Tables["Eq"]);


            Interaction.MsgBox("数据已修改", MsgBoxStyle.Information, "恭喜");
        }

        private void btnDeleteEq_Click(object sender, EventArgs e)
        {
            int x = 0; //要删除的行数
            if ((int)Interaction.MsgBox("您真的删除该条数据吗？", (int)MsgBoxStyle.YesNo + MsgBoxStyle.Question, "删除数据") == (int)DialogResult.Yes)
            {

                string delecom = "delete from Equipment where Eqseq = '" + gvwEq.CurrentRow.Cells[0].Value + "'";
                //adapter.Update(ds);
                cm = ConDatabase.OpenDatabase(delecom);
                cm.ExecuteNonQuery();
                Interaction.MsgBox("删除成功", MsgBoxStyle.Information, "恭喜");
            }
        }

        private void btnInsertEq_Click(object sender, EventArgs e)
        {
            string s = "";
            if (txtCondition.Text == "")
            {
                Interaction.MsgBox("请输入器材名称", MsgBoxStyle.Exclamation, "警告");
                return;
            }
            else
            {
                ds.Tables["Eq"].Clear();
                s = "select  *  from  Equipment  where  Eqname ='" + txtCondition.Text + "'";
                sqld.SelectCommand.CommandText = s;
                sqld.Fill(ds, "Eq");
                gvwEq.DataSource = ds.Tables["Eq"];
            }
        }
    }
}
    
