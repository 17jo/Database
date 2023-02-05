using FluentNHibernate.Mapping;
using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Mapiranja
{
    class OdabirMapiranje : ClassMap<Odabir>
    {
        public OdabirMapiranje()
        {
            Table("ODABIR");
            CompositeId(x => x.Id)
             .KeyReference(x => x.OdabirProjekat, "PROJEKAT")
             .KeyReference(x => x.OdabirStudent, "STUDENT");
            //mapiranje svojstava
            Map(x => x.Rok_zavrsetka, "ROK_ZAVRSETKA");
            Map(x => x.Datum_dodele, "DATUM_DODELE");
            Map(x => x.Zavrsen, "ZAVRSEN");
            Map(x => x.Vreme_zavrsetka, "VREME_ZAVRSETKA");

        }
 
    }
}
