using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MobilePhone.Base.MobilePhones;

namespace SMSSender
{
    public class SMSSenderTask:SmsSenderBase
    {
        public SMSSenderTask(MobilePhoneBase recipient):base(recipient){ }

        #region Messaging
        private Task task;
        private CancellationTokenSource cancelTokSrc;
        private bool IsTaskActive;
        public override  void StartMessaging(int IntervalSec)
        {
            if (!IsTaskActive)
            {
                cancelTokSrc = new CancellationTokenSource();
                task = Task.Run(() => Tick(IntervalSec, cancelTokSrc.Token));
                IsTaskActive = true;
            }
        }

        private void Tick(int IntervalSec,CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                    return;
                OnTimerIvent();
                Thread.Sleep(IntervalSec * 1000);
            }
        }
        public override void StopMessaging()
        {
            if (IsTaskActive)
            {
                cancelTokSrc.Cancel();
                IsTaskActive = false;
            }
        }
        #endregion
    }
}
