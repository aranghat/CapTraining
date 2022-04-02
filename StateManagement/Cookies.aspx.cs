using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRememberThisNote_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Reminder");
            cookie.Value = txtRemindMe.Text;
            cookie.Expires = DateTime.Now.AddDays(7);

            Response.Cookies.Add(cookie);
        }
    }
}