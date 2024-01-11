using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Hörbuch: CD, IAusleihen, IOutput
    {
        private string _genre;

        public Hörbuch(string name, int artikelid, int erscheinungsjahr, int dauer, float preis, string genre) : base(name, artikelid, erscheinungsjahr,dauer, preis)
        {
            setGenre(genre);

        }

        public string getGenre()
        {
            return _genre;
        }

        public void setGenre(string genre)
        {
            _genre = genre;
        }
        public override string getTypeInformation()
        {
            return "Hörbuch: ";
        }
        public new string Output()
        {
            return getTypeInformation() + "Name: " + getName() + " with the Id " + getArtikelid() + " has a duration of " + getDauer() + " Minutes. Genre: " + getGenre()+ " It was released in " + getErscheinungsjahr() + " Costs: " + getPreis(); ;
        }

    }
}
