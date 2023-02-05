using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class Clanci:Literatura
    {
        public virtual int Broj { get; set; }

        public virtual int ISSN { get; set; }

        public virtual string Ime_casopisa{ get; set; }

        public virtual string Godina { get; set; }

       // public virtual Literatura Literatura { get; set; }

    }
}
