using LoginBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginBasics
{
    public partial class Login : System.Web.UI.Page
    {
        CustomerRepository customerRepository = new CustomerRepository();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Customer custoemr = customerRepository.FindByUserNamePassword(txtUserName.Text
                                                                , txtPassword.Text);

            if (custoemr != null)
            {
                Session["User"] = custoemr;
                Response.Redirect("Default.aspx");
            }
            else
                lblMessage.Text = "Login Failed";

        }
    }
}