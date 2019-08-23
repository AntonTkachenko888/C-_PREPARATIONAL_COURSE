using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Batteries
{
    public class BatteryLiIon: BatteryBase
    {
        private string vBatteryType = "LiIon";

        public override string BatteryType{get{ return vBatteryType; }}


        public BatteryLiIon(int batteryCapacity, int batteryVoltage): base(batteryCapacity, batteryVoltage)
        {
        }

        public override string ToString()
        {
            return $"BatteryLiIon, type {vBatteryType}, battery energy = {BatteryCapacity}, battery voltage = {BatteryVoltage}";
        }
    }
}
