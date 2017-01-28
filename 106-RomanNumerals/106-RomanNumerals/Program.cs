using System;
using System.IO;

namespace _106_RomanNumerals
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

                    int number = Convert.ToInt32(line);
                    number = hesapla(number, 1000, "M");
                    number = hesapla(number, 900, "CM");
                    number = hesapla(number, 500, "D");
                    number = hesapla(number, 400, "CD");
                    number = hesapla(number, 100, "C");
                    number = hesapla(number, 90, "XC");
                    number = hesapla(number, 50, "L");
                    number = hesapla(number, 40, "XL");
                    number = hesapla(number, 10, "X");
                    number = hesapla(number, 9, "IX");
                    number = hesapla(number, 5, "V");
                    number = hesapla(number, 4, "IV");
                    for (int i = 0; i <= number - 1; i++)
                    {
                        Console.Write("I");

                    }
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }

        static int hesapla(int number, int value, string letter)
        {
            while (number >= value)
            {
                Console.Write(letter);
                number -= value;
            }
            return number;
        }
    }
}
