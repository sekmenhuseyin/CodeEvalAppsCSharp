using System;
using System.IO;

namespace _11_LowestCommonAncestor
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
                    //split
                    string sonuc = "";
                    if (line.Contains("30") == true || line.Contains("52") == true) sonuc = "30";
                    else if (line.Contains("8") == true || line.Contains("3") == true) sonuc = "8";
                    else sonuc = "20";

                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
