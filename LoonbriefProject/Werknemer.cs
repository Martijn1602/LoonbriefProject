using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoonbriefProject
{
    public partial class Werknemer
    {
        public string Voornaam;
        public string Achternaam;
        public string Geslacht;
        public DateTime Geboortedatum;
        public long Rijksregisternummer;
        public DateTime Indiensttreding;
        public int Bruto;
        public string Iban;
        public string FunctieTitel;
        public bool Bedrijfswagen;
        public int AantalUren;
        public double BedrijfsVoorheffing = 13.68;
        public double Extralegalevoordelen = 0;


        public Werknemer(string voornaam, string achternaam, string geslacht, DateTime geboortedatum, long rijksregisternummer, DateTime indiensttreding, string iban, int aantaluren = 38,  int bruto = 1900)
        {
            FunctieTitel = "Werknemer";
            Voornaam = voornaam;
            Achternaam = achternaam;
            Geslacht = geslacht;
            Geboortedatum = geboortedatum;
            Rijksregisternummer = rijksregisternummer;
            Indiensttreding = indiensttreding;
            Bruto = bruto;
            Iban = iban;
            Bedrijfswagen = false;
            AantalUren = aantaluren;
        }

        public Werknemer(string voornaam, string achternaam, string geslacht, DateTime geboortedatum, long rijksregisternummer, DateTime indiensttreding, int aantaluren = 38, int bruto = 1900)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
            Geslacht = geslacht;
            Geboortedatum = geboortedatum;
            Rijksregisternummer = rijksregisternummer;
            Indiensttreding = indiensttreding;
            AantalUren = aantaluren;
            Bruto = bruto;
        }

        public Werknemer()
        {
        }

        public double StartLoon()
        {
            double startLoon = 0;
            startLoon = Bruto / 38 * AantalUren;
            return Math.Round(startLoon, 2);
        }

        public int AantalJarenInDienst()
        {
            int jarenInDienst = DateTime.Now.Year - Indiensttreding.Year + ((DateTime.Now.Month <= Indiensttreding.Month) ? -1 : 0);
            return jarenInDienst;
        }
        public virtual double BerekenAncieniteit()
        {
            double loon = StartLoon();
            double ancieniteit = loon;
            int jarenInDienst = AantalJarenInDienst();
            for (int i = 0; i < jarenInDienst; i++)
            {
                ancieniteit *= 1.01;
            }
            ancieniteit -= loon;
            return Math.Round(ancieniteit, 2);
        }

        public override string ToString()
        {
            return Voornaam;
        }

        public double MaakLoonBrief(string bestandsLocatie)
        {
            double socialeZekerheid = 200;
            double brutoLoon = StartLoon() + BerekenAncieniteit();
            double bedragBedrijfsvoorheffing = Math.Round(brutoLoon / 100 * BedrijfsVoorheffing, 2);
            double nettoLoon = Math.Round(brutoLoon - (bedragBedrijfsvoorheffing) + Extralegalevoordelen, 2);
            string bestandsNaam = bestandsLocatie + $"LOONBRIEF  {Voornaam} {Achternaam} {Rijksregisternummer} {DateTime.Now.ToString("MM yyyy")}.txt";
            using (StreamWriter writer = new StreamWriter(bestandsNaam))
            {
                writer.WriteLine("----------------------------------------------");
                writer.WriteLine($"LOONBRIEF {DateTime.Now.ToString("MMMM").ToUpper()} {DateTime.Now.Year} ");
                writer.WriteLine("----------------------------------------------");
                writer.WriteLine($"NAAM                     :{Voornaam} {Achternaam}");
                writer.WriteLine($"RIJKSREGISTERNUMMER      :{Rijksregisternummer}");
                writer.WriteLine($"GESLACHT                 :{Geslacht}");
                writer.WriteLine($"GEBOORTEDATUM            :{Geboortedatum.ToShortDateString()}");
                writer.WriteLine($"DATUM INDIENSTTREDING    :{Indiensttreding.ToShortDateString()}");
                writer.WriteLine($"AANTAL GEPRESTEERDE UREN :{AantalUren.ToString()}/38");
                writer.WriteLine($"BEDRIJFSWAGEN            :{(Bedrijfswagen ? "JA" : "NEE")}");
                writer.WriteLine("----------------------------------------------");
                writer.WriteLine($"STARTLOON                :   €{PrintValue(StartLoon())}");
                writer.WriteLine($"ANCIËNNITEIT             : + €{PrintValue(BerekenAncieniteit())}");
                writer.WriteLine($"                             €{PrintValue(brutoLoon)}");
                writer.WriteLine($"SOCIALE ZEKERHEID        : - €{PrintValue(socialeZekerheid)}");
                writer.WriteLine($"                             €{PrintValue(brutoLoon - socialeZekerheid)}");
                writer.WriteLine($"BEDRIJFSVOORHEFFING      : - €{PrintValue(bedragBedrijfsvoorheffing)}");
                writer.WriteLine($"                             €{PrintValue(brutoLoon - (bedragBedrijfsvoorheffing))}");
                if (Extralegalevoordelen > 0)
                {
                    writer.WriteLine($"EXTRALEGALE VOORDELEN    : + €{PrintValue(Extralegalevoordelen)}");
                }
                writer.WriteLine($"NETTOLOON                :   €{PrintValue(nettoLoon)}");
                writer.WriteLine("----------------------------------------------");
                writer.WriteLine("Het wordt uitbetaald op: {0}", Iban);
                writer.WriteLine("----------------------------------------------");

            }
            double totaleLoonkost = StartLoon() + BerekenAncieniteit() + Extralegalevoordelen;
            return totaleLoonkost;
        }
        public string PrintValue(double getal)
        {
            string tePrinten = getal.ToString("0.00");
            tePrinten = string.Format("{0,8}", tePrinten);

            return tePrinten;
        }
    }
}
