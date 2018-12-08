using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MDE_Version_2._0
{
    public partial class Form1 : Form
    {

        DataTable DT = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatumtoolStripStatusLabel.Text = DateTime.Now.ToLongDateString();
            //Access access = new Access();
            //access.Accessdateioeffnen();

            

            BindingSource bindingsource = new BindingSource();
            bindingsource.DataSource = DT;

            //bindingsource.Add(new TestEntitity(1, "ABC", "123", 1));
            //bindingsource.Add(new TestEntitity(2, "def", "456", 2));
            //bindingsource.Add(new TestEntitity(3, "GHI", "789", 3));

            dataGridView1.DataSource = bindingsource;



        }

        private void Erfassungbutton_Click(object sender, EventArgs e)
        {

            if (ErfasserTextBox.Text == "")
            {
                MessageBox.Show("Bitte Zähler Namen eingeben!", "Bitte Zähler Namen eingeben!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErfasserTextBox.Focus();
               
            }
            else
            {

                EingabeModel eingabemodel = new EingabeModel();
                eingabemodel.AbfrageString = abfragestringTextBox.Text;
                eingabemodel.ZeahlerName = ErfasserTextBox.Text;
                
                
                //AccessDatenModel Accessdatenmodel = new AccessDatenModel();
                //Accessdatenmodel.DatenErfassen(eingabemodel);
                Anzahl anzahl = new Anzahl();
                anzahl.eingabemodel = eingabemodel;
                anzahl.
                anzahl.EingabemodelEvent += Anzahl_EingabemodelEvent;
                
            }
            


        }

        private void Anzahl_EingabemodelEvent(EingabeModel obj)
        {
            
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEinstellungen einstellungsform = new frmEinstellungen();
            einstellungsform.Show();
        }
    }
}
