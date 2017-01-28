using System;
using System.IO;

namespace _68_ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] parantez = new int[3,2];
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
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            parantez[i, j] = 0;
                        }
                    }

                    for (int i = 0; i < line.Length ; i++)
                    {
                        if (line.Substring(i,1) == "(")
                            parantez[0, 0] += 1;
                        else if (line.Substring(i,1) == ")")
                            parantez[0, 1] += 1;
                        else if (line.Substring(i,1) == "[")
                            parantez[1, 0] += 1;
                        else if (line.Substring(i,1) == "]")
                            parantez[1, 1] += 1;
                        else if (line.Substring(i,1) == "{")
                            parantez[2, 0] += 1;
                        else if (line.Substring(i,1) == "}")
                            parantez[2, 1] += 1;
                    }
                    //control
                    bool sonuc = true;
                    for (int i = 0; i < 3; i++)
                    {
                        if (parantez[i, 0] != parantez[i, 1])
                        {
                            sonuc = false;
                            break;
                        }
                    }
                    if (line.Contains("[)") == true | line.Contains("(}") == true)
                        sonuc = false;

                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
