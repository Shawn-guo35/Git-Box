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
	public partial class 查询场地租借情况
	{
		public 查询场地租借情况()
		{
			InitializeComponent();
		}
		public void GroupBox1_Enter(object sender, EventArgs e)
		{
			
		}
		
		public void Label1_Click(object sender, EventArgs e)
		{
			
		}
		
		public void Label2_Click(object sender, EventArgs e)
		{
			
		}
		
		public void 场地管理系统_Load(object sender, EventArgs e)
		{
			//TODO: 这行代码将数据加载到表“ChangguanDataSet6.Lease”中。您可以根据需要移动或删除它。
			this.LeaseTableAdapter.Fill(this.ChangguanDataSet6.Lease);
			
		}
		
		
		
		public void Button4_Click(object sender, EventArgs e)
		{
			string s = "";
			
			if (TextBox1.Text == "")
			{
				Interaction.MsgBox("请输入查询条件", MsgBoxStyle.Exclamation, "警告");
				return;
			}
			if ((string) ComboBox1.SelectedItem == "场地名称")
			{
				ChangguanDataSet1.Tables["Lease"].Clear();
				s = "select  *  from  Lease  where  Vname ='" + TextBox1.Text + "'";
				SqlDataAdapter1.SelectCommand.CommandText = s;
				SqlDataAdapter1.Fill(ChangguanDataSet1);
				DataGridView1.DataSource = ChangguanDataSet1.Tables["Lease"];
			}
			else if ((string) ComboBox1.SelectedItem == "场地名称&场地编号")
			{
				ChangguanDataSet1.Tables["Lease"].Clear();
				s = "select  *  from Lease where  Vno ='" + TextBox2.Text.Trim() + "'and Vname ='" + TextBox1.Text.Trim() + "'";
				
				
				SqlDataAdapter1.SelectCommand.CommandText = s;
				SqlDataAdapter1.Fill(ChangguanDataSet1);
				DataGridView1.DataSource = ChangguanDataSet1.Tables["Lease"];
			}
		}
		
		public void Button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
		
		public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ((string) ComboBox1.SelectedItem == "场地名称&场地编号")
			{
				TextBox2.Visible = true;
			}
			else
			{
				TextBox2.Visible = false;
			}
			
			if ((string) ComboBox1.SelectedItem == "场地名称&场地编号")
			{
				Label4.Visible = true;
			}
			else
			{
				Label4.Visible = false;
			}
		}
		
	}
}
