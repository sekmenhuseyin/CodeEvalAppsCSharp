using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeEvalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //open file
            using (StreamReader reader = new StreamReader(args[0])) {
                //for each line
                while (!reader.EndOfStream) {
                    //read it
                    string line = reader.ReadLine();
                    //if not empty
                    if (null == line) continue;
                    //TODO: actions here

                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
    }
}
