using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public class Call: ICall, IComparable<Call>
    {
        public int PhoneNamber { get; set; }
        public CallDirection CallDirection { get; set; }
        public DateTime StartTime { get; set; }

        public TimeSpan CallTime { get; set; }

        public Contact Contact  { get; set; }

        public int CompareTo(Call other)
        {
            return StartTime.CompareTo(other.StartTime);
        }
    }
}
