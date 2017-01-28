using System;
using System.IO;
using System.Globalization

namespace _237_PanaceaTruthOrLie
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
                    //TODO: actions here

                    Console.WriteLine(line);
                }
            }
            Console.ReadLine();
        }

        static string HexStringToBinary(string hexString)
        {
            int num = int.Parse(hexString, NumberStyles.HexNumber);
            return Convert.ToString(num, 2);
        }
        static int ConvertFromBinary(string input)
        {
            int ret = 0;
            char[] splitInput = input.ToCharArray;
            int modifier = 1;
            for (int i = splitInput.Length - 1; i >= 0; i += -1)
            {
                int thisChar = Conversion.Val(splitInput(i));
                if (thisChar == 1)
                {
                    ret += thisChar * modifier;
                }
                modifier *= 2;
            }

            return ret;
        }
    }
}
