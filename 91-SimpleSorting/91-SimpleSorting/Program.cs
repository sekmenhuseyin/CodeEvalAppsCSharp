using System;
using System.IO;

namespace _91_SimpleSorting
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

                    //string array

                    {
                        string[] numbers = line.Split(' ');
                        //decimal array
                        decimal[] decimals = new decimal[numbers.Length + 1];
                        for (int index = 0; index < numbers.Length; index++)
                        {
                            decimals[index] = Convert.ToDecimal(numbers[index].Replace(".", ","));
                        }
                        //sorting
                        string tmpS = null;
                        decimal tmpD = default(decimal);
                        for (int i = 0; i < numbers.Length - 1; i++)
                        {
                            for (int j = i + 1; j < numbers.Length; j++)
                            {
                                if (decimals[i] > decimals[j])
                                {
                                    tmpD = decimals[i];
                                    decimals[i] = decimals[j];
                                    decimals[j] = tmpD;
                                    tmpS = numbers[i];
                                    numbers[i] = numbers[j];
                                    numbers[j] = tmpS;
                                }
                            }
                        }


                        Console.WriteLine(string.Join(" ", numbers));
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
