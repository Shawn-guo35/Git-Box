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

using System.Data.SqlClient;
using WindowsApp1;
using MySql.Data.MySqlClient;

namespace WindowsApp1
{
	public partial class 登录界面
	{
		public 登录界面()
		{
			InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Font;
            //Added to support default instance behavour in C#
            if (defaultInstance == null)
				defaultInstance = this;
            
		}
		
#region Default Instance
		
		private static 登录界面 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static 登录界面 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new 登录界面();
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
        ConDatabase ConDatabase = new ConDatabase();
        MySqlConnection con;
        MySqlCommand cm;
        
		
		public void 登陆界面_Load(object sender, EventArgs e)
		{
			//登录界面为启动页面为了让欢迎界面先出现 设置两个timer来登录界面隐藏
			欢迎界面.Default.Show();
			Timer1.Interval = 1; //1000=1秒
			Timer1.Enabled = true;
			Timer2.Interval = 3000; //1000=1秒
			Timer2.Enabled = true;
            this.WindowState = FormWindowState.Maximized;
            
        }
		
		public void Timer1_Tick(object sender, EventArgs e)
		{
			this.Hide();
			Timer1.Enabled = false;
		}
		
		
		public void Timer2_Tick(object sender, EventArgs e)
		{
			this.Show();
			Timer2.Enabled = false;
		}
		
		public void btnRegister_Click(object sender, EventArgs e)
		{
			this.Hide();
			注册界面.Default.Show();
		}
		
		public void btnLogin2_Click(object sender, EventArgs e)
		{
            //调试
            //用户界面.Default.Show();
            //this.Visible = false;
            cm = ConDatabase.OpenDatabase("select * from v_users where Uid='" + txtID.Text + "'and Upwd='" + txtPwd.Text + "'and Uidentity='管理员'" );
            con = ConDatabase.getCon();
            if (txtID.Text == "")
            {
                MessageBox.Show("请输入账号！");

            }
            else if (txtPwd.Text == "")
            {
                MessageBox.Show("请输入密码！");
            }
            else
            {
                //string conn = "server=121.36.57.112;Uid=customer;password=Summer2020;Database=summer2020";
                //con = new MySqlConnection(conn);
                //con.Open();                
                //cm = new MySqlCommand("select * from v_users where Uid='" + txtID.Text + "'and Upwd='" + txtPwd.Text + "'", con);
                var num1 = Convert.ToInt32(cm.ExecuteScalar());
                if (num1 > 0)
                {                    
                    con.Close();
                    //MessageBox.Show("登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    用户界面.Default.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("用户名或密码错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }		
	}
}
