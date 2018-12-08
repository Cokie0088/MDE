using System;
using System.Windows.Forms;
using Settings;



namespace MDE_Version_2._0
{
    public partial class frmEinstellungen : Form
    {
        public frmEinstellungen()
        {
            InitializeComponent();
        }

        string Accessdatenbankpfad;
        string Dateifilter = "Access datei(*.mdb)|*.mdb";

        private void BtSettingsSave_Click(object sender, EventArgs e)
        {

            Einstellungen einstellungen = new Einstellungen("settings.cfg");
            einstellungen.Items["RenditeDatenbank"] = RenditeDatenbankTextBox.Text;
            einstellungen.Items["RenditeServer"] = SQLServerTextBox.Text;
            einstellungen.Items["Passwort"] = DatenbankPasswortTextBox.Text;
            einstellungen.Items["Benutzer"] = DatenbankBenutzerTextBox.Text;
            einstellungen.Items["Sicherdatenbank"] = DBSaveCheckBox.Checked;
            einstellungen.Items["AccessDatei"] = Accessdatenbankpfad;
            einstellungen.SaveWriter();
            Close();

    }

        private void AccessOeffnenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Filter = Dateifilter;
            DialogResult result = openfiledialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Accessdatenbankpfad = openfiledialog.FileName;
                AccessDatenbankTextBox.Text = Accessdatenbankpfad;
            }
        }

        private void ErstellenButton_Click(object sender, EventArgs e)
        {
            AccessErfassung access = new AccessErfassung();
            SaveFileDialog savefiledialog = new SaveFileDialog();
            savefiledialog.Filter = Dateifilter;
            var result = savefiledialog.ShowDialog();
            if (result == DialogResult.OK )
            {
                Accessdatenbankpfad = savefiledialog.FileName;
                access.ErfassungsDateiErstellen(Accessdatenbankpfad);
                AccessDatenbankTextBox.Text = Accessdatenbankpfad;
            }
        }

        private void BtAbort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmEinstellungen_Load(object sender, EventArgs e)
        {
            Einstellungen einstellungen = new Einstellungen("settings.cfg");
            einstellungen.LoadReader();
            AccessDatenbankTextBox.Text = (string)einstellungen.Items["AccessDatei"];
            RenditeDatenbankTextBox.Text = (string)einstellungen.Items["RenditeDatenbank"];
            SQLServerTextBox.Text = (string)einstellungen.Items["RenditeServer"];
            DatenbankPasswortTextBox.Text = (string)einstellungen.Items["Passwort"];
            DatenbankBenutzerTextBox.Text = (string)einstellungen.Items["Benutzer"];
            DBSaveCheckBox.Checked = Convert.ToBoolean(einstellungen.Items["Sicherdatenbank"]); 
            Accessdatenbankpfad = (string)einstellungen.Items["AccessDatei"];
         }
    }
}
