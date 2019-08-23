using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.MobilePhones;

namespace SMSSender
{
    public static class SMSSenderFactory
    {
            public static SmsSenderBase GetSMSSender(SmsSenders headsets, MobilePhoneBase recipient)
            {
                SmsSenderBase smsSender = null;
                switch (headsets)
                {
                    case SmsSenders.SMSSenderTask:
                        smsSender = new SMSSenderTask(recipient);
                        break;
                    case SmsSenders.SMSSenderThread:
                        smsSender = new SMSSenderThread(recipient);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                return smsSender;
            }
        
    }
}
