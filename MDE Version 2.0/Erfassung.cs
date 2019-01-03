using System;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;

//using System.Data.SqlClient;


namespace MDE_Version_2._0
{
    internal class Erfassung
    {


        public List<SqliteCollectionModel> NewEntry(DataCollectionmodel dataCollectionmodel)
        {
            var sqliteCore = new SqliteCore();
            return sqliteCore.NewEntry(dataCollectionmodel);

        }

        public void EditEntry(SqliteCollectionModel sqliteCollectionModel)
        {
            try
            {
            var sqliteCore = new  SqliteCore();
            sqliteCore.EditEntry(sqliteCollectionModel);
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        public List<SqliteCollectionModel> LoadEntry()
        {
            try
            {
            var sqliteCore = new SqliteCore();
            return sqliteCore.LoadViewEntry();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        internal void DeleteEntry(SqliteCollectionModel sqliteCollectionModel)
        {
            try
            {
                var sqliteCore = new SqliteCore();
                sqliteCore.DeleteEntry(sqliteCollectionModel);
            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}
