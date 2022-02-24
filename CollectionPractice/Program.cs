using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Student> students = new List<Student>();
            SortedSet<Student> students = new SortedSet<Student>();

            Student s1 = new Student { StudentId = 1001, Name = "Sree" };
            Student s2 = new Student { StudentId = 1002, Name = "Bill" };
            Student s3 = new Student { StudentId = 1003, Name = "Kate" };

            students.Add(s2);
            students.Add(s1);
            students.Add(s3);

            foreach (Student s in students)
                Console.WriteLine(s.ToString());

            //Student s4 = new Student { StudentId = 1001, Name = "Sree" };

            //if (students.Contains(s4))
            //    Console.WriteLine("Student is already there in the list");
            //else
            //    Console.WriteLine("Student is not there in the list");
        }
    }
}
