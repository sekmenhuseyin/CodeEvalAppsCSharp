using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_RemoveCharacters
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
                    string[] words = line.Split(',');
                    words[1] = words[1].Trim();
                    for (int i = 0; i < words[1].Length; i++)
                    {
                        words[0] = words[0].Replace(words[1].Substring(i,1), "");
                    }

                    Console.WriteLine(words[0]);
                }
            }
            Console.ReadLine();
        }
    }
}
