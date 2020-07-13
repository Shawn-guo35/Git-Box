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
            ProjectData.EndApp();
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.WindowState = FormWindowState.Maximized;
            funcpanel.Location = new Point(MenuStrip1.Location.X, MenuStrip1.Location.Y + MenuStrip1.Height + 3);       
            funcpanel.Width = 200;
            //获取屏幕高度、设置左侧panel的高度
            funcpanel.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - MenuStrip1.Location.Y - MenuStrip1.Height - 3;
            Settingpanel.Location = new Point(funcpanel.Location.X + funcpanel.Width, funcpanel.Location.Y);
            Settingpanel.Height = 100;
            Settingpanel.Width = this.Width - funcpanel.Width;
            this.IsMdiContainer = true;

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

        private void functab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void showChildForm(Form childform)
        {
            //添加子窗体函数
            Form form = childform;
            form.MdiParent = this;
            //设置为子窗体
            form.ControlBox = false;
            //去除控制栏
            form.FormBorderStyle = FormBorderStyle.None;
            //去除边框
            form.Width = SystemInformation.WorkingArea.Width - funcpanel.Width;
            form.Height = SystemInformation.WorkingArea.Height - funcpanel.Location.Y - Settingpanel.Height - 6;
            form.Show();
            form.Location = new Point(funcpanel.Width, Settingpanel.Height + 3);
            //MessageBox.Show(form.Width + "  " + form.Height);
            //输出form窗体的大小
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            //预约场地
            Form form = new Yuyue();
            //要添加的子窗体
            showChildForm(form);
            //添加
        }

        private void equipmentRent_Click(object sender, EventArgs e)
        {
            //器材租借
            Form form = new 器材预约();
            showChildForm(form);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void equipmentMg_Click(object sender, EventArgs e)
        {
            //器材管理
            Form form = new 器材管理();
            showChildForm(form);
        }

        private void groundTypeSearch_Click(object sender, EventArgs e)
        {
            //查询场地类型
            Form form = new 查询场地类型();
            showChildForm(form);
        }

        private void groundInfoSearch_Click(object sender, EventArgs e)
        {
            //查询场地信息
            Form form = new 查询场地信息();
            showChildForm(form);
        }

        private void lentInfoSearch_Click(object sender, EventArgs e)
        {
            //查询租借情况
            Form form = new 查询场地租借情况();
            showChildForm(form);
        }

        private void addGroundType_Click(object sender, EventArgs e)
        {
            //添加场地类型
            Form form = new 添加场地类型();
            showChildForm(form);
        }

        private void addGroundNum_Click(object sender, EventArgs e)
        {
            //添加场地数量
            Form form = new 添加场地信息();
            showChildForm(form);
        }

        private void userMg_Click(object sender, EventArgs e)
        {
            //用户管理，增删用户
            Form form = new 用户管理();
            showChildForm(form);
        }

        private void orderSearch_Click(object sender, EventArgs e)
        {
            //查询用户订单
            Form form = new 订单查询();
            showChildForm(form);
        }

        private void updatePass_Click(object sender, EventArgs e)
        {
            //修改用户密码
            Form form = new 修改密码();
            showChildForm(form);
        }

        private void incomeStatistics_Click(object sender, EventArgs e)
        {
            //收入统计
            Form form = new 收入统计();
            showChildForm(form);
        }

        private void bulletin_Click(object sender, EventArgs e)
        {
            //发布公告
            Form form = new 发布公告();
            showChildForm(form);
        }

        private void Settingpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void funcpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void oederBasket_Click(object sender, EventArgs e)
        {
            Form form = new orderBasketball();
            showChildForm(form);
        }

        private void 用户界面_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectData.EndApp();
        }
    }
	
}
