using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace MDE_Version_2._0
{
    internal class RenditeAbfrage
    {
        private readonly string _renditeEanQuery = Properties.Resources.RenditeEANAbfrageString;
        private readonly string _renditeArtikelAbfrageString = "SELECT eannummern.ean, eannummern.artnr, ARTSTAMM.ARTBEZ, GBEREICHE.GBEREICH, GBEREICHE.BEZ, FABRIKAT.FABRIKAT FROM ARTSTAMM INNER JOIN gruppen ON ARTSTAMM.GRUPPE = gruppen.GRUPPE INNER JOIN UNTERGRUPPEN ON gruppen.UNTERGRUPPE = UNTERGRUPPEN.UNTERGRUPPE INNER JOIN OBERGRUPPEN ON UNTERGRUPPEN.OBERGRUPPE = OBERGRUPPEN.OBERGRUPPE INNER JOIN GBEREICHE ON OBERGRUPPEN.GBEREICH = GBEREICHE.GBEREICH INNER JOIN eannummern ON ARTSTAMM.ARTNR = eannummern.artnr INNER JOIN FABRIKAT ON ARTSTAMM.FABRIKAT = FABRIKAT.FABRIKAT WHERE ARTSTAMM.ARTBEZ Like @Artikel AND FABRIKAT.FABRIKAT Like @Fabrikat";

        public List<RenditeModel> RenditeAbfragen(string abfrageString)
        {

            /*Sqlcommand erstellen*/
            var sqlcommand = new SqlCommand();
            var datenbankverbindung = new RenditeVerbindung();

            /*Erstellt das Sqlcommand Objekt und Richtet es gleich ein.*/
            sqlcommand.Connection = datenbankverbindung.Datenbankverbindung();

            /*Prüft an der stelle ob es sich um eine EAN handelt.*/
            if (long.TryParse(abfrageString, out var ean))
            {
                //var SQLparamenterEan = new SqlParameter("@AbfrageString", AbfrageString);
                sqlcommand.Parameters.AddWithValue("@AbfrageString", abfrageString);
                sqlcommand.CommandText = _renditeEanQuery;

            }
            else
            {
                var split = abfrageString.Split(',');
                sqlcommand.Parameters.AddWithValue("@Fabrikat", "%" + split[0] + "%");
                sqlcommand.Parameters.AddWithValue("@Artikel", "%" + split[1] + "%");
                sqlcommand.CommandText = _renditeArtikelAbfrageString;

            }

            /*Datenbank Abfrage*/
            var sqldataadpater = new SqlDataAdapter(sqlcommand);
            
            //SQLAd.SelectCommand.Parameters.Add(SQLParaEAN);
            
            var datatable = new DataTable();
            sqldataadpater.Fill(datatable);


            return RenditeMapping(datatable);

        }

        private List<RenditeModel> RenditeMapping(DataTable datatable)
        {
                var renditemodel = new List<RenditeModel>();
            if (datatable.Rows.Count <= 0)
            {
                return renditemodel;
            }
            var i = -1; /* Wichtig bei -1 zubeginnen. Zählt bei 0 los ;) */
            foreach (var item in datatable.Rows)
            {
                ++i;
                var model = new RenditeModel
                {
                    Artikelbezeichnung = datatable.Rows[i]["ARTBEZ"].ToString(),
                    Fabrikat = datatable.Rows[i]["FABRIKAT"].ToString(),
                    Geschaeftsbereich = datatable.Rows[i]["BEZ"].ToString(),
                    GeschaeftsbereichID = datatable.Rows[i]["GBEREICH"].ToString(),
                    Artikelnummer = datatable.Rows[i]["artnr"].ToString(),
                    EAN = datatable.Rows[i]["EAN"].ToString()
                };
                renditemodel.Add(model);
            }

            return renditemodel;



        }
     

    }
}
