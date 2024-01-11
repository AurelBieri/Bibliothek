using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	internal class Program
	{
		static void Main(string[] args)
		{
			LibraryClass library = new LibraryClass();

			Medium b1 = new Buch("TestBuch", 1, 2019, 263, "action", 13);
			Medium b2 = new Buch("TestBuch Version 2", 2, 2021, 354, "action", 15);
			Medium D1 = new DVD("TestBuch Version 2", 1, 2021, 120, "HD", "action", 20 );
			Medium n1 = new NichtAusleihbareMedien("sadfa", 1, 2004);
			Medium m1 = new Musik("GUTS", 17, 2023, 39, 30, "Olivia Rodrigo", "Pop");
			Medium h1 = new Hörbuch("Hello", 3, 2000, 13, 34, "Comedy");
			
			library.AddMedium(b1);
			library.AddMedium(b2);
			library.AddMedium(D1);
			library.AddMedium(n1);
			library.AddMedium(m1);
			library.AddMedium(h1);


            Kunde  k1 = new Kunde("Aurel", "Bieri", 16, 1);
            Kunde k2 = new Kunde("Larissa", "Fahrni", 16, 2);

            library.AddKunde(k1);
			library.AddKunde(k2);

			k1.addAusgelhiehen(b1, 6);
			k1.addAusgelhiehen(D1, 36);


			k2.addAusgelhiehen(m1, 17);
            k2.addAusgelhiehen(h1, 3);

			library.Output();

            Console.ReadKey();
		}
	}
}
