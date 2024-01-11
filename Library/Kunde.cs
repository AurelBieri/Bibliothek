using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Kunde: Person, IOutput
    {
        private int _kundennr;
        private List<Medium> _ausgeliehen = new List<Medium>();

        public Kunde(string vorname, string nachname, int alter, int kundennr, List<Medium> ausgeliehen, int anzahltage) : base(vorname, nachname, alter)
        {
            setKundennr(kundennr);
            setAusgeliehen(ausgeliehen, anzahltage);

        }

        public Kunde(string vorname, string nachname, int alter, int kundennr) : base(vorname, nachname, alter)
        {
            setKundennr(kundennr);
        }

        public int getKundennr()
        {
            return _kundennr;
        }

        public void setKundennr(int kundennr)
        {
            _kundennr = kundennr;
        }
        public List<Medium> getAusgeliehen()
        {
            return _ausgeliehen;
        }

        public void setAusgeliehen(List<Medium> ausgeliehen, int anzahltage)
        {
            foreach (Medium m in ausgeliehen)
            {
                if(m is IAusleihen ausleihenMedium)
                {
                    _ausgeliehen.Add(m);
                    ausleihenMedium.Anzahltage = anzahltage;
                }
                else
                {
                    Console.WriteLine(m.getName() + " isn't available.");
                }
            }
        }

        public void addAusgelhiehen(Medium medium, int anzahltage)
        {
            if(medium is IAusleihen ausleihenMedium)
            {
                _ausgeliehen.Add(medium);
                ausleihenMedium.Anzahltage = anzahltage;
            }
            else
            {
                Console.WriteLine(medium.getName() + " isn't available.");
            }
            
        }

        public override string getTypeInformation()
        {
            return "Kunde: ";
        }
        public string Output()
        {
            return getTypeInformation() + "Name: " + getVorname() + "" + getNachname() + ", " + getAlter() + "Jahre alt, " + "Mit der KundenNummer" + getKundennr();
        }
    }
}
