using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ReverseWords
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
                    //split
                    string[] words = line.Split(' ');
                    string sonuc = "";
                    for (int i = words.Length-1; i >=0; i--)
                    {
                        sonuc += words[i] + " ";
                    }

                    Console.WriteLine(sonuc.Trim());
                }
            }
            Console.ReadLine();
        }
    }
}
