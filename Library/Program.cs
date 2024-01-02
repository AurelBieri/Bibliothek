using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Medium b1 = new Buch("TestBuch", 1, 2019, 263, "action", 13);
			Medium b2 = new Buch("TestBuch Version 2", 2, 2021, 354, "action", 15);
			Medium D1 = new DVD("TestBuch Version 2", 1, 2021, 120, "HD", "action", 20 );


			Kunde  k1 = new Kunde("Aurel", "Bieri", 16, 1);

			k1.addAusgelhiehen(b1, 10);
			 k1.addAusgelhiehen(D1, 15);


			foreach (IOutput i in k1._ausgeliehen)
			{
				Console.WriteLine(i.Output());
			}

			foreach (IAusleihen i in k1._ausgeliehen)
			{
				Console.WriteLine(i.ausleihenPreis());
			}

			Console.ReadKey();
		}
	}
}
