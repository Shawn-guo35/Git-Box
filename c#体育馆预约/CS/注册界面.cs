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
using System.Data.SqlClient;
using WindowsApp1;
using System.Configuration;

namespace WindowsApp1
{
	public partial class 注册界面
	{

        public 注册界面()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
        public static string conn = ConfigurationManager.ConnectionStrings["connstr"].ToString();
        MySqlConnection con;
        MySqlCommand cm;
        #region Default Instance

        private static 注册界面 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static 注册界面 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new 注册界面();
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
		public void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
			登录界面.Default.Show();
		}
		
		public void btnRegister_Click(object sender, EventArgs e)
		{
			if (txtID.Text == "")
			{
				MessageBox.Show("请输入账号！");
			}
			if (txtPwd.Text == "")
			{
				MessageBox.Show("请输入密码！");
			}
			if (txtCpwd.Text == "")
			{
				MessageBox.Show("请再次输入密码！");
			}
			if (txtPwd.Text == "")
			{
				MessageBox.Show("请输入姓名！");
			}
			if (txtPwd.Text != txtCpwd.Text)
			{
				MessageBox.Show("两次输入密码不一致");
			}
            //string conn = "server=121.36.57.112;Uid=customer;password=Summer2020;Database=summer2020";
            con = new MySqlConnection(conn);
            con.Open();
            if (radInside.Checked)
			{
				cm = new MySqlCommand("select count(*) from Users where Uid='" + txtID.Text + "'", con);
				var num1 = Convert.ToInt32(cm.ExecuteScalar());
				if (num1 == 0)
				{

                    string sqlstr = "insert into  Users(Uid,Uname,Uidentity,Upwd,Uphone)  values('" + txtID.Text + "','" + txtName.Text + "','" + "校内人员 " + "','" + txtPwd.Text + "','" + txtID.Text + "')";
					cm = new MySqlCommand(sqlstr, con);
					cm.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
					登录界面.Default.Show();
					this.Visible = false;
				}
				else
				{
					MessageBox.Show("该账户已存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else if (radOutside.Checked)
			{
				cm = new MySqlCommand("select count(*) from Users where Uid='" + txtID.Text + "'", con);
				var num2 = Convert.ToInt32(cm.ExecuteScalar());
				if (num2 == 0)
				{
					
					string sqlstr = "insert into  Users(Uid,Uname,Uidentity,Upwd,Uphone) values('" + txtID.Text + "','" + txtName.Text + "','" + radOutside.Text + "','" + txtPwd.Text + "','" + txtID.Text + "')";
					cm = new MySqlCommand(sqlstr, con);
					cm.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
					登录界面.Default.Show();
					this.Visible = false;
				}
				else
				{
					MessageBox.Show("该账户已存在", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				
			}
			else
			{
				MessageBox.Show("请选择身份！");
			}
			
		}
		
		public void 注册界面_Load(object sender, EventArgs e)
		{
			
		}
		
		public void RadioButton2_CheckedChanged(object sender, EventArgs e)
		{
			
			Label6.Text = "(手机号码注册)";
			
		}
		
		public void RadioButton1_CheckedChanged(object sender, EventArgs e)
		{
			Label6.Text = "(学号/工号注册)";
		}
	}
}
