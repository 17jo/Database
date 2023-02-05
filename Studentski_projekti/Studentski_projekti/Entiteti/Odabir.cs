using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class Odabir
    {
        //ovde bio ID atribut
        public virtual DateTime Datum_dodele { get; set; }

        public virtual DateTime Rok_zavrsetka { get; set; }

        public virtual string Zavrsen { get; set; }

        public virtual DateTime Vreme_zavrsetka { get; set; }

        public virtual OdabirID Id { get; set; }

        public Odabir()
        {
            Id = new OdabirID();
        }
    }
}
