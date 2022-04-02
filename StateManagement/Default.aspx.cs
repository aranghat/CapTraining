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
                pageVisitCount = (int)Session["PageCount"];

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
        }
    }
}