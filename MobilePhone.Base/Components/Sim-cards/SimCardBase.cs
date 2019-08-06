using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Sim_cards
{
    public abstract class SimCardBase
    {
        public abstract string Type { get; }
        public abstract int? Namber { get; set; }
        
    }
}
