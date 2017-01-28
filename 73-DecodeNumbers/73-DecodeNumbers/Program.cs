using System;
using System.IO;

namespace _73_DecodeNumbers
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

                    int sayi = 0;
                    int num = Convert.ToInt32(line);
                    if (num < 10)
                        sayi = 1;
                    else if (num < 27)
                        sayi = 2;
                    else if (num < 100)
                        sayi = 1;
                    else if (num < 127)
                        sayi = 3;
                    else if (num < 200)
                        sayi = 2;
                    else if (num < 227)
                        sayi = 3;
                    else
                        sayi = 4;

                    Console.WriteLine(sayi.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
