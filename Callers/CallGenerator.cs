using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using MobilePhone.Base.Components.Calls;
using MobilePhone.Base.MobilePhones;

namespace CallGenerator
{
    public class CallGenerator
    {
        private MobilePhoneBase vRecipient;
        private List<ICall> Calls { get; set; }
        private int CurrentCall { get; set; } = 0;
        private CallGenerator()
        {
            Calls = new List<ICall>();

            Calls.Add(new PhoneCall(1, CallDirection.outgoing,
                new DateTime(2008, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 1)));
            Calls.Add(new PhoneCall(2, CallDirection.outgoing,
                new DateTime(2009, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 2)));
            Calls.Add(new PhoneCall(3, CallDirection.outgoing,
                new DateTime(2010, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 3)));
            Calls.Add(new PhoneCall(4, CallDirection.outgoing,
                new DateTime(2011, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 4)));
            Calls.Add(new PhoneCall(5, CallDirection.outgoing,
                new DateTime(2012, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 5)));
            Calls.Add(new PhoneCall(1, CallDirection.outgoing,
                new DateTime(2013, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 6)));
            Calls.Add(new PhoneCall(2, CallDirection.outgoing,
                new DateTime(2014, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 7)));
            Calls.Add(new PhoneCall(3, CallDirection.outgoing,
                new DateTime(2015, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 8)));
            Calls.Add(new PhoneCall(4, CallDirection.outgoing,
                new DateTime(2016, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 9)));
            Calls.Add(new PhoneCall(5, CallDirection.outgoing,
                new DateTime(2017, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 10)));
            Calls.Add(new PhoneCall(6, CallDirection.outgoing,
                new DateTime(2018, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 11)));

            Calls.Add(new PhoneCall(1, CallDirection.outgoing,
                new DateTime(2019, 3, 14, 10, 14, 23), new TimeSpan(0, 1, 1)));
            Calls.Add(new PhoneCall(2, CallDirection.outgoing,
                new DateTime(2020, 3, 14, 10, 14, 23), new TimeSpan(0, 2, 2)));
            Calls.Add(new PhoneCall(3, CallDirection.outgoing,
                new DateTime(2021, 3, 14, 10, 14, 23), new TimeSpan(0, 3, 3)));
            Calls.Add(new PhoneCall(4, CallDirection.outgoing,
                new DateTime(2022, 3, 14, 10, 14, 23), new TimeSpan(0, 4, 4)));
            Calls.Add(new PhoneCall(5, CallDirection.outgoing,
                new DateTime(2023, 3, 14, 10, 14, 23), new TimeSpan(0, 5, 5)));
            Calls.Add(new PhoneCall(1, CallDirection.outgoing,
                new DateTime(2024, 3, 14, 10, 14, 23), new TimeSpan(0, 6, 6)));
            Calls.Add(new PhoneCall(2, CallDirection.outgoing,
                new DateTime(2025, 3, 14, 10, 14, 23), new TimeSpan(0, 7, 7)));
            Calls.Add(new PhoneCall(3, CallDirection.outgoing,
                new DateTime(2026, 3, 14, 10, 14, 23), new TimeSpan(0, 8, 8)));
            Calls.Add(new PhoneCall(4, CallDirection.outgoing,
                new DateTime(2027, 3, 14, 10, 14, 23), new TimeSpan(0, 9, 9)));
            Calls.Add(new PhoneCall(5, CallDirection.outgoing,
                new DateTime(2028, 3, 14, 10, 14, 23), new TimeSpan(0, 10, 10)));
            Calls.Add(new PhoneCall(6, CallDirection.outgoing,
                new DateTime(2029, 3, 14, 10, 14, 23), new TimeSpan(0, 11, 11)));
        }
        public CallGenerator(MobilePhoneBase recipient):this()
        {
            vRecipient = recipient;
        }
        private void Call(ICall call)
        {
            vRecipient.CallProvider.CallEvent(call);
        }
        #region Messaging
        private Task task;
        private CancellationTokenSource cancelTokSrc;
        private bool IsTaskActive;
        public void Start(int IntervalSec)
        {
            if (!IsTaskActive)
            {
                cancelTokSrc = new CancellationTokenSource();
                task = Task.Run(() => Tick(IntervalSec, cancelTokSrc.Token));
                IsTaskActive = true;
            }
        }

        private void Tick(int IntervalSec, CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                    return;
                OnTimerIvent();
                Thread.Sleep(IntervalSec * 1000);
            }
        }
        public void Stop()
        {
            if (IsTaskActive)
            {
                cancelTokSrc.Cancel();
                IsTaskActive = false;
            }
        }
        #endregion

        private void OnTimerIvent()
        {
            ICall call = GetNext();
            if (call != null)
            {
                Call(call);
            }
        }
        private ICall GetNext()
        {
            ICall call = null;
            if (CurrentCall < Calls.Count)
            {
                call = Calls[CurrentCall];
                CurrentCall++;
            }
            return call;
        }
    }
}
