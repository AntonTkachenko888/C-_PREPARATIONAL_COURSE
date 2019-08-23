using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MobilePhone.Base.MobilePhones;

namespace SMSSender
{
    public class SMSSenderThread:SmsSenderBase
    {
        public SMSSenderThread(MobilePhoneBase recipient):base(recipient){}

        #region Messaging
        private Thread thread;
        private bool IsTaskActive;
        public override void StartMessaging(int IntervalSec)
        {
            if (!IsTaskActive)
            {
                thread = new Thread(() =>
            {
                while (true)
                {
                    OnTimerIvent();
                    Thread.Sleep(IntervalSec * 1000);
                }
            });
                thread.IsBackground = true;
                thread.Start();
                IsTaskActive = true;
            }
        }
        public override void StopMessaging()
        {
            if (IsTaskActive)
            {
                thread.Abort();
                IsTaskActive = false;
            }
        }
        #endregion
    }
}
