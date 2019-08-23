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
    public class FastChargeTask : ChargeBase
    {
        private IOutput Output;

        public FastChargeTask(BatteryBase batteryBase,IOutput output):base(batteryBase)
        {
            Output = output;
        }

        private Task taskCharge;
        private CancellationTokenSource cancelTokSrcCharge;
        private bool IsTaskActiveCharge;
        public override void PutOnCharge()
        {
            if (!IsTaskActiveCharge)
            {
                cancelTokSrcCharge = new CancellationTokenSource();
                taskCharge = Task.Run(() => Charging(cancelTokSrcCharge.Token));
                IsTaskActiveCharge = true;
            }
        }
        private void Charging(CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested)
                    return;
                BatteryBase.ChargeAction(3);
                Thread.Sleep(1 * 1000);
            }
        }
        public override void RemoveFromCharge()
        {
            if (IsTaskActiveCharge)
            {
                cancelTokSrcCharge.Cancel();
                IsTaskActiveCharge = false;
            }
        }

        public override void GetChargeMethod()
        {
            Output.WriteLine($"{nameof(FastChargeTask)} charging fast");
        }
    }
}
