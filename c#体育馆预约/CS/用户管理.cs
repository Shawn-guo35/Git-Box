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
using MySql.Data.MySqlClient;
using WindowsApp1;
using System.Configuration;

namespace WindowsApp1
{
	public partial class 用户管理 : System.Windows.Forms.Form
	{
		public 用户管理()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
            this.AutoScaleMode = AutoScaleMode.Dpi;
		}
		
#region Default Instance
		
		private static 用户管理 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static 用户管理 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new 用户管理();
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
        ConDatabase ConDatabase = new ConDatabase();
        public void 用户管理系统_Load(object sender, EventArgs e)
		{
            //TODO: 这行代码将数据加载到表“ChangguanDataSet1.Users”中。您可以根据需要移动或删除它。
            //this.UsersTableAdapter.Fill(this.ChangguanDataSet1.Users);
            //con = new MySqlConnection(conn);
            //con.Open();
            //cm = new MySqlCommand("select count(*) from Users");
            //cm = con.CreateCommand();
            //cm.CommandText = "select count(*) from Users";
            //string ConnectionStr = string.Format("server=121.36.57.112;Uid=customer;password=Summer2020;Database=summer2020;Charset=utf8;");
            //string SqlStr = string.Format("select count(*) from Users");
            //MySqlDataAdapter adapter = new MySqlDataAdapter(SqlStr, ConnectionStr);
            //DataSet ds1 = new DataSet();
            //adapter.Fill(ds1);
            //gvwUsers.DataSource = ds1;
            //string sqlCconnStr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            //连接数据库 
            ds = new DataSet();
            using (con = new MySqlConnection(conn))//链接数据库
            {
                sqld = new MySqlDataAdapter("select * from Users", con);//最后一个字符串为数据库的链接名
                sqld.Fill(ds, "userm");
            }
            gvwUsers.DataSource = ds.Tables["userm"].DefaultView;



        }
		
		public void btnUpdateUsers_Click(object sender, EventArgs e)
		{
            //ds = new DataSet();
            //using (con = new MySqlConnection(conn))//链接数据库
            //{
            //    sqld = new MySqlDataAdapter("select * from Users", con);//最后一个字符串为数据库的链接名
            //    sqld.Fill(ds, "userm");
            //}
            //gvwUsers.DataSource = ds.Tables["userm"].DefaultView;
            //sqld.Update(ds.Tables["userm"]);

            MySqlCommandBuilder scb = new MySqlCommandBuilder(sqld);
            sqld.Update(ds.Tables["userm"]);


            Interaction.MsgBox("数据已修改", MsgBoxStyle.Information, "恭喜");
		}
		
		public void btnDeleteUsers_Click(object sender, EventArgs e)
		{
            //         MySqlCommandBuilder scb = new MySqlCommandBuilder(sqld);
            //         int x = 0;
            //if ((int)Interaction.MsgBox("您真的删除该条数据吗？", (int) MsgBoxStyle.YesNo + MsgBoxStyle.Question, "删除数据") == (int)DialogResult.Yes)
            //{
            //	x = gvwUsers.CurrentRow.Index; //gvw中选择的行号
            //             ds.Tables["userm"].Rows[x].Delete();
            //             sqld.Update(ds.Tables["userm"]);
            //	Interaction.MsgBox("删除成功", MsgBoxStyle.Information, "恭喜");
            //}
            int x = 0; //要删除的行数
            if ((int)Interaction.MsgBox("您真的删除该条数据吗？", (int)MsgBoxStyle.YesNo + MsgBoxStyle.Question, "删除数据") == (int)DialogResult.Yes)
            {
                //x = gvwVtype.CurrentRow.Index;
                //ds.Tables["Vtype"].Rows[x].Delete();
                //SqlDataAdapter1.Update(ChangguanDataSet1);
                //MySqlDataAdapter adapter = new MySqlDataAdapter();
                string delecom = "delete from Users where Useq = '" + gvwUsers.CurrentRow.Cells[0].Value + "'";
                //adapter.Update(ds);
                cm = ConDatabase.OpenDatabase(delecom);
                cm.ExecuteNonQuery();
                Interaction.MsgBox("删除成功", MsgBoxStyle.Information, "恭喜");
            }
        }
		
		public void btnInsertUsers_Click(object sender, EventArgs e)
		{
			string s = "";
			if (txtCondition.Text == "")
			{
				Interaction.MsgBox("请输入查询条件", MsgBoxStyle.Exclamation, "警告");
				return;
			}
			//三种查询用户的方式
			if ((string) cbmGym.SelectedItem == "帐号")
			{
				ds.Tables["userm"].Clear();
				s = "select  *  from  Users  where  Uid ='" + txtCondition.Text + "'";
                sqld.SelectCommand.CommandText = s;
                sqld.Fill(ds, "userm");
				gvwUsers.DataSource = ds.Tables["userm"];
			}
			else if ((string) cbmGym.SelectedItem == "姓名")
			{
				ds.Tables["userm"].Clear();
				s = "select  *  from  Users  where  Uname = '" + txtCondition.Text + "'";
                sqld.SelectCommand.CommandText = s;
                sqld.Fill(ds, "userm");
				gvwUsers.DataSource = ds.Tables["userm"];
			}
			else if ((string) cbmGym.SelectedItem == "身份")
			{
                ds.Tables["userm"].Clear();
				s = "select  *  from  Users  where Uidentity = '" + txtCondition.Text + "'";
                sqld.SelectCommand.CommandText = s;
                sqld.Fill(ds, "userm");
				gvwUsers.DataSource = ds.Tables["userm"];
			}
		}
		
		
		public void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gvwUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
	
	
}
