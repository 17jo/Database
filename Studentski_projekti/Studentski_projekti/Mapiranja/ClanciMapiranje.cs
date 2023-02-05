using FluentNHibernate.Mapping;
using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Mapiranja
{
    class ClanciMapiranje : SubclassMap<Clanci>
    {
        public ClanciMapiranje()
        {
            Table("CLANCI");
            KeyColumn("LITERATURA");
            //mapiranje primarnog kljuca
            Map(x => x.Broj, "BROJ");
            Map(x => x.ISSN, "ISSN");
            Map(x => x.Godina, "GODINA");
            Map(x => x.Ime_casopisa, "IME_CASOPISA");

        }
        
    }
}
