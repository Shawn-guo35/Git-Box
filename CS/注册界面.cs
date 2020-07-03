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
	public partial class 注册界面
	{
		public 注册界面()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
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
		SqlConnection cn;
		SqlDataAdapter da;
		DataSet ds;
		SqlCommand cm;
		string sqlstr;
		public void Button2_Click(object sender, EventArgs e)
		{
			this.Close();
			登录界面.Default.Show();
		}
		
		public void Button1_Click(object sender, EventArgs e)
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
			string cnStr = "Data Source=DESKTOP-DSP6URK\\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=changguan";
			cn = new SqlConnection(cnStr);
			cn.Open();
			if (radInside.Checked)
			{
				cm = new SqlCommand("select count(*) from Users where ID='" + txtID.Text + "'", cn);
				var num1 = Convert.ToInt32(cm.ExecuteScalar());
				if (num1 == 0)
				{

                    sqlstr = "insert into  Users values('" + txtID.Text + "','" + txtName.Text + "','" + "校内人员" + "; //,'" + txtPwd.Text + "')";
					cm = new SqlCommand(sqlstr, cn);
					cm.ExecuteNonQuery();
					cn.Close();
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
				cm = new SqlCommand("select count(*) from Users where ID='" + txtID.Text + "'", cn);
				var num2 = Convert.ToInt32(cm.ExecuteScalar());
				if (num2 == 0)
				{
					
					sqlstr = "insert into  Users values('" + txtID.Text + "','" + txtName.Text + "','" + "校外人员" + "','" + txtPwd.Text + "')";
					cm = new SqlCommand(sqlstr, cn);
					cm.ExecuteNonQuery();
					cn.Close();
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
