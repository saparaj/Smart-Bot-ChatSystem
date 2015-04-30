using System;
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
using System.Data;
using System.Data.SqlClient;
using System.Threading;

public partial class _Default : System.Web.UI.Page 
{
    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Glogin;uid=sa;Pwd=rest1234");
    protected void Page_Load(object sender, EventArgs e)
    {
        int s;
        SqlDataAdapter da = new SqlDataAdapter("Select max(uid) from register", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        s = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
        s++;
        txtuid.Text = Convert.ToString(s);

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        

        if (txtfname.Text != "")
        {
            if (txtmname.Text != "")
            {
                if (txtlname.Text != "")
                {
                    if (txtemail.Text != "")
                    {
                        if (txtcontact.Text != "")
                        {
                            if (txtusername.Text != "")
                            {
                                if (txtpassword.Text != "")
                                {

                                    if (lblusername.Text == "Username Available")
                                    {
                                        con.Open();
                                        SqlCommand cmd = new SqlCommand("Insert into Register values('" + txtfname.Text + "','" + txtmname.Text + "','" + txtlname.Text + "','" + txtemail.Text + "','" + txtcontact.Text + "','" + txtcity.Text + "','" + txtaddress.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','" + Convert.ToInt32(txtuid.Text) + "','"+DropDownList1.SelectedItem.Value+"')", con);
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                        String alertmsg = "Thank You for Registering";
                                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
                                        Thread.Sleep(3000);
                                        Response.Redirect("Login.aspx");
                                    }
                                    else
                                    {
                                        String alertmsg = "Enter valid username";
                                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
        
                                    }
                                }
                                else
                                { Label1.Visible = true; }
                            }
                            else
                            { Label1.Visible = true; }
                        }
                        else
                        { Label1.Visible = true; }
                    }
                    else
                    { Label1.Visible = true; }
                }
                else
                { Label1.Visible = true; }
            }
            else
            { Label1.Visible = true; }
        }
        else
        { Label1.Visible = true; }
    }
    protected void txtusername_TextChanged(object sender, EventArgs e)
    {

        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da2 = new SqlDataAdapter("Select * from register where username='" + txtusername.Text + "'", con);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);
        
            if (ds2.Tables[0].Rows.Count == 0)
        {
            lblusername.Text = "Username Available";
        }
        else
        {
            lblusername.Text = "Username Not Available";
        }
            
        if (lblusername.Text == "Username Available")
            {
                txtpassword.Enabled = true;
            }
            else if (lblusername.Text == "Username Not Available")
            {
                txtpassword.Enabled = false;
            }
    }
    protected void txtaddress_TextChanged(object sender, EventArgs e)
    {

    }
}
