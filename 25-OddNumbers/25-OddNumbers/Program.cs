using System;

namespace _25_OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
