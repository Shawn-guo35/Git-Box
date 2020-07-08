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
	public partial class 查询场地租借情况
	{
        ConDatabase ConDatabase = new ConDatabase();
        MySqlConnection con;
        MySqlCommand cm;

		public 查询场地租借情况()
		{
			InitializeComponent();
		}
		
		public void 场地管理系统_Load(object sender, EventArgs e)
		{
			//TODO: 这行代码将数据加载到表“ChangguanDataSet6.Lease”中。您可以根据需要移动或删除它。
			this.LeaseTableAdapter.Fill(this.ChangguanDataSet6.Lease);
            cm = ConDatabase.OpenDatabase("");
            con = ConDatabase.getCon();
		}
		
		
		
		public void btnSelectLease_Click(object sender, EventArgs e)
		{
			string s = "";
			
			if (txtGymName.Text == "")
			{
				Interaction.MsgBox("请输入查询条件", MsgBoxStyle.Exclamation, "警告");
				return;
			}
			if ((string) cbmGym.SelectedItem == "场地名称")
			{
				ChangguanDataSet1.Tables["Lease"].Clear();
				s = "select  *  from  Lease  where  Vname ='" + txtGymName.Text + "'";
                //SqlDataAdapter1.SelectCommand.CommandText = s;
                //SqlDataAdapter1.Fill(ChangguanDataSet1);
                cm = ConDatabase.OpenDatabase(s);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cm);
                adapter.Fill(ChangguanDataSet1);
				txtGymLease.DataSource = ChangguanDataSet1.Tables["Lease"];
			}
			else if ((string) cbmGym.SelectedItem == "场地名称&场地编号")
			{
				ChangguanDataSet1.Tables["Lease"].Clear();
				s = "select  *  from Lease where  Vno ='" + txtGymNum.Text.Trim() + "'and Vname ='" + txtGymName.Text.Trim() + "'";
                cm = ConDatabase.OpenDatabase(s);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cm);
                adapter.Fill(ChangguanDataSet1);
				//SqlDataAdapter1.SelectCommand.CommandText = s;
				//SqlDataAdapter1.Fill(ChangguanDataSet1);
				txtGymLease.DataSource = ChangguanDataSet1.Tables["Lease"];
			}
		}
		
		public void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
		
		public void cbmGym_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((string) cbmGym.SelectedItem == "场地名称&场地编号")
			{
				txtGymNum.Visible = true;
			}
			else
			{
				txtGymNum.Visible = false;
			}
			
			if ((string) cbmGym.SelectedItem == "场地名称&场地编号")
			{
				lblResults14.Visible = true;
			}
			else
			{
				lblResults14.Visible = false;
			}
		}
		
		
	}
}
