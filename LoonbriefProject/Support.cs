using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoonbriefProject
{
    class Support : Werknemer
    {
        public Support(double brutoLoon = 2050)
        {
            AantalUren = 38;
            Extralegalevoordelen = 50;
        }

        public Support(string voornaam, string achternaam, string geslacht, DateTime geboortedatum, long rijksregisternummer, DateTime indiensttreding, string iban, int aantaluren = 38, int bruto = 2050) : base(voornaam, achternaam, geslacht, geboortedatum, rijksregisternummer, indiensttreding, aantaluren, bruto)
        {
            Extralegalevoordelen = 50;
        }

       
    }
}
