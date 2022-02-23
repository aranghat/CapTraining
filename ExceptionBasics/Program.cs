using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                GetStudentInfo();
            }
            #region excp
            /*
            catch(InvalidFirstNameException excp)
            {
                Console.WriteLine(excp.StackTrace);
                Console.WriteLine($"Name must be alphabets " +
                    $"{excp.Message}");
            }
            
            catch(FormatException forExcep)
            {

                Console.WriteLine(forExcep.Message);
                Console.WriteLine(forExcep.StackTrace);
                Console.WriteLine(forExcep.Source);
                Console.WriteLine(forExcep.HelpLink);
                //Console.WriteLine($"Looks like you have provided a invalid number : {forExcep.Message}");
            }
            catch (OverflowException excp)
            {
                Console.WriteLine("Please enter a smaller number");
            }*/
            #endregion
            catch (Exception excp)
            {
                Console.WriteLine($"An Error Occoured : {excp.Message}");
                Console.WriteLine(excp.InnerException);
            }
            //Catch Unmanaged Exceptions
            #region other excp

            catch
            {
                Console.WriteLine("Exception thrown from unmanaged code");
            }
            finally
            {
                Console.WriteLine("Finally will always execute");
            }

            Console.WriteLine("Rest of the program");
            #endregion
        }

        static void GetStudentInfo()
        {
            try
            {
                Student student = new Student();
                //if(id > 0 && RegEx.)
                student.Name = "12344";
            }
            catch(InvalidFirstNameException firstNameException)
            {
                //throw firstNameException; //He will rewrite the stack trace
                //throw; //Preserves the stack trace
                Exception exception = new Exception("Error Occured While Creating the student",firstNameException);
                throw exception;
            }
        }
    }
}
