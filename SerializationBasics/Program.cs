using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.Id = 10001;
            //employee.Name = "Sree";
            //employee.Email = "sree@gmail.com";

            //SerializeBinaryEmployee(employee);
            //SerializeXmlEmployee(employee);
            //SerializeJSONEmployee(employee);

            // Employee employee = DeserializeXmlEmployee();
            // Employee employee = DeserializeBinaryEmployee();
             Employee employee = DeserializeJSONEmployee();
            Console.WriteLine(employee);
        }

        static void SerializeXmlEmployee(Employee employee)
        {
            //1. Xml
            //2. Binary
            //3. Json

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            Stream stream = new FileStream(@"D:\CapTraining\SerializeData\Employee.xml"
                                                                        , FileMode.OpenOrCreate
                                                                        , FileAccess.ReadWrite);
            xmlSerializer.Serialize(stream, employee);
        }

        static Employee DeserializeXmlEmployee()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            Stream stream = new FileStream(@"D:\CapTraining\SerializeData\Employee.xml"
                                                                        , FileMode.OpenOrCreate
                                                                        , FileAccess.ReadWrite);
            Employee employee = (Employee)xmlSerializer.Deserialize(stream);

            return employee;
        }

        static void SerializeBinaryEmployee(Employee employee)
        {
            //1. Xml
            //2. Binary
            //3. Json

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\CapTraining\SerializeData\Employee.bin"
                                                                        , FileMode.OpenOrCreate
                                                                        , FileAccess.ReadWrite);
            formatter.Serialize(stream, employee);
        }

        static Employee DeserializeBinaryEmployee()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\CapTraining\SerializeData\Employee.bin"
                                                                        , FileMode.OpenOrCreate
                                                                        , FileAccess.ReadWrite);

            Employee employee = (Employee)formatter.Deserialize(stream);

            return employee;
        }

        static void SerializeJSONEmployee(Employee employee)
        {
            //1. Xml
            //2. Binary
            //3. Json


            var jsonContent = JsonConvert.SerializeObject(employee);
            File.WriteAllText(@"D:\CapTraining\SerializeData\Employee.json", jsonContent);
        }

        static Employee DeserializeJSONEmployee()
        {
            var jsonContent = File.ReadAllText(@"D:\CapTraining\SerializeData\Employee.json");
            Employee employee = JsonConvert.DeserializeObject<Employee>(jsonContent);

            return employee;
        }
    }
}
