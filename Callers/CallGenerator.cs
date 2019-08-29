using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MobilePhone.Base.Components.Calls;
using MobilePhone.Base.MobilePhones;

namespace CallGenerator
{
    public class CallGenerator
    {
        private MobilePhoneBase vRecipient;
        private MobilePhoneBase Recipient { get; set; }
        private List<ICall> Calls { get; set; }
        private int CurrentCall { get; set; } = 0;
        private CallGenerator()
        {
            Calls = new List<ICall>();
            //Add calls
        }
        public CallGenerator(MobilePhoneBase recipient):this()
        {
            vRecipient = recipient;
            MessagingInitialisation();
        }
        private void Call(ICall call)
        {
            vRecipient.CallProvider.CallEvent(call);
        }
        #region Messaging
        private Timer timer = new Timer();
        public virtual void StartMessaging(int IntervalSec)
        {
            timer.Interval = IntervalSec * 1000;
            timer.Start();
        }
        public virtual void StopMessaging()
        {
            timer.Stop();
        }
        public virtual void MessagingInitialisation()
        {
            timer.Elapsed += OnTimerIvent;
        }
        #endregion

        private void OnTimerIvent(object source, ElapsedEventArgs e)
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
