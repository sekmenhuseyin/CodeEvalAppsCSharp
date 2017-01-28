using System;
using System.IO;

namespace _97_FindWriter
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

                    string[] parts = line.Split('|');
                    string[] nums = parts[1].Split(' ');
                    string sonuc = "";
                    int tmp = 0;
                    //loop each key in nums
                    for (int i = 1; i <nums.Length; i++)
                    {
                        tmp = Convert.ToInt32(nums[i].Trim()) - 1;
                        sonuc += parts[0].Substring(tmp,1);
                    }
                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
