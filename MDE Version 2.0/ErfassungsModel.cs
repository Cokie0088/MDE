using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDE_Version_2._0
{
    class SqliteErfassungsModel
    {
        public int Artikel_ID { get; set; }
        public string Fabrikat { get; set; }
        public string Artikelbezeichnung { get; set; }
        public string EAN { get; set; }
        public string Warenbereich { get; set; }
        public int WarenbereichId { get; set; }
        public string Name { get; set; }

    }
}
