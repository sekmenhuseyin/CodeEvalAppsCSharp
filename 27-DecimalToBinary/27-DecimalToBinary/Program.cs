using System;
using System.IO;


namespace _27_DecimalToBinary
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
                    Console.WriteLine(Convert.ToString(Convert.ToInt32(line), 2));
                }
            }
            Console.ReadLine();
        }
    }
}
