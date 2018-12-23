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
        private string createTable =
            "CREATE TABLE Erfassung(Artikel_ID INTEGER PRIMARY KEY AUTOINCREMENT, Fabrikat TEXT, Artikelbez TEXT, EAN TEXT, Anzahl INTEGER, Warenbereich TEXT, WarenbereichID INTEGER, Name TEXT NOT NULL, Erfassungszeit INTEGER NOT NULL)";

        private string connectionstring = "C:\\temp\\Database.db";

        public SQLiteConnection SqLiteConnection()
        {
            var con = new SQLiteConnection("Data Source = " + connectionstring);
            LoadTable(con);
            return null;
        }


        /* Erstellt die Table in der Datenbank und bereite alles vor */
        public void CreateTable(SQLiteConnection sqLiteConnection)
        {
            SQLiteConnection.CreateFile(connectionstring);

            sqLiteConnection.Open();
            var command = new SQLiteCommand(createTable, sqLiteConnection);
            command.ExecuteNonQuery();
            sqLiteConnection.Close();
        }

        public void LoadTable(SQLiteConnection sqLiteConnection)
        {
            string queryString = "Select * From Erfassung";

            var sqLiteCommand = new SQLiteCommand(queryString, sqLiteConnection);

            sqLiteCommand.Connection.Open();
            //var test = sqLiteCommand.ExecuteReader();
            var adapter = new SQLiteDataAdapter(queryString, sqLiteConnection);
            //sqLiteCommand.Connection.Close();
            
        }
    }
}