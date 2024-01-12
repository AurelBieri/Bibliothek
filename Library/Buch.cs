using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Buch : Medium, IAusleihen
    {
        private int _anzseiten;
        private string _genre;
        private float _preis;
        public int Anzahltage { get; set; } //Diese Muss Public sein, da sie von dem Interface aus kommt.
        public bool IstAusgeliehen { get; set; } //Diese Muss Public sein, da sie von dem Interface aus kommt.

        public Buch(string name, int artikelid, int erscheinungsjahr, int anzseiten, string genre, float preis) : base(name, artikelid, erscheinungsjahr)  
        {
            setAnzSeiten(anzseiten);
            setGenre(genre);
            setPreis(preis);

        }

        public int getAnzSeiten()
        {
            return _anzseiten;
        }

        public void setAnzSeiten(int anzseiten)
        {
            _anzseiten = anzseiten;
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
            return "Book: ";
        }
        public override string Output() 
        {
            return getTypeInformation() + "Name: " + getName() + " with the Id " + getArtikelid() + " has "+ getAnzSeiten()+" Pages. Genre: "+ getGenre()+ " It was released in "+ getErscheinungsjahr()+" Costs: "+ getPreis(); ;
        }

        public double ausleihenPreis()
        {
            if (Anzahltage < 10)
            {
                return 0;
            }
            else
            {
                return ((Anzahltage * 3.0) / 100.0);
            }
        }
    }
}
