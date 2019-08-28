using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Calls
{
    public class Call:ICall
    {
        public int PhoneNamber { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime CallTime { get; set; }

        public Contact Contact  { get; set; }
    }
}
