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
	public partial class 用户管理 : System.Windows.Forms.Form
	{
		public 用户管理()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static 用户管理 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static 用户管理 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new 用户管理();
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
		
		
		
		public void GroupBox1_Enter(object sender, EventArgs e)
		{
			
		}
		
		
		private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		public void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		public void 用户管理系统_Load(object sender, EventArgs e)
		{
			//TODO: 这行代码将数据加载到表“ChangguanDataSet1.Users”中。您可以根据需要移动或删除它。
			this.UsersTableAdapter.Fill(this.ChangguanDataSet1.Users);
			
			
			
		}
		
		public void Button2_Click(object sender, EventArgs e)
		{
			SqlDataAdapter1.Update(ChangguanDataSet);
			Interaction.MsgBox("数据已修改", MsgBoxStyle.Information, "恭喜");
		}
		
		public void Button3_Click(object sender, EventArgs e)
		{
			int x = 0;
			if (Interaction.MsgBox("您真的删除该条数据吗？", (int) MsgBoxStyle.YesNo + MsgBoxStyle.Question, "删除数据") == DialogResult.Yes)
			{
				x = DataGridView1.CurrentRow.Index;
				ChangguanDataSet.Tables["Users"].Rows[x].Delete();
				SqlDataAdapter1.Update(ChangguanDataSet);
				Interaction.MsgBox("删除成功", MsgBoxStyle.Information, "恭喜");
			}
		}
		
		public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		public void Button4_Click(object sender, EventArgs e)
		{
			string s = "";
			if (TextBox1.Text == "")
			{
				Interaction.MsgBox("请输入查询条件", MsgBoxStyle.Exclamation, "警告");
				return;
			}
			if ((string) ComboBox1.SelectedItem == "帐号")
			{
				ChangguanDataSet.Tables["Users"].Clear();
				s = "select  *  from  Users  where  ID ='" + TextBox1.Text + "'";
				SqlDataAdapter1.SelectCommand.CommandText = s;
				SqlDataAdapter1.Fill(ChangguanDataSet);
				DataGridView1.DataSource = ChangguanDataSet.Tables["Users"];
			}
			else if ((string) ComboBox1.SelectedItem == "姓名")
			{
				ChangguanDataSet.Tables["Users"].Clear();
				s = "select  *  from  Users  where  Uname = '" + TextBox1.Text + "'";
				SqlDataAdapter1.SelectCommand.CommandText = s;
				SqlDataAdapter1.Fill(ChangguanDataSet);
				DataGridView1.DataSource = ChangguanDataSet.Tables["Users"];
			}
			else if ((string) ComboBox1.SelectedItem == "身份")
			{
				ChangguanDataSet.Tables["Users"].Clear();
				s = "select  *  from  Users  where Uidentity = '" + TextBox1.Text + "'";
				SqlDataAdapter1.SelectCommand.CommandText = s;
				SqlDataAdapter1.Fill(ChangguanDataSet);
				DataGridView1.DataSource = ChangguanDataSet.Tables["Users"];
			}
		}
		
		
		
		private void SqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
		{
			
		}
		
		public void Button5_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void SqlDataAdapter1_RowUpdated_1(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
		{
			
		}
		
		private void Users1BindingSource_CurrentChanged(object sender, EventArgs e)
		{
			
		}
	}
	
	
}
