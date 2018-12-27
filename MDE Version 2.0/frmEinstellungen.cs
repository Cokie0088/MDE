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

      
        private string Dateifilter = "Sqlite Datenbank(*.db)|*.db";
        private string Filename;

        private void BtSettingsSave_Click(object sender, EventArgs e)
        {
            var setting = new Setting();
            var settingModel = new SettingModel
            {
                Database = RenditeDatenbankTextBox.Text,
                IpAdresse = SQLServerTextBox.Text,
                Creditals = DBSaveCheckBox.Checked,
                Password = DatenbankPasswortTextBox.Text,
                UserName = DatenbankBenutzerTextBox.Text,
                SqliteDatabase = Filename
                };
            setting.Save(settingModel);


            Close();
        }

        private void AccessOeffnenButton_Click(object sender, EventArgs e)
        {
            var openfiledialog = new OpenFileDialog {Filter = Dateifilter};
            var result = openfiledialog.ShowDialog();
            if (result == DialogResult.OK)
            {

                Filename = openfiledialog.FileName;
                AccessDatenbankTextBox.Text = Filename;
                //Accessdatenbankpfad = openfiledialog.FileName;
                //AccessDatenbankTextBox.Text = Accessdatenbankpfad;
            }
        }

        private void ErstellenButton_Click(object sender, EventArgs e)
        {
            //AccessErfassung access = new AccessErfassung();
            var savefiledialog = new SaveFileDialog {Filter = Dateifilter};
            var result = savefiledialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var sqliteCore = new SqliteCore();
                Filename = savefiledialog.FileName;
                AccessDatenbankTextBox.Text = Filename;
                sqliteCore.CreateDatabase(Filename);
                
               


                //Accessdatenbankpfad = savefiledialog.FileName;
                //access.ErfassungsDateiErstellen(Accessdatenbankpfad);
                //AccessDatenbankTextBox.Text = Accessdatenbankpfad;
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
            AccessDatenbankTextBox.Text = settingModel.SqliteDatabase;

        }
    }
}