using System;
using System.IO;

namespace _115_MixedContent
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

                    string[] words = line.Split(',');
                    string kelimeler = "";
                    string sayilar = "";
                    for (int i = 0; i <words.Length; i++)
                    {
                        if (IsNumeric(words[i]) == true)
                        {
                            if (!string.IsNullOrEmpty(sayilar))
                                sayilar += ",";
                            sayilar += words[i];
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(kelimeler))
                                kelimeler += ",";
                            kelimeler += words[i];
                        }
                    }
                    if (string.IsNullOrEmpty(kelimeler) | string.IsNullOrEmpty(sayilar))
                    {
                        Console.WriteLine(kelimeler + sayilar);
                    }
                    else
                    {
                        Console.WriteLine(kelimeler + "|" + sayilar);
                    }
                }
            }
            Console.ReadLine();
        }
        static bool IsNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }
    }
}
