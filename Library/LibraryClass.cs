using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class LibraryClass
    {
        public List<Medium> AlleMedien = new List<Medium>();
        public List<Kunde> AlleKunden = new List<Kunde>();
        public List<Mitarbeiter> AlleMitarbeiter = new List<Mitarbeiter>();

        public void AddMedium(Medium m)
        {
            AlleMedien.Add(m);
        }

        public void AddKunde(Kunde k)
        {
            AlleKunden.Add(k);
        }

        public void AddMitarbeiter(Mitarbeiter m)
        {
            AlleMitarbeiter.Add(m);
        }

        public void  Output()
        {
            Console.WriteLine("Alle Ausleihbaren Medien");
            Console.WriteLine("----------------------------------------------------------------------------");
            foreach(Medium i in AlleMedien)
            {
                if (i is IAusleihen)
                {
                    Console.WriteLine(i.Output());
                    Console.WriteLine("---------");
                }
            }

            Console.WriteLine("\nAlle nicht Ausleihbaren Medien");
            Console.WriteLine("----------------------------------------------------------------------------");
            foreach (Medium m in AlleMedien)
            {
                if(!(m is IAusleihen))
                {
                    Console.WriteLine(m.Output());
                    Console.WriteLine("---------");
                }
            }

            Console.WriteLine("\n\nAlle Kunden");
            Console.WriteLine("----------------------------------------------------------------------------");
            foreach(Kunde k in AlleKunden)
            {
                Console.WriteLine("\n");
                Console.WriteLine(k.Output());
                Console.WriteLine("Dieser Kunde hat im Moment Folgendes Ausgeliehen"); 
                Console.WriteLine("---------------------");
                foreach(IAusleihen i in k.getAusgeliehen())
                {
                    Console.WriteLine(i.Output());
                    Console.WriteLine($"Dieser Artikel kostet für das Ausleihen von {i.Anzahltage} Tagen {i.ausleihenPreis()} Franken" );
                    Console.WriteLine("---");
                }
            }
        }
    }
}
