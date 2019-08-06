using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Batterys
{
    public class BatteryLiIon: BatteryBase
    {
        private readonly string vBatteryType = "LiIon";
        public override string BatteryType { get { return vBatteryType; } }


        public BatteryLiIon(int batteryEnergy, int batteryVoltage): base(batteryEnergy, batteryVoltage)
        {
        }

        public override string ToString()
        {
            return $"BatteryLiIon, type {vBatteryType}, battery energy = {BatteryEnergy}, battery voltage = {BatteryVoltage}";
        }
    }
}
