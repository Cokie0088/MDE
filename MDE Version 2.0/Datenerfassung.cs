using System.Data;
namespace MDE_Version_2._0
{
    public class Datenerfassung
    {
        public Datenerfassung(EingabeModel eingabemodel)
        {
            RenditeAbfrage renditeabfrage = new RenditeAbfrage();
            var entity = renditeabfrage.RenditeAbfragen(eingabemodel.AbfrageString);
            DataTable DT = new DataTable();

            DT.Columns.Add("Fabrikat");
            DT.Columns.Add("Artikelbez");
            DT.Columns.Add("EAN");
            DT.Columns.Add("Warenbereich");
            DT.Columns.Add("WarenbereichID");
            DT.Columns.Add("Name");
            DT.Columns.Add("Anzahl");

            ///Mappt die Entitys in eine DataTable um.
            foreach (var item in entity)
            {


                var row = DT.NewRow();

                row["Fabrikat"] = item.Fabrikat;
                row["Artikelbez"] = item.Artikelbezeichnung;
                row["EAN"] = item.EAN;
                row["Warenbereich"] = item.Geschaeftsbereich;
                row["WarenbereichID"] = item.GeschaeftsbereichID;
                row["Name"] = eingabemodel.ZeahlerName;
                row["Anzahl"] = eingabemodel.Anzahl;



                DT.Rows.Add(row);
            }
        }
}
}
