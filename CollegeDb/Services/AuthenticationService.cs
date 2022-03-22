using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDb.Services
{
    public class AuthenticationService
    {
        StudentDataContext context;

        public AuthenticationService()
        {
            context = new StudentDataContext(); 
        }

        public Student Login(string registernumber,string password)
        {
            Student student = context.Students.FirstOrDefault(d => d.RegisterNumber == registernumber 
                                && d.Password == password);

            if (student == null)
                throw new Exception("Login Failed");

            return student;
        }

    }
}
