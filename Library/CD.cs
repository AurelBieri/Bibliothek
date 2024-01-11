using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class CD: Medium, IAusleihen, IOutput
    {
        private int _dauer;
        private float _preis;
        public int Anzahltage { get; set; }

        public CD(string name, int artikelid, int erscheinungsjahr, int dauer, float preis) : base(name, artikelid, erscheinungsjahr)
        {
            setDauer(dauer);
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
            return "CD: ";
        }
        public string Output()
        {
            return getTypeInformation() + "Name: " + getName() + " with the Id " + getArtikelid() + " has a duration of " + getDauer() + " Minutes."+ " It was released in " + getErscheinungsjahr()+ " Costs: "+ getPreis(); ;
        }

        public double ausleihenPreis()
        {
            if(Anzahltage < 10)
            {
                return 0;
            }
            else
            {
                return (Anzahltage * 5.0) / 10.0;
            }
        }
    }
}
