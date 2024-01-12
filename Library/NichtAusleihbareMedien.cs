using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class NichtAusleihbareMedien: Medium
    {
        public NichtAusleihbareMedien(string name, int artikelid, int erscheinungsjahr) : base(name, artikelid, erscheinungsjahr)
        {
        }

        
        public override string Output()
        {
            return "Name: " + getName() + " with the Id " + getArtikelid() +  ", was released in " + getErscheinungsjahr() +" and isn't  available."; ;
        }
    }
}
