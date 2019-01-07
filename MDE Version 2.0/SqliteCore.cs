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

        /// <summary>
        /// Stellt Die SqLiteConnection zur verfügung.
        /// </summary>
        /// <returns></returns>
        public SQLiteConnection SqLiteConnection()
        {
            var setting = new Setting();
            var settingModel = setting.Load();

            var con = new SQLiteConnection("Data Source = " + settingModel.SqliteDatabase);

            return con;
        }

        /// <summary>
        /// Stellt Die SqLiteConnection zur verfügung.
        /// </summary>
        /// <param name="databasePath">Der Dateipfad zur Datenbank datei.</param>
        /// <returns></returns>
        private SQLiteConnection SqLiteConnection(string databasePath)
        {
            var con = new SQLiteConnection("Data Source = " + databasePath);

            return con;
        }

        /* Erstellt die Table in der Datenbank und bereite alles vor */
        public void CreateDatabase(string databasePath)
        {
            try
            {
                SQLiteConnection.CreateFile(databasePath);
                var con = SqLiteConnection(databasePath);

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

        public DataTable LoadTable(string databasePath)
        {
            var queryString = "Select * From Erfassung";
            var dataTable = new DataTable();
            var con = SqLiteConnection(databasePath);
            var sqLiteCommand = new SQLiteCommand(queryString, con);

            sqLiteCommand.Connection.Open();
            //var test = sqLiteCommand.ExecuteReader();
            var adapter = new SQLiteDataAdapter(queryString, con);
            adapter.Fill(dataTable);
            sqLiteCommand.Connection.Close();
            return dataTable;

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

        public List<SqliteCollectionModel> LoadViewEntry()
        {
            var queryString = "Select Artikel_ID, Artikelbez, Fabrikat, Anzahl, EAN, Warenbereich, Name From Erfassung";
            var dataTable = new DataTable();
            var con = SqLiteConnection();
            var sqLiteCommand = new SQLiteCommand(queryString, con);

            var listesqliteErfassungsModels = new List<SqliteCollectionModel>();
            try
            {
                using (sqLiteCommand)
                {
                    sqLiteCommand.Connection.Open();
                    SQLiteDataReader dataReader = sqLiteCommand.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var model = new SqliteCollectionModel
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


        public List<SqliteCollectionModel> NewEntry(DataCollectionmodel dataCollectionmodel)
        {
            var Insertcommand =
                "INSERT INTO Erfassung (Fabrikat, Artikelbez, EAN, Anzahl, Warenbereich, WarenbereichID, Name, Erfassungszeit) VALUES (@Fabrikat, @Artikelbez, @EAN, @Anzahl, @Warenbereich, @WarenbereichID, @Name, @Erfassungszeit)";

            var sqliteCommand = new SQLiteCommand();

            using (sqliteCommand)
            {
                sqliteCommand.Connection = SqLiteConnection();
                sqliteCommand.Connection.Open();
                sqliteCommand.CommandText = Insertcommand;
                sqliteCommand.Parameters.AddWithValue("@Fabrikat", dataCollectionmodel.Fabrikat);
                sqliteCommand.Parameters.AddWithValue("@Artikelbez",
                    dataCollectionmodel.Artikelbezeichnung);
                sqliteCommand.Parameters.AddWithValue("@EAN", dataCollectionmodel.EAN);
                sqliteCommand.Parameters.AddWithValue("@Anzahl", dataCollectionmodel.Anzahl);
                sqliteCommand.Parameters.AddWithValue("@Warenbereich", dataCollectionmodel.Warenbereich);
                sqliteCommand.Parameters.AddWithValue("@WarenbereichID",
                    dataCollectionmodel.WarenbereichId);
                sqliteCommand.Parameters.AddWithValue("@Name", dataCollectionmodel.ZeahlerName);
                sqliteCommand.Parameters.AddWithValue("@Erfassungszeit",
                    dataCollectionmodel.ErfassungsZeit);
                var result = sqliteCommand.ExecuteNonQuery();
                sqliteCommand.Connection.Close();
                return LoadViewEntry();
            }
        }


        public void EditEntry(SqliteCollectionModel sqliteCollectionModel)
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
                    command.Parameters.AddWithValue("@Anzahl", sqliteCollectionModel.Anzahl);
                    command.Parameters.AddWithValue("@Artikel_ID", sqliteCollectionModel.Artikel_ID);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                
            }
        }

        internal void DeleteEntry(SqliteCollectionModel sqliteCollectionModel)
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
                    command.Parameters.AddWithValue("@Artikel_ID", sqliteCollectionModel.Artikel_ID);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                
            }
        }
    }
}