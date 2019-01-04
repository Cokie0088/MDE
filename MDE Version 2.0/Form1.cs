using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MDE_Version_2._0.Properties;

namespace MDE_Version_2._0
{
    public partial class MainForm : Form
    {
        private readonly BindingSource _bs = new BindingSource();
        private List<SqliteCollectionModel> _erfassungsModels;


        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            DatumtoolStripStatusLabel.Text = DateTime.Now.ToLongDateString();
#if DEBUG
            abfragestringTextBox.Text = "7311271441489";
            ErfasserTextBox.Text = "Test";
#endif

            LoadData();
        }

        private void Erfassungbutton_Click(object sender, EventArgs e)
        {
            if (ErfasserTextBox.Text == "")
            {
                MessageBox.Show("Bitte Zähler Namen eingeben!", "Bitte Zähler Namen eingeben!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ErfasserTextBox.Focus();
                ErfasserTextBox.BackColor = Color.Red;
            }
            else
            {
                if (abfragestringTextBox.Text == "")
                {
                    MessageBox.Show("Nichts eingetragen im Markierten Feld!", "Fehlerhafte eingabe",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    abfragestringTextBox.BackColor = Color.Red;
                }
                else
                {
                    var eingabemodel = new EingabeModel
                    {
                        AbfrageString = abfragestringTextBox.Text,
                        ZeahlerName = ErfasserTextBox.Text
                    };

                    var datenerfassung = new Datenerfassung();

                    datenerfassung.DatenerfassungEvent += Datenerfassung_DatenerfassungEvent;
                    try
                    {
                        datenerfassung.Erfassung(eingabemodel);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show(
                            "Verbindung zum Server konnte nicht Hergestellt werden evtl. sind die Einstellungen Fehlerhaft. Bitte Korrigieren.",
                            "Fehler", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Datenerfassung_DatenerfassungEvent(DataCollectionmodel obj)
        {
            if (obj != null)
            {
                obj.ZeahlerName = ErfasserTextBox.Text;

                var anzahl = new Anzahl(obj);
                anzahl.NewEntryEvent += Anzahl_NewEntryEvent;
                anzahl.Show();
            }
            else
            {
                MessageBox.Show("Nichts gefunden!", "Nichts Da!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Anzahl_NewEntryEvent(List<SqliteCollectionModel> obj)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var erfassung = new Erfassung();
                _erfassungsModels = erfassung.LoadEntry();

                _bs.DataSource = _erfassungsModels;
                dataGridView1.DataSource = _bs;
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Es wurde keine SQL-Lite Databank gefunden. Bitte unter Datei/Einstellungen -> SQL-Lite Karteireiter eine Datenbank auswählen oder erstellen.",
                    "Keine Datenbank gefunden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void EinstellungenToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void createDatabaseSQLiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sqlitecore = new SqliteCore();
            sqlitecore.SqLiteConnection();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1) return;
            var sqlitecore = new SqliteCore();
            sqlitecore.EditEntry((SqliteCollectionModel) _bs.Current);
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var sqlitecore = new SqliteCore();
            sqlitecore.DeleteEntry((SqliteCollectionModel) _bs.Current);
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (!int.TryParse(e.FormattedValue.ToString(), out int result))
            {
                MessageBox.Show(Properties.Resources.Bitte_eine_gültig_Zahl_eingeben,
                    Properties.Resources.Fehlerhafte_eingabe, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }

            if (Convert.ToInt32(e.FormattedValue) <= 1000) return;
            var messageboxresult = MessageBox.Show(Resources.Anzahl_groesser_1000,
                Resources.Anzahl_bitte_Prüfen, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (messageboxresult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}