using System;
using System.IO;

namespace _107_ShortestRepetition
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

                    string tmp1 = null;
                    string tmp2 = null;
                    int sonuc = 0;
                    for (int i = 1; i <= line.Length; i++)
                    {
                        tmp1 = line.Substring(0, i);
                        try
                        {
                            tmp2 = line.Substring(i, i);
                        }
                        catch (Exception ex)
                        {
                            tmp2 = "";
                        }
                        sonuc = i;
                        if (tmp1 == tmp2)
                            break; // TODO: might not be correct. Was : Exit For

                    }
                    Console.WriteLine(sonuc.ToString());
                }
            }
            Console.ReadLine();
        }
    }
}
