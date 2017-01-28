using System;
using System.IO;

namespace _41_ArrayAbsurdity
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

                    if (line != "")
                    {
                        string[] parts = line.Split(';');
                        string[] numbers = parts[1].Split(',');
                        for (int i = 0; i <numbers.Length - 1; i++)
                        {
                            for (int j = i + 1; j <numbers.Length; j++)
                            {
                                if (numbers[i] == numbers[j])
                                {
                                    line = numbers[i]; break; 
                                }
                            }
                        }
                    }

                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();
        }
    }
}
