using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122_HiddenDigits
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

                    string sonuc = ""; int i = 0;
                    byte[] ASCIIValues = Encoding.ASCII.GetBytes(line);
                    foreach (byte b in ASCIIValues)
                    {
                        string kar = line.Substring(i, 1);
                        if (b >= 97 & b <= 106)
                            sonuc += (b-97).ToString();
                        else if (b >= 48 & b <= 57)
                            sonuc += kar;
                        i++;
                    }
                    if (sonuc == "")
                        Console.WriteLine("NONE");
                    else
                        Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
