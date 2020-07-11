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

using static System.String;
using WindowsApp1;
using MySql.Data.MySqlClient;

namespace WindowsApp1
{
	public partial class orderBasketball
	{
        ConDatabase ConDatabase = new ConDatabase();
        MySqlConnection con;
        MySqlCommand cm;   
        
        

		public orderBasketball()
		{
			InitializeComponent();
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static orderBasketball defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static orderBasketball Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new orderBasketball();
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
		
		public void btnGymview_Click(object sender, EventArgs e)
		{
			viewBasketball.Default.Show();
		}
		
		public void btnSubmit1_Click(object sender, EventArgs e)
		{
			dgvOrder.Rows.Clear();
			dgvOrder.Columns.Clear();
			//显示表格
			this.dgvOrder.AllowUserToAddRows = false;
			dgvOrder.RowTemplate.Height = 50;
			dgvOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			this.dgvOrder.Columns.Add("时间", "时间");
			this.dgvOrder.Columns[0].Width = 90;
			//可预约的时间段规定为以下四个
			this.dgvOrder.Rows.Add("12:00-13:00");
			this.dgvOrder.Rows.Add("13:00-14:00");
			this.dgvOrder.Rows.Add("18:00-19:00");
			this.dgvOrder.Rows.Add("19:00-20:00");

			for (var i = 1; i <= 7; i++)
			{
                //DataGridViewTextBoxColumn newcolumn = new DataGridViewTextBoxColumn();
                //newcolumn.Name = DateAndTime.Now.Year + (i - 1) + "-" + DateAndTime.Now.Month.ToString("00") + "-" + DateAndTime.Now.Day.ToString("00");
                this.dgvOrder.Columns.Add(DateAndTime.Now.Year + "-" + DateAndTime.Now.Month.ToString("00") + "-" + (DateAndTime.Now.Day + (i - 1)).ToString("00"), DateAndTime.Now.Year + (i - 1) + "-" + DateAndTime.Now.Month.ToString("00") + "-" + (DateAndTime.Now.Day + (i - 1)).ToString("00"));
                //this.dgvOrder.Columns.Add(System.Convert.ToString(DateAndTime.DateAdd(DateInterval.Day, System.Convert.ToDouble(i - 1), DateTime.Now.Date)), 
                //    System.Convert.ToString(DateAndTime.DateAdd(DateInterval.Day, System.Convert.ToDouble(i - 1), DateTime.Now.Date)));
                //this.dgvOrder.Columns.Add(Convert.ToString(DateAndTime.Now.Year + (i - 1) + "-" + DateAndTime.Now.Month.ToString("00") + "-" + DateAndTime.Now.Day.ToString("00"));
                this.dgvOrder.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
				this.dgvOrder.Columns[i].Width = 70;
			}
			for (var i = 1; i <= 7; i++)
			{
				for (var j = 0; j <= 3; j++)
				{
					this.dgvOrder[System.Convert.ToInt32(i), System.Convert.ToInt32(j)].Value = "可用";
				}
			}
            //查出场地编号表，绑定combobox数据源
            string combo = "select Vnid from v_venue where Vtnamen = '篮球场' order by Vnid";
            cm = ConDatabase.OpenDatabase(combo);
            cm.ExecuteNonQuery();
            //DataSet comboData = new DataSet();
            //MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(cm);
            //mySqlDataAdapter.Fill(comboData, "combo");
            //cbmGymnum.DataSource = comboData.Tables["combo"];
			//连接数据库 更改表格
			//string sql = "";
			//查询Lease表 得出空闲的场地
			//sql = "select convert(date,Stime),convert(time,Stime,8),convert(time,Etime),Condition from Lease where Vno='" + cbmGymnum.SelectedValue.ToString() + "' and Vname='篮球场'";
            cm = ConDatabase.OpenDatabase("select convert(Vsstart,date),convert(Vsstart,time),convert(Vsend,time),Vsstate from v_state where Vnids='" + cbmGymnum.SelectedValue.ToString() + "' and Vtnames='篮球场'");
            con = ConDatabase.getCon();
            dstBasketLease.Reset();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cm);
            adapter.Fill(dstBasketLease, "ss");
            //odadSelBaseket = new System.Data.OleDb.OleDbDataAdapter(sql, OleDbConnection1);
            //odadSelBaseket.Fill(dstBasketLease, "ss");
			if (dstBasketLease.Tables["ss"].Rows.Count != 0)
			{
				for (var j = 1; j <= dstBasketLease.Tables["ss"].Rows.Count; j++)
				{
					for (var i = 1; i <= 7; i++)
					{
						//填充DateGridView 如果dgv里的时间在select出的表中也存在 则把dgv中相应的场地状态改为已借出
						if (dgvOrder.Columns[i].Name == dstBasketLease.Tables["ss"].Rows[j - 1][0])
						{
							if (dstBasketLease.Tables["ss"].Rows[j - 1][1].ToString() == "12:00:00.0000000")
							{
								dgvOrder[System.Convert.ToInt32(i), 0].Value = dstBasketLease.Tables["ss"].Rows[j - 1][3];
							}
							if (dstBasketLease.Tables["ss"].Rows[j - 1][1].ToString() == "13:00:00.0000000")
							{
								dgvOrder[System.Convert.ToInt32(i), 1].Value = dstBasketLease.Tables["ss"].Rows[j - 1][3];
							}
							if (dstBasketLease.Tables["ss"].Rows[j - 1][1].ToString() == "18:00:00.0000000")
							{
								dgvOrder[System.Convert.ToInt32(i), 2].Value = dstBasketLease.Tables["ss"].Rows[j - 1][3];
							}
							if (dstBasketLease.Tables["ss"].Rows[j - 1][1].ToString() == "19:00:00.0000000")
							{
								dgvOrder[System.Convert.ToInt32(i), 3].Value = dstBasketLease.Tables["ss"].Rows[j - 1][3];
							}
						}
					}
				}
			}
			
		}
		
