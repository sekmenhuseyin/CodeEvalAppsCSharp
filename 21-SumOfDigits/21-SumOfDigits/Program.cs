using System;
using System.IO;

namespace _21_SumOfDigits
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
                    string line = reader.ReadLine(),tmp;
                    //if not empty
                    if (null == line) continue;
                    //copy
                    int sonuc = 0;
                    for (int i = 0; i < line.Length; i++)
                    {
                        sonuc += Convert.ToInt32(line.Substring(i, 1));
                    }
                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
