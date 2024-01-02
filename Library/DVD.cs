using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DVD : Medium, IAusleihen, IOutput
    {
        public int _dauer;
        public string _auflösung;
        public string _genre;
        public float _preis;
        public int Anzahltage { get; set; }

        public DVD(string name, int artikelid, int erscheinungsjahr, int dauer, string auflösung, string genre, float preis) : base(name, artikelid, erscheinungsjahr)
        {
            setDauer(dauer);
            setAuflösung(auflösung);
            setGenre(genre);
            setPreis(preis);

        }

        public int getDauer()
        {
            return _dauer;
        }

        public void setDauer(int dauer)
        {
            _dauer = dauer;
        }
        public string getAuflösung()
        {
            return _auflösung;
        }

        public void setAuflösung(string auflösung)
        {
            _auflösung = auflösung;
        }
        public string getGenre()
        {
            return _genre;
        }

        public void setGenre(string genre)
        {
            _genre = genre;
        }
        public float getPreis()
        {
            return _preis;
        }

        public void setPreis(float preis)
        {
            _preis = preis;
        }
        public override string getTypeInformation()
        {
            return "DVD: ";
        }
        public string Output()
        {
            return getTypeInformation() + "Name: " + getName() + " with the Id " + getArtikelid() + " has a duration of " + getDauer() + " Minutes. With a resolution of "+getAuflösung()+". Genre: " + getGenre() + "Was  released in " + getErscheinungsjahr()+ "Costs: "+ getPreis(); ;
        }

        public float ausleihenPreis()
        {
            if (Anzahltage < 10)
            {
                return 0;
            }
            else
            {
                return (Anzahltage * 10) / 100;
            }
        }
    }
}
