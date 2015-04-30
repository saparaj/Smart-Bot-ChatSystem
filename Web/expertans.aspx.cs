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

public partial class expertans : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=SIDDHITA\\SQLEXPRESS;Initial Catalog=chatbot;uid=sa;Pwd=123");
    string questions;
    int i = 0;
    int count;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("Select unansque,reply from unansq where flag=0", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        count = Convert.ToInt32(ds.Tables[0].Rows.Count);
        if (count != 0)
        {
            if (i < count)
            {

                questions = Convert.ToString(ds.Tables[0].Rows[i][0]).ToLower();
                Label2.Text = questions;
            }
                        
        }
        else
        {
            Label2.Text = "No Unanswered Questions";
        }

               
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "")
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE unansq  SET reply = @reply,flag=@flag where unansque = @unans", con);
            cmd.Parameters.AddWithValue("@reply", TextBox1.Text);
            cmd.Parameters.AddWithValue("@unans", Label2.Text);
            cmd.Parameters.AddWithValue("@flag", 1);
            cmd.ExecuteNonQuery();
            con.Close();
            String alertmsg = "Your answer successfully submitted";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
            Response.Redirect("expertans.aspx");
        }
        else
        {
            String alertmsg = "Enter text in answer field";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da = new SqlDataAdapter("Select unansque,reply from unansq where flag=0", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        count = Convert.ToInt32(ds.Tables[0].Rows.Count);
        i++;
        if (count != 0)
        {
            if (i < count)
            {

                questions = Convert.ToString(ds.Tables[0].Rows[i][0]).ToLower();
                Label2.Text = questions;
            }

        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        String delq = Label2.Text;
        con.Open();
        SqlCommand cmd = new SqlCommand("Delete from unansq where unansque='"+delq+"'", con);
        cmd.ExecuteNonQuery();
        con.Close();
        Label2.Text = "Deleted The question";
    }
   
}