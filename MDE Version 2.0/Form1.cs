using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
#if DEBUG
            abfragestringTextBox.Text = "7311271441489";
            ErfasserTextBox.Text = "Test";
#endif


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
                ErfasserTextBox.BackColor = Color.Red;
            }
            else
            {

                var eingabemodel = new EingabeModel
                {
                    AbfrageString = abfragestringTextBox.Text,
                    ZeahlerName = ErfasserTextBox.Text
                };

                if (abfragestringTextBox.Text == "")
                {
                    MessageBox.Show("Nichts eingetragen im Markierten Feld!", "Fehlerhafte eingabe",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    abfragestringTextBox.BackColor = Color.Red;
                }
                else
                {
                    //var anzahl = new Anzahl(eingabemodel);
                    //anzahl.ShowDialog();
                    //anzahl.EingabemodelEvent += Anzahl_EingabemodelEvent;

                    var datenerfassung = new Datenerfassung();
                    datenerfassung.EingabemodelEvent += delegate(Datenerfassungmodel datenerfassungmodel)
                        {
                            var anzahl = new Anzahl(datenerfassungmodel);
                            anzahl.Show();
                        };
                    datenerfassung.Erfassung(eingabemodel);


                }
            }
            


        }

        //private void Anzahl_EingabemodelEvent(EingabeModel obj)
        //{
            
        //}

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEinstellungen einstellungsform = new frmEinstellungen();
            einstellungsform.Show();
        }

        private void abfragestringTextBox_TextChanged(object sender, EventArgs e)
        {
            abfragestringTextBox.BackColor = Color.Empty;
        }

        private void ErfasserTextBox_TextChanged(object sender, EventArgs e)
        {
            ErfasserTextBox.BackColor = Color.Empty;
        }
    }
}
