using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class Web_strana
    {
        public virtual int Id { get; set; }

        public virtual string Web_stranica { get; set; }

        public virtual Projekat Projekat { get; set; }
    }
}
