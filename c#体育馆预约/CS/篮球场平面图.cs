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
	public partial class viewBasketball
	{
		public viewBasketball()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static viewBasketball defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static viewBasketball Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new viewBasketball();
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
		//Picturebox均为篮球场平面图
		public void viewBasketball_Load(object sender, EventArgs e)
		{
			string sql = "";
			sql = "select * from Vtype where Vname='篮球场'";
			OleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter(sql, OleDbConnection1);
			OleDbDataAdapter1.Fill(DataSet1, "ss");
			lblResults16.Text = "篮球场地址：" + DataSet1.Tables["ss"].Rows[0][3].ToString() + "\r\n" 
				+ "校内人员租金为" + DataSet1.Tables["ss"].Rows[0][1] + "元/小时" + "\r\n" 
				+ "校外人员租金为" + DataSet1.Tables["ss"].Rows[0][2] + "元/小时";
		}
		
	}
}
