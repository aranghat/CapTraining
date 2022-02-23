using System;
using System.Collections.Generic;


namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List
            /*
            //Type Safe
            List<int> intArry = new List<int>();
            intArry.Add(10);
            intArry.Add(20);    
            intArry.Add(30);

            List<string> stringArry = new List<string>();
            stringArry.Add("Sree");
            stringArry.Add("Hello");
            stringArry.Add("World");

            stringArry.AddRange(new string[] { "Test", "User", "Some sentence" });

            foreach(string str in stringArry)
                Console.WriteLine(str);*/
            #endregion

            //Dictionary<int,string> studentDetails = new Dictionary<int, string>();
            //studentDetails.Add(10001, "Sree");
            //studentDetails.Add(10002, "Bill");
            //studentDetails.Add(10003, "Steve");

            #region dictionary
            /*
            SortedList<int,string> list = new SortedList<int, string>();
            SortedDictionary<int, string> studentDetails = new SortedDictionary<int, string>();

            studentDetails.Add(10002, "Bill");
            studentDetails.Add(10001, "Sree");
            studentDetails.Add(10003, "Steve");

            var studentName = studentDetails[10001];
            Console.WriteLine(studentName);

            foreach(var student in studentDetails)
                Console.WriteLine(student.Key + "  " + student.Value);

            if (studentDetails.ContainsKey(10001))
                Console.WriteLine("Student with id 10001 exist");


            SortedSet<string> students = new SortedSet<string>();
            students.Add("Sree");
            students.Add("Bill");
            students.Add("KAte");


            foreach (var student in students)
                Console.WriteLine(student);

            */
            #endregion

            //Stack<int> stack = new Stack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine("Rest of the items");
            //foreach(int i in stack)
            //    Console.WriteLine(i);

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Sree");
            //queue.Enqueue("Bill");
            //queue.Enqueue("Kate");
            //queue.Enqueue("Steve");

            //Console.WriteLine(queue.Dequeue());

            //Console.WriteLine("Rest of the items");
            //foreach(var i in queue)
            //    Console.WriteLine(i);
        }
    }
}
