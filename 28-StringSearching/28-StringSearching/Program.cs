using System;
using System.IO;

namespace _28_StringSearching
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

                    string[] words = line.Split(',');
                    bool sonuc = words[0].Contains(words[1]) == true;
                    if (sonuc == false & words[1].Contains("*") == true)
                    {
                        if (words[1].Contains("\\*") == true & words[0].Contains("*") == false)
                        {
                        }
                        else
                        {
                            sonuc = true;
                        }

                    }

                    Console.WriteLine(sonuc.ToString().ToLower());
                }
            }
            Console.ReadLine();
        }
    }
}
