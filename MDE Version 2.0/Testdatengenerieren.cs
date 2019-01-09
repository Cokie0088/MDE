using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDE_Version_2._0
{
    class Testdatengenerieren
    {
        DataCollectionmodel _datacollection;
        internal void generieren()
        {
            var eingabemodel = new EingabeModel();
            eingabemodel.AbfrageString = "123456789";
            var datacollection = new Datenerfassung();
            datacollection.DatenerfassungEvent += Datacollection_DatenerfassungEvent;
            datacollection.Erfassung(eingabemodel);
            
            var erfassung = new Erfassung();
            erfassung.NewEntry(_datacollection);

}

        private void Datacollection_DatenerfassungEvent(DataCollectionmodel obj)
        {
            _datacollection = obj;
        }
    }
}
