using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public class ContactNameLastNameEqualityComparer:EqualityComparer<Contact>
    {
        private static readonly ContactNameLastNameEqualityComparer vInstance =
            new ContactNameLastNameEqualityComparer();

        public static ContactNameLastNameEqualityComparer Instance {get { return vInstance; } }

        private ContactNameLastNameEqualityComparer() { }

        public override bool Equals(Contact x, Contact y)
        {
            return x.Name.ToUpperInvariant() == y.Name.ToUpperInvariant() &&
                   x.LastName.ToUpperInvariant() == y.LastName.ToUpperInvariant();
        }

        public override int GetHashCode(Contact obj)
        {
            return obj.Name.ToUpperInvariant().GetHashCode() ^
                   obj.LastName.ToUpperInvariant().GetHashCode();
        }
    }
}
