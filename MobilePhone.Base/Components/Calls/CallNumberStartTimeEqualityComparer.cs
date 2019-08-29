using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public class CallNumberStartTimeEqualityComparer: EqualityComparer<PhoneCall>
    {
        private static readonly CallNumberStartTimeEqualityComparer vInstance =
            new CallNumberStartTimeEqualityComparer();

        public static CallNumberStartTimeEqualityComparer Instance { get { return vInstance; } }

        private CallNumberStartTimeEqualityComparer() { }
        public override bool Equals(PhoneCall x, PhoneCall y)
        {
            return x.PhoneNamber == y.PhoneNamber &&
                   x.StartTime == y.StartTime;
        }

        public override int GetHashCode(PhoneCall obj)
        {
            return obj.PhoneNamber.GetHashCode() ^ obj.StartTime.GetHashCode();
        }
    }
}
