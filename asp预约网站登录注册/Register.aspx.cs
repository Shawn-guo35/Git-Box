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
        string userPasswordc = this.txtConfirm.Text;
        string userPhone = this.txtUphonei.Text;
        string userRemarks = this.txtUremarksi.Text;


        //if (userPhone.length() == 11)
        //if(ddlUidentity.Text=="校内人员")
        //{
        //    lblUidentity.Text = "校内人员账号默认为工号或学号。";
        //}
        //else
        //{
        //    lblUidentity.Text = "校外人员请用电话号码用作账号注册。";
        //}
        if (userId.Equals("") || userName.Equals("") || userIdentity.Equals("") || userPasswordc.Equals("") || userPassword.Equals("") || userPhone.Equals(""))
        {
            Response.Write("<script>alert('除备注外都不能为空！')</script>");
        }

        else if(userPassword == userPasswordc)
        {
            string strcon = "server=121.36.57.112;database=summer2020;user id=customer;password=Summer2020;Charset=utf8";
            MySqlConnection con = new MySqlConnection(strcon);
            try
            {
                con.Open();
                string sqlSel = "select * from v_users where Uid = '" + userId + "' or Uname = '" + userName + "'or Uphone = '" + userPhone + "'";
                MySqlCommand com = new MySqlCommand(sqlSel, con);
                //MySqlDataReader sdr = com.ExecuteReader();
                if (Convert.ToInt32(com.ExecuteScalar()) > 0)
                {
                    Session["Uid"] = userId;
                    Session["Uname"] = userName;
                    Session["Uphone"] = userPhone;
             
                    Response.Write("<script>alert('该账号、用户名或者电话已被使用！')</script>");
                }

                else
                {
                    String sqli = "INSERT INTO v_users(Uid,Uname,Uidentity,Upwd,Uphone,Uremarks) VALUES('" + userId + "','" + userName + "','" + userIdentity + "','" + userPassword + "','" + userPhone + "','" + userRemarks + "')";
                    MySqlCommand cmd = new MySqlCommand(sqli, con);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show("注册成功");
                    Session["Uid"] = userId;
                    Session["Uname"] = userName;
                    Session["Uidentity"] = userIdentity;
                    Session["Upwd"] = userPassword;
                    Session["Uphone"] = userPhone;
                    Session["Uremarks"] = userRemarks;
                    Response.Write("<script>alert('注册成功！');location.href='Login.aspx'</script>");
                    con.Close();
                }
            }

            catch (Exception ex)
            {
                Response.Write("<script>alert('打开数据库失败！')</script>");
            }
        }

        else
        {
            Response.Write("<script>alert('两次输入的密码不一致！')</script>");
        }

    }

    protected void btnReturnl_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }
}