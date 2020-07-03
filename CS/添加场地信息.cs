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
		public void Button2_Click(object sender, EventArgs e)
		{
			TextBox1.Text = "";
			TextBox2.Text = "";
			TextBox1.Focus();
		}
		
		public void Button1_Click(object sender, EventArgs e)
		{
			string s = "";
			string n = "";
			int r = 0;
			if (TextBox1.Text == "")
			{
				Interaction.MsgBox("场地名称不能为空", MsgBoxStyle.Exclamation, "警告");
				TextBox1.Focus();
				return;
			}
			if (TextBox2.Text == "")
			{
				Interaction.MsgBox("场地编号不能为空", MsgBoxStyle.Exclamation, "警告");
				TextBox2.Focus();
				return;
			}
			try
			{
				ChangguanDataSet1.Tables["Venue"].Clear();
				n = "select  *  from Venue where  Vno ='" + TextBox2.Text.Trim() + "'and Vname ='" + TextBox1.Text.Trim() + "'";
				SqlDataAdapter1.SelectCommand.CommandText = n;
				SqlDataAdapter1.Fill(ChangguanDataSet1);
				r = ChangguanDataSet1.Venue.Rows.Count;
				if (r != 0)
				{
					Interaction.MsgBox("该场地已存在，请重新输入", MsgBoxStyle.Exclamation, "警告");
					TextBox1.Text = "";
					TextBox1.Focus();
					TextBox2.Text = "";
				}
				else
				{
					s = "insert into Venue values('" + TextBox1.Text + "','" + TextBox2.Text + "')";
					SqlDataAdapter1.SelectCommand.CommandText = s;
					SqlDataAdapter1.Fill(ChangguanDataSet1);
					Interaction.MsgBox("添加成功", MsgBoxStyle.Information, "恭喜");
					TextBox1.Text = "";
					TextBox1.Focus();
					TextBox2.Text = "";
					
				}
			}
			catch (Exception)
			{
				Interaction.MsgBox("请输入正确信息", MsgBoxStyle.Exclamation, "警告");
			}
		}
		
		public void Button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void 添加场地信息_Load(object sender, EventArgs e)
		{
			
		}
	}
}
