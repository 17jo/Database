using FluentNHibernate.Mapping;
using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Mapiranja
{
    class PrakticanMapiranje: SubclassMap<Praktican>
    {
        public PrakticanMapiranje()
        {//Mapiranje tabele
            Table("PRAKTICAN");


            //mapiranje primarnog kljuca
            KeyColumn("PROJEKAT");
            //mapiranje svojstava
            Map(x => x.Izabrani_jezik, "IZABRANI_JEZIK");
            Map(x => x.Programski_jezik, "PROGRAMSKI_JEZIK");
            Map(x => x.Opis_zadatka, "OPIS_ZADATKA");
            Map(x => x.Web_stranica, "WEBSTRANICA");
            HasMany(x => x.ListaIzvestaja).KeyColumn("PRAKTICAN").LazyLoad().Cascade.All().Inverse();

        }
    }
}
