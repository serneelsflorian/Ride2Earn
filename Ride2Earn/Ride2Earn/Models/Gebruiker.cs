﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride2Earn.Models
{
    public class Gebruiker
    {
        private string strVoornaam;
        private string strAchternaam;
        private string strEmail;
        private string strWachtwoord;
        private string strStraat;
        private string strGemeente;
        private string strRknNummer;
        private int intNummer;
        private int intPostcode;
        private int intID;

        [PrimaryKey, AutoIncrement]
        public int ID
        {
            get { return intID; }
            set { intID = value; }
        }
        public string Voornaam
        {
            get { return strVoornaam; }
            set { strVoornaam = value; }
        }
        public string Achternaam
        {
            get { return strAchternaam; }
            set { strAchternaam = value; }
        }
        public string Email
        {
            get { return strEmail; }
            set { strEmail = value; }
        }
        public string Wachtwoord
        {
            get { return strWachtwoord; }
            set { strWachtwoord = value; }
        }
        public string Straat
        {
            get { return strStraat; }
            set { strStraat = value; }
        }
        public string Gemeente
        {
            get { return strGemeente; }
            set { strGemeente = value; }
        }
        public string RknNummer
        {
            get { return strRknNummer; }
            set { strRknNummer = value; }
        }

        public int Nummer
        {
            get { return intNummer; }
            set { intNummer = value; }
        }
        public int Postcode
        {
            get { return intPostcode; }
            set { intPostcode = value; }
        }

        public Gebruiker()
        { }

        /*public Gebruiker(string pVnaam, string pAnaam, string pEmail, string pWw, string pStraat, string pGemeente, string pRknnummer, int pNmr, int pPcode)
        {
            strVoornaam = pVnaam;
            strAchternaam = pAnaam;
            strEmail = pEmail;
            strWachtwoord = pWw;
            strStraat = pStraat;
            strGemeente = pGemeente;
            strRknNummer = pRknnummer;
            intNummer = pNmr;
            intPostcode = pPcode;
        }/*


        /*public override string ToString()
         {
             return string.Format("[Gebruiker: ID={0}, strVoornaam={1}, strAchternaam={2}, strEmail{3}, strWachtwoord{4}]", ID, strVoornaam, strAchternaam, strEmail, strWachtwoord);
         }*/

        public override string ToString()
        {
            return $"({ID}) {strVoornaam}, {strAchternaam}";
        }
    }
}
