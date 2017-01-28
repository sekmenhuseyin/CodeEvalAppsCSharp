using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_MthToLastElement
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
                    int sayi = Convert.ToInt32(words[words.Length-1]);
                    sayi=words.Length-sayi-1;
                    if (sayi < 0) Console.WriteLine();
                    else Console.WriteLine(words[sayi]);
                }
            }
            Console.ReadLine();
        }
    }
}
