using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Batteries
{
    public abstract class BatteryBase
    {
        public event Action BatteryChargeChanged;
        public abstract string BatteryType { get; }

        protected int vBatteryCapacity;
        public virtual int BatteryCapacity
        {
            get { return vBatteryCapacity; }
            set
            {
                if (value >= 0)
                {
                    vBatteryCapacity = value;
                    if (BatteryChargeChanged!=null)
                        BatteryChargeChanged.Invoke();
                }
                else
                {
                    throw new Exception("Value can't be less than 0");
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

        private Thread threadPhoneActive;
        private bool IsTaskActivePhoneActive;
        public virtual void PhoneRun()
        {
            if (!IsTaskActivePhoneActive)
            {
                threadPhoneActive = new Thread(() =>
                {
                    while (true)
                    {
                        ChargeAction(-1);
                        Thread.Sleep(1 * 1000);
                    }
                });
                threadPhoneActive.IsBackground = true;
                threadPhoneActive.Start();
                IsTaskActivePhoneActive = true;
            }
        }
        public void ChargeAction(int value)
        {
            lock (new object())
            {
                if ((BatteryCapacity + value >= 0) & (BatteryCapacity + value <= 100))
                {
                    BatteryCapacity += value;
                }
            }
        }
        public virtual void TurnOffPhone()
        {
            if (IsTaskActivePhoneActive)
            {
                threadPhoneActive.Abort();
                IsTaskActivePhoneActive = false;
            }
        }
    }
}
