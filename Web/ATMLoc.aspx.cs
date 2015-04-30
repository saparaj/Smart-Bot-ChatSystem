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

public partial class ATMLoc : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=SIDDHITA\\SQLEXPRESS;Initial Catalog=branch;uid=sa;Pwd=123");
    protected void Page_Load(object sender, EventArgs e)
    {
        
        SqlDataAdapter da2 = new SqlDataAdapter("Select * from branches", con);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);
        GridView1.DataSource = ds2;
        GridView1.DataBind();

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataAdapter da2 = new SqlDataAdapter("Select * from branches where city='"+DropDownList1.SelectedItem.Value+"'", con);
        DataSet ds2 = new DataSet();
        da2.Fill(ds2);
        GridView1.DataSource = ds2;
        GridView1.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from branches where address like '%" + txtarea.Text + "%'", con);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            if (ds2.Tables[0].Rows[0][0] == null)
            {
                String alertmsg = "Sorry No Branches in that Area";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
            }
            GridView1.DataSource = ds2;
            GridView1.DataBind();
        }
        catch (IndexOutOfRangeException ex)
        {
            String alertmsg = "Sorry No Branches in that Area";
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + alertmsg + "');", true);
        }
    }
}
