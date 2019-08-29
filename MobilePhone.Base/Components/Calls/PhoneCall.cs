using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public class PhoneCall: ICall
    {
        public int PhoneNamber { get; set; }
        public CallDirection CallDirection { get; set; }
        public DateTime StartTime { get; set; }

        public TimeSpan CallTime { get; set; }

        public Contact Contact  { get; set; } = new Contact();

        public PhoneCall(){}
        public PhoneCall(int phoneNamber, CallDirection callDirection, DateTime startTime, TimeSpan callTime)
        {
            PhoneNamber = phoneNamber;
            CallDirection = callDirection;
            StartTime = startTime;
            CallTime = callTime;
        }
        public PhoneCall(ICall call, Contacts contacts)
            : this(call.PhoneNamber, call.CallDirection, call.StartTime, call.CallTime)
        {
            var contact = contacts.Get(call.PhoneNamber);
            if (contact != null)
            {
                Contact = contact;
            } 
        }
        public PhoneCall(int phoneNamber, CallDirection callDirection, DateTime startTime, TimeSpan callTime, Contacts contacts)
            :this(phoneNamber, callDirection, startTime, callTime)
        {
            var contact = contacts?.Get(phoneNamber);
            if (contact != null)
            {
                Contact = contact;
            }
        }
    }
}
