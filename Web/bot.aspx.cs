
using System;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Threading;
using System.Timers;
using System.Text.RegularExpressions;
using SpeechLib;

public partial class bot : System.Web.UI.Page
{
    
    SqlConnection con = new SqlConnection("Data Source=SIDDHITA\\SQLEXPRESS;Initial Catalog=chatbot;uid=sa;Pwd=123");
    System.Timers.Timer t = new System.Timers.Timer();
    protected void Page_Load(object sender, EventArgs e)
    {
        Label3.Text = "Hello"+" "+GlobalClass.GlobalVar+"!";
       lblbot.Text = Session["txt"].ToString();

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtuser.Text != "")
        {
            String s = Convert.ToString(txtuser.Text);
            String reply;
            s = s.ToLower();
            string st = lblbot.Text;
            Match match = Regex.Match(s, "(hi+|he+l+o+|hie+|hey+)", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                SqlDataAdapter da = new SqlDataAdapter("Select top 1 * from generalreply order by NEWID()", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                reply = Convert.ToString(ds.Tables[0].Rows[0][0]);
                lblbot.Text = reply;
            }
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from slang", con);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            string[] words = s.Split(' ');
            int n1 = words.Length;
            int n = Convert.ToInt32(ds1.Tables[0].Rows.Count);
            for (int j = 0; j < n1; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    String m = Convert.ToString(ds1.Tables[0].Rows[k][0]).ToLower();
                    if (words[j] == m)
                    {
                        words[j] = Convert.ToString(ds1.Tables[0].Rows[k][1]).ToLower();
                    }
                }
            }
            s = string.Join(" ", words);

            if (s.Contains("you") && s.Contains("how") || s.Contains("you") && s.Contains("how") && s.Contains("do"))
            {

                lblbot.Text = "I am Fine.. How Are You ?";
            }
            if (s.Contains("i") && s.Contains("fine") || s.Contains("i") && s.Contains("good"))
            {
                SqlDataAdapter da2 = new SqlDataAdapter("Select top 1 * from addqueries order by NEWID()", con);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                reply = Convert.ToString(ds2.Tables[0].Rows[0][0]);
                lblbot.Text = reply;
            }
            if (s.Contains("account") || s.Contains("accounts"))
            {
                String k1, k2, k3, rep = "s";
                int count;
                SqlDataAdapter da3 = new SqlDataAdapter("Select * from Acc where keywords = 4", con);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3);
                count = Convert.ToInt32(ds3.Tables[0].Rows.Count);
                for (int i = 0; i < count; i++)
                {
                    k1 = Convert.ToString(ds3.Tables[0].Rows[i][1]).ToLower();
                    k2 = Convert.ToString(ds3.Tables[0].Rows[i][2]).ToLower();
                    k3 = Convert.ToString(ds3.Tables[0].Rows[i][3]).ToLower();
                    if (s.Contains(k1) && s.Contains(k2) && s.Contains(k3))
                    {
                        rep = Convert.ToString(ds3.Tables[0].Rows[i][5]); ;
                    }

                }
                if (rep == "s")
                {
                    SqlDataAdapter da4 = new SqlDataAdapter("Select * from Acc where keywords = 2", con);
                    DataSet ds4 = new DataSet();
                    da4.Fill(ds4);
                    count = Convert.ToInt32(ds4.Tables[0].Rows.Count);
                    for (int i = 0; i < count; i++)
                    {
                        k1 = Convert.ToString(ds4.Tables[0].Rows[i][1]);

                        if (s.Contains(k1))
                        {
                            rep = Convert.ToString(ds4.Tables[0].Rows[i][5]); ;
                        }
                    }
                }
                if (rep == "s")
                {
                    rep = "What did you mean by account saving account or salary account??";
                }

                lblbot.Text = rep;
            }
            if (s.Contains("saving") && s.Contains("account"))
            {
                String k1, k2, k3, rep = "s";
                int count;
                SqlDataAdapter da3 = new SqlDataAdapter("Select * from savacc where keywords = 4", con);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3);
                count = Convert.ToInt32(ds3.Tables[0].Rows.Count);
                for (int i = 0; i < count; i++)
                {
                    k1 = Convert.ToString(ds3.Tables[0].Rows[i][1]).ToLower();
                    k2 = Convert.ToString(ds3.Tables[0].Rows[i][2]).ToLower();
                    k3 = Convert.ToString(ds3.Tables[0].Rows[i][3]).ToLower();
                    if (s.Contains(k1) && s.Contains(k2) && s.Contains(k3))
                    {
                        rep = Convert.ToString(ds3.Tables[0].Rows[i][5]); ;
                    }

                }
                if (rep == "s")
                {
                    SqlDataAdapter da4 = new SqlDataAdapter("Select * from savacc where keywords = 2", con);
                    DataSet ds4 = new DataSet();
                    da4.Fill(ds4);
                    count = Convert.ToInt32(ds4.Tables[0].Rows.Count);
                    for (int i = 0; i < count; i++)
                    {
                        k1 = Convert.ToString(ds4.Tables[0].Rows[i][1]);

                        if (s.Contains(k1))
                        {
                            rep = Convert.ToString(ds4.Tables[0].Rows[i][5]); ;
                        }

                    }
                }

