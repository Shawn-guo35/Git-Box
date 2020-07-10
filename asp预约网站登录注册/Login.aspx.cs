using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // 登录

        string userId = this.txtUname.Text;
        string userPassword = this.txtUpwd.Text;

        if (userId.Equals("") || userPassword.Equals(""))
        {
            Response.Write("<script>alert('没有输入账号或密码！')</script>");
        }
        else
        {
            string strcon = "server=121.36.57.112;database=summer2020;user id=customer;password=Summer2020;Charset=utf8";
            MySqlConnection con = new MySqlConnection(strcon);
            MySqlDataAdapter a = null;
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                string sqlSel = "select * from v_users where Uid = '" + userId + "' and Upwd = '" + userPassword + "'";
                MySqlCommand com = new MySqlCommand(sqlSel, con);
                a = new MySqlDataAdapter(com);
                a.Fill(ds, "vuser");
                //MySqlCommand MySqlComGet = new MySqlCommand();
                //MySqlComGet.Connection = con;
                //MySqlComGet.CommandText  = "select count(*) from v_users where Uname = '" + userName + "' and Upwd = '" + userPassword + "'";
                ////MySqlCommand com = new MySqlCommand(sqlSel, con);
                //MySqlDataReader sdr = MySqlComGet.ExecuteReader();
                if (Convert.ToInt32(com.ExecuteScalar()) > 0)
                {
                    //Response.Write(sdr["Uname"].ToString());
                    //Response.Write(sdr["Upwd"].ToString());
                    Session["Uid"] = userId;
                    Session["Upwd"] = userPassword;
                    Session["Uname"] = ds.Tables["vuser"].Rows[0][2].ToString();
                    Response.Write("<script>alert('登录成功！');location.href='Loginsuccess.aspx'</script>");
                    con.Close();
                    //Response.Redirect("Loginsuccess.aspx");
                }

                else
                {
                    Response.Write("<script>alert('账号或者密码不正确，请重新输入！')</script>");

                }
            }

            catch (Exception ex)
            {
                Response.Write("<script>alert('打开数据库失败！')</script>");
            }
        }
    }



    protected void btnRegister_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}