using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MobilePhone.Base.Components.Batteries;

namespace MobilePhone.Base.Components.Chargers
{
    public abstract class ChargeBase
    {
        protected BatteryBase BatteryBase;

        protected ChargeBase(BatteryBase batteryBase)
        {
            BatteryBase = batteryBase;
        }
        public abstract void PutOnCharge();
        public abstract void RemoveFromCharge();
        public abstract void GetChargeMethod();
    }
}
