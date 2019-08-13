using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MobilePhone.Base.MobilePhones;

namespace SMSSender
{
    public class SmsSender
    {
        private MobilePhoneBase vRecipient;
        private MobilePhoneBase Recipient { get; set; }
        public SmsSender(MobilePhoneBase recipient)
        {
            vRecipient = recipient;
        }       
        private void SendSMS(string message)
        {
            vRecipient.SMSProvider.RaiseSMSReceivedEvent(message);
        }
        public void TimerTick(int IntervalSec)
        {
            Timer timer = new Timer();
            timer.Elapsed += OnTimerIvent;
            timer.Interval = IntervalSec*1000;
            timer.Enabled = true;
        }
        private void OnTimerIvent(object source, ElapsedEventArgs e)
        {
            SendSMS("Hello World!");
        }
    }
}
