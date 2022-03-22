using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeDb.Repositories
{
    public class StudentRepository
    {
        StudentDataContext context;

        public StudentRepository()
        {
            context = new StudentDataContext();
        }

        public Student Add(Student newStudent)
        {
            if (!context.Students.Any(d => d.RegisterNumber == newStudent.RegisterNumber))
            {
                context.Students.Add(newStudent);
                context.SaveChanges();
            }
            else
                throw new Exception($"Student with the same register number {newStudent.RegisterNumber} already exist");

            return newStudent;
        }

        public Student Update(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();

            return student;
        }

        public void Delete(int studentId)
        {
            Student student = context.Students.FirstOrDefault(d => d.Id == studentId);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
            else
                throw new Exception($"Stuxdent with the id: {studentId} does not exist");

        }

        public Student FindStudentById(int studentId)
        {
            Student student = context.Students.FirstOrDefault(d => d.Id == studentId);
            if (student == null)
                throw new Exception("Invalid student id");

            return student;
        }
    }
}
