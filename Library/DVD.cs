using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DVD : Medium
    {
        public int _dauer;
        public int _auflösung;
        public string _genre;
        public float _preis;

        public DVD(string name, int artikelid, int erscheinungsjahr, int dauer,int auflösung, string genre, float preis) : base(name, artikelid, erscheinungsjahr)
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
        public int getAuflösung()
        {
            return _auflösung;
        }

        public void setAuflösung(int auflösung)
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
        public override string Output()
        {
            return getTypeInformation() + "Name: " + getName() + " with the Id " + getArtikelid() + " has a duration of " + getDauer() + " Minutes. With a resolution of "+getAuflösung()+". Genre: " + getGenre() + "Was  released in " + getErscheinungsjahr()+ "Costs: "+ getPreis(); ;
        }
    }
}
