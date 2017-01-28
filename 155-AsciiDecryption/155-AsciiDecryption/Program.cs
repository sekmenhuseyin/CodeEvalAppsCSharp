using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _155_AsciiDecryption
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

                    string[] parts = line.Split('|');
                    int wordLength = Convert.ToInt32(parts[0].Trim());
                    int ascii = Convert.ToChar(parts[1].Trim());
                    string[] asciis = parts[2].Trim().Split(' ');
                    int asciiFark = 0;
                    string sonuc = "";
                    bool rightWord = false;
                    //check for every ascii in line
                    //ilk harften aranan kelime uzunluğu kadar eksik olan yere kadar
                    for (int i = 0; i < (asciis.Length - wordLength + 1); i++)
                    {
                        //her kelime zannedilen yerin son harfi aranan harfin ascii'sinden büyükse
                        if (Convert.ToInt32(asciis[i + wordLength - 1]) > ascii)
                        {
                            //ilk bakılan kelimenin ardındaki kelimeden başlayarak sona kadar bak
                            for (int j = (i + wordLength + 1); j < (asciis.Length - wordLength + 1); j++)
                            {
                                rightWord = true;
                                for (int k = 0; k <= wordLength - 1; k++)
                                {
                                    if (asciis[i + k] != asciis[j + k])
                                        rightWord = false;
                                }
                                if (rightWord == true)
                                {
                                    int tmp = Convert.ToInt32(asciis[i + wordLength - 1]) - ascii;
                                    for (int k = 0; k <= wordLength - 1; k++)
                                    {
                                        if (asciis[i + k] == (Convert.ToChar(" ").ToString() + asciiFark))
                                            rightWord = false;
                                    }
                                    if (rightWord == true)
                                        asciiFark = tmp;
                                }
                            }
                        }
                    }
                    for (int i = 0; i <asciis.Length; i++)
                    {
                        sonuc += (char)(Convert.ToInt32(asciis[i]) - asciiFark);
                    }
                    Console.WriteLine(sonuc);

                }
            }
            Console.ReadLine();
        }
    }
}
