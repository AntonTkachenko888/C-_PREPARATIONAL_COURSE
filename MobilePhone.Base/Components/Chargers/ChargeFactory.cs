using MobilePhone.Base.GeneralInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Chargers
{
    public class ChargeFactory
    {
        public static ICharger GetCharge(Charges charges , IOutput output)
        {
            ICharger charger = null;
            switch (charges)
            {
                case Charges.FastCharge:
                    charger = new FastCharge(output);
                    break;
                case Charges.UsualCharge:
                    charger = new UsualCharge(output);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return charger;
        }
    }
}
