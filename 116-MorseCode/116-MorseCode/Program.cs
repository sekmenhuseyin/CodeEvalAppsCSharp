using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _116_MorseCode
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] morse = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--..","-----",".----","..---","...--","....-",".....","-....","--...","---..","----."};
            string[] alfabe = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","0","1","2","3","4","5","6","7","8","9"};           //open file
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

                    string sonuc = "";
                    line = line.Replace("  ", ";");
                    string[] words = line.Split(';');
                    //all words
                    for (int i = 0; i <= words.Length - 1; i++)
                    {
                        string[] letters = words[i].Split(' ');
                        //all letters
                        for (int j = 0; j <= letters.Length - 1; j++)
                        {
                            //morse codes
                            for (int k = 0; k <= morse.Length - 1; k++)
                            {
                                if (morse[k] == letters[j])
                                {
                                    sonuc += alfabe[k]; break; // TODO: might not be correct. Was : Exit For
                                }

                            }


                        }
                        sonuc += " ";

                    }
                    Console.WriteLine(sonuc);
                }
            }
            Console.ReadLine();
        }
    }
}
