using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace StateManagement
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            File.AppendAllText(@"D:\CapTraining\Log\myapplog.txt"
                            , $"Application started on {DateTime.Now}\n");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            File.AppendAllText(@"D:\CapTraining\Log\myapplog.txt"
                            , $"Application Stopped on {DateTime.Now}\n");
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            File.AppendAllText(@"D:\CapTraining\Log\myapplog.txt"
                            , $"Session started on {DateTime.Now}\n");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            File.AppendAllText(@"D:\CapTraining\Log\myapplog.txt"
                            , $"Session Stopped on {DateTime.Now}\n");
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = Server.GetLastError();
            File.AppendAllText(@"D:\CapTraining\Log\myapplog.txt"
                            , $"ERROR OCCURED : {exception.ToString()} \n");

            Response.Redirect("Error.aspx");
        }
     }
}