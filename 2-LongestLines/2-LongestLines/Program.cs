using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_LongestLines
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSatir = 0, satirNo=0;
            string[] lines=new string[40];
            string tmp;
            for (int j = 0; j < 40; j++) lines[j] = "";

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
                    //actions here
                    if (maxSatir == 0) maxSatir = Convert.ToInt32(line);
                    else { lines[satirNo] = line; satirNo++; }
                }
            }
            //order
            for (int i = 0; i < 39; i++)
            {
                for (int j = i; j < 40; j++)
                {
                    if (lines[i].Length<lines[j].Length)
                    {
                        tmp = lines[j]; lines[j] = lines[i]; lines[i] = tmp;
                    }
                    
                }
            }
            //show
            for (int i = 0; i < maxSatir ; i++)
            {
                Console.WriteLine(lines[i]);
           }
            Console.ReadLine();
        }
    }
}
