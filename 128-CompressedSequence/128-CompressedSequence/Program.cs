using System;
using System.IO;

namespace _128_CompressedSequence
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

                    string[] rakam = line.Split(' ');
                    string sonuc = "";
                    string simdiki = "";
                    int sayi = 0;
                    for (int i = 0; i < rakam.Length; i++)
                    {
                        if (rakam[i] != simdiki)
                        {
                            if (!string.IsNullOrEmpty(simdiki))
                            {
                                if (!string.IsNullOrEmpty(sonuc))
                                    sonuc += " ";
                                sonuc += sayi + " " + simdiki;
                            }
                            simdiki = rakam[i];
                            sayi = 0;
                        }
                        sayi += 1;
                    }
                    if (!string.IsNullOrEmpty(sonuc))
                        sonuc += " ";
                    sonuc += sayi + " " + simdiki;

                    Console.WriteLine(sonuc);

                }
            }
            Console.ReadLine();
        }
    }
}
