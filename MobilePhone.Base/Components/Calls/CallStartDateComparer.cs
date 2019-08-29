using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public class CallStartDateComparer:Comparer<Call>
    {
        private static CallStartDateComparer vInstance = new CallStartDateComparer();
        public static CallStartDateComparer Instance { get { return vInstance; }}

        private CallStartDateComparer(){}

        public override int Compare(Call x, Call y)
        {
            if (x == null && y == null)
                return 0;
            if (x == null)
                return -1;
            if (y == null)
                return 1;
            return DateTime.Compare( x.StartTime, y.StartTime);
        }
    }
}
