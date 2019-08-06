﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Batterys
{
    public class BatteryLiPoly: BatteryBase
    {
        private readonly string vBatteryType = "LiPoly";
        public override string BatteryType{get { return vBatteryType; }}
        
        public BatteryLiPoly(int batteryEnergy,int batteryVoltage): base(batteryEnergy, batteryVoltage)
        {
        }
        public override int BatteryVoltage
        {
            get { return vBatteryVoltage; }
            protected set
            {
                if (value < 7)
                {
                    vBatteryVoltage = value;
                }
                else
                {
                    throw new Exception("Value can't be more than 7");
                }
            }
        }
        public override string ToString()
        {
            return $"BatteryLiPoly, type {vBatteryType}, battery energy = {BatteryEnergy}, battery voltage = {BatteryVoltage}";
        }

    }
}
