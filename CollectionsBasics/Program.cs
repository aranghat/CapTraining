using System;
using System.Collections;

namespace CollectionsBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(10);
            //arrayList.Add(20);
            //arrayList.Add(40);
            //arrayList.AddRange(new int[] { 70, 80, 90, 100 });
            //arrayList.Add("Sree");
            //arrayList.Add(15.7F);
            

            //Console.WriteLine(arrayList.Count);

            //arrayList.Add(50);
            //Console.WriteLine(arrayList.Count);

            //arrayList.RemoveAt(0);
            //arrayList.RemoveAt(1);

            //Console.WriteLine(arrayList.Count);

            //arrayList.Insert(4, 1000);

            //foreach(var item in arrayList)
            //    Console.WriteLine(item);

            //for(int i = 0;i < arrayList.Count;i++)
            //    Console.WriteLine(arrayList[i]);

            */

            Hashtable citiesAndCapital =new Hashtable();
            citiesAndCapital.Add("Karnataka"  , "Bangalore");
            citiesAndCapital.Add("Maharastra" , "Mumbai");
            citiesAndCapital.Add("West Bengal", "Kolkata");


            var capitalByKey = citiesAndCapital["Karnataka"];
            Console.WriteLine(capitalByKey);

            

            if (citiesAndCapital.ContainsKey("Karnataka"))
                Console.WriteLine("Karnataka is there in the list");
        }
    }
}
