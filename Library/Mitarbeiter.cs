﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Mitarbeiter: Person
    {
        public int _mitarbeiterid;
        public float _lohn;
        public string _rolle;
        

        public Mitarbeiter(string vorname, string nachname, int alter, int mitarbeiterid, float lohn, string rolle) : base(vorname, nachname, alter)
        {
            setMitarbeiterid(mitarbeiterid);
            setLohn(lohn);
            setRolle(rolle);

        }

        public int getMitarbeiterid()
        {
            return _mitarbeiterid;
        }

        public void setMitarbeiterid(int mitarbeiterid)
        {
            _mitarbeiterid = mitarbeiterid;
        }
        public float getLohn()
        {
            return _lohn;
        }

        public void setLohn(float lohn)
        {
            _lohn = lohn;
        }
        public string getRolle()
        {
            return _rolle;
        }

        public void setRolle(string rolle)
        {
            _rolle = rolle;
        }
        public override string getTypeInformation()
        {
            return "Mitarbeiter: ";
        }
        public override string Output()
        {
            return getTypeInformation() + "Name: " + getVorname() + getNachname()+", "+getAlter()+"years old, "+ " with the Id " + getMitarbeiterid() + " has a salary of " + getLohn() + " Role: " + getRolle(); ;
        }
    }
}
