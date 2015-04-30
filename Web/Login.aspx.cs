using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    
    SqlConnection con = new SqlConnection("Data Source=SIDDHITA\\SQLEXPRESS;Initial Catalog=Glogin;uid=sa;Pwd=123");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da2 = new SqlDataAdapter("Select username,password from register where username='" + txtusername.Text + "' and password='"+txtpassword.Text+"'", con);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);
        if (ds2.Tables[0].Rows.Count != 0)
        {
            String alertmsg = "Yes valid Login";
            GlobalClass.GlobalVar = txtusername.Text;
            Page.ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
            Session["txt"] = "Welcome friend";
            Response.Redirect("bot.aspx");
        }
        else
        {
            String alertmsg = "Enter valid username / Password";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
        
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
   
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if ((TextBox1.Text == "admin") && (TextBox2.Text == "rss123"))
        {
            Response.Redirect("expertans.aspx");
        }
        else
        {
            String alertmsg = "Enter valid username / Password";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

    }
}
