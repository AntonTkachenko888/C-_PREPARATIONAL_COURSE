using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Batterys
{
    public abstract class BatteryBase
    {
        public abstract string BatteryType { get; }

        protected int vBatteryEnergy;
        public virtual int BatteryEnergy
        {
            get { return vBatteryEnergy; }
            private set
            {
                if (value >= 1)
                {
                    vBatteryEnergy = value;
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

        protected BatteryBase(int batteryEnergy, int batteryVoltage)
        {
            vBatteryEnergy = batteryEnergy;
            vBatteryVoltage = batteryVoltage;
        }
    }
}
