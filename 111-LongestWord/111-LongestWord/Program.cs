using System;
using System.IO;

namespace _111_LongestWord
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
                    for (int i = 0; i <words.Length - 1; i++)
                    {
                        for (int j = i + 1; j <words.Length; j++)
                        {
                            if (words[i].Length < words[j].Length)
                            {
                                string tmp = words[j];
                                words[i] = words[j];
                                words[j] = tmp;
                            }
                        }
                    }
                    Console.WriteLine(words[0]);
                }
            }
            Console.ReadLine();
        }
    }
}
