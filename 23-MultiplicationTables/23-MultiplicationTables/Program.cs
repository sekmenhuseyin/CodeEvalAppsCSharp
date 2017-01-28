using System;

namespace _23_MultiplicationTables
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp;
            for (int i = 1; i <= 12; i++)
            {
                string line = "";
                for (int j = 1; j <= 12; j++)
                {
                    tmp="   " + (i * j);
                    line += tmp.Substring(tmp.Length - 4);
                }
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}
