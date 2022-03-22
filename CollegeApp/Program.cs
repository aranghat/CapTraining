using CollegeDb;
using CollegeDb.Repositories;
using CollegeDb.Services;
using System;

namespace CollegeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StudentRepository studentRepository = new StudentRepository();

            //Student student = new Student();
            //student.Name = "Sreehari";
            //student.Course = "B.TECH";
            //student.RegisterNumber = "12345";
            //student.Age = 35;

            //Student newStudent = studentRepository.Add(student);

            string userName = Console.ReadLine();
            string password = Console.ReadLine();

            AuthenticationService authenticationService = new AuthenticationService();
            Student student = authenticationService.Login(userName, password);


            
        }
    }
}
