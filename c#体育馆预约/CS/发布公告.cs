using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsApp1
{
    public partial class 发布公告 : Form
    {
        MySqlConnection con;
        MySqlCommand cm;
        ConDatabase ConDatabase;
        dataDataSet ds;
        MySqlDataAdapter adapter;
        
        public 发布公告()
        {
            InitializeComponent();
            ConDatabase = new ConDatabase();
            cm = ConDatabase.OpenDatabase();
            con = ConDatabase.getCon();
            ds = new dataDataSet();           
            string inquery = "select Ntdate,Ntitle,Ntcontent from v_notice";        
            cm = ConDatabase.OpenDatabase(inquery);
            adapter = new MySqlDataAdapter(cm);
            adapter.Fill(ds, "content");
            gridtitle.DataSource = ds.Tables["content"];
            gridtitle.Columns[2].Visible = false;
            //gridtitle.Columns.Add(ds.Tables["content"].Columns[0].ColumnName, ds.Tables["content"].Columns[0].ColumnName);
            //gridtitle.Columns.Add(ds.Tables["content"].Columns[1].ColumnName, ds.Tables["content"].Columns[1].ColumnName);
            //gridtitle.Columns[0].DataPropertyName = ds.Tables["content"].Columns[0].ColumnName;
            //gridtitle.Columns[1].DataPropertyName = ds.Tables["content"].Columns[1].ColumnName;
   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            //发布公告
            string getpublisher = "select Uname from v_users where Uid = '" + 登录界面.Default.txtID.Text + "'";
            cm = ConDatabase.OpenDatabase(getpublisher);
            adapter = new MySqlDataAdapter(cm);
            adapter.Fill(ds, "v_users");
            string user = ds.Tables["v_users"].Rows[0][0].ToString();
            string insert = "insert into v_notice(Ntdate,Ntpublisher,Ntitle,Ntcontent) values('" + DateTime.Now.ToString() + "','"
               + user + "','" + bulletinTitle.Text.ToString() + "','" + bulletin.Text.ToString() + "')";
            cm = ConDatabase.OpenDatabase(insert);
            cm.ExecuteNonQuery();
            MessageBox.Show("公告已发布。");
            bulletinTitle.Text = "";
            bulletin.Text = "";
        }

        private void gridtitle_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                oldContent.Text = ds.Tables["content"].Rows[index][2].ToString();
            }
            catch
            {

            }
        }
    }
}
