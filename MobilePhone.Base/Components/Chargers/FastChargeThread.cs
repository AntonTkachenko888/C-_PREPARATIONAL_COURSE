using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MobilePhone.Base.Components.Batteries;
using MobilePhone.Base.Components.HeadSets;
using MobilePhone.Base.GeneralInterfaces;

namespace MobilePhone.Base.Components.Chargers
{
    public class FastChargeThread:ChargeBase
    {
        private IOutput Output;

        public FastChargeThread(BatteryBase batteryBase, IOutput output):base(batteryBase)
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
                        BatteryBase.ChargeAction(3);
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
            Output.WriteLine($"{nameof(FastChargeThread)} charging fast");
        }
    }
}
