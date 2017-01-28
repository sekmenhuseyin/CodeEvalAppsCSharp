using System;
using System.IO;

namespace _197_ColumnNames
{
	class Program
	{
		static void Main(string[] args)
		{

			//harfler
			string[] alfabe = {"","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
			string[] harfler = new string[18278];
			string sonuc = null;
			//excel sütun isimleri
			for (int i = 1; i <harfler.Length; i++) {
				int harf = i % 26;
				if (i < 27) {
					if (harf == 0)
						harf = 26;
					sonuc = alfabe[harf];
				} else if (i > 26 & i < 703) {
					int harf2 = Convert.ToInt32(Math.Floor(Convert.ToDecimal(i) / 26));
					harf = i - (harf2 * 26);
					if (harf == 0){harf = 26;harf2 -= 1;}
					sonuc = alfabe[harf2] + alfabe[harf];
				} else {
					int harf2 = Convert.ToInt32(Math.Floor(Convert.ToDecimal(i) / 26));
					harf = i - (harf2 * 26);
					if (harf == 0){harf = 26;harf2 -= 1;}
					//harf3
					int harf3 = Convert.ToInt32(Math.Floor(Convert.ToDecimal(harf2) / 26));
					harf2 = harf2 - (harf3 * 26);
					if (harf2 == 0){harf2 = 26;harf3 -= 1;}
					sonuc = alfabe[harf3] + alfabe[harf2] + alfabe[harf];
				}
				harfler[i] = sonuc;
			}

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

					sonuc = harfler[Convert.ToInt32(line)];
					Console.WriteLine(sonuc);
				}
			}
			Console.ReadLine();
		}
	}
}
