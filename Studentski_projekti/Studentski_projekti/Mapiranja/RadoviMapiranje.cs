using FluentNHibernate.Mapping;
using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Mapiranja
{
    class RadoviMapiranje : SubclassMap<Radovi>
    {
        public RadoviMapiranje()
        {
            Table("RADOVI");
            KeyColumn("LITERATURA");
            //mapiranje primarnog kljuca
            Map(x => x.Format, "FORMAT");
            Map(x => x.Web_adresa, "WEBSADRESA");
            Map(x => x.Konferencija, "KONFERENCIJA");
        }
    }
}
