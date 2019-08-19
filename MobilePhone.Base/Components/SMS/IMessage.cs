using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.SMS
{
    public interface IMessage
    {
        string User { get; set; }
        string Text { get; set; }
        DateTime  ReceivingTime { get; set; }
    }
}
