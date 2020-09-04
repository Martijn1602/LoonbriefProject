using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoonbriefProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Werknemer> mijnWerknemers = new List<Werknemer>()
        {
            new Programmeur("Arne", "Wauters" ,"Man", new DateTime(1985,04,10), 85041004968,new DateTime(2005,04,04), "BE66063954500242", true, 38, 2200), 
            new Werknemer("Petra", "Van Hemelryk", "Vrouw", new DateTime(1985,03,06),85030604832,new DateTime(2015,04,24)),
            new IT("Pieter", "Sanders", "Man",new DateTime(1984,03,25),84052532948,new DateTime(2008,07,09), "BE54084778951234", 38, 1950),
            new Customer("Martijn", "Wauters", "Man",new DateTime(1983,02,16),83021605558,new DateTime(2005,04,05), "BE54084778998764", 38)
        };

        private void Form1_Load_1(object sender, EventArgs e)
        {
            lbWerknemer.DataSource = mijnWerknemers;
        }


        private void lbWerknemer_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lbWerknemer.SelectedIndex > -1)
            {
                Werknemer geselecteerdeWerknemer = (Werknemer)lbWerknemer.SelectedItem;
            }
        }

        private void btnMaakBrief_Click_1(object sender, EventArgs e)
        {
            MaakLoonBrief();
        }

        private void MaakLoonBrief()
        {
            double totaleLoonkost = 0;
            string BestandsLocatie = Environment.CurrentDirectory + $"\\LOONBRIEVEN {DateTime.Now.ToString("MMMM yyyy").ToUpper()}\\";
            if (!Directory.Exists(BestandsLocatie))
            {
                Directory.CreateDirectory(BestandsLocatie);
            }

            foreach (Werknemer werknemer in mijnWerknemers)
            {
                totaleLoonkost += werknemer.MaakLoonBrief(BestandsLocatie);
            }
            string loonKost = Environment.CurrentDirectory + $"\\loonkosten {DateTime.Now.ToString("MMMM yyyy").ToUpper()}\\";
            //string loonKost = File.ReadAllText("loonkosten.txt");
            if (!loonKost.Contains(DateTime.Now.ToString("MMMM yyyy").ToUpper()))
            {
                using (StreamWriter writer = new StreamWriter("loonkosten.txt", true))
                {
                    writer.WriteLine($"Loonkost voor de maand {DateTime.Now.ToString("MMMM yyyy").ToUpper()}: €{totaleLoonkost}");
                }
            }

        }

        private void btnPasAan_Click_1(object sender, EventArgs e)
        {
            Werknemer actieveWerknemer = (Werknemer)lbWerknemer.SelectedItem;
            using (Form2 newForm = new Form2(actieveWerknemer))
            {
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    actieveWerknemer = newForm.actieveWerknemer;
                }
            }
            lbWerknemer.DataSource = null;
            lbWerknemer.DataSource = mijnWerknemers;
        }

        private void btnMaakAan_Click(object sender, EventArgs e)
        {
            Werknemer nieuweWerknemer;
            using (Form2 newForm = new Form2())
            {
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    nieuweWerknemer = newForm.actieveWerknemer;
                    mijnWerknemers.Add(nieuweWerknemer);
                    lbWerknemer.DataSource = null;
                    lbWerknemer.DataSource = mijnWerknemers;
                }
            }
        }
    }
}
