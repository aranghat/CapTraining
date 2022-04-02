using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class SecondPage : System.Web.UI.Page
    {
        int pageVisitCount = 0;
        string userName = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["PageCount"] != null)
                pageVisitCount = (int)Application["PageCount"];

            pageVisitCount++;

            /*1.InProc
             * a. Fastest amoung all modes
             * b. Session End Event which will fire only in inprocess
             * 
             * c. A larger number of session data can slow down application
             * d. Session values will be cleared in case of proccess restart
             * 
             * 2. State Server
             * a. Saved outside the process in state server service
             * b. Session can survive webserver restart
             * c. Keeps the web server process leaner
             * 
             * d. Slower than In Proc
             * e. ITs still stored in the same machine this will not survive
             *    system restart
             *    
             * 3. Sql Server
             * a. Most reliable session storage
             * b. The only option in case of a web farm
             * 
             * c. Its the slowest of all three
            */
            //Session["PageCount"] = pageVisitCount;
            Application["PageCount"] = pageVisitCount;
            Session["UserId"] = userName;

            lblShowPageVisitCount.Text = pageVisitCount.ToString();
        }
    }
}