                lblbot.Text = rep;
            }
            if (s.Contains("salary") && s.Contains("account"))
            {
                String k1, k2, k3, rep = "s";
                int count;
                SqlDataAdapter da3 = new SqlDataAdapter("Select * from salacc where keywords = 4", con);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3);
                count = Convert.ToInt32(ds3.Tables[0].Rows.Count);
                for (int i = 0; i < count; i++)
                {
                    k1 = Convert.ToString(ds3.Tables[0].Rows[i][1]).ToLower();
                    k2 = Convert.ToString(ds3.Tables[0].Rows[i][2]).ToLower();
                    k3 = Convert.ToString(ds3.Tables[0].Rows[i][3]).ToLower();
                    if (s.Contains(k1) && s.Contains(k2) && s.Contains(k3))
                    {
                        rep = Convert.ToString(ds3.Tables[0].Rows[i][5]); ;
                    }

                }
                if (rep == "s")
                {
                    SqlDataAdapter da4 = new SqlDataAdapter("Select * from salacc where keywords = 2", con);
                    DataSet ds4 = new DataSet();
                    da4.Fill(ds4);
                    count = Convert.ToInt32(ds4.Tables[0].Rows.Count);
                    for (int i = 0; i < count; i++)
                    {
                        k1 = Convert.ToString(ds4.Tables[0].Rows[i][1]);

                        if (s.Contains(k1))
                        {
                            rep = Convert.ToString(ds4.Tables[0].Rows[i][5]); ;
                        }

                    }

                }
                lblbot.Text = rep;
            }
            if (s.Contains("loan"))
            {
                String rep = "s";
                if (s.Contains("personal"))
                {
                    String k1, k2, k3;
                    int count;
                    SqlDataAdapter da3 = new SqlDataAdapter("Select * from ploan where keywords = 4", con);
                    DataSet ds3 = new DataSet();
                    da3.Fill(ds3);
                    count = Convert.ToInt32(ds3.Tables[0].Rows.Count);
                    for (int i = 0; i < count; i++)
                    {
                        k1 = Convert.ToString(ds3.Tables[0].Rows[i][1]).ToLower();
                        k2 = Convert.ToString(ds3.Tables[0].Rows[i][2]).ToLower();
                        k3 = Convert.ToString(ds3.Tables[0].Rows[i][3]).ToLower();
                        if (s.Contains(k1) && s.Contains(k2) && s.Contains(k3))
                        {
                            rep = Convert.ToString(ds3.Tables[0].Rows[i][5]); ;
                        }

                    }
                    if (rep == "s")
                    {
                        SqlDataAdapter da4 = new SqlDataAdapter("Select * from ploan where keywords = 2", con);
                        DataSet ds4 = new DataSet();
                        da4.Fill(ds4);
                        count = Convert.ToInt32(ds4.Tables[0].Rows.Count);
                        for (int i = 0; i < count; i++)
                        {
                            k1 = Convert.ToString(ds4.Tables[0].Rows[i][1]);

                            if (s.Contains(k1))
                            {
                                rep = Convert.ToString(ds4.Tables[0].Rows[i][5]); ;
                            }

                        }

                    }

                    lblbot.Text = rep + "<a href=http://www.icicibank.com/Personal-Banking/loans/personal-loan/> More Info </a>";
                }
                if (s.Contains("home"))
                {
                    String k1, k2, k3;
                    int count;
                    SqlDataAdapter da3 = new SqlDataAdapter("Select * from hloan where keywords = 4", con);
                    DataSet ds3 = new DataSet();
                    da3.Fill(ds3);
                    count = Convert.ToInt32(ds3.Tables[0].Rows.Count);
                    for (int i = 0; i < count; i++)
                    {
                        k1 = Convert.ToString(ds3.Tables[0].Rows[i][1]).ToLower();
                        k2 = Convert.ToString(ds3.Tables[0].Rows[i][2]).ToLower();
                        k3 = Convert.ToString(ds3.Tables[0].Rows[i][3]).ToLower();
                        if (s.Contains(k1) && s.Contains(k2) && s.Contains(k3))
                        {
                            rep = Convert.ToString(ds3.Tables[0].Rows[i][5]); ;
                        }

                    }
                    if (rep == "s")
                    {
                        SqlDataAdapter da4 = new SqlDataAdapter("Select * from hloan where keywords = 2", con);
                        DataSet ds4 = new DataSet();
                        da4.Fill(ds4);
                        count = Convert.ToInt32(ds4.Tables[0].Rows.Count);
                        for (int i = 0; i < count; i++)
                        {
                            k1 = Convert.ToString(ds4.Tables[0].Rows[i][1]);

                            if (s.Contains(k1))
                            {
                                rep = Convert.ToString(ds4.Tables[0].Rows[i][5]); ;
                            }

                        }


                    }
                    lblbot.Text = rep + "<a href=http://www.icicibank.com/Personal-Banking/loans/home-loan/> More Info </a>";
                }

                if (s.Contains("car"))
                {
                    String k1, k2, k3;
                    int count;
                    SqlDataAdapter da3 = new SqlDataAdapter("Select * from cloan where keywords = 4", con);
                    DataSet ds3 = new DataSet();
                    da3.Fill(ds3);
                    count = Convert.ToInt32(ds3.Tables[0].Rows.Count);
                    for (int i = 0; i < count; i++)
                    {
                        k1 = Convert.ToString(ds3.Tables[0].Rows[i][1]).ToLower();
                        k2 = Convert.ToString(ds3.Tables[0].Rows[i][2]).ToLower();
                        k3 = Convert.ToString(ds3.Tables[0].Rows[i][3]).ToLower();
                        if (s.Contains(k1) && s.Contains(k2) && s.Contains(k3))
                        {
                            rep = Convert.ToString(ds3.Tables[0].Rows[i][5]); ;
                        }

                    }
                    if (rep == "s")
                    {
                        SqlDataAdapter da4 = new SqlDataAdapter("Select * from cloan where keywords = 2", con);
                        DataSet ds4 = new DataSet();
                        da4.Fill(ds4);
                        count = Convert.ToInt32(ds4.Tables[0].Rows.Count);
                        for (int i = 0; i < count; i++)
                        {
                            k1 = Convert.ToString(ds4.Tables[0].Rows[i][1]);

                            if (s.Contains(k1))
                            {
                                rep = Convert.ToString(ds4.Tables[0].Rows[i][5]); ;
                            }

                        }

                    }
                    
                }    
                    if (rep == "s")
                    {
                        rep = "What did you mean by loan Personal loan,Home loan or car loan?? <a href=http://www.icicibank.com/Personal-Banking/loans/loans.html>Loans";
                    }

                    lblbot.Text = rep + "<a href= http://www.icicibank.com/Personal-Banking/loans/car-loan/index.html> More Info </a>";
                

            }

