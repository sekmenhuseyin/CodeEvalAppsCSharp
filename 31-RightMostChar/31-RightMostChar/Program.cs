using System;
using System.IO;

namespace _31_RightMostChar
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
                    //copy

                    string[] words = line.Split(',');
                    int sonuc = -1;
                    for (int i = 0; i <= words[0].Length - 1; i++)
                    {
                        if (words[0].Substring(i, 1) == words[1])
                            sonuc = i;
                    }
                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
