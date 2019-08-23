using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MobilePhone.Base.Components.Batteries;
using MobilePhone.Base.GeneralInterfaces;

namespace MobilePhone.Base.Components.Chargers
{
    public class UsualChargeThread : ChargeBase
    {
        private IOutput Output;
        public UsualChargeThread(BatteryBase batteryBase, IOutput output):base(batteryBase)
        {
            Output = output;
        }
        private Thread threadCharge;
        private bool IsTaskActiveCharge;
        public override void PutOnCharge()
        {
            if (!IsTaskActiveCharge)
            {
                threadCharge = new Thread(() =>
                {
                    while (true)
                    {
                        BatteryBase.ChargeAction(2);
                        Thread.Sleep(1 * 1000);
                    }
                });
                threadCharge.IsBackground = true;
                threadCharge.Start();
                IsTaskActiveCharge = true;
            }
        }

        public override void RemoveFromCharge()
        {
            if (IsTaskActiveCharge)
            {
                threadCharge.Abort();
                IsTaskActiveCharge = false;
            }
        }
        public override void GetChargeMethod()
        {
            Output.WriteLine($"{nameof(UsualChargeThread)} charging slowly");
        }
    }
}
