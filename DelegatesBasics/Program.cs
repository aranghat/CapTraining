using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesBasics
{
    internal class Program
    {
        //Declare a delegate which will have the same signature as the method it intent to point to
        delegate void EmployeeOperation(Employee employee);

        static void Main(string[] args)
        {
            //Stores Values
            int a = 10;
            int b = 20;

            int c = a + b;

            //Stores Reference
            Employee employee = new Employee();
            employee.Name = "Sree";

            //Stores the pointer to the Method
            EmployeeOperation scheduleOperation   = ScheduleEmployeeBoardingDate;
            EmployeeOperation initOperation       = InitiateEmployeeBoardingProcess;
            EmployeeOperation sentWelcomeKit      = SentWelcomeKit;

            //MultiCaste Delegate
            EmployeeOperation onBoardEmployee  = scheduleOperation
                                                + initOperation
                                                + sentWelcomeKit;


            //Ability to treat a method like a variable
            ProcessEmployeeRecruitment(onBoardEmployee, employee);

            onBoardEmployee = onBoardEmployee - sentWelcomeKit;
            ProcessEmployeeRecruitment(onBoardEmployee,employee);


        }

        static void ProcessEmployeeRecruitment(
             EmployeeOperation operation // Able to pass the Method as a variable to another method
            ,Employee employee)
        {
            operation(employee);
        }
            
        static void ShowMessage(string message)
        {

        }

        static void InitiateEmployeeBoardingProcess(Employee employee)
        {
            Console.WriteLine($"Initiating Boarding Process For {employee.Name}");
        }

        static void ScheduleEmployeeBoardingDate(Employee employee)
        {
            Console.WriteLine($"Employee Boarding Scheduled for {employee.Name} at March 1 2022");
        }

        static void SentWelcomeKit(Employee employee)
        {
            Console.WriteLine($"Sending Welcome kit with all details to {employee.Name}");
        }
    }
}
