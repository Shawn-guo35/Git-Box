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
    
	public partial class 添加场地信息
	{
        ConDatabase ConDatabase = new ConDatabase();
        MySqlConnection con;
        MySqlCommand cm;
        DataSet ds;
		public 添加场地信息()
		{
			InitializeComponent();
            cm = ConDatabase.OpenDatabase("");
            con = ConDatabase.getCon();
            ds = new DataSet();
		}
		public void btnCancel_Click(object sender, EventArgs e)
		{
			txtGymName.Text = "";
			txtGymNum.Text = "";
			txtGymName.Focus();
		}
		
		public void btnInsertVtype_Click(object sender, EventArgs e)
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
			if (txtGymNum.Text == "")
			{
				Interaction.MsgBox("场地编号不能为空", MsgBoxStyle.Exclamation, "警告");
				txtGymNum.Focus();
				return;
			}
			try
			{
				//ChangguanDataSet1.Tables["Venue"].Clear();
				n = "select  *  from v_venue where  Vnid ='" + Convert.ToInt32(txtGymTypeID.Text.Trim()) + "'and Vtnamen ='" + txtGymName.Text.Trim() + "'";
                //SqlDataAdapter1.SelectCommand.CommandText = n;
                //SqlDataAdapter1.Fill(ChangguanDataSet1);
                cm = ConDatabase.OpenDatabase(n);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cm);
                adapter.Fill(ds,"v_venue");
				r = ds.Tables["v_venue"].Rows.Count;                 
				if (r != 0)
				{
					Interaction.MsgBox("该场地不存在，请重新输入", MsgBoxStyle.Exclamation, "警告");
					txtGymName.Text = "";
					txtGymName.Focus();
					txtGymNum.Text = "";
				}
				else
				{
					s = "insert into v_venue(vtnamen,vnid,vtidn,vnstate) values('" + txtGymName.Text + "','" + Convert.ToInt32(txtGymNum.Text) + "','"+ Convert.ToInt32(txtGymTypeID.Text) + "','" + txtState.Text +"')";
                    //SqlDataAdapter1.SelectCommand.CommandText = s;
                    //SqlDataAdapter1.Fill(ChangguanDataSet1);
                    cm = ConDatabase.OpenDatabase(s);
                    con = ConDatabase.getCon();
                    cm.ExecuteNonQuery();
                    //adapter = new MySqlDataAdapter(cm);
                    //adapter.Fill(ChangguanDataSet1);
					Interaction.MsgBox("添加成功", MsgBoxStyle.Information, "恭喜");
					txtGymName.Text = "";
					txtGymName.Focus();
					txtGymNum.Text = "";
					
				}
                con.Close();
			}
			catch (Exception)
			{
				Interaction.MsgBox("请输入正确信息", MsgBoxStyle.Exclamation, "警告");
			}
		}
		
		public void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void 添加场地信息_Load(object sender, EventArgs e)
		{
			
		}

        private void lblResults2_Click(object sender, EventArgs e)
        {

        }
    }
}
