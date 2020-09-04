using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoonbriefProject
{
    class Programmeur : Werknemer
    {
        public Programmeur()
        {
        }

        public Programmeur(string voornaam, string achternaam, string geslacht, DateTime geboortedatum, long rijksregisternummer, DateTime indiensttreding, string iban, bool bedrijfswagen = false, int aantaluren = 38, int bruto = 2200) : base(voornaam, achternaam, geslacht, geboortedatum, rijksregisternummer, indiensttreding, aantaluren, bruto)
        {
            Bedrijfswagen = bedrijfswagen;
            BedrijfsVoorheffing = (bedrijfswagen ? 17.30 : 13.68);
        }

    }
}
