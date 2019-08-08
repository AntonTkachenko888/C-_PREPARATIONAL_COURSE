using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.GeneralInterfaces;

namespace MobilePhone.Base.Components.Chargers
{
    public class UsualCharge:ICharger
    {
        private IOutput Output;
        public UsualCharge(IOutput output)
        {
            Output = output;
        }
        public void Charge()
        {
            Output.WriteLine($"{nameof(UsualCharge)} charging slowly");
        }
    }
}
