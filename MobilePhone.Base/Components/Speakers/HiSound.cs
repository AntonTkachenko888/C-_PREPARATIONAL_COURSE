using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Speakers
{
    public class HiSound:ISound
    {
        private readonly string vSound = "Hi";
        public string Sound { get { return vSound; } }
    }
}
