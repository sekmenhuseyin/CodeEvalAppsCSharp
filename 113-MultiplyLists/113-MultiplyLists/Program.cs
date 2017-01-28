using System;
using System.IO;

namespace _113_MultiplyLists
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
                    parts[0] = parts[0].Trim();
                    parts[1] = parts[1].Trim();
                    string[] numbers1 = parts[0].Split(' ');
                    string[] numbers2 = parts[1].Split(' ');
                    string sonuc = "";
                    int num1 = 0;
                    int num2 = 0;
                    for (int index = 0; index <numbers1.Length; index++)
                    {
                        num1 = Convert.ToInt32(numbers1[index]);
                        num2 = Convert.ToInt32(numbers2[index]);
                        sonuc += (num1 * num2).ToString() + " ";
                    }
                    Console.WriteLine(sonuc.Trim());
                }
            }
            Console.ReadLine();
        }
    }
}
