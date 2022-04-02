using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    //1. ViewState
    public partial class Default : System.Web.UI.Page
    {
        int pageVisitCount = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (ViewState["PageCount"] != null)
            //    pageVisitCount = int.Parse(ViewState["PageCount"].ToString());

            if (Application["PageCount"] != null)
                pageVisitCount = (int)Application["PageCount"];

            pageVisitCount++;

            //if (IsPostBack)
            //{
            //    ViewState["PageCount"] = pageVisitCount.ToString();
            //}
            //else
            //    ViewState.Add("PageCount", "1");

            Application["PageCount"] = pageVisitCount;

            lblShowPageVisitCount.Text = pageVisitCount.ToString();
            //lblServerTime.Text = DateTime.Now.ToString("hh:mm:ss");

             var cookie = 
                Request.Cookies["Reminder"];

            if(cookie != null)
            {
                lblServerTime.Text 
                    = "Hey last time you asked me remind : " 
                    + cookie.Value;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            throw new Exception("Invalid details");
        }
    }
}