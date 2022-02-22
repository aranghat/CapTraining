using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student [] students = new Student[2];

            for(int i = 0;i< 2;i++)
            {
                Student student   = new Student();
                
                student.StudentId = StudentIdGenerator.Id;
                student.Name      = Console.ReadLine();
                student.TotalMarks = int.Parse(Console.ReadLine());
                students[i] = student;
            }

            Student studentWithMaxMarks = new Student();
            foreach (Student student in students)
            {
                if(student.TotalMarks > studentWithMaxMarks.TotalMarks)
                    studentWithMaxMarks = student;
            }

            Console.WriteLine($"Student with Max Marks : {studentWithMaxMarks.Name}" +
                $" {studentWithMaxMarks.TotalMarks}");
        }

       
    }

    public static class StudentExtentions
    {
        public static void DisplayDetails(this Student student)
        {
            Console.WriteLine(student.Name);
            Console.WriteLine(student.StudentId);
            Console.WriteLine("--------------------------------");
        }
    }
}
