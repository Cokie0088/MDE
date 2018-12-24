using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MDE_Version_2._0
{
    public class Datenerfassung
    {
        public event Action<Datenerfassungmodel> DatenerfassungEvent;

        public void Erfassung(EingabeModel eingabemodel)
        {
            var renditeabfrage = new RenditeAbfrage();
            var renditeModel = renditeabfrage.RenditeAbfragen(eingabemodel.AbfrageString);
            

            /* Wenn nichts in der Abfrage gefunden wurde wird ein null objekt zurückgegeben.
             Ansonsten wird geschaut ob mehr als 1 Artikel gefunden wurde und dies in einem Fenster
             angzeigt */
            if (renditeModel.Count <= 0)
            {
                OnDatenerfassungEvent(new Datenerfassungmodel());
                return;

            }
            else if (renditeModel.Count > 1)
            {
                var artikelauswahl = new Artikelauswahl {RenditeModel = renditeModel.ToList()};
                artikelauswahl.Show();
                
                return;
            }
            else
            {
                var datenerfassungmodel = new Datenerfassungmodel
                {
                    Fabrikat = renditeModel[0].Fabrikat,
                    Artikelbezeichnung = renditeModel[0].Artikelbezeichnung,
                    EAN = renditeModel[0].EAN,
                    Warenbereich = renditeModel[0].Geschaeftsbereich,
                    WarenbereichId = Convert.ToInt32(renditeModel[0].GeschaeftsbereichID)
                };
                OnDatenerfassungEvent(datenerfassungmodel);
                return;
            }

           

            //DataTable DT = new DataTable();

            //DT.Columns.Add("Fabrikat");
            //DT.Columns.Add("Artikelbez");
            //DT.Columns.Add("EAN");
            //DT.Columns.Add("Warenbereich");
            //DT.Columns.Add("WarenbereichID");
            //DT.Columns.Add("Name");
            //DT.Columns.Add("Anzahl");

            ///Mappt die Entitys in eine DataTable um.
            //foreach (var item in entity)
            //{

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

        protected virtual void OnDatenerfassungEvent(Datenerfassungmodel obj)
        {
            DatenerfassungEvent?.Invoke(obj);
            
        }
    }
}

