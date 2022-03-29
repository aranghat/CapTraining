using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NavigationBasics.App_Entities
{
    public class StudentRepository
    {
        static List<Student> students = new List<Student>();

        public StudentRepository()
        {
            students.Add(new Student { Name = "Sree", Age = 35 });
            students.Add(new Student { Name = "Bill", Age = 42 });
            students.Add(new Student { Name = "Kate", Age = 25 });
            students.Add(new Student { Name = "Emma", Age = 41 });
        }

        public List<Student> GetStudents()
        {
            return students;
        }
    }
}