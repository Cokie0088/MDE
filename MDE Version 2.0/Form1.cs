﻿using System;
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
            try
            {
            var erfassung = new Erfassung();
            DT = erfassung.LoadEntry();
            dataGridView1.DataSource = DT;
            }
            catch (Exception exception)
            {

                MessageBox.Show("Es wurde keine SQL-Lite Databank gefunden. Bitte unter Datei/Einstellungen -> SQL-Lite Karteireiter eine Datenbank auswählen oder erstellen.", "Keine Datenbank gefunden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            

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
                        MessageBox.Show("Verbindung zum Server konnte nicht Hergestellt werden evtl. sind die Einstellungen Fehlerhaft. Bitte Korrigieren.", "Fehler", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    
                }
            }
        }

        private void Datenerfassung_DatenerfassungEvent(Datenerfassungmodel obj)
        {
            if (obj.HasEntry)
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

        private void Anzahl_NewEntryEvent(DataTable obj)
        {
            dataGridView1.DataSource = obj;
        }

        //private void Anzahl_EingabemodelEvent(EingabeModel obj)
        //{

        //}

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

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            try
            {
                var sqliteCore = new SqliteCore();
                sqliteCore.EditEntry(DT);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}