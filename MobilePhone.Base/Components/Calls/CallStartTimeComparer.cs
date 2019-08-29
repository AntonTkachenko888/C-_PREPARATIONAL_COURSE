using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public class CallStartTimeComparer:Comparer<PhoneCall>
    {
        private static readonly CallStartTimeComparer vInstance = new CallStartTimeComparer();
        public static CallStartTimeComparer Instance { get { return vInstance; }}

        private CallStartTimeComparer(){}

        public override int Compare(PhoneCall x, PhoneCall y)
        {
            if (x == null && y == null)
            {
                return 0;
            }
            if (x == null)
            {
                return -1;
            }
            if (y == null)
            {
                return 1;
            }

            var res = DateTime.Compare(x.StartTime, y.StartTime);
            if (res < 0)
            {
                return 1;
            }
            if (res > 0)
            {
                return -1;
            }
            return 0;
        }
    }
}
