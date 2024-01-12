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
            if (AlleMedien.OfType<IAusleihen>().Any())
            {
                Console.WriteLine("Alle Ausleihbaren Medien");
                Console.WriteLine("----------------------------------------------------------------------------");
                foreach (Medium i in AlleMedien.OfType<IAusleihen>())
                {
                    Console.WriteLine(i.Output());
                    Console.WriteLine("---------");
                }
            }
            else
            {
                Console.WriteLine("Keine ausleihbaren Medien verfügbar.");
            }

            if (AlleMedien.OfType<IAusleihen>().Count() != AlleMedien.Count)
            {
                Console.WriteLine("\nAlle nicht Ausleihbaren Medien");
                Console.WriteLine("----------------------------------------------------------------------------");
                foreach (Medium m in AlleMedien.Where(m => !(m is IAusleihen)))
                {
                    Console.WriteLine(m.Output());
                    Console.WriteLine("---------");
                }
            }
            else
            {
                Console.WriteLine("Keine nicht ausleihbaren Medien verfügbar");
            }

            if (AlleMedien.OfType<IAusleihen>().Any())
            {
                Console.WriteLine("\nAlle im Moment Verfügbaren Ausleihbare Medien");
                Console.WriteLine("----------------------------------------------------------------------------");

                foreach (Medium i in AlleMedien)
                {
                    if (i is IAusleihen)
                    {
                        if (!((IAusleihen)i).IstAusgeliehen)
                        {
                            Console.WriteLine(i.Output());
                            Console.WriteLine("---------");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Im Moment gibt es keine Bücher zum ausleihen.");
            }

            Console.WriteLine("\n\nAlle Kunden");
            Console.WriteLine("----------------------------------------------------------------------------");
            if(AlleMedien.Count == 0)
            {
                Console.WriteLine("Es gibt keine Kunden");
            }
            else
            {
                foreach (Kunde k in AlleKunden)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine(k.Output());
                    if (k.getAusgeliehen().Count == 0)
                    {
                        Console.WriteLine("Dieser Kunde hat nichts ausgeliehen.");
                        Console.WriteLine("---------------------\n");
                    }
                    else
                    {
                        Console.WriteLine("Dieser Kunde hat im Moment Folgendes Ausgeliehen");
                        Console.WriteLine("---------------------");
                        foreach (IAusleihen i in k.getAusgeliehen())
                        {
                            Console.WriteLine(i.Output());
                            Console.WriteLine($"This article costs {i.ausleihenPreis()} francs to borrow for  {i.Anzahltage} days.");
                            Console.WriteLine("---");
                        }
                    }
                }
            }
			Console.WriteLine("\n\nAlle Mitarbeiter");
			Console.WriteLine("----------------------------------------------------------------------------");
            if(AlleMitarbeiter.Count == 0)
            {
                Console.WriteLine("\nEs gibt keine Mitarbeiter");
            }
            else
            {
                foreach (Mitarbeiter m in AlleMitarbeiter)
                {
                    Console.WriteLine(m.Output());
                    Console.WriteLine("----");
                }
            }
		}
    }
}
