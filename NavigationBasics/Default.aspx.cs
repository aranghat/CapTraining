using NavigationBasics.App_Entities;
using System;
using System.Collections.Generic;
using System.IO;
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
            //foreach(var student in repository.GetStudents())
            //{
            //    HyperLink link = new HyperLink();
            //    link.Text = student.Name;
            //    link.NavigateUrl = $"/Details.aspx?name={student.Name}&age={student.Age}";

            //    form1.Controls.Add(link);
            //    form1.Controls.Add(new Label { Text = "<br />" });

            //    var menuItem = new MenuItem(student.Name);
            //    menuItem.NavigateUrl = $"/Details.aspx?name={student.Name}&age={student.Age}";

            //    Menu1.Items[0].ChildItems.Add(menuItem);
            //    //Menu1.Items.AddAt(0,menuItem);
            //}
            TreeNode rootNode = new TreeNode("D");
            
            foreach(var di in new DirectoryInfo(@"D:\").EnumerateDirectories())
            {
                TreeNode node = new TreeNode(di.Name);
                node.NavigateUrl = di.FullName;

                try
                {
                    foreach (var fi in new DirectoryInfo(di.FullName).EnumerateFiles())
                    {
                        TreeNode fileNode = new TreeNode(fi.Name);
                        fileNode.NavigateUrl = fi.FullName;
                        node.ChildNodes.Add(fileNode);
                    }
                }
                catch (Exception) { }

                rootNode.ChildNodes.Add(node);
                
            }

            TreeView1.Nodes.Add(rootNode);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}