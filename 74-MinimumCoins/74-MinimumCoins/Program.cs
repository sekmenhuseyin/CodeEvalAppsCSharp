using System;
using System.IO;

namespace _74_MinimumCoins
{
    class Program
    {
        static void Main(string[] args)
        {
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
                    //copied

                    int number = Convert.ToInt32(line);
                    int para = Convert.ToInt32(Math.Floor(Convert.ToDouble(number / 5)));
                    int kalan = number % 5;
                    if (kalan > 0)
                        para += Convert.ToInt32(Math.Floor(Convert.ToDouble(kalan / 3))) + (kalan % 3);
                    Console.WriteLine(para);

                }
            }
            Console.ReadLine();
        }
    }
}
