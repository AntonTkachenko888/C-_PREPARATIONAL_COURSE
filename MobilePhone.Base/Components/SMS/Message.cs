using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.SMS
{
    public class Message:IMessage
    {
        public string User { get; set; }
        public string Text { get; set; }
        public DateTime ReceivingTime { get; set; }
    }
}
