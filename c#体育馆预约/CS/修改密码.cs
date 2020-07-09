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

using System.ComponentModel;
using System.Data.OleDb;
using WindowsApp1;
using MySql.Data.MySqlClient;

namespace WindowsApp1
{
	public partial class 修改密码
	{
        ConDatabase ConDatabase = new ConDatabase();
        MySqlConnection con;
        MySqlCommand cm;
		public 修改密码()
		{
			InitializeComponent();
            cm = ConDatabase.OpenDatabase("");
            con = ConDatabase.getCon();
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static 修改密码 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static 修改密码 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new 修改密码();
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
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        //OleDbConnection con = new OleDbConnection();
        //OleDbDataAdapter ads = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public void btnSubmit_Click(object sender, EventArgs e)
		{
			if (txtOldPwd.Text == "")
			{
				Interaction.MsgBox(Prompt: "请输入旧密码", Title: "系统提示");
				return;
			}
			if (txtNewPwd.Text == "")
			{
				Interaction.MsgBox(Prompt: "新密码不得为空", Title: "系统提示");
				return;
			}
			if (txtNewPwd.Text != txtNewPwd1.Text)
			{
				Interaction.MsgBox(Prompt: "新密码不一致，请重新输入", Title: "系统提示");
				return;
			}
            //OleDbCommand com = new OleDbCommand();
            //com.CommandText = "select Upassword from Users where ID='" + 登录界面.Default.txtID.Text + "'";
            //com.Connection = con;
            //ads.SelectCommand = com;
            cm = ConDatabase.OpenDatabase("select Upwd from Users where ID='" + 登录界面.Default.txtID.Text + "'");
            //ads.Fill(ds, "Stable");
            adapter.Fill(ds, "Stable");
			if (txtOldPwd.Text != ds.Tables["Stable"].Rows[0]["Upassword"])
			{
				Interaction.MsgBox(Prompt: "密码不正确", Title: "系统提示");
				return;
			}
            //com.CommandText = "update Users set Upassword= '" + txtNewPwd.Text + "' where ID='" + 登录界面.Default.txtID.Text + "'";
            //con.Open();
            //com.ExecuteNonQuery();
            cm = ConDatabase.OpenDatabase("update Users set Upwd= '" + txtNewPwd.Text + "' where ID='" + 登录界面.Default.txtID.Text + "'");
            cm.ExecuteNonQuery()
;			con.Close();
			Interaction.MsgBox(Prompt: "修改完成", Title: "系统提示");
			this.Hide();
		}
		
		public void Form3_Load(object sender, EventArgs e)
		{
			//con.ConnectionString = Module1.str;
		}
		
		
	}
}
