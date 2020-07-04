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

using Microsoft.VisualBasic.CompilerServices;
using WindowsApp1;

namespace WindowsApp1
{
	
	public partial class 用户界面
	{
		public 用户界面()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static 用户界面 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static 用户界面 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new 用户界面();
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
		public void tsmiClose1_Click(object sender, EventArgs e)
		{
			ProjectData.EndApp();
		}
		
		public void tsmiCancellation_Click(object sender, EventArgs e)
		{
			this.Close();
			登录界面.Default.Show();
		}
		
		public void Form1_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
		}
		
		public void tsmiUserPwd_Click(object sender, EventArgs e)
		{
			修改密码.Default.ShowDialog();
		}
		
		public void tsmiUserOrders_Click(object sender, EventArgs e)
		{
			用户订单查询.Default.Show();
		}
		
		public void tsmiAppointment_Click(object sender, EventArgs e)
		{
			Yuyue.Default.Show();
		}
		
		
	}
	
}
