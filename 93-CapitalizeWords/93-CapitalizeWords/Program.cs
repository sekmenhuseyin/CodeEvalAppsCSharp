using System;
using System.IO;

namespace _93_CapitalizeWords
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
					
					string sonuc = "";
					bool cevir = true;
					for (int i = 0; i <= line.Length - 1; i++) {
						string kar = line.Substring(i, 1);
						if (kar == " ") {
							cevir = true;
						} else {
							if (cevir == true) {
								kar = kar.ToUpper();
								cevir = false;
							}
						}
						sonuc += kar;
					}
					Console.WriteLine(sonuc);

				}
			}
			Console.ReadLine();
		}
	}
}
