using FluentNHibernate.Mapping;
using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Mapiranja
{
    class Autori_literatureMapiranje : ClassMap<Autori_literature>
    {
        public Autori_literatureMapiranje()
        {
            //Mapiranje tabele
            Table("AUTORI_LITERATURE");


            //mapiranje primarnog kljuca
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            //mapiranje svojstava
            Map(x => x.Autori, "AUTORI");}
    }
}
