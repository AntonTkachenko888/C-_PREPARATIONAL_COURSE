using MobilePhone.Base.GeneralInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.Components.Batteries;

namespace MobilePhone.Base.Components.Chargers
{
    public class ChargeFactory
    {
        public static ChargeBase GetCharge(Charges charges,BatteryBase batteryBase, IOutput output)
        {
            ChargeBase charger = null;
            switch (charges)
            {
                case Charges.FastChargeThread:
                    charger = new FastChargeThread(batteryBase,output);
                    break;
                case Charges.UsualChargeThread:
                    charger = new UsualChargeThread(batteryBase, output);
                    break;
                case Charges.FastChargeTask:
                    charger = new FastChargeTask(batteryBase, output);
                    break;
                case Charges.UsualChargeTask:
                    charger = new UsualChargeTask(batteryBase, output);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return charger;
        }
    }
}
