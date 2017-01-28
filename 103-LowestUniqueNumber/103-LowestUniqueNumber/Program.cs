using System;
using System.IO;

namespace _103_LowestUniqueNumber
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

                    string[] numbers = line.Split(' ');
                    bool sonuc = false;
                    int count = 0;
                    for (int i = 1; i <= 9; i++)
                    {
                        count = 0;
                        for (int j = 0; j <numbers.Length; j++)
                        {
                            if (numbers[j] == i.ToString())
                                count += 1;
                        }
                        if (count == 1)
                        {
                            for (int j = 0; j <numbers.Length; j++)
                            {
                                if (numbers[j] == i.ToString())
                                    count = j + 1;
                            }
                            sonuc = true;
                            break; // TODO: might not be correct. Was : Exit For
                        }
                    }
                    if (sonuc == false)
                        count = 0;
                    Console.WriteLine(count);

                }
            }
            Console.ReadLine();
        }
    }
}
