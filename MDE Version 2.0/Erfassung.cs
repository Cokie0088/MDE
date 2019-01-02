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


        public List<SqliteErfassungsModel> Erfassen(Datenerfassungmodel datenerfassungmodel)
        {
            var sqliteCore = new SqliteCore();
            return sqliteCore.NewEntry(datenerfassungmodel);

        }

        public void EditEntry(SqliteErfassungsModel sqliteErfassungsModel)
        {
            try
            {
            var sqliteCore = new  SqliteCore();
            sqliteCore.EditEntry(sqliteErfassungsModel);
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        public List<SqliteErfassungsModel> LoadEntry()
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

        internal void DeleteEntry(SqliteErfassungsModel sqliteErfassungsModel)
        {
            try
            {
                var sqliteCore = new SqliteCore();
                sqliteCore.DeleteEntry(sqliteErfassungsModel);
            }
            catch (Exception)
            {

                throw;
            }


        }

    }
}
