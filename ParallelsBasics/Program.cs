using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelsBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 2000000);

            Stopwatch stopwatch1 = Stopwatch.StartNew();
            var primeNumbers = GetPrimeNumbers(numbers.ToList());
            stopwatch1.Stop();

            Stopwatch stopwatch2 = Stopwatch.StartNew();
            var primeNumbers2 = GetPrimeNumbersFromParallel(numbers.ToList());
            stopwatch2.Stop();

            Console.WriteLine($"Total Prime Numbers using Traditional call tool " +
                $"{stopwatch1.ElapsedMilliseconds}, Total Prime numbers found {primeNumbers.Count}");

            Console.WriteLine($"Total Prime Numbers using Prallel call tool " +
               $"{stopwatch2.ElapsedMilliseconds}, Total Prime numbers found {primeNumbers2.Count}");

        }

        public static List<int> GetPrimeNumbersFromParallel(List<int> numbers)
        {
            var primeNumbers = new ConcurrentBag<int>();

            Parallel.ForEach(numbers, number =>
            {
                bool isPrime = IsPrime(number);
                if(isPrime)
                    primeNumbers.Add(number);

            });

            return primeNumbers.ToList();
        }

        public static List<int> GetPrimeNumbers(List<int> numbers)
        {
            List<int> primeNumbers = new List<int>();

            foreach(int number in numbers)
            {
                bool isPrime = IsPrime(number);
                if(isPrime)
                {
                    primeNumbers.Add(number);
                }
            }

            return primeNumbers;
        }

        public static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
