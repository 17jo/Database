using FluentNHibernate.Mapping;
using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Mapiranja
{
    class PredmetMapiranje:ClassMap<Predmet>
    {   
        public PredmetMapiranje()
        {
            //Mapiranje tabele
            Table("PREDMET");


            //mapiranje primarnog kljuca
            Id(x => x.Sifra, "SIFRA").GeneratedBy.Assigned();
            //mapiranje svojstava
            Map(x => x.Naziv_predmeta, "NAZIV_PREDMETA");
            Map(x => x.Semestar, "SEMESTAR");
            Map(x => x.Katedra, "KATEDRA");
            HasMany(x => x.ListaProjekta).KeyColumn("PREDMET").LazyLoad().Cascade.All().Inverse();
        }
    }
}
