using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class Praktican:Projekat
    {
        public virtual string Izabrani_jezik { get; set; }
        public virtual string Programski_jezik { get; set; }

        public virtual string Opis_zadatka { get; set; }

        public virtual string Web_stranica { get; set; }

        public virtual Projekat Projekat { get; set; }
        public virtual IList<Izvestaj> ListaIzvestaja { get; set; }

        public Praktican()
        {
            ListaIzvestaja = new List<Izvestaj>();
        }

    }
}
