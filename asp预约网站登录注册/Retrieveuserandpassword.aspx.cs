using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;


public partial class Retrieveuserandpassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRertievea_Click(object sender, EventArgs e)
    {
        string userPhone = this.txtRetrievea.Text;
        string strcon = "server=121.36.57.112;database=summer2020;user id=customer;password=Summer2020;Charset=utf8";
        MySqlConnection con = new MySqlConnection(strcon);
        con.Open();
        string sqlSelrup = "select * from v_users where Uphone = '" + userPhone + "'";
        MySqlCommand com = new MySqlCommand(sqlSelrup, con);
        if (Convert.ToInt32(com.ExecuteScalar()) > 0)
        {
            Session["Uphone"] = userPhone;
            Response.Write("<script>alert('电话号码正确，请输入验证码！');location.href='Retrieveuserandpasswordn.aspx'</script>");
            con.Close();
        }

        else
        {
            Response.Write("<script>alert('电话号码不正确，请重新输入！')</script>");

        }
    }
}