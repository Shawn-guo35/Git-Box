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
	public partial class Yuyue
	{
		public Yuyue()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static Yuyue defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static Yuyue Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Yuyue();
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
		public void Button4_Click(object sender, EventArgs e)
		{
			MessageBox.Show("敬请期待！");
		}
		
		public void Button1_Click(object sender, EventArgs e)
		{
			//Me.Hide()
			orderBasketball.Default.Show();
		}
		
		public void Button3_Click(object sender, EventArgs e)
		{
			MessageBox.Show("敬请期待！");
		}
		
		public void Button6_Click(object sender, EventArgs e)
		{
			MessageBox.Show("敬请期待！");
		}
		
		public void Button2_Click(object sender, EventArgs e)
		{
			MessageBox.Show("敬请期待！");
		}
		
		public void Button5_Click(object sender, EventArgs e)
		{
			MessageBox.Show("敬请期待！");
		}
	}
}
