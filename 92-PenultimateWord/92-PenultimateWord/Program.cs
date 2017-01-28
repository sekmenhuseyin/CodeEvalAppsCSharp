using System;
using System.IO;

namespace _92_PenultimateWord
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

                    string[] words = line.Split(' ');

                    Console.WriteLine(words[words.Length - 2]);
                }
            }
            Console.ReadLine();
        }
    }
}
