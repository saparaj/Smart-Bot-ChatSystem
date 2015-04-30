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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // Timer1.Start();
    }
    protected void Timer1_Tick1(object sender, EventArgs e)
    {
        Label1.Text = DateTime.Now.ToString();
        Timer1.Enabled = false;
    }
}
