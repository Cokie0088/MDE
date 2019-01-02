using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;


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

        public List<SqliteErfassungsModel> LoadViewEntry()
        {
            var queryString = "Select Artikel_ID, Artikelbez, Fabrikat, Anzahl, EAN, Warenbereich, Name From Erfassung";
            var dataTable = new DataTable();
            var con = SqLiteConnection();
            var sqLiteCommand = new SQLiteCommand(queryString, con);

            var listesqliteErfassungsModels = new List<SqliteErfassungsModel>();
            try
            {
                using (sqLiteCommand)
                {
                    sqLiteCommand.Connection.Open();
                    SQLiteDataReader dataReader = sqLiteCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var model = new SqliteErfassungsModel
                        {
                            Artikel_ID = dataReader.GetInt32(0),
                            Artikelbezeichnung = dataReader.GetString(1),
                            Fabrikat = dataReader.GetString(2),
                            Anzahl = dataReader.GetInt32(3),
                            EAN = dataReader.GetString(4),
                            Warenbereich = dataReader.GetString(5),
                            Name = dataReader.GetString(6)
                        };
                        listesqliteErfassungsModels.Add(model);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqLiteCommand.Connection.Close();
            }

            return listesqliteErfassungsModels;
        }


        public List<SqliteErfassungsModel> NewEntry(Datenerfassungmodel datenerfassungmodel)
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
                return LoadViewEntry();
            }
        }


        public void EditEntry(SqliteErfassungsModel sqliteErfassungsModel)
        {
            var command = new SQLiteCommand
            {
                CommandText = "UPDATE Erfassung SET Anzahl = @Anzahl WHERE Artikel_ID = @Artikel_ID",
                Connection = SqLiteConnection(),
                Parameters = {new SQLiteParameter()}
            };

            try
            {
                using (command)
                {
                    command.Connection.Open();
                    command.Parameters.AddWithValue("@Anzahl", sqliteErfassungsModel.Anzahl);
                    command.Parameters.AddWithValue("@Artikel_ID", sqliteErfassungsModel.Artikel_ID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Connection.Close();
            }
        }

        internal void DeleteEntry(SqliteErfassungsModel sqliteErfassungsModel)
        {
            var command = new SQLiteCommand
            {
                CommandText = "DELETE FROM Erfassung WHERE Artikel_ID = @Artikel_ID",
                Connection = SqLiteConnection(),
                Parameters = {new SQLiteParameter()}
            };
            try
            {
                using (command)
                {
                    command.Parameters.AddWithValue("@Artikel_ID", sqliteErfassungsModel.Artikel_ID);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                throw;
            }
            finally
            {
                command.Connection.Close();
            }
        }
    }
}