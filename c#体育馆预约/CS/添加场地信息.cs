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

namespace WindowsApp1
{
	public partial class 添加场地信息
	{
		public 添加场地信息()
		{
			InitializeComponent();
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
				ChangguanDataSet1.Tables["Venue"].Clear();
				n = "select  *  from Venue where  Vno ='" + txtGymNum.Text.Trim() + "'and Vname ='" + txtGymName.Text.Trim() + "'";
				SqlDataAdapter1.SelectCommand.CommandText = n;
				SqlDataAdapter1.Fill(ChangguanDataSet1);
				r = ChangguanDataSet1.Venue.Rows.Count;
				if (r != 0)
				{
					Interaction.MsgBox("该场地已存在，请重新输入", MsgBoxStyle.Exclamation, "警告");
					txtGymName.Text = "";
					txtGymName.Focus();
					txtGymNum.Text = "";
				}
				else
				{
					s = "insert into Venue values('" + txtGymName.Text + "','" + txtGymNum.Text + "')";
					SqlDataAdapter1.SelectCommand.CommandText = s;
					SqlDataAdapter1.Fill(ChangguanDataSet1);
					Interaction.MsgBox("添加成功", MsgBoxStyle.Information, "恭喜");
					txtGymName.Text = "";
					txtGymName.Focus();
					txtGymNum.Text = "";
					
				}
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
	}
}
