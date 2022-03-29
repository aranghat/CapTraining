using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NavigationBasics
{
    public partial class Details : System.Web.UI.Page
    {
        string name = "";
        int age = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request["name"] != null)
                name = Request["name"];

            if (Request["age"] != null)
                age = int.Parse(Request["age"]);

            lblName.Text = name;
            lblAge.Text = age.ToString();

        }
    }
}