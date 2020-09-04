using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoonbriefProject
{
    class IT : Support
    {
        public IT()
        {
        }

        public IT(string voornaam, string achternaam, string geslacht, DateTime geboortedatum, long rijksregisternummer, DateTime indiensttreding, string iban, int aantaluren = 38, int bruto = 2050) : base(voornaam, achternaam, geslacht, geboortedatum, rijksregisternummer, indiensttreding, aantaluren.ToString(), bruto)
        {
        }

        public override double BerekenAncieniteit()
        {
            double loon = StartLoon() * 0.94;
            double ancieniteit = loon;
            int jarenInDienst = AantalJarenInDienst();
            for (int i = 0; i < jarenInDienst; i++)
            {
                ancieniteit *= 1.01;
            }
            ancieniteit -= loon;
            return Math.Round(ancieniteit, 2);
        }

    }
}
