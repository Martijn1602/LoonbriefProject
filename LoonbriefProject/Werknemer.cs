using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoonbriefProject
{
    class Werknemer
    {
        public string naam;
        public string geslacht;
        public DateTime geboortedatum;
        public int rijksregisternummer;
        public DateTime indiensttreding;
        public int salaris;
        public string iban;
        

        public Werknemer(string naam, string geslacht, DateTime geboortedatum, int rijksregisternummer, DateTime indiensttreding, string iban, int salaris = 1900)
        {
            
        }

        public override string ToString()
        {
            return naam;
        }

    }
}
