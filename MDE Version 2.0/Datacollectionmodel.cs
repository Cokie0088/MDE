namespace MDE_Version_2._0
{
   public class DataCollectionmodel : EingabeModel
    {

        public string Fabrikat { get; set; }
        public string Artikelbezeichnung { get; set; }
        public string EAN { get; set; }
        public string Warenbereich { get; set; }
        public int WarenbereichId { get; set; }

        public bool HasEntry
        {
            get { return Fabrikat != null && Artikelbezeichnung != null && EAN != null; }
            
            
        }
       


    }
}
