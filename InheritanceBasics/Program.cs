using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You cannot create the instance of a abstract class
            //Employee employee = new Employee();

            JuniorSoftwareEngineer juniorSoftware 
                                    = new JuniorSoftwareEngineer();
            juniorSoftware.Name                   = "Sreehari";
            juniorSoftware.EmployeeID             = 10001;
            juniorSoftware.BasicPay               = 10000;

            Console.WriteLine(juniorSoftware.CalculateSalary());
            juniorSoftware.DisplayDetails();
            juniorSoftware.DisplaySalary();

            ProjectManager projectManager   
                                    = new ProjectManager();
            projectManager.BasicPay         = 50000;
            projectManager.EmployeeID       = 10002;
            projectManager.Name             = "Steve";
            projectManager.ProjectBonus     = 25000;

            Console.WriteLine(projectManager.CalculateSalary());
            projectManager.DisplayDetails();
            projectManager.DisplaySalary();
        }
    }
}
