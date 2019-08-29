using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public class CallProvider
    {
        public delegate void CallDelegate(ICall call);

        public event CallDelegate Call;

        public void CallEvent(ICall call)
        {
            Call?.Invoke(call);
        }
    }
}
