using System;
using System.IO;

namespace _62_NmodM
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

                    string[] numbers = line.Split(',');
                    decimal num1 = Convert.ToInt32(numbers[0]);
                    decimal num2 = Convert.ToInt32(numbers[1]);
                    decimal sonuc = 0;
                    if (num1 < num2)
                    {
                        sonuc = num1;
                    }
                    else
                    {
                        int tmp = Convert.ToInt32(Math.Floor(num1 / num2));
                        sonuc = num1 - (tmp * num2);
                    }

                    Console.WriteLine(sonuc.ToString());

                }
            }
            Console.ReadLine();
        }
    }
}
