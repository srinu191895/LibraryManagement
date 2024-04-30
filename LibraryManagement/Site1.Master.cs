using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true;//userlogin LinkButton
                    LinkButton2.Visible = true;//ign up LinkButton

                    LinkButton3.Visible = false;//log out LinkButton
                    LinkButton7.Visible = false;//hello user LinkButton

                    LinkButton6.Visible = true;//admin login LinkButton
                    LinkButton11.Visible = false;//author management LinkButton
                    LinkButton12.Visible = false;//publisher management LinkButton
                    LinkButton8.Visible = false;//book inventory LinkButton
                    LinkButton9.Visible = false;//book issuing LinkButton
                    LinkButton10.Visible = false;//member management LinkButton

                }
                else if(Session["role"].Equals("user"))
                {
                    LinkButton1.Visible = false;//userlogin LinkButton
                    LinkButton2.Visible = false;//ign up LinkButton

                    LinkButton3.Visible = true;//log out LinkButton
                    LinkButton7.Visible = true;//hello user LinkButton
                    LinkButton7.Text = "Hello"+Session["username"].ToString();


                    LinkButton6.Visible = true;//admin login LinkButton
                    LinkButton11.Visible = false;//author management LinkButton
                    LinkButton12.Visible = false;//publisher management LinkButton
                    LinkButton8.Visible = false;//book inventory LinkButton
                    LinkButton9.Visible = false;//book issuing LinkButton
                    
                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false;//userlogin LinkButton
                    LinkButton2.Visible = false;//ign up LinkButton

                    LinkButton3.Visible = true;//log out LinkButton
                    LinkButton7.Visible = true;//hello user LinkButton
                    LinkButton7.Text = "Hello Admin";


                    LinkButton6.Visible = false;//admin login LinkButton
                    LinkButton11.Visible = true;//author management LinkButton
                    LinkButton12.Visible = true;//publisher management LinkButton
                    LinkButton8.Visible = true;//book inventory LinkButton
                    LinkButton9.Visible = true;//book issuing LinkButton
                }

            }
            catch(Exception ex)
            {

            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthormanagement.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["username"] = "";
            Session["fullname"] = "";
            Session["role"] = "";
            Session["status"] = "";
            LinkButton1.Visible = true;//userlogin LinkButton
            LinkButton2.Visible = true;//ign up LinkButton

            LinkButton3.Visible = false;//log out LinkButton
            LinkButton7.Visible = false;//hello user LinkButton

            LinkButton6.Visible = true;//admin login LinkButton
            LinkButton11.Visible = false;//author management LinkButton
            LinkButton12.Visible = false;//publisher management LinkButton
            LinkButton8.Visible = false;//book inventory LinkButton
            LinkButton9.Visible = false;//book issuing LinkButton
            LinkButton10.Visible = false;//member management LinkButton
        }
    }
}