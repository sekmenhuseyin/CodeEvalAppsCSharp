using System;
using System.IO;

namespace _37_Pangrams
{
    class Program
    {
        static void Main(string[] args)
        {
            string alfabe = "abcdefghijklmnopqrstuvwxyz";
            //open file
            using (StreamReader reader = new StreamReader(args[0]))
            {
                //for each line
                while (!reader.EndOfStream)
                {
                    //read it
                    string line = reader.ReadLine().ToLower();
                    //if not empty
                    if (null == line) continue;
                    //copied

                    string eksikler = "";
                    for (int i = 0; i < alfabe.Length; i++)
                    {
                        if (line.IndexOf(alfabe.Substring(i, 1)) == -1)
                            eksikler += alfabe.Substring(i, 1);
                    }
                    if (eksikler=="")
                        eksikler = "NULL";
                    Console.WriteLine(eksikler);
                }
            }
            Console.ReadLine();
        }
    }
}
