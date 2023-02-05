using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class Predmet
    {
        public virtual string Sifra { get; set; }
        public virtual string Naziv_predmeta { get; set; }
        public virtual string Semestar { get; set; }
        public virtual string Katedra { get; set; }

        public virtual IList<Projekat> ListaProjekta { get; set; }

        public Predmet()
        {
            ListaProjekta = new List<Projekat>();
        }
    }
}
