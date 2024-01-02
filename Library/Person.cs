using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class Person
    {
        public string _vorname;
        public string _nachname;
        public int _alter;

        public Person(string vorname, string nachname, int alter)
        {
            setVorname(vorname);
            setNachname(nachname);
            setAlter(alter);
        }
        public string getVorname()
        {
            return _vorname;
        }
        public void setVorname(string value)
        {
            _vorname = value;
        }
        public string getNachname()
        {
            return _nachname;
        }
        public void setNachname(string value)
        {
            _nachname = value;
        }
        public int getAlter()
        {
            return _alter;
        }
        public void setAlter(int value)
        {
            _alter = value;
        }

        public virtual string getTypeInformation()
        {
            return "Person:";
        }
    }
}
