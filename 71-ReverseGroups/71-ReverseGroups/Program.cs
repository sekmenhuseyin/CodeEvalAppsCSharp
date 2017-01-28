using System;
using System.IO;

namespace _71_ReverseGroups
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

                    string[] parts = line.Split(';');
                    string[] nums = parts[0].Split(',');
                    int max = Convert.ToInt32(parts[1]);
                    int count = Convert.ToInt32(Math.Floor(Convert.ToDouble(nums.Length / max)));
                    int sayi = 0;
                    line = "";
                    for (int index = 0; index <= nums.Length; index += max)
                    {
                        //check for for count
                        if (count == 0)
                            break; // TODO: might not be correct. Was : Exit For
                        //take part of array
                        string[] list = new string[max];
                        for (int i = 0; i <= (max - 1); i++)
                        {
                            list[i] = nums[index + i];
                            sayi += 1;
                        }
                        //reverse given array
                        Array.Reverse(list);
                        if (!string.IsNullOrEmpty(line))
                            line += ",";
                        line += string.Join(",", list);
                        count -= 1;
                    }
                    //add the remainings
                    for (int i = sayi; i < nums.Length; i++)
                    {
                        line += "," + nums[i];
                    }


                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
    }
}
