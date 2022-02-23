using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExceptionBasics
{
    public class Student
    {
        public int Id { get; set; }

        string name;
        public string Name { 
        
            get { return name; }
            set {
                if (Regex.IsMatch(value, "^[a-zA-Z ]+$"))
                    name = value;
                else
                    throw new InvalidFirstNameException("Invalid Name");
            }

        }
    }
}
