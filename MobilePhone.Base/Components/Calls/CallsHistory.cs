using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public class CallsHistory
    {
        public event Action CallAdded;
        public event Action CallRemoved;
        private List<Call> Calls { get; set; } = new List<Call>();

        private CallProvider vCallProvider;
        public CallsHistory(CallProvider callProvider)
        {
            vCallProvider = callProvider;
        }
        

        public void Add(Call call)
        {
            
        }
        public void Remove(Call call)
        {

        }

        public IEnumerable<Call> GetAllCalls()
        {
            return null;
        }
        public IEnumerable<Call> GetContactCalls(Contact contact)
        {
            return null;
        }
    }
}
