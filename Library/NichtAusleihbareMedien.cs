using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class NichtAusleihbareMedien: Medium, IOutput
    {
        public NichtAusleihbareMedien(string name, int artikelid, int erscheinungsjahr) : base(name, artikelid, erscheinungsjahr)
        {
            

        }

        
        public string Output()
        {
            return "Name: " + getName() + " with the Id " + getArtikelid() +  "Was  released in " + getErscheinungsjahr() +" and isn't  available."; ;
        }
    }
}
