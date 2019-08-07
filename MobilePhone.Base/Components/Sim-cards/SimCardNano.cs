using System;
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

        private int? vNumber;
        public override int? Number
        {
            get { return vNumber; }
            set { vNumber = value; }
        }
        public SimCardNano()
        {
        }
        public SimCardNano(int number)
        {
            vNumber = number;
        }
        public override string ToString()
        {
            if (Number == null)
            {
                return "Slot = SimCardMicro, simcard not instaled";
            }
            else
            {
                return "SimCardNano, Number = " + vNumber;
            }
        }
    }
}
