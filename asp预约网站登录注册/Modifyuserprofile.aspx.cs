using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Modifyuserprofile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (ddlUidentitym.SelectedValue == "校内人员")
        {
            txtUphonem.Enabled = true;
        }
        else
        {
            txtUphonem.Enabled = false;
        }
        MySqlDataAdapter a = null;
        DataSet ds = new DataSet();
        string userUname = Session["Uname"].ToString();
        string strcon = "server=121.36.57.112;database=summer2020;user id=customer;password=Summer2020;Charset=utf8";
        MySqlConnection con = new MySqlConnection(strcon);
        con.Open();
        string sqlSelrupn = "select * from v_users where  Uname = '" + userUname + "'";
        MySqlCommand com = new MySqlCommand(sqlSelrupn, con);

        a = new MySqlDataAdapter(com);
        a.Fill(ds, "vuser");
        lblUidm.Text = ds.Tables["vuser"].Rows[0][1].ToString();
        lblUnamem.Text = ds.Tables["vuser"].Rows[0][2].ToString();
        ddlUidentitym.Text = ds.Tables["vuser"].Rows[0][3].ToString();
        txtUphonem.Text = ds.Tables["vuser"].Rows[0][5].ToString();
        txtUremarksm.Text = ds.Tables["vuser"].Rows[0][6].ToString();
        if (ddlUidentitym.SelectedValue == "校内人员")
        {
            txtUphonem.Enabled = true;
        }
        else
        {
            txtUphonem.Enabled = false;
        }
        //ddlUidentitym.Items.FindByText(ds.Tables["vuser"].Rows[0][3].ToString()).Selected = true;//选项Text 

        //con.Close();

    }

    protected void btnModify_Click(object sender, EventArgs e)
    {
        string strcon = "server=121.36.57.112;database=summer2020;user id=customer;password=Summer2020;Charset=utf8";
        MySqlConnection con = new MySqlConnection(strcon);
        con.Open();
        try
        {
            string sqlUm = "update v_users set Uphone='" + txtUphonem.Text + "', Uremarks = '" + txtUremarksm.Text + "' where Uid='" + lblUidm.Text + "'";
            MySqlCommand com = new MySqlCommand(sqlUm, con);
            //com.ExecuteNonQuery();

            lblMessagem.Text = "修改成功！";
        }
        catch
        {

            lblMessagem.Text = "修改失败！";
        }
        con.Close();

    }
    //private void chkModfile()
    //{
    //    string strcon = "server=121.36.57.112;database=summer2020;user id=customer;password=Summer2020;Charset=utf8";
    //    MySqlConnection con = new MySqlConnection(strcon);
    //    con.Open();
    //    string sqlSec = "select * from  v_users  where Uid ='" + lblUidm.Text + "'";
    //    MySqlCommand com = new MySqlCommand(sqlSec, con);
    //    if (Convert.ToInt32(com.ExecuteScalar()) > 0)
    //    {
    //        Umdfile();
    //        con.Close();
    //    }
    //    else
    //    {
    //        lblMessagem.Text = "原账号不正确！";
    //    }

    //}
    //private void Umdfile()
    //{
    //    string strcon = "server=121.36.57.112;database=summer2020;user id=customer;password=Summer2020;Charset=utf8";
    //    MySqlConnection con = new MySqlConnection(strcon);
    //    con.Open();
    //    try
    //    {
    //        con.Open();
    //        string sqlUm = "update v_users set Uphone='" + txtUphonem.Text + "', Uremarks = '" + txtUremarksm.Text + "' where Uid='" + lblUidm.Text + "'";
    //        MySqlCommand com = new MySqlCommand(sqlUm, con);
    //        com.ExecuteNonQuery();

    //        lblMessagem.Text = "修改成功！";
    //    }
    //    catch
    //    {

    //        lblMessagem.Text = "修改失败！";
    //    }
    //}





    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}

