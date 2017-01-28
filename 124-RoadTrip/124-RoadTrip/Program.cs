using System;
using System.IO;

namespace _124_RoadTrip
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

                    string[] cities = line.Split(';');
                    int[] distances = new int[cities.Length-1];
                    //loop each city
                    for (int i = 0; i <cities.Length - 1; i++)
                    {
                        distances[i] = Convert.ToInt32(cities[i].Substring(cities[i].IndexOf(",")+1));
                    }
                    //sort
                    Array.Sort(distances);
                    int tmp = 0;
                    string sonuc = "";
                    foreach (int item in distances)
                    {
                        tmp = item - tmp;
                        sonuc += "," + tmp;
                        tmp = item;
                    }
                    Console.WriteLine(sonuc.Remove(0, 1));
                }
            }
            Console.ReadLine();
        }
    }
}
