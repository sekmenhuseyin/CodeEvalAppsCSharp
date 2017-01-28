using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_BitPositions
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
                    //splits
                    string[] parts=line.Split(',');
                    string binary=Convert.ToString(Convert.ToInt32(parts[0]),2);
                    char num1 = binary[binary.Length - Convert.ToInt32(parts[1])],
                        num2 = binary[binary.Length - Convert.ToInt32(parts[2])];
                    //compare
                    if (num1 == num2)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
