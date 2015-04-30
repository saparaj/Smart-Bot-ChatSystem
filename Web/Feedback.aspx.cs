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

public partial class Feedback : System.Web.UI.Page
{
    // SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Feedback;uid=sa;Pwd=rest1234");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   /* protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text != "")
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into feedback values('" + TextBox1.Text + "','"+ DropDownList1.SelectedItem.Value + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            ScriptManager.RegisterStartupScript(this, GetType(), "Success", "alert('Successful Submission of feedback');", true);
            Response.Redirect("Feedback.aspx");
        }

    }
    */
    
}