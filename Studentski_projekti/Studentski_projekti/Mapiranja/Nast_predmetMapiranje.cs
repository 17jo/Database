using FluentNHibernate.Mapping;
using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Mapiranja
{
    class Nast_predmetMapiranje : ClassMap<Nast_predmet>
    {
        public Nast_predmetMapiranje()
        {
            //Mapiranje tabele
            Table("NAST_PREDMET");


            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            //mapiranje svojstava;
            Map(x => x.Nastavnik, "NASTAVNIK");


        }
    }
}
