using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class CD: Medium
    {
        public int _dauer;
        public float _preis;

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
        public override string Output()
        {
            return getTypeInformation() + "Name: " + getName() + " with the Id " + getArtikelid() + " has a duration of " + getDauer() + " Minutes."+ "Was  released in " + getErscheinungsjahr()+ "Costs: "+ getPreis(); ;
        }
    }
}
