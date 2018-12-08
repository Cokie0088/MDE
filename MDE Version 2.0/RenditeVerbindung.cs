using System.Data.SqlClient;

namespace MDE_Version_2._0
{
    class RenditeVerbindung
    {

        /// <summary>
        /// Stellt die Datenbank Verbindung Bereit
        /// </summary>
        /// <returns>Gibt eine Fertig Konfiguriertes SqlConnection Objekt zurück.</returns>
        public virtual SqlConnection datenbankverbindung()
        {
            ///Connection Erstellen
            SqlConnection sqlconnection = new SqlConnection();
            ///Connection String Erstellen
            SqlConnectionStringBuilder SQLConnStringBuilder = new SqlConnectionStringBuilder();
            SQLConnStringBuilder.DataSource = "192.168.5.100";
            SQLConnStringBuilder.InitialCatalog = "Rendite";
            SQLConnStringBuilder.UserID = "sysdba";
            SQLConnStringBuilder.Password = "euronicsadmin";

            sqlconnection.ConnectionString = SQLConnStringBuilder.ConnectionString;
            return sqlconnection;


        }


    }
}
