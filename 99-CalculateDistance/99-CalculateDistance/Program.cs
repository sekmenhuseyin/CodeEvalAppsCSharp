using System;
using System.IO;

namespace _99_CalculateDistance
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

                    line = line.Replace(") (", ",");
                    line = line.Replace(" ", "");
                    line = line.Replace("(", "");
                    line = line.Replace(")", "");
                    string[] nums = line.Split(',');
                    int x = Convert.ToInt32(nums[0]) - Convert.ToInt32(nums[2]);
                    int y = Convert.ToInt32(nums[1]) - Convert.ToInt32(nums[3]);

                    Console.WriteLine(Math.Sqrt((x * x) + (y * y)));
                }
            }
            Console.ReadLine();
        }
    }
}
