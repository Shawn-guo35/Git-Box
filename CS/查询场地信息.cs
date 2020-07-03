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
	public partial class 查询场地信息
	{
		public 查询场地信息()
		{
			InitializeComponent();
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
				ChangguanDataSet1.Tables["Venue"].Clear();
				s = "select  *  from  Venue  where  Vname ='" + TextBox1.Text + "'";
				SqlDataAdapter1.SelectCommand.CommandText = s;
				SqlDataAdapter1.Fill(ChangguanDataSet1);
				DataGridView1.DataSource = ChangguanDataSet1.Tables["Venue"];
				//Case "场地编号"
				//    DataDataSet.Tables("Venue").Clear()
				//    s = "select  *  from  Venue  where  Vno ='" + TextBox1.Text + "'"
				//    SqlDataAdapter1.SelectCommand.CommandText = s
				//    SqlDataAdapter1.Fill(DataDataSet)
				//    DataGridView1.DataSource = DataDataSet.Tables("Venue")
			}
		}
		
		public void Button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void Button3_Click(object sender, EventArgs e)
		{
			int x = 0;
			if (Interaction.MsgBox("您真的删除该条数据吗？", (int) MsgBoxStyle.YesNo + MsgBoxStyle.Question, "删除数据") == DialogResult.Yes)
			{
				x = DataGridView1.CurrentRow.Index;
				ChangguanDataSet1.Tables["Venue"].Rows[x].Delete();
				SqlDataAdapter1.Update(ChangguanDataSet1);
				Interaction.MsgBox("删除成功", MsgBoxStyle.Information, "恭喜");
			}
		}
		
		public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		public void GroupBox1_Enter(object sender, EventArgs e)
		{
			
		}
		
		public void 查询场地信息_Load(object sender, EventArgs e)
		{
			//TODO: 这行代码将数据加载到表“ChangguanDataSet5.Venue”中。您可以根据需要移动或删除它。
			this.VenueTableAdapter.Fill(this.ChangguanDataSet5.Venue);
			
		}
	}
}
