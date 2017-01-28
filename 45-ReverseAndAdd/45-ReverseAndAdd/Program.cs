using System;
using System.IO;

namespace _45_ReverseAndAdd
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

                    int dongu = 0;
                    long sonuc = Convert.ToInt64(line);

                    while (isPalindrome(sonuc) != true)
                    {
                        line = Reverse(line);
                        long num2 = Convert.ToInt64(line);
                        sonuc = sonuc + num2;
                        line = sonuc.ToString();
                        dongu += 1;

                    }


                    Console.WriteLine(dongu.ToString() + " " + sonuc.ToString());

                }
            }
            Console.ReadLine();
        }
        static bool isPalindrome(long sayi)
        {
            string tmp = sayi.ToString();
            for (int i = 0; i < tmp.Length - 1; i++)
            {
                if (tmp[i] != tmp[tmp.Length - i - 1]) return false;
            }
            return true;
        }
        static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
