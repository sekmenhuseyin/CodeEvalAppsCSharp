using System;
using System.IO;

namespace _63_CountingPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primeNumbers = new int[1229];
            int k = 0;
            for (int i = 2; i <= 10000; i++)
            {
                bool itsPrime = true;
                for (int j = 2; j <= i - 1; j++)
                {
                    if (i % j == 0)
                    {
                        itsPrime = false; break; // TODO: might not be correct. Was : Exit For
                    }
                }
                if (itsPrime == true) { primeNumbers[k] = i; k += 1; }
            }
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

                    string[] numbs = line.Split(',');
                    int numb1 = Convert.ToInt32(numbs[0]);
                    int numb2 = Convert.ToInt32(numbs[1]);
                    int sayi = 0;
                    for (int i = 0; i <primeNumbers.Length; i++)
                    {
                        if (primeNumbers[i] > numb2)
                            break; // TODO: might not be correct. Was : Exit For
                        if (primeNumbers[i] >= numb1)
                            sayi += 1;
                    }


                    Console.WriteLine(sayi);
                }
            }
            Console.ReadLine();
        }
    }
}
