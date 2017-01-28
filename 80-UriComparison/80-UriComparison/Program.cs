using System;
using System.IO;

namespace _80_UriComparison
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

                    string[] urls = line.Split(';');
                    for (int i = 0; i <= 1; i++)
                    {
                        urls[i] = urls[i].ToLower();
                        urls[i] = urls[i].Replace(":80/", "/");
                        urls[i] = urls[i].Replace("%20", " ");
                        urls[i] = urls[i].Replace("%21", "!");
                        urls[i] = urls[i].Replace("%22", "\"");
                        urls[i] = urls[i].Replace("%23", "#");
                        urls[i] = urls[i].Replace("%24", "$");
                        urls[i] = urls[i].Replace("%25", "%");
                        urls[i] = urls[i].Replace("%26", "&");
                        urls[i] = urls[i].Replace("%27", "'");
                        urls[i] = urls[i].Replace("%28", "(");
                        urls[i] = urls[i].Replace("%29", ")");
                        urls[i] = urls[i].Replace("%2a", "*");
                        urls[i] = urls[i].Replace("%2b", "+");
                        urls[i] = urls[i].Replace("%2c", ",");
                        urls[i] = urls[i].Replace("%2d", "-");
                        urls[i] = urls[i].Replace("%2e", ".");
                        urls[i] = urls[i].Replace("%2f", "/");
                        urls[i] = urls[i].Replace("%3a", ":");
                        urls[i] = urls[i].Replace("%3b", ";");
                        urls[i] = urls[i].Replace("%3c", "<");
                        urls[i] = urls[i].Replace("%3d", "=");
                        urls[i] = urls[i].Replace("%3e", ">");
                        urls[i] = urls[i].Replace("%3f", "?");
                        urls[i] = urls[i].Replace("%40", "@");
                        urls[i] = urls[i].Replace("%5b", "[");
                        urls[i] = urls[i].Replace("%5c", "\\");
                        urls[i] = urls[i].Replace("%5d", "]");
                        urls[i] = urls[i].Replace("%5e", "^");
                        urls[i] = urls[i].Replace("%5f", "_");
                        urls[i] = urls[i].Replace("%60", "`");
                        urls[i] = urls[i].Replace("%7b", "{");
                        urls[i] = urls[i].Replace("%7c", "|");
                        urls[i] = urls[i].Replace("%7d", "}");
                        urls[i] = urls[i].Replace("%7e", "~");
                    }

                    bool sonuc = urls[0] == urls[1];

                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
