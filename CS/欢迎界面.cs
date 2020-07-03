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
	public partial class 欢迎界面
	{
		public 欢迎界面()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static 欢迎界面 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static 欢迎界面 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new 欢迎界面();
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
		
		public void Form1_Load(object sender, EventArgs e)
		{
			Timer1.Interval = 3000; //1000=1秒
			Timer1.Enabled = true;
			
		}
		
		public void Timer1_Tick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void Label1_Click(object sender, EventArgs e)
		{
			
		}
	}
	
}
