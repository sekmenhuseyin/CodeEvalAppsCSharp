using System;
using System.IO;

namespace _22_FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibonecci = new int[101];
            fibonecci[0] = 0;
            fibonecci[1] = 1;
            for (int i = 1; i <= 40; i++)
            {
                fibonecci[i + 1] = fibonecci[i] + fibonecci[i - 1];
            }

            //open file
            using (StreamReader reader = new StreamReader(args[0]))
            {
                //for each line
                while (!reader.EndOfStream)
                {
                    //read it
                    string line = reader.ReadLine();
                    //if not empty
                    if (null == line) continue;

                    Console.WriteLine(fibonecci[Convert.ToInt32(line)]);
                }
            }
            Console.ReadLine();
        }
    }
}
