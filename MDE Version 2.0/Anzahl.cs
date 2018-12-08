using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDE_Version_2._0
{
    public partial class Anzahl : Form
    {

        public event Action<EingabeModel> EingabemodelEvent;

        public EingabeModel eingabemodel { get; set; }
        public RenditeModel renditeentity { get; set; }

        public Anzahl()
        {
            InitializeComponent();
        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            eingabemodel.Anzahl = Convert.ToInt32(AnzahltextBox.Text);
            if (EingabemodelEvent != null)
            {
                EingabemodelEvent(eingabemodel);
            }
        }
    }
}
