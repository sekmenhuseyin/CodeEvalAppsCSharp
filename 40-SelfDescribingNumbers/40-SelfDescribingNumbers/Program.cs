using System;
using System.IO;

namespace _40_SelfDescribingNumbers
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
                    int digit = 0;
                    int digit2 = 0;
                    byte sonuc = 1;
                    //loop each number
                    for (int i = 0; i <= line.Length - 1; i++)
                    {
                        digit = Convert.ToInt32(line.Substring(i, 1));
                        sayi = 0;

                        for (int j = 0; j <= line.Length - 1; j++)
                        {
                            digit2 = Convert.ToInt32(line.Substring(j, 1));

                            if (i == digit2)
                                sayi += 1;

                        }
                        if (sayi != digit)
                            sonuc = 0;

                    }
                    Console.WriteLine(sonuc.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
