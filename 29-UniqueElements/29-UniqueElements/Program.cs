using System;
using System.IO;

namespace _29_UniqueElements
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


                    string[] numbers = line.Split(',');
                    string sonuc = "";
                    string onceki = "";
                    for (int i = 0; i <numbers.Length; i++)
                    {
                        if (onceki != numbers[i])
                        {
                            if (sonuc != "")
                                sonuc += ",";
                            sonuc += numbers[i];
                            onceki = numbers[i];
                        }

                    }

                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
