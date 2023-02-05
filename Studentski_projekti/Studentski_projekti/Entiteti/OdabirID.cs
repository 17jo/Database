using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentski_projekti.Entiteti
{
    public class OdabirID
    {
        public virtual Projekat OdabirProjekat { get; set; }
        public virtual Student OdabirStudent { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(OdabirID))
                return false;

            OdabirID recievedObject = (OdabirID)obj;

            if ((OdabirProjekat.JID == recievedObject.OdabirProjekat.JID) &&
                (OdabirStudent.Broj_indeksa == recievedObject.OdabirStudent.Broj_indeksa))
            {
                return true;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
