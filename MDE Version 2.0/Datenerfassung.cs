using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MDE_Version_2._0
{
    public class Datenerfassung
    {
        public event Action<DataCollectionmodel> DatenerfassungEvent;
        /// <summary>
        /// Fragt die Daten vom WWS ab und Konvertiert sie ins Datacolletion Model.
        /// Lösst das Event "DatenerfassungsEvent" aus.
        /// </summary>
        /// <param name="eingabemodel">Das eingabe Model was die WWS Abfrage Parameter enthält.</param>
        public void Erfassung(EingabeModel eingabemodel)
        {
            var renditeabfrage = new RenditeAbfrage();
            var renditeModel = renditeabfrage.RenditeAbfragen(eingabemodel.AbfrageString);
            

            /* Wenn nichts in der Abfrage gefunden wurde wird ein null objekt zurückgegeben.
             Ansonsten wird geschaut ob mehr als 1 Artikel gefunden wurde und dies in einem Fenster
             angzeigt */
            if (renditeModel.Count <= 0)
            {

                
                OnDatenerfassungEvent(null);
                return;

            }
            else if (renditeModel.Count > 1)
            {
                var artikelauswahl = new Artikelauswahl {RenditeModel = renditeModel.ToList()};
                artikelauswahl.Show();
                artikelauswahl.ProductSelektionEvent += Artikelauswahl_ProductSelektionEvent;
                
                return;
            }
            else
            {
                var datenerfassungmodel = new DataCollectionmodel
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

            }
        /// <summary>
        /// Wird von Erfassung ausgelösst.
        /// </summary>
        /// <param name="obj">Die WWS Daten.</param>
        private void Artikelauswahl_ProductSelektionEvent(RenditeModel obj)
        {
            var datenerfassungmodel = new DataCollectionmodel
            {

                Fabrikat = obj.Fabrikat,
                Artikelbezeichnung = obj.Artikelbezeichnung,
                EAN = obj.EAN,
                Warenbereich = obj.Geschaeftsbereich,
                WarenbereichId = Convert.ToInt32(obj.GeschaeftsbereichID)
            };

            OnDatenerfassungEvent(datenerfassungmodel);
        }

        /// <summary>
        /// Das Event wird von Erfassung ausgelöst
        /// </summary>
        /// <param name="obj">Enthält die Erfassten Daten bzw. gibt NULL zurück wenn keine Datenvorhanden sind.</param>
        protected virtual void OnDatenerfassungEvent(DataCollectionmodel obj)
        {
            DatenerfassungEvent?.Invoke(obj);
            
        }
    }
}

