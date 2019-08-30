using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public class CallsHistory
    {
        public event Action CallListChanged;
        private List<PhoneCall> Calls { get; set; } = new List<PhoneCall>();

        private CallProvider vCallProvider;
        private Contacts vContacts;
        public CallsHistory(CallProvider callProvider, Contacts contacts)
        {
            vCallProvider = callProvider;
            vCallProvider.Call += this.Add;
            vContacts = contacts;
            vContacts.ContactListChanged += OnContactChanged;
            

            Calls.Add(new PhoneCall(1, CallDirection.incoming,
                new DateTime(1997, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 1), vContacts));
            Calls.Add(new PhoneCall(2, CallDirection.incoming,
                new DateTime(1998, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 2), vContacts));
            Calls.Add(new PhoneCall(3, CallDirection.incoming,
                new DateTime(1999, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 3), vContacts));
            Calls.Add(new PhoneCall(4, CallDirection.incoming,
                new DateTime(2000, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 4), vContacts));
            Calls.Add(new PhoneCall(5, CallDirection.incoming,
                new DateTime(2001, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 5), vContacts));
            Calls.Add(new PhoneCall(1, CallDirection.incoming,
                new DateTime(2002, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 6), vContacts));
            Calls.Add(new PhoneCall(2, CallDirection.incoming,
                new DateTime(2003, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 7), vContacts));
            Calls.Add(new PhoneCall(3, CallDirection.incoming,
                new DateTime(2004, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 8), vContacts));
            Calls.Add(new PhoneCall(4, CallDirection.incoming,
                new DateTime(2005, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 9), vContacts));
            Calls.Add(new PhoneCall(5, CallDirection.incoming,
                new DateTime(2006, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 10), vContacts));
            Calls.Add(new PhoneCall(6, CallDirection.incoming,
                new DateTime(2007, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 11), vContacts));
        }

        private void OnContactChanged()
        {
            foreach (var item in Calls)
            {
                if (item?.Contact?.Name == null)
                {
                    item.Contact = vContacts.Get(item.PhoneNamber);
                }
                if (item?.Contact?.Name != null)
                {
                    var c = vContacts.Get(item.Contact.Name, item.Contact.LastName);
                    if (c == null)
                        item.Contact = null;
                }
            }
        }

        public void Add(ICall call)
        {
            Calls.Add(new PhoneCall(call, vContacts));
            CallListChanged?.Invoke();
        }
        public void Remove(PhoneCall call)
        {
            var c = Calls.Find(x => x.PhoneNamber == call.PhoneNamber & x.StartTime == call.StartTime);
            Calls.Remove(c);

            if (Calls.Contains(call, CallNumberStartTimeEqualityComparer.Instance))
                throw new Exception("Can't delete this call please try again");

            CallListChanged?.Invoke();
        }
        public void ClearCallHistory()
        {
            Calls.Clear();
            
            if(Calls.Count!=0)
                throw new Exception("Can't clear this call history please try again");

            CallListChanged?.Invoke();
        }
        public IEnumerable<PhoneCall> GetAllCalls()
        {
            Calls.Sort(CallStartTimeComparer.Instance);
            return Calls;
        }
        private IEnumerable<PhoneCall> GetCalls(Contact contact)
        {
            var contactCalls = Calls.Where(c => c?.Contact?.Name == contact.Name &&
                                                c?.Contact?.LastName == contact.LastName).ToList();
            contactCalls.Sort(CallStartTimeComparer.Instance);
            return contactCalls;
        }
        private IEnumerable<PhoneCall> GetNumberCalls(int number)
        {
            var contactCalls = Calls.Where(c => c.PhoneNamber == number).ToList();
            contactCalls.Sort(CallStartTimeComparer.Instance);
            return contactCalls;
        }

        public IEnumerable<PhoneCall> GetRelatedCalls(PhoneCall phoneCall  )
        {
            if (!string.IsNullOrEmpty(phoneCall?.Contact?.Name) && !string.IsNullOrEmpty(phoneCall?.Contact?.LastName))
            {
                return GetCalls(phoneCall.Contact);
            }
            else
            {
                return GetNumberCalls(phoneCall.PhoneNamber);
            }
        }
    }
}
