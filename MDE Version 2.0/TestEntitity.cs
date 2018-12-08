using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace MDE_Version_2._0
{

    //[Database(Name = "MDE")
    class TestEntitity
    {


        public TestEntitity(int ID, string Artikel, string EAN, int Anzahl)
        {
            this.ID = ID;
            this.Artikel = Artikel;
            this.EAN = EAN;
            this.Anzahl = Anzahl;

        }

        public int ID { get; set; }
        public string Artikel { get; set; }
        public string EAN { get; set; }
        public int Anzahl { get; set; }




    }
}
