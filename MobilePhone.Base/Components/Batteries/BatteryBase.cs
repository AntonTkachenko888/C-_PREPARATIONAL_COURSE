using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Batteries
{
    public abstract class BatteryBase
    {
        public abstract string BatteryType { get; }

        protected int vBatteryCapacity;
        public virtual int BatteryCapacity
        {
            get { return vBatteryCapacity; }
            private set
            {
                if (value >= 1)
                {
                    vBatteryCapacity = value;
                }
                else
                {
                    throw new Exception("Value can't be less than 1");
                }
            }
        }

        protected int vBatteryVoltage;
        public virtual int BatteryVoltage
        {
            get { return vBatteryVoltage; }
            protected set
            {
                if (value < 10)
                {
                    vBatteryVoltage = value;
                }
                else
                {
                    throw new Exception("Value can't be more than 10");
                }
            }
        }

        protected BatteryBase(int batteryCapacity, int batteryVoltage)
        {
            vBatteryCapacity = batteryCapacity;
            vBatteryVoltage = batteryVoltage;
        }
    }
}
