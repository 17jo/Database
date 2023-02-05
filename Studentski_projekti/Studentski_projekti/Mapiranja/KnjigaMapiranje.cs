using FluentNHibernate.Mapping;
using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Mapiranja
{
    class KnjigaMapiranje : SubclassMap<Knjiga>
    {
        public KnjigaMapiranje()
        {
            Table("KNJIGA");
            KeyColumn("LITERATURA");
            //mapiranje primarnog kljuca
            Map(x => x.ISBN, "ISBN");
            Map(x => x.Izdavac, "IZDAVAC");
            Map(x => x.Godina_izdavanja, "GODINA_IZDAVANJA");
            //References(x => x.Literatura).Column("TEORIJSKI").LazyLoad();
        }
    }
}
