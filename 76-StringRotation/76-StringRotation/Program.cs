using System;
using System.IO;

namespace _76_StringRotation
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
                    string first = words[0];
                    string second = words[1];
                    bool sonuc = false;
                    for (int i = 0; i <= second.Length - 1; i++)
                    {
                        string tmp = second.Substring(i) + second.Substring(0,i);
                        if (first == tmp)
                        {
                            sonuc = true; break; // TODO: might not be correct. Was : Exit For
                        }
                    }


                    Console.WriteLine(sonuc);

                }
            }
            Console.ReadLine();
        }
    }
}
