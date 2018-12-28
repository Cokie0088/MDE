using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing.Printing;

namespace MDE_Version_2._0
{
    internal class SqliteCore
    {
        //public event Action<>
        private string createTable =
            "CREATE TABLE Erfassung(Artikel_ID INTEGER PRIMARY KEY AUTOINCREMENT, Fabrikat TEXT, Artikelbez TEXT, EAN TEXT, Anzahl INTEGER, Warenbereich TEXT, WarenbereichID INTEGER, Name TEXT NOT NULL, Erfassungszeit TEXT NOT NULL)";


        public SQLiteConnection SqLiteConnection()
        {
            var setting = new Setting();
            var settingModel = setting.Load();

            var con = new SQLiteConnection("Data Source = " + settingModel.SqliteDatabase);

            return con;
        }

        private SQLiteConnection SqLiteConnection(string DatabasePath)
        {
            var con = new SQLiteConnection("Data Source = " + DatabasePath);

            return con;
        }

        /* Erstellt die Table in der Datenbank und bereite alles vor */
        public void CreateDatabase(string DatabasePath)
        {
            try
            {
                SQLiteConnection.CreateFile(DatabasePath);
                var con = SqLiteConnection(DatabasePath);

                con.Open();
                var command = new SQLiteCommand(createTable, con);
                command.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable LoadTable()
        {
            var queryString = "Select * From Erfassung";
            var dataTable = new DataTable();
            var con = SqLiteConnection();
            var sqLiteCommand = new SQLiteCommand(queryString, con);

            sqLiteCommand.Connection.Open();
            //var test = sqLiteCommand.ExecuteReader();
            var adapter = new SQLiteDataAdapter(queryString, con);
            adapter.Fill(dataTable);
            sqLiteCommand.Connection.Close();
            return dataTable;
        }

        public DataTable LoadViewEntry()
        {
            var queryString = "Select Artikel_ID, Artikelbez, Fabrikat, Anzahl, EAN, Warenbereich From Erfassung";
            var dataTable = new DataTable();
            var con = SqLiteConnection();
            var sqLiteCommand = new SQLiteCommand(queryString, con);
            try
            {
            var adapter = new SQLiteDataAdapter(queryString, con);
                using (adapter)
                {
                    adapter.Fill(dataTable);

                }

            }
            catch (Exception)
            {
                throw;
            }
          
            return dataTable;
        }
    

        public DataTable NewEntry(Datenerfassungmodel datenerfassungmodel)
        {
          
            var Insertcommand =
                "INSERT INTO Erfassung (Fabrikat, Artikelbez, EAN, Anzahl, Warenbereich, WarenbereichID, Name, Erfassungszeit) VALUES (@Fabrikat, @Artikelbez, @EAN, @Anzahl, @Warenbereich, @WarenbereichID, @Name, @Erfassungszeit)";

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
                return LoadTable();
            }
        }


        public void EditEntry(DataTable dataTable)
        {
            try
            {
            var sqLiteDataAdapter = new SQLiteDataAdapter("Select Artikel_ID, Anzahl From Erfassung", SqLiteConnection());

            var commandbuilder = new SQLiteCommandBuilder
            {
                DataAdapter = sqLiteDataAdapter
            };
            sqLiteDataAdapter.UpdateCommand = commandbuilder.GetUpdateCommand();
            sqLiteDataAdapter.Update(dataTable);
            }
            catch (Exception)
            {

                throw;
            }
           

            

        }
    }
}