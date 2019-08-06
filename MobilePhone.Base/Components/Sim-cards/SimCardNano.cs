﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Sim_cards
{
    public class SimCardNano:SimCardBase
    {
        private readonly string vType = "Nano";
        public override string Type { get { return vType; } }

        private int? vNamber;
        public override int? Namber
        {
            get { return vNamber; }
            set { vNamber = value; }
        }
        public SimCardNano()
        {
        }
        public SimCardNano(int namber)
        {
            vNamber = namber;
        }
        public override string ToString()
        {
            if (Namber == null)
            {
                return "Slot = SimCardMicro, simcard not instaled";
            }
            else
            {
                return "SimCardNano, namber = " + vNamber;
            }
        }
    }
}
