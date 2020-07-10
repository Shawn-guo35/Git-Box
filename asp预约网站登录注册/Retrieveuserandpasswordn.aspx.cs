using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Retrieveuserandpasswordn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MySqlDataAdapter a = null;
        DataSet ds = new DataSet();
        string userPhone = Session["Uphone"].ToString();
        string strcon = "server=121.36.57.112;database=summer2020;user id=customer;password=Summer2020;Charset=utf8";
        MySqlConnection con = new MySqlConnection(strcon);
        con.Open();
        string sqlSelrupn = "select * from v_users where  Uphone = '" + userPhone + "'";
        MySqlCommand com = new MySqlCommand(sqlSelrupn, con);

        a = new MySqlDataAdapter(com);
        a.Fill(ds, "vuser");

        if (!Page.IsPostBack)
        {

            //lblRnuname.Text = a["Uname"].ToString();
            //lblRnupwd.Text = a["Upwd"].ToString();
            lblRnuname.Text = ds.Tables["vuser"].Rows[0][2].ToString();
            lblRnupwd.Text = ds.Tables["vuser"].Rows[0][4].ToString();


        }

        else
        {
            Response.Write("<script>alert('查询失败，请重新查询！')</script>");

        }
        con.Close();
    }


    protected void btnReturnrn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}