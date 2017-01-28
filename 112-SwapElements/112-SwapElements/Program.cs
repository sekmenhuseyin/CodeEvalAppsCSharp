using System;
using System.IO;

namespace _112_SwapElements
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

                    string[] parts = line.Split(':');
                    string[] numbers = parts[0].Trim().Split(' ');
                    string[] swaps = parts[1].Trim().Split(',');
                    //tüm değiştirme istekleri boyunca dön
                    for (int i = 0; i <swaps.Length; i++)
                    {
                        string[] vars = swaps[i].Trim().Split('-');
                        ChangeOrder(numbers, Convert.ToInt32(vars[0]), Convert.ToInt32(vars[1]));
                    }
                    //finish
                    string sonuc = "";
                    for (int i = 0; i <numbers.Length; i++)
                    {
                        sonuc += numbers[i];
                        if (i < numbers.Length)
                            sonuc += " ";
                    }
                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }

        static void ChangeOrder(string[] dizi, int var1, int var2)
        {
            string tmp = dizi[var1];
            dizi[var1] = dizi[var2];
            dizi[var2] = tmp;
        }
    }
}
