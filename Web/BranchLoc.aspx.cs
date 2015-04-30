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

public partial class BranchLoc : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=SIDDHITA\\SQLEXPRESS;Initial Catalog=branch;uid=sa;Pwd=123");
   
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtarea.Text == "" && txtstation.Text == "")
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from branches where city='" + ddlcity.Text + "'", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            GridView1.DataSource = ds2;
            GridView1.DataBind();
        }
        else if (txtarea.Text == "")
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from branches where city='" + ddlcity.Text + "' And address like '%"+txtstation.Text+"%'", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            GridView1.DataSource = ds2;
            GridView1.DataBind();
        }
        else if (txtstation.Text == "")
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from branches where city='" + ddlcity.Text + "' And address like '%" + txtarea.Text + "%'", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            GridView1.DataSource = ds2;
            GridView1.DataBind();
        }
        GridView1.DataBind();
        if (GridView1.Rows.Count == 0)
        {
            String alertmsg = "Sorry no branches in that location";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
        
        }
    }
}
