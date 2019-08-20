using MobilePhone.Base.Components.SMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.SMS
{
    public class Storage
    {
        public event Action MessageAdded;
        public event Action MessageRemoved;
        private List<IMessage> Messages { get; set; } = new List<IMessage>();

        private SMSProvider vSMSProvider;
        public Storage(SMSProvider smsProvider)
        {
            vSMSProvider = smsProvider;
            vSMSProvider.SMSRecieved += this.Add;
            InitialiseReceivedMessages();
        }
        private void InitialiseReceivedMessages()
        {
            Messages.Add(new Message()
            {
                User = "Bart",
                Text = "Loser",
                ReceivingTime = new DateTime(1993, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Homer",
                Text = "D’Oh!",
                ReceivingTime = new DateTime(1994, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Marge",
                Text = "You have no idea what it's like, being married to you.",
                ReceivingTime = new DateTime(1995, 3, 14, 10, 14, 23)
            });
            Messages.Add(new Message()
            {
                User = "Homer",
                Text = "Boring!",
                ReceivingTime = new DateTime(1996, 3, 14, 10, 14, 23)
            });
        }

        public void Add(IMessage message)
        {
            Messages.Add(message);
            MessageAdded?.Invoke();
        }
        public void Remove(IMessage message)
        {
            var messagesForRemoving = (from m in Messages
                                        where m.User == message.User &&
                                              m.Text == message.Text &&
                                              m.ReceivingTime == message.ReceivingTime
                                        select m).First();
            
            Messages.Remove(messagesForRemoving);
            MessageRemoved?.Invoke();
        }

        public List<string> GetUsers(string current)
        {
            List<string> users = new List<string>();
            users.Add("");
            var result = from u in Messages
                         group u by u.User
                         into g
                         select g.Key;
            users.AddRange(result);
            users.Remove(current);
            users.Add(current);
            users.Reverse();
            return users;
        }
        
        public IEnumerable<IMessage> GetMessages(MessageFilteringParams messageFilteringParams)
        {
            var filteredMessages = GetFilteredMessages(messageFilteringParams);
            var filteredMessagesForFormatting = from m in filteredMessages
                                                select new Message()
                                                {
                                                    User = m.User,
                                                    Text = m.Text,
                                                    ReceivingTime = m.ReceivingTime
                                                };
            return Format(filteredMessagesForFormatting, messageFilteringParams).ToList();
        }
        private IEnumerable<IMessage> GetFilteredMessages(MessageFilteringParams messageFilteringParams)
        {
            var filteredByUser = FilteredByUser(messageFilteringParams);
            var filteredByText = FilteredByText(messageFilteringParams);
            var filteredByDate = FilteredByDate(messageFilteringParams);

            if (messageFilteringParams.UsersSortOptions == SortOptions.AND)
            {
                filteredByUser = filteredByUser.Intersect(filteredByText, new MessageComparer());
            }
            else if (messageFilteringParams.UsersSortOptions == SortOptions.OR)
            {
                filteredByUser = filteredByUser.Union(filteredByText, new MessageComparer());
            }

            if (messageFilteringParams.MessageTextSortOptions == SortOptions.AND)
            {
                filteredByUser = filteredByUser.Intersect(filteredByDate, new MessageComparer());
            }
            else if (messageFilteringParams.MessageTextSortOptions == SortOptions.OR)
            {
                filteredByUser = filteredByUser.Union(filteredByDate, new MessageComparer());
            }
            return filteredByUser;
        }
        private IEnumerable<IMessage> FilteredByDate(MessageFilteringParams messageFilteringParams)
        {
            var filteredMessages = from i in Messages
                                  where i.ReceivingTime < messageFilteringParams.BeforeDate &&
                                        i.ReceivingTime > messageFilteringParams.FromDate
                                  select i;
            return filteredMessages;
        }
        private IEnumerable<IMessage> FilteredByUser(MessageFilteringParams messageFilteringParams)
        {
            if (string.IsNullOrEmpty(messageFilteringParams.SelectedUser))
                return Messages;
            var filteredMessages = from i in Messages
                                  where i.User == messageFilteringParams.SelectedUser
                                  select i;
            return filteredMessages;
        }
        private IEnumerable<IMessage> FilteredByText( MessageFilteringParams messageFilteringParams)
        {
            if(string.IsNullOrEmpty(messageFilteringParams.MessageText))
                return Messages;
            var filteredMessages = from i in Messages
                                  where i.Text.Contains(messageFilteringParams.MessageText)
                                  select i;
            return filteredMessages;
        }
        private static IEnumerable<IMessage> Format(IEnumerable<IMessage> messages, MessageFilteringParams messageFilteringParams)
        {
            var formatedMessages = from m in messages
                select FormatMethods.GetFormatMethod(messageFilteringParams.FormattingOptions).Invoke(m);
            return formatedMessages;
        }
    }
}
