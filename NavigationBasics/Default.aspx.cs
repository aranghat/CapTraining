using NavigationBasics.App_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NavigationBasics
{
    public partial class Default : System.Web.UI.Page
    {
        StudentRepository repository = new StudentRepository();

        protected void Page_Init(object sender,EventArgs e)
        {
            foreach(var student in repository.GetStudents())
            {
                HyperLink link = new HyperLink();
                link.Text = student.Name;
                link.NavigateUrl = $"/Details.aspx?name={student.Name}&age={student.Age}";
                 
                form1.Controls.Add(link);
                form1.Controls.Add(new Label { Text = "<br />" });
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}