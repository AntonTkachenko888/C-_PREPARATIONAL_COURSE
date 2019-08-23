using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using MobilePhone.Base.Components.SMS;
using MobilePhone.Base.MobilePhones;

namespace SMSSender
{
    public abstract class SmsSenderBase
    {
        private MobilePhoneBase vRecipient;
        private MobilePhoneBase Recipient { get; set; }
        private List<IMessage> Messages { get; set; }
        private int CurrentMessage { get; set; } = 0;
        private SmsSenderBase()
        {
            Messages = new List<IMessage>();
            Messages.Add(new Message()
            {
                User = "Bart",
                Text = "Caramba",
                ReceivingTime = new DateTime(1997, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Marge",
                Text = "You don’t win friends with salad",
                ReceivingTime = new DateTime(1998, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Krusty",
                Text = "Hey, Hey Kids!",
                ReceivingTime = new DateTime(1999, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Krusty",
                Text = "I didn't do it!",
                ReceivingTime = new DateTime(2000, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Marge",
                Text = "I don't think that's a very good idea",
                ReceivingTime = new DateTime(2001, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Krusty",
                Text = "Hi",
                ReceivingTime = new DateTime(2002, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Krusty",
                Text = "Be",
                ReceivingTime = new DateTime(2003, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Marge",
                Text = "I don't think that's a very good idea.",
                ReceivingTime = new DateTime(2004, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Krusty",
                Text = "I didn't do it!",
                ReceivingTime = new DateTime(2005, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Bart",
                Text = "Eat My Shorts!",
                ReceivingTime = new DateTime(2006, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Marge",
                Text = "So many",
                ReceivingTime = new DateTime(2007, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Krusty",
                Text = "Yay!!!",
                ReceivingTime = new DateTime(2008, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Homer",
                Text = "Boring!",
                ReceivingTime = new DateTime(2009, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Krusty",
                Text = "Ha Ha!",
                ReceivingTime = new DateTime(2010, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Marge",
                Text = "Oh, Homie.",
                ReceivingTime = new DateTime(2011, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Bart",
                Text = "Everything’s coming up Milhouse!",
                ReceivingTime = new DateTime(2012, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Homer",
                Text = "Ha ha",
                ReceivingTime = new DateTime(2013, 3, 14, 10, 14, 23)
            });
        }
        public SmsSenderBase(MobilePhoneBase recipient) : this()
        {
            vRecipient = recipient;
        }
        private void SendSMS(IMessage message)
        {
            vRecipient.SMSProvider.RaiseSMSReceivedEvent(message);
        }
        #region Messaging
        public abstract void StartMessaging(int IntervalSec);
        public abstract void StopMessaging();
        #endregion
        protected void OnTimerIvent()
        {
            IMessage message = GetNext();
            if (message != null)
            {
                SendSMS(message);
            }
        }
        private IMessage GetNext()
        {
            IMessage message = null;
            if (CurrentMessage < Messages.Count)
            {
                message = Messages[CurrentMessage];
                CurrentMessage++;
            }
            return message;
        }
    }
}
