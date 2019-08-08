using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.Components.HeadSets;
using MobilePhone.Base.GeneralInterfaces;

namespace MobilePhone.Base.Components.Chargers
{
    public class FastCharge:ICharger
    {
        private IOutput Output;
        public FastCharge(IOutput output)
        {
            Output = output;
        }
        public void Charge()
        {
            Output.WriteLine($"{nameof(FastCharge)} charging fast");
        }
    }
}
