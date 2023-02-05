using FluentNHibernate.Mapping;
using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Mapiranja
{
    class IzvestajMapiranje : ClassMap<Izvestaj>
    { 
        public IzvestajMapiranje()
        {
            Table("IZVESTAJ");
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            //mapiranje svojstava
            Map(x => x.Broj_izvestaja, "BROJ_IZVESTAJA");
            Map(x => x.Opis, "OPIS");
            Map(x => x.Vreme_podnosenja, "VREME_PODNOSENJA");
            Map(x => x.Vreme_predaje, "VREME_PREDAJE");
            References(x => x.Praktican).Column("PRAKTICAN").LazyLoad();

        }

    }
}
