using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace MobilePhone.Base.Components.SMS
{
    public class SMSProvider
    {
        public delegate void SMSReceivedDelegate(IMessage message);

        public event SMSReceivedDelegate SMSRecieved;

        public void RaiseSMSReceivedEvent(IMessage message)
        {
            var handler = SMSRecieved;
            if (handler != null)
            {
                handler(message);
            }
        }
    }
}
