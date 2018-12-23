using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MDE_Version_2._0
{
    internal class Setting
    {
        private string Path = Environment.CurrentDirectory + "Config.xml";
        public void Save(SettingModel settingModel)
        {
            try
            {
                var doc = new XDocument(
                    new XElement("MDE-Settings",
                        new XElement("IpAdress", settingModel.IpAdresse),
                        new XElement("Database", settingModel.Database),
                        new XElement("Creditals", settingModel.Creditals),
                        new XElement("UserName", settingModel.UserName),
                        new XElement("Password", settingModel.Password)));
                doc.Save(Path);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Fehler" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        public SettingModel Load()
        {

            try
            {
                var doc = XDocument.Load(Path);
                var q = from b in doc.Descendants("MDE-Settings")
                select new SettingModel()
                {
                    Password = b.Element("Password")?.Value,
                    IpAdresse = b.Element("IpAdress")?.Value,
                    Creditals = Convert.ToBoolean(b.Element("Creditals")?.Value),
                    UserName = b.Element("UserName")?.Value,
                    Database = b.Element("Database")?.Value
                };
                return q.First();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new SettingModel();
            }
            
           

            


        }
    }
}
