using System;
using System.IO;

namespace _32_TrailingString
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

                    string sonuc = "";
                    if (!string.IsNullOrEmpty(line))
                    {
                        string[] words = line.Split(',');
                        int tmp = words[0].Length - words[1].Length;
                        if (tmp < 0) tmp = 0;
                        if (words[0].Substring(tmp) == words[1])
                            sonuc = "1";
                        else
                            sonuc = "0";
                    }
                    Console.WriteLine(sonuc);

                }
            }
            Console.ReadLine();
        }
    }
}
