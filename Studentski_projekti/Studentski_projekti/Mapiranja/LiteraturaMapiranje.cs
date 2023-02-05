using FluentNHibernate.Mapping;
using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Mapiranja
{
    class LiteraturaMapiranje: ClassMap<Literatura>
    {   
        public LiteraturaMapiranje()
        {
            Table("LITERATURA");

            //mapiranje primarnog kljuca
            // Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity().UnsavedValue(-1);
            Id(x => x.Id_literature, "ID").GeneratedBy.TriggerIdentity();
            //mapiranje svojstava
            //Map(x => x.Tip, "TIP");
            Map(x => x.Naziv, "NAZIV");

            //mapiranje veze 1:N
            //References(x => x.Projekat).Column("JID").LazyLoad();
            References(x => x.Teorijski).Column("TEORIJSKI").LazyLoad();
        }

    }
}
