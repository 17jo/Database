using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class Izvestaj
    {
        public virtual int Id { get; set; }

        public virtual int Broj_izvestaja { get; set;}

        public virtual string Opis { get; set; }

        public virtual DateTime Vreme_podnosenja { get; set; }

        public virtual DateTime Vreme_predaje { get; set; }

        public virtual Praktican Praktican{ get; set; }

    }
}
