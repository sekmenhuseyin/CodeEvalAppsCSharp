using System;
using System.IO;

namespace _12_FirstNonRepeatedCharacter
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
                    string line = reader.ReadLine(), tmp = "", sonuc = "";
                    //if not empty
                    if (null == line) continue;
                    for (int i = 0; i < line.Length; i++)
                    {
                        tmp = line.Replace(line.Substring(i, 1), "");
                        if (tmp.Length == line.Length - 1)
                        {
                            sonuc = line.Substring(i, 1);
                            break;
                        }
                    }

                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
