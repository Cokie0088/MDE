using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MDE_Version_2._0.Properties;

namespace MDE_Version_2._0
{
    public partial class Anzahl : Form
    {

        

        public EingabeModel Eingabemodel { get; set; }
        private readonly DataCollectionmodel _datencollectionmodel;
        public event Action<DataCollectionmodel> NewEntryEvent;

        public Anzahl(DataCollectionmodel dataCollectionmodel)
        {
            _datencollectionmodel = dataCollectionmodel;
            InitializeComponent();
            Herstellerlabel.Text = dataCollectionmodel.Fabrikat;
            Artikelbezeichunglabel.Text = dataCollectionmodel.Artikelbezeichnung;
            eanlabel.Text = dataCollectionmodel.EAN;
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(AnzahltextBox.Text, out var result))
            {
                var anzahl = Convert.ToInt32(AnzahltextBox.Text);
                if (anzahl > 1000)
                {
                    var messageboxresult = MessageBox.Show(Resources.Anzahl_groesser_1000,
                        Resources.Anzahl_bitte_Prüfen, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (messageboxresult == DialogResult.No)
                    {
                        return;
                    }
                }
                _datencollectionmodel.Anzahl = anzahl;
                
                NewEntryEvent?.Invoke(_datencollectionmodel);
                this.Close();
            }
            else
            {
                MessageBox.Show(Resources.Bitte_eine_gültig_Zahl_eingeben, Resources.Fehlerhafte_eingabe, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Abbrechenbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
