using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.SMS
{
    class MessageComparer : IEqualityComparer<IMessage>
    {
        public bool Equals(IMessage x, IMessage y)
        {
            if (Object.ReferenceEquals(x, y)) return true;

            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

            return x.User == y.User && x.Text == y.Text && x.ReceivingTime == y.ReceivingTime;
        }

        public int GetHashCode(IMessage obj)
        {
            if (Object.ReferenceEquals(obj, null)) return 0;

            int hashUser = obj.User.GetHashCode();

            int hashText = obj.Text.GetHashCode();

            int hashReceivingTime = obj.ReceivingTime.GetHashCode();

            return hashUser ^ hashText ^ hashReceivingTime;
        }
    }
}
