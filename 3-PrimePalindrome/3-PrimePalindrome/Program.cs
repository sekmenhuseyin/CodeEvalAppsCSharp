using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PrimePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1000; i > 4; i--)
            {
                if (isPalindrome(i)==true && isPrime(i)==true)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadLine();
        }

        static bool isPalindrome(int sayi) 
        {
            string tmp = sayi.ToString();
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                if (tmp[i]!=tmp[tmp.Length-i-1]) return false;
            }
            return true;
        }

        static bool isPrime(int sayi)
        {
            bool result = true;
            for (int i = 2; i < sayi-1; i++)
            {
                if (sayi % i==0)
                {
                    result = false; break;
                }
                
            }
            return result;
        }
    }
}
