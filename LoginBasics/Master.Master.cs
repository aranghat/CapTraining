using LoginBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginBasics
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
                Response.Redirect("Login.aspx");
            else
            {
                Customer customer = (Customer)Session["User"];
                lblWelcomeMessage.Text = "Welcome back : " + customer.Name;
            }


        }
    }
}