using FluentNHibernate.Mapping;
using Studentski_projekti.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Mapiranja
{
    class Web_stranaMapiranje : ClassMap<Web_strana>
    {
        public Web_stranaMapiranje()
        {
            Table("WEBSTRANA");
            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();
            //mapiranje svojstava
            Map(x => x.Web_stranica, "WEB_STRANICA");
            
        }
    }
}
