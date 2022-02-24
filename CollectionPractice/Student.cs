using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    public class Student : IEquatable<Student>, IComparable<Student>    
    {
        public int StudentId { get; set; }
        public string Name   { get; set; }

        public int CompareTo(Student other)
        {
            //1. If the current student is greater
            //   than the other student return a positve value 1

            //2. If the current student is less
            //   than the other student return a negative value -1

            //3. If the current student is equal to 
            //   than the other student return 0

            if(this.StudentId > other.StudentId)
                return 1;
            else if(this.StudentId < other.StudentId)
                return -1;
            else
                return 0;
        }

        public bool Equals(Student other)
        {
           return this.StudentId == other.StudentId;
        }

        public override string ToString()
        {
            return $@"Id : {StudentId}, Name {Name}";
        }
    }
}
