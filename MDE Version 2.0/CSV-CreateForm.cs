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
    public partial class CSV_CreateForm : Form
    {
        public CSV_CreateForm()
        {
            InitializeComponent();
        }

        private void SelectFilesbutton_Click(object sender, EventArgs e)
        {
            var openfiledialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Datenbank Dateien (*.db)| *.db"
                
            };
            openfiledialog.ShowDialog();
            var result = openfiledialog.FileNames;
            var csvCreate = new CSV_Create();
            csvCreate.Create(result);

        }

        }
}
