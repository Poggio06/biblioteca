using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Documento : Scaffale
    {
        public string codice { get; set; }
        public string titolo { get; set; }  
        public int anno { get; set; }
        public string settore { get; set; }
        public Stato stato { get; set; }
    }
}
