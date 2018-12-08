using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace MDE_Version_2._0
{
    class RenditeAbfrage
    {


        string RenditeEANQuery = Properties.Resources.RenditeEANAbfrageString;

        public List<RenditeModel> RenditeAbfragen(string EAN)
        {
            
            ///Sqlparameter Hinzufügen
            SqlParameter SQLparamenterEan = new SqlParameter("@EAN", EAN);

            ///Sqlcommand erstellen
            SqlCommand sqlcommand = new SqlCommand();
            var datenbankverbindung = new RenditeVerbindung();
            ///Erstellt das Sqlcommand Objekt und Richtet es gleich ein.
            sqlcommand.Connection = datenbankverbindung.datenbankverbindung();
            sqlcommand.Parameters.AddWithValue("@EAN", EAN);
            sqlcommand.CommandText = RenditeEANQuery;

            ///Datenbank Abfrage
            SqlDataAdapter sqldataadpater = new SqlDataAdapter(sqlcommand);
            
            //SQLAd.SelectCommand.Parameters.Add(SQLParaEAN);
            
            DataTable datatable = new DataTable();
            sqldataadpater.Fill(datatable);


            return RenditeMapping(datatable);

        }

        private List<RenditeModel> RenditeMapping(DataTable datatable)
        {
                List<RenditeModel> renditemodel = new List<RenditeModel>();
            if (datatable.Rows.Count <= 0)
            {
                return renditemodel;
            }
            
            foreach (var item in datatable.Rows)
            {
                RenditeModel model = new RenditeModel();
                model.Artikelbezeichnung = datatable.Rows[0]["ARTBEZ"].ToString();
                model.Fabrikat = datatable.Rows[0]["FABRIKAT"].ToString();
                model.Geschaeftsbereich = datatable.Rows[0]["BEZ"].ToString();
                model.GeschaeftsbereichID = datatable.Rows[0]["GBEREICH"].ToString();
                model.Artikelnummer = datatable.Rows[0]["artnr"].ToString();
                model.EAN = datatable.Rows[0]["EAN"].ToString();
                renditemodel.Add(model);
            }

            return renditemodel;



        }
     

    }
}
