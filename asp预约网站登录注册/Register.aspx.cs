using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegisteri_Click(object sender, EventArgs e)
    {
        //注册txtUidi
        string userId = this.txtUidi.Text;
        string userName = this.txtUnamei.Text;
        string userIdentity = this.ddlUidentity.Text;
        string userPassword = this.txtUpwdi.Text;
        string userPhone = this.txtUphonei.Text;
        string userRemarks = this.txtUremarksi.Text;

        string strcon = "server=121.36.57.112;database=summer2020;user id=customer;password=Summer2020;Charset=utf8";

        MySqlConnection con = new MySqlConnection(strcon);
        con.Open();
        String sql = "INSERT INTO v_users(Uid,Uname,Uidentity,Upwd,Uphone,Uremarks) VALUES('" + userId + "','" + userName + "','" + userIdentity + "','" + userPassword + "','" + userPhone + "','" + userRemarks + "')"; // 没有判断重复插入

        MySqlCommand cmd = new MySqlCommand(sql, con);
        cmd.ExecuteNonQuery();
        //MessageBox.Show("注册成功");
        Response.Write("<script>alert('注册成功！')</script>");
        Response.Redirect("Login.aspx");
    }

    protected void btnReturnl_Click(object sender, EventArgs e)
    {

    }
}