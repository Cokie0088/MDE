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
            var sqliteCore = new  SqliteCore();
            sqliteCore.EditEntry(dataTable);

        }

        public DataTable LoadEntry()
        {
            var sqliteCore = new SqliteCore();
            return sqliteCore.LoadViewEntry();
        }





        //public DataTable Erfassen(string EAN)
        // {

        //     var dt = new DataTable();
        //     var renditeabfage = new RenditeAbfrage();
        //     renditeabfage.RenditeAbfragen(EAN);
        //     var access = new AccessErfassung();
        //     access.Accessdateischreiben(dt);
        //     return dt;

        // }



    }
}
