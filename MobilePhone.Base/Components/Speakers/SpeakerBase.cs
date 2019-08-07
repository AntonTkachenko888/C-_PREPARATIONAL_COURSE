using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Speakers
{
    public abstract class DynamicBase
    {
        public abstract int Loudness { get; }
        public abstract string MakeSound(ISound sound);
    }
}
