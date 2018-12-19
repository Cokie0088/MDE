using System;
using System.Text;
using System.Data;
using System.Data.SQLite;

//using System.Data.SqlClient;


namespace MDE_Version_2._0
{
    internal class Erfassung
    {


        public void Erfassen(Datenerfassungmodel datenerfassungmodel)
        {
            var sqlitecon = new SqliteCore();
           

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
