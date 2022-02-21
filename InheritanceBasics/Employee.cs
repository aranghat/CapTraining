using System;

namespace InheritanceBasics
{
    //Base Class
    public abstract class Employee
    {
        public int EmployeeID   { get; set; }
        public string Name      { get; set; }
        public float BasicPay   { get; set; }

        //1. It does not have a implementation
        //2. Every child class has to provide their own implementation
        public abstract void DisplayDetails();

        public virtual float CalculateSalary()
        {
            float totalSalary = BasicPay - (BasicPay * .20F);
            return totalSalary;
        }

        public void DisplaySalary()
        {
            var totalSalary = CalculateSalary();
            Console.WriteLine(
                $"Before Tax : {BasicPay}" +
                $"Inhand Salary : {totalSalary}");
        }
    }

    //Child Class
    public class JuniorSoftwareEngineer
        : Employee
    {
        public override void DisplayDetails()
        {
            Console.WriteLine($@"NAME : {Name}
                                DESIGNATION : JSE
                                SALARY : {BasicPay}");
        }
    }
    public class SeniorSoftwareEngineer 
        : Employee {

        public override void DisplayDetails()
        {
            Console.WriteLine($@"NAME : {Name}
                                DESIGNATION : SSE
                                SALARY : {BasicPay}");
        }
    }
    public class ProjectManager : Employee
    {
        public float ProjectBonus { get; set; }
        public override float CalculateSalary()
        {
            var baseSalary  = base.CalculateSalary();
            var totalSalary = baseSalary + ProjectBonus;

            return totalSalary;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($@"NAME : {Name}
                                DESIGNATION : PROJECT MANAGER
                                SALARY : {BasicPay}
                                PROJECT BONUS : {ProjectBonus}");
        }

        //Method Hiding
        public new void DisplaySalary()
        {
            var totalSalary = CalculateSalary();
            Console.WriteLine(
                $"Before Tax : {BasicPay}" +
                $"Inhand Salary : {totalSalary}" +
                $"Project Bonus : {ProjectBonus}");
        }
    }

    public sealed class SeniorProjectManager : ProjectManager
    {

    }

}


