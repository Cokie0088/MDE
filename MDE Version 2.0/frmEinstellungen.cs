using System;
using System.Windows.Forms;


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
            var setting = new Setting();
            var settingModel = new SettingModel
            {
                Database = RenditeDatenbankTextBox.Text,
                IpAdresse = SQLServerTextBox.Text,
                Creditals = DBSaveCheckBox.Checked,
                Password = DatenbankPasswortTextBox.Text,
                UserName = DatenbankBenutzerTextBox.Text
            };
            setting.Save(settingModel);


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
            if (result == DialogResult.OK)
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
            var setting = new Setting();
            var settingModel = setting.Load();

            RenditeDatenbankTextBox.Text = settingModel.Database;
            SQLServerTextBox.Text = settingModel.IpAdresse;
            DBSaveCheckBox.Checked = settingModel.Creditals;
            DatenbankPasswortTextBox.Text = settingModel.Password;
            DatenbankBenutzerTextBox.Text = settingModel.UserName;
        }
    }
}