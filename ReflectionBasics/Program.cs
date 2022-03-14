using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionBasics
{
    internal class Program
    {
        static string assemblyPath = @"D:\CapTraining\DataTypes\SampleLibrary\bin\Debug\SampleLibrary.dll";
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFile(assemblyPath);
            
            foreach(var type in assembly.GetTypes())
                Console.WriteLine(type.FullName);

             Type emailType = assembly.GetType("SampleLibrary.EmailProvider");
            
            // ShowMethods(emailType);    

            MethodInfo methodInfo = emailType.GetMethod("SentEmail");
            if(methodInfo != null)
            {
                //EmailProvider instance = new EmailProvider();
                var instance = Activator.CreateInstance(emailType);

                //instance.SentEmail("sreehariis@gmail.com","sree@outlook.com","Email Body","Email Subject");
                methodInfo.Invoke(instance,new[] { "sreehariis@gmail.com","sree@outlook.com","Email Body","Email Subject"});
            }
        }

        static void ShowMethods(Type type)
        {
            foreach(MethodInfo info in type.GetMethods())
            { 

                if (info.IsStatic)
                {
                    Console.WriteLine($"Name : {info.Name}");
                    Console.WriteLine($"Return Type : {info.ReturnType}");
                    Console.WriteLine($"Parameters : {info.GetParameters()}");
                }
            }
        }
    }
}
