using System;
using System.IO;

namespace _24_SumOfIntegersFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0;
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
                    //TODO: actions here
                    sonuc += Convert.ToInt32(line);
                }
            }
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
