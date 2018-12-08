using System.Data;
namespace MDE_Version_2._0
{
    public class Datenerfassung
    {

        public DataTable Erfassung(EingabeModel eingabemodel)
        {
            RenditeAbfrage renditeabfrage = new RenditeAbfrage();
            var entity = renditeabfrage.RenditeAbfragen(eingabemodel.AbfrageString);
            var datenerfassungmodel = new Datenerfassungmodel();

            datenerfassungmodel.Fabrikat = entity[0].Fabrikat;
            datenerfassungmodel.Artikelbezeichnung = entity[0].Artikelbezeichnung;
            datenerfassungmodel.EAN = entity[0].EAN;
            datenerfassungmodel.Warenbereich = entity[0].Geschaeftsbereich;
            datenerfassungmodel.WarenbereichID = entity[0].GeschaeftsbereichID;
            datenerfassungmodel.Name = eingabemodel.ZeahlerName;
            
            //DataTable DT = new DataTable();

            //DT.Columns.Add("Fabrikat");
            //DT.Columns.Add("Artikelbez");
            //DT.Columns.Add("EAN");
            //DT.Columns.Add("Warenbereich");
            //DT.Columns.Add("WarenbereichID");
            //DT.Columns.Add("Name");
            //DT.Columns.Add("Anzahl");

            ///Mappt die Entitys in eine DataTable um.
            foreach (var item in entity)
            {






                //var row = DT.NewRow();

                //row["Fabrikat"] = item.Fabrikat;
                //row["Artikelbez"] = item.Artikelbezeichnung;
                //row["EAN"] = item.EAN;
                //row["Warenbereich"] = item.Geschaeftsbereich;
                //row["WarenbereichID"] = item.GeschaeftsbereichID;
                //row["Name"] = eingabemodel.ZeahlerName;
                //row["Anzahl"] = eingabemodel.Anzahl;



                //DT.Rows.Add(row);
            }
            return DT;
        }
}
}
