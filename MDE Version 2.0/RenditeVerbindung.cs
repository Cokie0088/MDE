using System.Data.SqlClient;


namespace MDE_Version_2._0
{
    class RenditeVerbindung
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
            var sqlConnStringBuilder = new SqlConnectionStringBuilder
            {
                
                DataSource = settingModel.IpAdresse,
                InitialCatalog = settingModel.Database,
                UserID = settingModel.UserName,
                Password = settingModel.Password
            };

            sqlconnection.ConnectionString = sqlConnStringBuilder.ConnectionString;
            return sqlconnection;


        }


    }
    
}
