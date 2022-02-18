using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTax
{
    public enum Gender
    {
        Male,
        Female,
        Others
    }

    public  class Employee
    {
        public int id;
        public string name;
        public Gender gender;
        public float annualincome;

        public float CalculateTax()
        {
            float tax = 0.0F;
            float minTaxAmount = gender == Gender.Male ? 200000 : 250000;

            if (minTaxAmount >= 200000 && annualincome < 500000)
                tax = .10F;
            else if (annualincome >= 500000 && annualincome < 700000)
                tax = .20F;
            else if (annualincome >= 700000)
                tax = .30F;

            return tax;
        }

        public float CalculateTaxAmount()
        {
            float tax   = CalculateTax();
            return annualincome * tax;
        }

        public void DisplayDetails()
        {
            float taxPer    = CalculateTax();
            float taxAmount = CalculateTaxAmount();

            Console.WriteLine($@"Id : {id}
                                 Name : {name}
                                 Gender : {gender}
                                 Annual Income : {annualincome}
                                 Tax Per : {taxPer}
                                 Tax Amount : {taxAmount}");
        }
    }
}
