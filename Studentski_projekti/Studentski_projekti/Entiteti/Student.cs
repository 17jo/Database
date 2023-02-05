using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class Student
    {
        public virtual int Broj_indeksa { get; set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Ime_roditelja { get; set; }

        public virtual string Smer { get; set; }

        public virtual IList<Projekat> Projekti { get; set; }
        public virtual IList<Odabir> OdabirProjekat { get; set; }

        public Student()
        {
            OdabirProjekat = new List<Odabir>();
            Projekti = new List<Projekat>();
        }

    }
}
