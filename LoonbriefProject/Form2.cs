using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoonbriefProject
{
    public partial class Form2 : Form
    {
        public Form2()


        {
            InitializeComponent();
            btnMaakAan.Text = "Maak werknemer aan";
        }
        public Werknemer actieveWerknemer = null;
        public Form2(Werknemer werknemer)
        {
            InitializeComponent();
            actieveWerknemer = werknemer;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            cbWagen.DataSource = new List<string>() { "Ja", "Nee" };
            cbFunctie.DataSource = new List<string>() { "Werknemer", "Programmeur", "IT-Support", "Customer-Support" };
            cbGeslacht.DataSource = new List<string>() { "Man", "Vrouw" };
            dtGeboorte.Format = DateTimePickerFormat.Custom;
            dtGeboorte.CustomFormat = "dd MMM yyyy";

            if (actieveWerknemer != null)
            {

                ActiveForm.Text = "Gegevens wijzigen";
                btnMaakAan.Text = "Wijzigingen bevestigen";
                txtVoornaam.Text = actieveWerknemer.Voornaam;
                txtAchternaam.Text = actieveWerknemer.Achternaam;
                dtGeboorte.Value = actieveWerknemer.Geboortedatum;
                cbGeslacht.SelectedItem = actieveWerknemer.Geslacht;
                txtRijksregisternummer.Text = actieveWerknemer.Rijksregisternummer.ToString();
                txtIBAN.Text = actieveWerknemer.Iban;
                cbFunctie.SelectedItem = actieveWerknemer.FunctieTitel;
                numUren.Value = actieveWerknemer.AantalUren;
                numBruto.Value = Convert.ToDecimal(actieveWerknemer.Bruto);
                cbWagen.SelectedItem = actieveWerknemer.Bedrijfswagen ? "Ja" : "Nee";

            }
        }

        private void btnMaakAan_Click(object sender, EventArgs e)
        {
            UpdateWerknemer();
            DialogResult = DialogResult.OK;
        }


        public void UpdateWerknemer()
        {
            switch (cbFunctie.SelectedItem)
            {
                case "Werknemer":
                    actieveWerknemer = new Werknemer();
                    break;
                case "Programmeur":
                    actieveWerknemer = new Programmeur();
                    break;
                case "IT-Support":
                    actieveWerknemer = new IT();
                    break;
                case "Customer-Support":
                    actieveWerknemer = new Customer();
                    break;
            }

            actieveWerknemer.Voornaam = txtVoornaam.Text;
            actieveWerknemer.Geboortedatum = dtGeboorte.Value;
            //actieveWerknemer.Geslacht = (Werknemer.geslacht)cbGeslacht.SelectedItem;
            //actieveWerknemer.Rijksregisternummer = txtRijksregisternummer;
            actieveWerknemer.Iban = txtIBAN.Text;
            actieveWerknemer.FunctieTitel = cbFunctie.SelectedItem.ToString();
            
            actieveWerknemer.AantalUren = (int)numUren.Value;
            if (numBruto.Value != 0)
            {
                actieveWerknemer.Bruto = (int)Convert.ToDouble(numBruto.Value);
            }
            actieveWerknemer.Bedrijfswagen = (cbWagen.SelectedItem.ToString() == "Ja" ? true : false);
        }

        private void cbFunctie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cbFunctie.SelectedItem)
            {
                case "Werknemer":
                    cbWagen.Enabled = false;
                    cbWagen.SelectedItem = "Nee";
                    numUren.Enabled = true;
                    break;
                case "Programmeur":
                    cbWagen.Enabled = true;
                    cbWagen.SelectedItem = "Nee";
                    numUren.Enabled = true;
                    break;
                case "IT Support":
                    cbWagen.Enabled = false;
                    cbWagen.SelectedItem = "Nee";
                    numUren.Enabled = false;
                    numUren.Value = 38;
                    break;
                case "Customer Support":
                    cbWagen.Enabled = false;
                    cbWagen.SelectedItem = "Nee";
                    numUren.Enabled = false;
                    numUren.Value = 38;
                    break;
            }
        }

        private void btnAnnuleer_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
