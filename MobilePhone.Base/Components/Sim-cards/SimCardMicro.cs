using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Sim_cards
{
    public class SimCardMicro:SimCardBase
    {
        private readonly string vType = "Micro";
        public override string Type { get { return vType; } }

        private int? vNumber;
        public override int? Number
        {
            get { return vNumber; }
            set { vNumber = value; }
        }
        public SimCardMicro()
        {
        }
        public SimCardMicro(int number)
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
