using System;
using System.IO;

namespace _75_FlaviusJosephus
{
    class Program
    {
        static void Main(string[] args)
        {
            string line,sonuc;
            int num1 = 0,num2 = 0,killed = 0,lastPerson = 0;
            //open file
            using (StreamReader reader = new StreamReader(args[0]))
            {
                //for each line
                while (!reader.EndOfStream)
                {
                    //read it
                    line = reader.ReadLine();
                    //if not empty
                    if (null == line) continue;
                    //copied

                    string[] nums = line.Split(',');
                    num1 = Convert.ToInt32(nums[0]);
                    num2 = Convert.ToInt32(nums[1]);
                    killed = 0;
                    lastPerson = -1;
                    sonuc = "";
                    bool[] people = new bool[num1 + 1];
                    //clear people
                    for (int i = 0; i <= num1; i++)
                    {
                        people[i] = true;
                    }
                    //kill everyone
                    while (killed < num1)
                    {
                        for (int i = 1; i <= num2; i++)
                        {
                            lastPerson += 1;
                            if (lastPerson > num1)
                                lastPerson -= num1;
                            if (people[lastPerson] == false)
                                i -= 1;
                        }
                        people[lastPerson] = false;
                        sonuc += " " + (lastPerson % num1).ToString();
                        killed += 1;
                    }


                    Console.WriteLine(sonuc.Trim());

                }
            }
            Console.ReadLine();
        }
    }
}
