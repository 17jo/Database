using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class Autori_literature
    {
        public virtual int Id { get; set; }
        public virtual string Autori { get; set; }
        public virtual Literatura Literatura { get; set; }
    }
}
