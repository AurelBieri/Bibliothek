using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Musik: CD, IOutput
    {
        private string _sänger;
        private string _musikstil;

        public Musik(string name, int artikelid, int erscheinungsjahr, int dauer, float preis, string sänger, string musikstil) : base(name, artikelid, erscheinungsjahr, dauer, preis)
        {
            setSänger(sänger);
            setMusikstil(musikstil);

        }

        public string getSänger()
        {
            return _sänger;
        }

        public void setSänger(string sänger)
        {
            _sänger = sänger;
        }
        public string getMusikstil()
        {
            return _musikstil;
        }

        public void setMusikstil(string musikstil)
        {
            _musikstil = musikstil;
        }
        public override string getTypeInformation()
        {
            return "Musik: ";
        }
        public new string Output()
        {
            return getTypeInformation() + "Name: " + getName() + " with the Id " + getArtikelid() + " has a duration of " + getDauer() + " Minutes." + "Was  released in " + getErscheinungsjahr() + "Costs: " + getPreis()+ "Singer: "+ getSänger()+"Style of music: "+getMusikstil(); ;
        }
    }
}
