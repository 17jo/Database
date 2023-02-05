using FluentNHibernate.Mapping;
using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Mapiranja
{
    class TeorijskiMapiranje: SubclassMap<Teorijski>
    {
        
        public TeorijskiMapiranje()
        {
            //Mapiranje tabele
            Table("TEORIJSKI");

            KeyColumn("PROJEKAT");
            //mapiranje svojstava
            Map(x => x.Max_strana, "MAX_STRANA");

            HasMany(x => x.ListaLiteratura).KeyColumn("TEORIJSKI").LazyLoad().Cascade.All().Inverse();
        }
    }
}
