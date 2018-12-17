using System;
using System.Windows.Forms;

namespace MDE_Version_2._0
{
    public partial class Anzahl : Form
    {

        

        public EingabeModel Eingabemodel { get; set; }
        //private Datenerfassungmodel Datenerfassungmodel;

        public Anzahl(Datenerfassungmodel datenerfassungmodel)
        {
            //Eingabemodel = eingabemodel;
            //var datenerfassung = new Datenerfassung();
            //var datenerfassungmodel = datenerfassung.Erfassung(Eingabemodel);


            //if (datenerfassungmodel == null)
            //{
            //    this.Close();

            //}

            InitializeComponent();
            Herstellerlabel.Text = datenerfassungmodel.Fabrikat;
            Artikelbezeichunglabel.Text = datenerfassungmodel.Artikelbezeichnung;
            eanlabel.Text = datenerfassungmodel.EAN;
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AnzahltextBox.Text, out var result))
            {
                Eingabemodel.Anzahl = Convert.ToInt32(AnzahltextBox.Text);
                //EingabemodelEvent?.Invoke(Eingabemodel);
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte eine Zahl eingeben!", "Fehlerhafte eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Abbrechenbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Anzahl_Load(object sender, EventArgs e)
        {

        }
    }
}
