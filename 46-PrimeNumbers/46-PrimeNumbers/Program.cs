using System;
using System.IO;

namespace _46_PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primeNumbers=new int[1229];
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
                    string line = reader.ReadLine(),sonuc="";
                    //if not empty
                    if (null == line) continue;
                    //copied
                    int num = Convert.ToInt32(line);


                    for (int i = 0; i <primeNumbers.Length; i++)
                    {
                        if (primeNumbers[i] < num)
                        {
                            if (string.IsNullOrEmpty(sonuc))
                                sonuc = primeNumbers[i].ToString();
                            else
                                sonuc += "," + primeNumbers[i];
                        }
                    }

                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