		public void dgvOrder_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string str = "";
			string sql1 = "";
			string sql2 = "";
			string sql3 = "";
			string Vno = "";
			string Stime = ""; //开始时间
			string Etime = ""; //结束时间
			double fee = 0; //租借费用
			string uname = ""; //用户姓名
			string userId = "";
			userId = 登录界面.Default.txtID.Text;
            //获取用户姓名和租金
            cm = ConDatabase.OpenDatabase("select Uname,Uidentity,Vtinrank,Vtoutrank from v_users,v_vtype where Uid='" + userId + "' and Vtname='篮球场'");
            con = ConDatabase.getCon();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(cm);
            adapter1.Fill(dstBasketLease, "ff");
			//odadSelBaseket = new System.Data.OleDb.OleDbDataAdapter("select Uname,Uidentity,INrental,OUTrental from Users,Vtype where ID='" + userId + "' and Vname='篮球场'", OleDbConnection1);
			//odadSelBaseket.Fill(dstBasketLease, "ff");
			if (dstBasketLease.Tables["ff"].Rows[0][1].ToString() == "校外人员")
			{
				fee = System.Convert.ToDouble(dstBasketLease.Tables["ff"].Rows[0][3]); //校外人员价格
			}
			else
			{
				fee = System.Convert.ToDouble(dstBasketLease.Tables["ff"].Rows[0][2]); //校内人员价格
			}
			uname = System.Convert.ToString(dstBasketLease.Tables["ff"].Rows[0][0]);

