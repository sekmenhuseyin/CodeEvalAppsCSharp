using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _102_JsonMenuIds
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

                    int total = 0;
                    string tmp = null;
                    Regex regex = new Regex("(\"id\": [\\d]+(,))");
                    Match match = regex.Match(line);
                    while (match.Success)
                    {
                        tmp = match.Value.Replace("\"id\": ", "").Replace(",", "");
                        total += Convert.ToInt32(tmp);
                        match = match.NextMatch();
                    }
                    Console.WriteLine(total);
                }
            }
            Console.ReadLine();
        }
    }
}
