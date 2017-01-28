using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_SumOfIntegers
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
                    string[] nums = line.Split(',');
                    int enBuyuk = -100000;
                    int tmp = 0;
                    if (nums.Length == 0) enBuyuk = Convert.ToInt32(nums[0]);
                    else
                    {
                        for (int i = 0; i < nums.Length; i++)
                        {
                            for (int j = i; j < nums.Length; j++)
                            {
                                tmp = 0;
                                for (int k = i; k <= j; k++)
                                {
                                    tmp += Convert.ToInt32(nums[k]);
                                }
                                if (tmp > enBuyuk)
                                    enBuyuk = tmp;
                            }
                        }
                    }
                    Console.WriteLine(enBuyuk);
                }
            }
            Console.ReadLine();
        }
    }
}
