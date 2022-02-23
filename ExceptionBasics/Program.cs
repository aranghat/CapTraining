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
                Console.WriteLine("Enter a number");
                string userInput = Console.ReadLine();

                int number = int.Parse(userInput);


            }
            catch(FormatException forExcep)
            {
                Console.WriteLine($"Looks like you have provided a invalid number : {forExcep.Message}");
            }
            catch (OverflowException excp)
            {
                Console.WriteLine("Please enter a smaller number");
            }
            catch (Exception excp)
            {
                Console.WriteLine($"An Error Occoured : {excp.Message}");
            }
            //Catch Unmanaged Exceptions
            catch
            {
                Console.WriteLine("Exception thrown from unmanaged code");
            }
            finally
            {
                Console.WriteLine("Finally will always execute");
            }

            Console.WriteLine("Rest of the program");
        }
    }
}
