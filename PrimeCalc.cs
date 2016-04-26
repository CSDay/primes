using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Start = DateTime.Now;
            for (int i = 0; i < int.MaxValue - 1; ++i)
            {
                bool prime = isPrime(i);

                if(prime)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(i);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    Console.WriteLine(i);
                }

            }
            DateTime End = DateTime.Now;
            TimeSpan total = End - Start;
            Console.WriteLine(total);
            Console.ReadLine();
        }

        static bool isPrime(int candidate)
        {
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }
    }
}
