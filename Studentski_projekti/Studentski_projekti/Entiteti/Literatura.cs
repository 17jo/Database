using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class Literatura
    {
        public virtual int Id_literature { get; set; }

        public virtual string Naziv { get; set; }

        public virtual Teorijski Teorijski { get; set; }

        public Literatura()
        {

        }
    }
}
