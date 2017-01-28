using System;
using System.IO;

namespace _30_SetIntersection
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

                    string[] parts = line.Split(';');
                    string[] nums1 = parts[0].Split(',');
                    string[] nums2 = parts[1].Split(',');
                    string sonuc = "";
                    foreach (string item in nums1)
                    {
                        foreach (string item2 in nums2)
                        {
                            if (item == item2)
                            {
                                if (!string.IsNullOrEmpty(sonuc))
                                    sonuc += ",";
                                sonuc += item;
                            }
                        }
                    }
                    Console.WriteLine(sonuc);

                }
            }
            Console.ReadLine();
        }
    }
}
