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

namespace WindowsApp1
{
	public partial class 登录界面
	{
		public 登录界面()
		{
			InitializeComponent();
			
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
		SqlConnection cn;
		SqlCommand cm;
		
		public void 登陆界面_Load(object sender, EventArgs e)
		{
			//登录界面为启动页面为了让欢迎界面先出现 设置两个timer来登录界面隐藏
			欢迎界面.Default.Show();
			Timer1.Interval = 1; //1000=1秒
			Timer1.Enabled = true;
			Timer2.Interval = 3000; //1000=1秒
			Timer2.Enabled = true;
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
			if (txtID.Text == "")
			{
				MessageBox.Show("请输入账号！");
				
			}
			if (txtPwd.Text == "")
			{
				MessageBox.Show("请输入密码！");
			}
			string cnStr = "Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=changguan;";
			cn = new SqlConnection(cnStr);
			cn.Open();
			
			if (radUser.Checked)
			{
				cm = new SqlCommand("select count(*) from Users where ID='" + txtID.Text + "'and Upassword='" + txtPwd.Text + "'", cn);
				var num1 = Convert.ToInt32(cm.ExecuteScalar());
				if (num1 > 0)
				{
					cn.Close();
					MessageBox.Show("登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
					用户界面.Default.Show();
					this.Visible = false;
				}
				else
				{
					MessageBox.Show("用户名或密码错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else if (radAdmin.Checked)
			{
				cm = new SqlCommand("select count(*) from Users where ID='" + txtID.Text + "'and Upassword='" + txtPwd.Text + "'", cn);
				var num2 = Convert.ToInt32(cm.ExecuteScalar());
				if (num2 > 0)
				{
					cn.Close();
					MessageBox.Show("登录成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
					管理员界面.Default.Show();
					this.Visible = false;
				}
				else
				{
					MessageBox.Show("用户名或密码错误", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				
			}
			else
			{
				MessageBox.Show("请选择登录类型！");
			}
			
		}
		
	}
}
