using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MDE_Version_2._0
{
    class Erfassung
    {


       public DataTable Erfassen(string EAN)
        {

            DataTable DT = new DataTable();
            var renditeabfage = new RenditeAbfrage();
            renditeabfage.RenditeAbfragen(EAN);
            var access = new AccessErfassung();
            access.Accessdateischreiben(DT);
            return DT;

        }



    }
}
