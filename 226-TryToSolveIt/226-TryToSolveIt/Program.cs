using System;
using System.IO;

namespace _226_TryToSolveIt
{
	class Program
	{
		static void Main(string[] args)
		{

			string[] alphabet = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"," "};
			string[] cyphered = {"u","v","w","x","y","z","n","o","p","q","r","s","t","g","h","i","j","k","l","m","a","b","c","d","e","f"," "};

			//open file
			using (StreamReader reader = new StreamReader(args[0]))
			{
				//for each line
				while (!reader.EndOfStream)
				{
					//read it
					string line = reader.ReadLine(),
						sonuc="";
					//if not empty
					if (null == line) continue;
					for (int i = 0; i <= line.Length - 1; i++)
					{
						for (int j = 0; j <alphabet.Length; j++)
						{
							if (line.Substring(i, 1) == cyphered[j])
							{
								sonuc += alphabet[j]; break; 
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
