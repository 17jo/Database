using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class Nast_predmet
    {
        public virtual int Id { get; set; }

        public virtual string Nastavnik { get; set; }

        public virtual Predmet Predmet { get; set; }
    }
}
