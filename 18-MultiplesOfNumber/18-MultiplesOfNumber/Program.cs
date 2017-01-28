using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_MultiplesOfNumber
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
                    string[] nums = line.Split(',');
                    int num1 = Convert.ToInt32(nums[0]),
                        num2 = Convert.ToInt32(nums[1]),
                        carpan=1;
                    bool sonuc = false;
                    while (!sonuc)
                    {
                        if (num2*carpan>=num1)
                        {
                            sonuc = true; num2 *= carpan;
                        }
                        carpan++;
                    }


                    Console.WriteLine(num2);
                }
            }
            Console.ReadLine();
        }
    }
}
