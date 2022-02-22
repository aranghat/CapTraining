using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentManager
{
    public class Student
    {
        public int StudentId { get; set; }

        string name;
        public string Name { 
            get 
            { return name; }
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Z ]+$"))
                    name = value;
                else
                    throw new Exception("Invalid Student Name");
            }
        }

        public int TotalMarks { get; set; }
    }

    public static class StudentIdGenerator
    {
        static int id = 1001;
        public static int Id { get { return id++; } }
    }
}
