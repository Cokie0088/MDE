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
    public partial class Artikelauswahl : Form
    {
        public List<RenditeModel> RenditeModel { get; set; }
        public event Action<RenditeModel> ProductSelektionEvent;
        BindingSource _bs;

        public Artikelauswahl()
        {
            InitializeComponent();
        }

        private void Artikelauswahl_Load(object sender, EventArgs e)
        {
            _bs = new BindingSource
            {
                DataSource = RenditeModel
            };
            ArtikellistedataGridView.DataSource = _bs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auswahl();
        }


        private void ArtikellistedataGridView_DoubleClick(object sender, EventArgs e)
        {
            Auswahl();
        }

        private void Auswahl()
        {
            if (ArtikellistedataGridView.CurrentRow != null)
            {
                
                Artikelauswahl_ProductSelektion((RenditeModel)_bs.Current));
            }
        }

        private void Artikelauswahl_ProductSelektion(RenditeModel obj)
        {
            ProductSelektionEvent?.Invoke(obj);
        }
    }
}