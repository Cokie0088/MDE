using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDE_Version_2._0
{
    public class EingabeModel
    {

        public string AbfrageString { get; set; }
        public string ZeahlerName { get; set; }
        public int Anzahl { get; set; }
        public DateTime ErfassungsZeit => DateTime.Now;
    }
}
