using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoonbriefProject
{
    class Customer : Support
    {
        public Customer(string voornaam, string achternaam, string geslacht, DateTime geboortedatum, long rijksregisternummer, DateTime indiensttreding, string iban, int aantaluren = 38, int bruto = 2050) : base(voornaam, achternaam, geslacht, geboortedatum, rijksregisternummer, indiensttreding, iban, aantaluren, bruto)
        {
            Extralegalevoordelen = 50 + 19.5;
        }

        public Customer()
        {
            Extralegalevoordelen = 50 + 19.5;
        }
    }
}
