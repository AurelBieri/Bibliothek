using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Medium
    {
        public string _name;
        public int _artikelid;
        public int _erscheinungsjahr;

        public Medium(string name,int artikelid, int erscheinungsjahr)
        {
            setName(name);
            setArtikelid(artikelid);
            setErscheinungsjahr(erscheinungsjahr);
        }
        public string getName()
        {
            return _name;
        }
        public void setName(string value)
        {
            _name = value;
        }
        public int getArtikelid()
        {
            return _artikelid;
        }
        public void setArtikelid(int value)
        {
            _artikelid = value;
        }
        public int getErscheinungsjahr()
        {
            return _erscheinungsjahr;
        }
        public void setErscheinungsjahr(int value)
        {
            _erscheinungsjahr = value;
        }
        public abstract string Output();

        public virtual string getTypeInformation()
        {
            return "Medium:";
        }
    }
}
