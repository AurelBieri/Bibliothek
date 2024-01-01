using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Kunde: Person
    {
        public int _kundennr;
        public List<Medium> _ausgeliehen;

        public Kunde(string vorname, string nachname, int alter, int kundennr, List<Medium> ausgeliehen) : base(vorname, nachname, alter)
        {
            setKundennr(kundennr);
            setAusgeliehen(ausgeliehen);

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

        public void setAusgeliehen(List<Medium> ausgeliehen)
        {
            _ausgeliehen = ausgeliehen;
        }
        public override string getTypeInformation()
        {
            return "Kunde: ";
        }
        public override string Output()
        {
            return getTypeInformation() + "Name: " + getVorname() + getNachname() + ", " + getAlter() + "years old, " + " with the Nr. " + getKundennr() + " has borrowed " + getAusgeliehen(); ;
        }
    }
}
