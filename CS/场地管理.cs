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
	public partial class 场地管理
	{
		public 场地管理()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static 场地管理 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static 场地管理 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new 场地管理();
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
		public void Button5_Click(object sender, EventArgs e)
		{
			添加场地信息 fm = new 添加场地信息();
			fm.Show();
		}
		
		public void GroupBox1_Enter(object sender, EventArgs e)
		{
			
		}
		
		public void Button3_Click(object sender, EventArgs e)
		{
			查询场地租借情况 fm = new 查询场地租借情况();
			fm.Show();
		}
		
		public void Button1_Click(object sender, EventArgs e)
		{
			查询场地类型 fm = new 查询场地类型();
			fm.Show();
		}
		
		public void Button2_Click(object sender, EventArgs e)
		{
			查询场地信息 fm = new 查询场地信息();
			fm.Show();
		}
		
		public void Button4_Click(object sender, EventArgs e)
		{
			添加场地类型 fm = new 添加场地类型();
			fm.Show();
		}
		
		public void Button6_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void Form1_Load(object sender, EventArgs e)
		{
			
		}
	}
}
