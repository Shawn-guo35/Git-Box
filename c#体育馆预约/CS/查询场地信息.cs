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
	public partial class 查询场地信息
	{
        ConDatabase ConDatabase = new ConDatabase();
        MySqlConnection con;
        MySqlCommand cm;
        DataSet ds;
		public 查询场地信息()
		{
			InitializeComponent();
            cm = ConDatabase.OpenDatabase("");
            con = ConDatabase.getCon();
            ds = new DataSet();
		}
		
		
		
		public void btnSelectVtype_Click(object sender, EventArgs e)
		{
			string s = "";
			if (txtCondition.Text == "")
			{
				Interaction.MsgBox("请输入查询条件", MsgBoxStyle.Exclamation, "警告");
				return;
			}
			if ((string) cbmGym.SelectedItem == "场地名称")
			{
				//ChangguanDataSet1.Tables["Venue"].Clear();
				s = "select  Vnseq as 序号,Vnid as 编号,Vtidn as 类型号,Vtnamen as 名称,Vnstate as 状态,Vnremarks as 备注  from  Venue  where  vtnamen ='" + txtCondition.Text + "'";
                //SqlDataAdapter1.SelectCommand.CommandText = s;
                //SqlDataAdapter1.Fill(ChangguanDataSet1);
                cm = ConDatabase.OpenDatabase(s);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cm);
                adapter.Fill(ds,"v_venue");
                gvwVenue.DataSource = ds.Tables["v_venue"];
				//Case "场地编号"
				//    DataDataSet.Tables("Venue").Clear()
				//    s = "select  *  from  Venue  where  Vno ='" + TextBox1.Text + "'"
				//    SqlDataAdapter1.SelectCommand.CommandText = s
				//    SqlDataAdapter1.Fill(DataDataSet)
				//    DataGridView1.DataSource = DataDataSet.Tables("Venue")
			}
		}
		
		public void btnReturn_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void btnDeleteVtype_Click(object sender, EventArgs e)
		{
			int x = 0; //要删除的行数
			if ((int)Interaction.MsgBox("您真的删除该条数据吗？", (int) MsgBoxStyle.YesNo + MsgBoxStyle.Question, "删除数据") == (int)DialogResult.Yes)
			{
                //x = gvwVenue.CurrentRow.Index;
                //ChangguanDataSet1.Tables["Venue"].Rows[x].Delete();
                //ds.Tables["v_venue"].Rows[x].Delete();
                //SqlDataAdapter1.Update(ChangguanDataSet1);
                //MySqlDataAdapter adapter = new MySqlDataAdapter();
                //adapter.Update(ds);
                string com = "delete from Venue where vtnamen = '" + gvwVenue.CurrentRow.Cells[3].Value + "'";
                cm = ConDatabase.OpenDatabase(com);
                cm.ExecuteNonQuery();
				Interaction.MsgBox("删除成功", MsgBoxStyle.Information, "恭喜");
			}
		}
		
		
		
		public void 查询场地信息_Load(object sender, EventArgs e)
		{
			//TODO: 这行代码将数据加载到表“ChangguanDataSet5.Venue”中。您可以根据需要移动或删除它。
			//this.VenueTableAdapter.Fill(this.ChangguanDataSet5.Venue);
			
		}
		
	}
}
