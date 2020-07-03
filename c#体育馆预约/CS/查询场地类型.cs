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
	public partial class 查询场地类型
	{
		public 查询场地类型()
		{
			InitializeComponent();
		}
		public void 查询场地类型_Load(object sender, EventArgs e)
		{
			//TODO: 这行代码将数据加载到表“ChangguanDataSet3.Vtype”中。您可以根据需要移动或删除它。
			this.VtypeTableAdapter.Fill(this.ChangguanDataSet3.Vtype);
			
		}
		
		public void btnSelcetVenue_Click(object sender, EventArgs e)
		{
			string s = "";
			if (txtCondition.Text == "")
			{
				Interaction.MsgBox("请输入查询条件", MsgBoxStyle.Exclamation, "警告");
				return;
			}
			if ((string) cbmGym.SelectedItem == "场地名称")
			{
				ChangguanDataSet1.Tables["Vtype"].Clear();
				s = "select  *  from  Vtype  where  Vname ='" + txtCondition.Text + "'";
				SqlDataAdapter1.SelectCommand.CommandText = s;
				SqlDataAdapter1.Fill(ChangguanDataSet1);
				gvwVtype.DataSource = ChangguanDataSet1.Tables["Vtype"];
			}
		}
		
		public void btnUpdteVenue_Click(object sender, EventArgs e)
		{
			SqlDataAdapter1.Update(ChangguanDataSet1);
			Interaction.MsgBox("数据已修改", MsgBoxStyle.Information, "恭喜");
		}
		
		public void btnDeleteVenue_Click(object sender, EventArgs e)
		{
			int x = 0; //要删除的行数
			if ((int)Interaction.MsgBox("您真的删除该条数据吗？", (int) MsgBoxStyle.YesNo + MsgBoxStyle.Question, "删除数据") == (int)DialogResult.Yes)
			{
				x = gvwVtype.CurrentRow.Index;
				ChangguanDataSet1.Tables["Vtype"].Rows[x].Delete();
				SqlDataAdapter1.Update(ChangguanDataSet1);
				Interaction.MsgBox("删除成功", MsgBoxStyle.Information, "恭喜");
			}
		}
		
		public void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
	}
}
