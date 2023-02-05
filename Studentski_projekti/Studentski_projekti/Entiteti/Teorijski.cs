using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class Teorijski :Projekat
    {
        public virtual string Max_strana { get; set; }
        
        public virtual Projekat Projekat { get; set; }

        public virtual IList<Literatura> ListaLiteratura { get; set; }

        public Teorijski()
        {
            ListaLiteratura = new List<Literatura>();
        }
    }
}
