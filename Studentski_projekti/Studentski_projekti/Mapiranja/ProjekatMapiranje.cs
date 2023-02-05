using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace Studentski_projekti.Mapiranja
{
    class ProjekatMapiranje: ClassMap<Projekat>
    {
        public ProjekatMapiranje()
        {
            //Mapiranje tabele
            Table("PROJEKAT");


            //mapiranje primarnog kljuca
            Id(x => x.JID, "JID").GeneratedBy.Assigned();
            //mapiranje svojstava;
            Map(x => x.Ime_projekta, "IME_PROJEKTA");
            Map(x => x.Godina, "GODINA");
            Map(x => x.Grupni_rad, "GRUPNI_RAD");

            //mapiranje veze 1:N 
            References(x => x.Predmet).Column("PREDMET").LazyLoad();
            HasManyToMany(x => x.Studenti)
              .Table("ODABIR")
              .ParentKeyColumn("PROJEKAT")
              .ChildKeyColumn("STUDENT")
              .Cascade.All();
            HasMany(x => x.OdabirStudent).KeyColumn("PROJEKAT").LazyLoad().Cascade.All().Inverse();
        }
    }
}
