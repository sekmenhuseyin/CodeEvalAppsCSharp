using System;
using System.IO;

namespace _26_FileSize
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo myFile = new FileInfo(args[0]);
            Console.WriteLine(myFile.Length);
            Console.ReadLine();
        }
    }
}
