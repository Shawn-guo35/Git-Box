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

using WindowsApp1;
using MySql.Data.MySqlClient;

namespace WindowsApp1
{
	public partial class 添加场地类型
	{
        ConDatabase ConDatabase = new ConDatabase();
        MySqlConnection con;
        MySqlCommand cm;
		public 添加场地类型()
		{
			InitializeComponent();
            cm = ConDatabase.OpenDatabase("");
            con = ConDatabase.getCon();
		}
		public void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void btnInsertVenue_Click(object sender, EventArgs e)
		{
			string s = "";
			string n = "";
			int r = 0; //查询出的行数
			if (txtGymName.Text == "")
			{
				Interaction.MsgBox("场地名称不能为空", MsgBoxStyle.Exclamation, "警告");
				txtGymName.Focus();
				return;
			}
			try
			{
				ChangguanDataSet1.Tables["Vtype"].Clear();
				n = "select  *  from Vtype where  Vname ='" + txtGymName.Text.Trim() + "'";
                //SqlDataAdapter1.SelectCommand.CommandText = n;
                //SqlDataAdapter1.Fill(ChangguanDataSet1);
                cm = ConDatabase.OpenDatabase(n);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cm);
                adapter.Fill(ChangguanDataSet1);
				r = ChangguanDataSet1.Vtype.Rows.Count;
				if (r != 0)
				{
					Interaction.MsgBox("该场地名称已存在，请重新输入", MsgBoxStyle.Exclamation, "警告");
					txtGymName.Text = "";
					txtGymName.Focus();
					txtGymInrent.Text = "";
					txtGymOutrent.Text = "";
					txtGymAddress.Text = "";
				}
				else
				{
					s = "insert into Vtype values('" + txtGymName.Text + "','" + txtGymInrent.Text + "','" + txtGymOutrent.Text + "','" + txtGymAddress.Text + "')";
                    //SqlDataAdapter1.SelectCommand.CommandText = s;
                    //SqlDataAdapter1.Fill(ChangguanDataSet1);
                    cm = ConDatabase.OpenDatabase(n);
                    adapter = new MySqlDataAdapter(cm);
                    adapter.Fill(ChangguanDataSet1);
					Interaction.MsgBox("添加成功", MsgBoxStyle.Information, "恭喜");
					txtGymName.Text = "";
					txtGymName.Focus();
					txtGymInrent.Text = "";
					txtGymOutrent.Text = "";
					txtGymAddress.Text = "";
				}
			}
			catch (Exception)
			{
				Interaction.MsgBox("请输入正确信息", MsgBoxStyle.Exclamation, "警告");
			}
			
		}
		
		public void btnCancel_Click(object sender, EventArgs e)
		{
			txtGymName.Text = "";
			txtGymInrent.Text = "";
			txtGymOutrent.Text = "";
			txtGymAddress.Text = "";
			txtGymName.Focus();
		}
		
		public void 添加场地类型_Load(object sender, EventArgs e)
		{
			
		}
	}
}
