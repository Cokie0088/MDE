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
            var sqlConnStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "192.168.5.102",
                InitialCatalog = "Rendite",
                UserID = "sysdba",
                Password = "masterkey"
            };

            sqlconnection.ConnectionString = sqlConnStringBuilder.ConnectionString;
            return sqlconnection;


        }


    }
    
}
