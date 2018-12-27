using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace MDE_Version_2._0
{
    internal class RenditeVerbindung
    {
        /// <summary>
        /// Stellt die Datenbank Verbindung Bereit
        /// </summary>
        /// <returns>Gibt eine Fertig Konfiguriertes SqlConnection Objekt zurück.</returns>
        public virtual SqlConnection Datenbankverbindung()
        {
            /* Connection Erstellen */
            var sqlconnection = new SqlConnection();
            /*Connection String Erstellen */
            var setting = new Setting();
            var settingModel = setting.Load();
            if (settingModel == null) return null;
            try
            {
                var sqlConnStringBuilder = new SqlConnectionStringBuilder
                {
                    DataSource = settingModel.IpAdresse,
                    InitialCatalog = settingModel.Database,
                    UserID = settingModel.UserName,
                    Password = settingModel.Password
                };
                sqlconnection.ConnectionString = sqlConnStringBuilder.ConnectionString;
            }
            catch (Exception)
            {
                throw;
            }


            return sqlconnection;

        }
    }
}