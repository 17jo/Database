using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
   public class Projekat
    {
        public virtual int JID { get; set; }
        public virtual string Ime_projekta { get; set; }
        public virtual string Godina { get; set; }
        public virtual string Grupni_rad { get; set; }
        public virtual Predmet Predmet { get; set; }

        public virtual IList<Student> Studenti { get; set; }

        public virtual IList<Odabir> OdabirStudent { get; set; }

        public Projekat()
        {
            OdabirStudent = new List<Odabir>();
            Studenti = new List<Student>();
        }
    }
}
