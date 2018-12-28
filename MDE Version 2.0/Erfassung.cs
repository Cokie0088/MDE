using System;
using System.Text;
using System.Data;
using System.Data.SQLite;

//using System.Data.SqlClient;


namespace MDE_Version_2._0
{
    internal class Erfassung
    {


        public DataTable Erfassen(Datenerfassungmodel datenerfassungmodel)
        {
            var sqliteCore = new SqliteCore();
            return sqliteCore.NewEntry(datenerfassungmodel);

        }

        public void EditEntry(DataTable dataTable)
        {
            try
            {
            var sqliteCore = new  SqliteCore();
            sqliteCore.EditEntry(dataTable);
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        public DataTable LoadEntry()
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

        

    }
}
