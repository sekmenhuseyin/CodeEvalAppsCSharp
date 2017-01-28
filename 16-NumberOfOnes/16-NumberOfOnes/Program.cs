using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_NumberOfOnes
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
                    line = Convert.ToString(Convert.ToInt32(line), 2);
                    int sayac=0;
                    //looop
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line.Substring(i, 1) == "1") sayac++;
                    }

                    Console.WriteLine(sayac);
                }
            }
            Console.ReadLine();
        }
    }
}