//////////////////////////////////////////////////////////////////////////////////////////////////////
           


            if (s.Contains("atm") || s.Contains("debit"))
            {
                String k1, k2, k3, rep = "s";
                int count;
                SqlDataAdapter da3 = new SqlDataAdapter("Select * from ATMdebit where keywords = 4", con);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3);
                count = Convert.ToInt32(ds3.Tables[0].Rows.Count);
                for (int i = 0; i < count; i++)
                {
                    k1 = Convert.ToString(ds3.Tables[0].Rows[i][1]).ToLower();
                    k2 = Convert.ToString(ds3.Tables[0].Rows[i][2]).ToLower();
                    k3 = Convert.ToString(ds3.Tables[0].Rows[i][3]).ToLower();
                    if (s.Contains(k1) && s.Contains(k2) && s.Contains(k3))
                    {
                        rep = Convert.ToString(ds3.Tables[0].Rows[i][5]); ;
                    }

                }
               
                if (rep == "s")
                {
                    SqlDataAdapter da4 = new SqlDataAdapter("Select * from ATMdebit where keywords = 2", con);
                    DataSet ds4 = new DataSet();
                    da4.Fill(ds4);
                    count = Convert.ToInt32(ds4.Tables[0].Rows.Count);
                    for (int i = 0; i < count; i++)
                    {
                        k1 = Convert.ToString(ds4.Tables[0].Rows[i][1]);

                        if (s.Contains(k1))
                        {
                            rep = Convert.ToString(ds4.Tables[0].Rows[i][5]); ;
                        }

                    }

                }
                if (s.Contains("atm") && s.Contains("loan"))
                {
                    rep = " <a href=http://www.icicibank.com/Personal-Banking/insta-banking/atm-banking/vas/index.html> ATM info </a><br/><a href=http://www.icicibank.com/Personal-Banking/loans/loans.html>  Loan info </a> ";

                }
                if (rep == "s")
                {
                    rep = "What information you want about ATM (History,PIN,Limit,Transaction) and debit cards(Validity,CVV No.)???<a href=http://www.icicibank.com/Personal-Banking/insta-banking/atm-banking/vas/index.html> ATM & Debit Card info</a>";
                }
                               
                lblbot.Text = rep;
            }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (s.Contains("cheque"))
            {

                String k1, k2, k3, rep = "s";
                int count;
                SqlDataAdapter da3 = new SqlDataAdapter("Select * from chek where keywords = 4", con);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3);
                count = Convert.ToInt32(ds3.Tables[0].Rows.Count);
                for (int i = 0; i < count; i++)
                {
                    k1 = Convert.ToString(ds3.Tables[0].Rows[i][1]).ToLower();
                    k2 = Convert.ToString(ds3.Tables[0].Rows[i][2]).ToLower();
                    k3 = Convert.ToString(ds3.Tables[0].Rows[i][3]).ToLower();
                    if (s.Contains(k1) && s.Contains(k2) && s.Contains(k3))
                    {
                        rep = Convert.ToString(ds3.Tables[0].Rows[i][5]); ;
                    }

                }
                if (rep == "s")
                {
                    SqlDataAdapter da4 = new SqlDataAdapter("Select * from chek where keywords = 2", con);
                    DataSet ds4 = new DataSet();
                    da4.Fill(ds4);
                    count = Convert.ToInt32(ds4.Tables[0].Rows.Count);
                    for (int i = 0; i < count; i++)
                    {
                        k1 = Convert.ToString(ds4.Tables[0].Rows[i][1]);

                        if (s.Contains(k1))
                        {
                            rep = Convert.ToString(ds4.Tables[0].Rows[i][5]); ;
                        }

                    }

                }
                if (rep == "s")
                {
                    rep = "Do you want to know about clear cheque,cancel cheque,alter cheque or deposit???";
                }
                lblbot.Text = rep;

            }

            if (s.Contains("thank") || s.Contains("thanks"))
            {
                lblbot.Text = "Its my pleasure,please fill the feedback form,link has given below";
            }
            SqlDataAdapter da5 = new SqlDataAdapter("Select * from unansq where flag = 1", con);
            DataSet ds5 = new DataSet();
            da5.Fill(ds5);
            int n2 = Convert.ToInt32(ds5.Tables[0].Rows.Count);
            for (int i = 0; i < n2; i++)
            {
                string que = Convert.ToString(ds5.Tables[0].Rows[i][1]);

                if (s == que)
                {
                    lblbot.Text = Convert.ToString(ds5.Tables[0].Rows[i][2]);
                }

            }


            if (lblbot.Text == st)
            {
                lblbot.Text = "Sorry I am not aware of this,call helpline no.1800-2200-2400 if urgent or you will get your answer by our expert after 24 hrs";
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into unansq values('" + GlobalClass.GlobalVar + "','" + s + "','" + "" + "',0)", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            /*  else
                     {
                         Label1.Text = "";
                     }
             */
            
            Thread.Sleep(2000);
            Session["txt"] = "User:"+s+"<br><br> Smart Bot: "+lblbot.Text;
            Response.Redirect("bot.aspx");
            ImageButton1.ImageUrl = "images/sb.jpg";
        }
        else
        {
            
            lblbot.Text = "Enter text in chat field";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        
        SpVoice voice = new SpVoice();
        voice.Speak(lblbot.Text, SpeechVoiceSpeakFlags.SVSFDefault);
    }
   
  
}
                         
            

           
    
