using System;
using System.ComponentModel.DataAnnotations;

namespace CollegeDb
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }    
        public int Age { get; set; }
        public string Course { get; set; }

        public string RegisterNumber { get; set; }
        public string Password { get; set; }
    }
}
