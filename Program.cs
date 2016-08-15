using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<ulong> primes = new SortedSet<ulong>();
            Console.WriteLine("PrimeGenerator v1.0");
            Console.WriteLine("Up to which number do you want to generate your primes: ");
            ulong result = ulong.MaxValue;
            try { 
            result = ulong.Parse(Console.ReadLine());
            } catch
            {
                result = ulong.MaxValue;
            }
            Console.WriteLine("Create primes to " + result + "...");
            Console.ReadKey();

            for(uint number = 0; number < result; number++)
            {
                if (number % 2 == 0 && number != 2)
                {
                    continue;
                }
                if(IsPrime(number))
                {
                    Console.WriteLine(number);
                    primes.Add(number);
                }
            }
            Console.WriteLine("Created " + primes.Count + " prime numbers!");
            Console.ReadKey();
        }

        private static bool IsPrime(ulong number)
        {
            ulong i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            if (i == number)
            {
                return true;
            }
            return false;
        }
    }
}
