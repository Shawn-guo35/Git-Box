using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Loginsuccess : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Session["Uname"].ToString();

    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {

        Response.Redirect("Login.aspx");
    }

    protected void lbtCupwd_Click(object sender, EventArgs e)
    {
        Session["Uname"] = Label1.Text;
        Response.Redirect("Changepassword.aspx");
    }

    protected void lbtMufile_Click(object sender, EventArgs e)
    {
        Session["Uname"] = Label1.Text;
        Response.Redirect("Modifyuserprofile.aspx");
    }
}