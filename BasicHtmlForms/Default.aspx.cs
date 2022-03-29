using BasicHtmlForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicHtmlForms
{
    public partial class Default : System.Web.UI.Page
    {
        static List<Student> students = new List<Student>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSaveStudentDetails_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            //student.Age = int.Parse(txtAge.Text);

            if (chkEnglish.Checked)
                student.Languages = "English";
            if (chkHindi.Checked)
                student.Languages += ", Hindi";

            if (rdoManagement.Checked)
                student.SeatType = "Management";
            else
                student.SeatType = "Merit";

            student.Name = txtFirstName.Text;

             
           
            foreach(ListItem listItem in lbChoiceOfLocation.Items)
            {
                if (listItem.Selected)
                    student.PreferedCity += listItem.Value;
            }


            students.Add(student);

            containerHtmlForm.Visible = false;
            containerMessageBox.Visible = true;
        }

        protected void customValidator_ServerValidate(object source
            , ServerValidateEventArgs args)
        {
            string[] indoorSports = 
                { "Chess"
                , "Carroms"
                , "Table Tennis" };

            if (indoorSports.Contains(args.Value))
                args.IsValid = false;
            else
                args.IsValid = true;
        }
    }
}