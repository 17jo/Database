using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class Radovi:Literatura
    {
        public virtual string Format { get; set; }

        public virtual string Web_adresa { get; set; }

        public virtual string Konferencija { get; set; }

       // public virtual Literatura Literatura { get; set; }
    }
}
