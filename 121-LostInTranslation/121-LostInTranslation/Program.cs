using System;
using System.IO;

namespace _121_LostInTranslation
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] alphabet = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"," "};
            string[] cyphered = {"y","n","f","i","c","w","l","b","k","u","o","m","x","s","e","v","z","p","d","r","j","g","t","h","a","q"," "};

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

                    string sonuc = "";
                    for (int i = 0; i <= line.Length - 1; i++)
                    {
                        for (int j = 0; j <alphabet.Length; j++)
                        {
                            if (line.Substring(i, 1) == cyphered[j])
                            {
                                sonuc += alphabet[j]; break; // TODO: might not be correct. Was : Exit For
                            }
                        }
                    }
                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
