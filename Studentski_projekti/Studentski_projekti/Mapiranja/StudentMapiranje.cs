using FluentNHibernate.Mapping;
using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Mapiranja
{
    class StudentMapiranje : ClassMap<Student>
    {
        public StudentMapiranje()
        {
            Table("STUDENT");


            Id(x => x.Broj_indeksa, "BROJ_INDEKSA").GeneratedBy.Assigned();
         
            Map(x => x.Ime, "IME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.Ime_roditelja, "IME_RODITELJA");
            Map(x => x.Smer, "SMER");

            HasManyToMany(x => x.Projekti)
               .Table("ODABIR")
               .ParentKeyColumn("STUDENT")
               .ChildKeyColumn("PROJEKAT")
               .Cascade.All();


            HasMany(x => x.OdabirProjekat).KeyColumn("STUDENT").LazyLoad().Cascade.All().Inverse();
        }
    }
}
