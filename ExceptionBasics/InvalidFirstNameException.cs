using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBasics
{
    //1. The class has to inherit from Exception
    //2. Provide implementation for the 3 Constuctors
    //3. Its suggested to name as class name ending with Exception
    public class InvalidFirstNameException : Exception
    {
        public InvalidFirstNameException() : base() { }

        public InvalidFirstNameException(string message) 
            : base(message) { }  
        
        public InvalidFirstNameException(string message
            ,Exception innerException)
            : base(message, innerException) { }
    }
}
