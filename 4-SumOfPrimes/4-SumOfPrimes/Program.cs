using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_SumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int primes = 0,total=0,i=2;
            while (primes<1000)
            {
                if (isPrime(i) == true)
                {
                    total += i;
                    primes++;
                }
                i++;

            }
            Console.WriteLine(total);
            Console.ReadLine();
        }

        static bool isPrime(int sayi)
        {
            bool result = true;
            for (int i = 2; i < sayi - 1; i++)
            {
                if (sayi % i == 0)
                {
                    result = false; break;
                }

            }
            return result;
        }
    }
}
