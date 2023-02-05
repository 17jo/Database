using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class Knjiga:Literatura
    {
        public virtual string Izdavac { get; set; }
        public virtual int ISBN { get; set; }

        public virtual string Godina_izdavanja { get; set; }

        //public virtual Literatura Literatura { get; set; }
    }
}
