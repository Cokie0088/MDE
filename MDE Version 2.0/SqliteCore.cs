using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace MDE_Version_2._0
{
    internal class SqliteCore
    {
        //public event Action<>
        private string createTable =
            "CREATE TABLE Erfassung(Artikel_ID INTEGER PRIMARY KEY AUTOINCREMENT, Fabrikat TEXT, Artikelbez TEXT, EAN TEXT, Anzahl INTEGER, Warenbereich TEXT, WarenbereichID INTEGER, Name TEXT NOT NULL, Erfassungszeit REAL NOT NULL)";

        private readonly string _connectionstring = "C:\\temp\\Database.db";

        public SQLiteConnection SqLiteConnection()
        {
            
            var con = new SQLiteConnection("Data Source = " + _connectionstring);
            
            return con;
        }


        /* Erstellt die Table in der Datenbank und bereite alles vor */
        public void CreateDatabase(string DatabasePath)
        {
            
            SQLiteConnection.CreateFile(DatabasePath);

            //sqliteConnection.Open();
            //var command = new SQLiteCommand(createTable, sqliteConnection);
            //command.ExecuteNonQuery();
            //sqliteConnection.Close();
        }

        public void LoadTable(SQLiteConnection sqLiteConnection)
        {
            var queryString = "Select * From Erfassung";

            var sqLiteCommand = new SQLiteCommand(queryString, sqLiteConnection);

            sqLiteCommand.Connection.Open();
            //var test = sqLiteCommand.ExecuteReader();
            var adapter = new SQLiteDataAdapter(queryString, sqLiteConnection);
            //sqLiteCommand.Connection.Close();
            
        }

        public void SaveTable(Datenerfassungmodel datenerfassungmodel)
        {
            var dt = ConvertModelToDataTable(datenerfassungmodel);
            var Insertcommand =
                "INSERT INTO Erfassung (Fabrikat, Artikelbez, EAN, Anzahl, Warenbereich, Name, Erfassungszeit) VALUES (@Fabrikat, @Artikelbez, @EAN, @Anzahl, @WarenbereichID, @Name, @Erfassungszeit)";

            var sqliteCommand = new SQLiteCommand();
            
            using (sqliteCommand)
            {
                sqliteCommand.Connection = SqLiteConnection();
                sqliteCommand.Connection.Open();
                sqliteCommand.CommandText = Insertcommand;
            sqliteCommand.Parameters.AddWithValue("@Fabrikat", datenerfassungmodel.Fabrikat);
            sqliteCommand.Parameters.AddWithValue("@Artikelbez",
                datenerfassungmodel.Artikelbezeichnung);
            sqliteCommand.Parameters.AddWithValue("@EAN", datenerfassungmodel.EAN);
            sqliteCommand.Parameters.AddWithValue("@Anzahl", datenerfassungmodel.Anzahl);
            sqliteCommand.Parameters.AddWithValue("@Warenbereich", datenerfassungmodel.Warenbereich);
            sqliteCommand.Parameters.AddWithValue("@WarenbereichID",
                datenerfassungmodel.WarenbereichId);
            sqliteCommand.Parameters.AddWithValue("@Name", datenerfassungmodel.ZeahlerName);
            sqliteCommand.Parameters.AddWithValue("@Erfassungszeit",
                datenerfassungmodel.ErfassungsZeit);
            var result = sqliteCommand.ExecuteNonQuery(); 
                sqliteCommand.Connection.Close();
            }
           
        }


        private DataTable ConvertModelToDataTable(Datenerfassungmodel dataDatenerfassungmodel)
        {
            return null;
        }
    }
}