            //判断租借场地是否达到上限
            //sql3 = "select * from Orders where ID='" + 登录界面.Default.txtID.Text + "' and Stime between '" + System.Convert.ToString(DateTime.Now.Date) + "' and '" + System.Convert.ToString(DateTime.Now.Date.AddDays(6)) + "'";
            //odadSelOrder = new System.Data.OleDb.OleDbDataAdapter(sql3, OleDbConnection1);
            //odadSelOrder.Fill(dstSelOrder, "order");
            cm = ConDatabase.OpenDatabase("select * from v_vorder where Uidr='" + 登录界面.Default.txtID.Text + "' and Vrstart between '" + System.Convert.ToString(DateTime.Now.Date) + "' and '" + System.Convert.ToString(DateTime.Now.Date.AddDays(6)) + "'");
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cm);
            adapter2.Fill(dstSelOrder, "order");
            if (dstSelOrder.Tables["order"].Rows.Count >= 5)
			{
				MessageBox.Show("抱歉，一周内预订总时长不能超过五小时。");
			}
			else
			{
				//时间预定
				if (btnSubmit1.Visible == false)
				{
					Vno = dgvOrder[e.ColumnIndex, e.RowIndex].Value.ToString();
					Stime = dtpTime.Value.Date.ToString("yyyy-MM-dd") + " " + cmbBegintime.SelectedItem.ToString();
					Etime = dtpTime.Value.Date.ToString("yyyy-MM-dd") + " " + txtEndtime.Text;
					str = "确定预订" + Stime + "到" + Etime + "的篮球场" + Vno + "吗？";
					if ((int)Interaction.MsgBox(str, Constants.vbOKCancel, null) == 1)
					{
						if ((int)Interaction.MsgBox("本次预订租金为" + System.Convert.ToString(fee) + "元", Constants.vbOKCancel, null) == 1)
						{
							sql1 = "insert into v_state(Vtnames,Vnids,Vsstart,Vsend,Vsstate) values('篮球场','" + Vno + "','" + Stime + "','" + Etime + "','" + "已预约')";
							sql2 = "insert into v_vorder(Vidr,Vtnamer,Vnidr,Vrstart,Vrend,Vrstate,Vramount,Vrremarks,Unamer) values('" + 登录界面.Default.txtID.Text + "','篮球场','" + Vno + "','" + Stime + "','" + Etime + "',1," + System.Convert.ToString(fee) +
								",'" + DateTime.Now.ToString("yyyyMMddhhmm") + "b" + Vno + "','" + uname + "','')";
                            //odcmdInsLease = new System.Data.OleDb.OleDbCommand(sql1, OleDbConnection1);
                            //odcmdInsOrder = new System.Data.OleDb.OleDbCommand(sql2, OleDbConnection1);
                            //OleDbConnection1.Open();
                            //odcmdInsLease.ExecuteNonQuery();
                            //odcmdInsOrder.ExecuteNonQuery();
                            //OleDbConnection1.Close();
                            cm = ConDatabase.OpenDatabase(sql1);
                            cm.ExecuteNonQuery();
                            //cm = ConDatabase.OpenDatabase(sql2);
                            //cm.ExecuteNonQuery();
                            con.Close();
							MessageBox.Show("预订成功");
						}
					}
				}
				else
				{
					//场地预定
					Vno = cbmGymnum.SelectedValue.ToString();
					str = "确定预订" + dgvOrder.Columns[e.ColumnIndex].Name + " " + System.Convert.ToString(dgvOrder[0, e.RowIndex].Value) + "的篮球场" + Vno + "吗？";
					if (dgvOrder[e.ColumnIndex, e.RowIndex].Value.ToString() != "可用")
					{
						MessageBox.Show("该时间段不可预订！");
					}
					else if ((int)Interaction.MsgBox(str, Constants.vbOKCancel, null) == 1)
					{
						if ((int)Interaction.MsgBox("本次预订租金为" + System.Convert.ToString(fee) + "元", Constants.vbOKCancel, null) == 1)
						{
							if (e.RowIndex == 0)
							{
								sql1 = "insert into v_state(Vtnames,Vnids,Vsstart,Vsend,Vsstate) values('篮球场','" + Vno + "','" + dgvOrder.Columns[e.ColumnIndex].Name + " 12:00:00','" + dgvOrder.Columns[e.ColumnIndex].Name + " 13:00:00','" + "已预约')";
								sql2 = "insert into v_vorder(Vidr,Vtnamer,Vnidr,Vrstart,Vrend,Vrstate,Vramount,Vrremarks,Unamer) values('" + 登录界面.Default.txtID.Text + "','篮球场','" + Vno + "','" + dgvOrder.Columns[e.ColumnIndex].Name + " 12:00:00','" + dgvOrder.Columns[e.ColumnIndex].Name + " 13:00:00',1," + System.Convert.ToString(fee) +
									",'" + DateTime.Now.ToString("yyyyMMddhhmm") + "b" + Vno + "','" + uname + "','')";
							}
							else if (e.RowIndex == 1)
							{
								sql1 = "insert into v_state(Vtnames,Vnids,Vsstart,Vsend,Vsstate) values('篮球场','" + Vno + "','" + dgvOrder.Columns[e.ColumnIndex].Name + " 13:00:00','" + dgvOrder.Columns[e.ColumnIndex].Name + " 14:00:00','" + "已预约')";
								sql2 = "insert into v_vorder(Vidr,Vtnamer,Vnidr,Vrstart,Vrend,Vrstate,Vramount,Vrremarks,Unamer) values('" + 登录界面.Default.txtID.Text + "','篮球场','" + Vno + "','" + dgvOrder.Columns[e.ColumnIndex].Name + " 13:00:00','" + dgvOrder.Columns[e.ColumnIndex].Name + " 14:00:00',1," + System.Convert.ToString(fee) +
									",'" + DateTime.Now.ToString("yyyyMMddhhmm") + "b" + Vno + "','" + uname + "','')";
							}
							else if (e.RowIndex == 2)
							{
								sql1 = "insert into v_state(Vtnames,Vnids,Vsstart,Vsend,Vsstate) values('篮球场','" + Vno + "','" + dgvOrder.Columns[e.ColumnIndex].Name + " 18:00:00','" + dgvOrder.Columns[e.ColumnIndex].Name + " 19:00:00','" + "已预约')";
								sql2 = "insert into v_vorder(Vidr,Vtnamer,Vnidr,Vrstart,Vrend,Vrstate,Vramount,Vrremarks,Unamer) values('" + 登录界面.Default.txtID.Text + "','篮球场','" + Vno + "','" + dgvOrder.Columns[e.ColumnIndex].Name + " 18:00:00','" + dgvOrder.Columns[e.ColumnIndex].Name + " 19:00:00',1," + System.Convert.ToString(fee) +
									",'" + DateTime.Now.ToString("yyyyMMddhhmm") + "b" + Vno + "','" + uname + "','')";
							}
							else if (e.RowIndex == 3)
							{
								sql1 = "insert into v_state(Vtnames,Vnids,Vsstart,Vsend,Vsstate) values('篮球场','" + Vno + "','" + dgvOrder.Columns[e.ColumnIndex].Name + " 19:00:00','" + dgvOrder.Columns[e.ColumnIndex].Name + " 20:00:00','" + "已预约')";
								sql2 = "insert into v_vorder(Vidr,Vtnamer,Vnidr,Vrstart,Vrend,Vrstate,Vramount,Vrremarks,Unamer) values('" + 登录界面.Default.txtID.Text + "','篮球场','" + Vno + "','" + dgvOrder.Columns[e.ColumnIndex].Name + " 19:00:00','" + dgvOrder.Columns[e.ColumnIndex].Name + " 20:00:00',1," + System.Convert.ToString(fee) +
									",'" + DateTime.Now.ToString("yyyyMMddhhmm") + "b" + Vno + "','" + uname + "','')";
							}
                            //odcmdInsLease = new System.Data.OleDb.OleDbCommand(sql1, OleDbConnection1);
                            //odcmdInsOrder = new System.Data.OleDb.OleDbCommand(sql2, OleDbConnection1);
                            //OleDbConnection1.Open();
                            //odcmdInsLease.ExecuteNonQuery();
                            //odcmdInsOrder.ExecuteNonQuery();
                            //OleDbConnection1.Close();
                            cm = ConDatabase.OpenDatabase(sql1);
                            cm.ExecuteNonQuery();
                            //cm = ConDatabase.OpenDatabase(sql2);
                            //cm.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("预订成功");
						}
					}
				}
			}
		}
		
		public void cmbBegintime_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			if (cmbBegintime.SelectedItem.ToString() == "12:00")
			{
				txtEndtime.Text = "13:00";
			}
			else if (cmbBegintime.SelectedItem.ToString() == "13:00")
			{
				txtEndtime.Text = "14:00";
			}
			else if (cmbBegintime.SelectedItem.ToString() == "18:00")
			{
				txtEndtime.Text = "19:00";
			}
			else if (cmbBegintime.SelectedItem.ToString() == "19:00")
			{
				txtEndtime.Text = "20:00";
			}
		}
		
		public void btnSubmit2_Click(object sender, EventArgs e)
		{
			//连接数据库
			string sql1 = "";
			string sql2 = "";
			sql1 = "select vnid from v_venue where Vtnamen='篮球场'";
			dstBasketLease.Reset();
            cm = ConDatabase.OpenDatabase(sql1);
            con = ConDatabase.getCon();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(cm);
            adapter1.Fill(dstBasketLease, "ss");
			//odadSelBaseket = new System.Data.OleDb.OleDbDataAdapter(sql1, OleDbConnection1);
			//odadSelBaseket.Fill(dstBasketLease, "ss");
			sql2 = "select Vnids from v_state where Vtnames='篮球场' and Vsstart = '" 
				+ dtpTime.Value.Date.ToString("yyyy-MM-dd") + " " + cmbBegintime.SelectedItem.ToString() + "'";
            cm = ConDatabase.OpenDatabase(sql2);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(cm);
            adapter2.Fill(dstBasketLease, "aa");
			//odadSelBaseket = new System.Data.OleDb.OleDbDataAdapter(sql2, OleDbConnection1);
			//odadSelBaseket.Fill(dstBasketLease, "aa");
			
			//显示表格
			dgvOrder.Rows.Clear();
			dgvOrder.Columns.Clear();
			this.dgvOrder.AllowUserToAddRows = false;
			dgvOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
			this.dgvOrder.Columns.Add("空闲场地", "空闲场地");
			this.dgvOrder.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
			for (var i = 0; i <= dstBasketLease.Tables["ss"].Rows.Count - 1; i++)
			{
				this.dgvOrder.Rows.Add();
				this.dgvOrder[0, System.Convert.ToInt32(i)].Value = dstBasketLease.Tables["ss"].Rows[i][0];
			}
			
			//修改表格
			if (dstBasketLease.Tables["aa"].Rows.Count != 0)
			{
				for (var i = dstBasketLease.Tables["aa"].Rows.Count - 1; i >= 0; i--)
				{
					this.dgvOrder.Rows.RemoveAt(int.Parse(System.Convert.ToString(dstBasketLease.Tables["aa"].Rows[i][0])) - 1);
				}
			}
			
		}
		
		public void orderBasketball_Load(object sender, EventArgs e)
		{
            btnSubmit1.Visible = false;
            Label4.Visible = false;
            cbmGymnum.Visible = false;
            dtpTime.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            txtEndtime.Visible = false;
            cmbBegintime.Visible = false;
            btnSubmit2.Visible = false;
            Label3.Visible = true;
			dtpTime.MinDate = DateTime.Now;
			dtpTime.MaxDate = DateTime.Now.AddDays(6); //只可预订一周的场地
			string sql = "select Vnid from v_venue where Vtnamen='篮球场' order by Vnid";
			dstSelOrder.Reset();
            cm = ConDatabase.OpenDatabase(sql);
            con = ConDatabase.getCon();
            MySqlDataAdapter adapter = new MySqlDataAdapter(cm);
            adapter.Fill(dstSelOrder, "ss");
			//odadSelBaseket = new System.Data.OleDb.OleDbDataAdapter(sql, OleDbConnection1);
			//odadSelBaseket.Fill(dstSelOrder, "ss");
			cbmGymnum.DataSource = dstSelOrder.Tables["ss"];
			for (var i = 0; i <= dstSelOrder.Tables["ss"].Rows.Count - 1; i++)
			{
				cbmGymnum.ValueMember = dstSelOrder.Tables["ss"].Columns[0].ToString(); //填充下拉栏里的场地号
			}
		}
		
		//按场地预订时点击确认发生的事件
		public void btnGymorder_Click(object sender, EventArgs e)
		{
			btnSubmit1.Visible = true;
			Label4.Visible = true;
			cbmGymnum.Visible = true;
			dtpTime.Visible = false;
			Label1.Visible = false;
			Label2.Visible = false;
			txtEndtime.Visible = false;
			cmbBegintime.Visible = false;
			btnSubmit2.Visible = false;
			Label3.Visible = true;
			Label3.Text = "双击表中'可用'即可预订该时间的场地";
			dgvOrder.Rows.Clear();
			dgvOrder.Columns.Clear();
		}
		
		//按时间预订时点击确认发生的事件
		public void btnTimeorder_Click(object sender, EventArgs e)
		{
			btnSubmit1.Visible = false;
			Label4.Visible = false;
			cbmGymnum.Visible = false;
			dtpTime.Visible = true;
			Label1.Visible = true;
			Label2.Visible = true;
			txtEndtime.Visible = true;
			cmbBegintime.Visible = true;
			btnSubmit2.Visible = true;
			Label3.Visible = true;
			Label3.Text = "双击表中的场地号即可预订该场地";
			dgvOrder.Rows.Clear();
			dgvOrder.Columns.Clear();
		}

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
	
}
