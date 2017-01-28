using System;
using System.IO;

namespace _82_ArmstrongNumbers
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

                    int sonuc = 0;
                    int tmp = 0;
                    string str = null;
                    for (int i = 0; i <= line.Length - 1; i++)
                    {
                        str = line.Substring(i,1);
                        tmp = Convert.ToInt32(str);
                        tmp = Convert.ToInt32(Math.Pow(tmp, (line.Length)));
                        sonuc += tmp;
                    }

                    Console.WriteLine(sonuc == Convert.ToInt32(line));
                }
            }
            Console.ReadLine();
        }
    }
}
