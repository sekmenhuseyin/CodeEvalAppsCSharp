using System;
using System.IO;
using System.Text;

namespace _96_SwapCase
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
                    string sonuc = ""; int i=0;
                    byte[] ASCIIValues = Encoding.ASCII.GetBytes(line);
                    foreach (byte b in ASCIIValues)
                    {
                        string kar = line.Substring(i, 1);
                        if (b >= 97 & b <= 122)
                            kar = kar.ToUpper();
                        else
                            kar = kar.ToLower();
                        sonuc += kar; i++;
                    }
                    Console.WriteLine(sonuc);

                }
            }
            Console.ReadLine();
        }
    }
}
