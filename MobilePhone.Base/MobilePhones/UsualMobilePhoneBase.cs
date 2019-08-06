using MobilePhone.Base.Components.Keyboards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.MobilePhones
{
    public abstract  class UsualMobilePhoneBase:MobilePhoneBase
    {
        public abstract KeyboardBase Keyboard { get; }
        
        public new string GetDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Keyboard Type: {Keyboard.ToString()}");
            return base.GetDescription()+ descriptionBuilder.ToString();
        }
    }
}
