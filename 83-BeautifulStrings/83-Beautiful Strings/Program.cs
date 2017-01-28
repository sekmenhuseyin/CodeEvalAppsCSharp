using System;
using System.IO;
using System.Text;

namespace _83_Beautiful_Strings
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
                    line = line.ToLower();
                    int[] counter = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
                    byte[] ASCIIValues = Encoding.ASCII.GetBytes(line);
                    foreach(byte b in ASCIIValues) {
                        if (b >= 97 & b <= 122)
                            counter[b - 97] = counter[b - 97] + 1;
                    }
                    //sayıları topla
                    int puan = 26;
                    int sonuc = 0;
                    Array.Sort(counter);
                    Array.Reverse(counter);
                    foreach (int item in counter)
                    {
                        sonuc += item * puan;
                        puan -= 1;
                    }
                    //show
                    Console.WriteLine(sonuc);

                }
            }
            Console.ReadLine();
        }
    }
}
