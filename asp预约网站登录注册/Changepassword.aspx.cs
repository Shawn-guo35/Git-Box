using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Changepassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            if (Session["Uname"] == null)
            {
                Response.Write("<script>alert('对不起您还没有登录!');location.href='Login.aspx'</script>");
            }
            else
            {
                Label1.Text = Session["Uname"].ToString();
            }
        }
    }
    protected void btnCrreturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
    protected void btnChangepasswaord_Click(object sender, EventArgs e)
    {
        chkUpwd();
    }


    /// <summary>
    /// 修改密码
    /// </summary>
    private void Uupwd()
    {
        string strcon = "server=121.36.57.112;database=summer2020;user id=customer;password=Summer2020;Charset=utf8";
        MySqlConnection con = new MySqlConnection(strcon);
        //string Username = Session["Uname"].ToString();
        try
        {
            con.Open();
            string sqlUc = "update v_users  set Upwd ='" + txtUpwdn.Text.ToString() + "' where Uname='" + Session["Uname"].ToString() + "' ";
            MySqlCommand com = new MySqlCommand(sqlUc, con);
            com.ExecuteNonQuery();




            lblMessage.Text = "修改成功！";


        }
        catch
        {

            lblMessage.Text = "修改失败！";
        }
    }
    /// <summary>
    /// 检验原来的密码
    /// </summary>
    private void chkUpwd()
    {
        string strcon = "server=121.36.57.112;database=summer2020;user id=customer;password=Summer2020;Charset=utf8";
        MySqlConnection con = new MySqlConnection(strcon);
        con.Open();
        string sqlSec = "select * from  v_users  where Uname='" + Session["Uname"].ToString() + "' and Upwd='" + txtUpwdo.Text + "'";
        MySqlCommand com = new MySqlCommand(sqlSec, con);
        //SqlDataReader dr;
        //dr = data.GetDataReader("select * from  Users  where Uname='" + Session["Uname"].ToString() + "' and Upwd='" + txtUpwdo.Text + "'");
        if (Convert.ToInt32(com.ExecuteScalar()) > 0)
        {
            Uupwd();
            con.Close();
        }
        else
        {
            lblMessage.Text = "原密码不正确！";
        }

    }

}