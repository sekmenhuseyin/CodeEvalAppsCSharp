using System;
using System.IO;

namespace _215_DoubleTrouble
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

                    int uzunluk = line.Length / 2;
                    int olasi = 1;
                    string part1 = line.Substring(0, line.Length / 2);
                    string part2 = line.Substring(line.Length / 2);
                    for (int i = 0; i <= part1.Length - 1; i++)
                    {
                        if (part1.Substring(i, 1) == "*" & part2.Substring(i, 1) == "*")
                        {
                            olasi *= 2;
                        }
                        else if (part1.Substring(i, 1) == "*" | part2.Substring(i, 1) == "*")
                        {
                        }
                        else if (part1.Substring(i, 1) != part2.Substring(i, 1))
                        {
                            olasi = 0;
                            break;
                        }
                    }
                    Console.WriteLine(olasi);
                }
            }
            Console.ReadLine();
        }
    }
}
