using MobilePhone.Base.Components.MemoryCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.MobilePhones
{
    public abstract class SmartPhoneBase: MobilePhoneBase
    {
        public abstract MemoryCardBase MemoryCard { get; }

        public override string ToString()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"MemoryCard Type: {MemoryCard.ToString()}");
            return base.ToString() + descriptionBuilder.ToString();
        }
    }
}
