using System;
using System.Windows.Forms;

namespace MDE_Version_2._0
{
    public partial class Anzahl : Form
    {

        public event Action<EingabeModel> EingabemodelEvent;

        public EingabeModel Eingabemodel { get; set; }
        public RenditeModel Renditeentity { get; set; }

        public Anzahl() => InitializeComponent();







        private void Okbutton_Click(object sender, EventArgs e)
        {


            if (int.TryParse(AnzahltextBox.Text, out int result))
            {
                Eingabemodel.Anzahl = Convert.ToInt32(AnzahltextBox.Text);
                EingabemodelEvent?.Invoke(Eingabemodel);
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
    }
}
