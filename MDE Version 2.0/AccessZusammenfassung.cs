using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOX;

namespace MDE_Version_2._0
{
    class AccessZusammenfassung : AccessBase
    {


        public void ZusammenfassungsDateiErstellen(string Pfad)
        {

            var datei = Accessdateierstellen(Pfad);


        }


        public override Catalog Accessdateierstellen(string Pfad)
        {

            return base.Accessdateierstellen(Pfad);


        }

        public override Table Tabelleerstellen()
        {

            ADOX.Table();

          
        }



    }
}
