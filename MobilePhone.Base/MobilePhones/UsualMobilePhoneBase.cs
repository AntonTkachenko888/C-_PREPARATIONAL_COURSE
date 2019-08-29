using MobilePhone.Base.Components.Keyboards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.Components.Calls;

namespace MobilePhone.Base.MobilePhones
{
    public abstract  class UsualMobilePhoneBase:MobilePhoneBase
    {
        public abstract KeyboardBase Keyboard { get; }
        
        public override string ToString()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Keyboard Type: {Keyboard.ToString()}");
            return base.ToString()+ descriptionBuilder.ToString();
        }
    }
}
