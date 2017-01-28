using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_FizzBuzz
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
                    String[] nums=line.Split(' ');
                    int num1 = Convert.ToInt32(nums[0]),
                        num2 = Convert.ToInt32(nums[1]),
                        max = Convert.ToInt32(nums[2]);
                    string sonuc="";
                    for (int i = 1; i <= max; i++)
                    {
                        if (sonuc != "") sonuc += " ";
                        if (i % num1 == 0 && i % num2 == 0) sonuc += "FB";
                        else if (i % num1 == 0) sonuc += "F";
                        else if (i % num2 == 0) sonuc += "B";
                        else sonuc += i.ToString();
                    }
                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
