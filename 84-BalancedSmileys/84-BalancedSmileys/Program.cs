using System;
using System.IO;

namespace _84_BalancedSmileys
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] parantez = new int[2];
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
                    for (int i = 0; i < 2; i++)
                    {
                        parantez[i] = 0;
                    }

                    line = line.Replace(":)", "}").Replace(":(", "{");
                    for (int i = 0; i <= line.Length - 1; i++)
                    {
                        if (line[i] == '(')
                        {
                            parantez[0] += 1;
                            parantez[1] += 1;
                        }
                        else if (line[i] == ')')
                        {
                            parantez[0] -= 1;
                            parantez[1] -= 1;
                            if (parantez[1] < 0)
                                break; // TODO: might not be correct. Was : Exit For
                        }
                        else if (line[i] == '{')
                        {
                            parantez[1] += 1;
                        }
                        else if (line[i] == '}')
                        {
                            parantez[0] -= 1;
                        }
                    }
                    //control
                    string sonuc = "NO";
                    if (parantez[0] <= 0 & parantez[1] >= 0) sonuc = "YES";
                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
