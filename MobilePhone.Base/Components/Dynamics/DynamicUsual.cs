using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Dynamics
{
    public class DynamicUsual:DynamicBase
    {
        private readonly int vLoudness = 5;
        public override int Loudness { get { return vLoudness; } }

        public override string MakeSound(ISound sound)
        {
            return "DynamicUsual sound -> " + sound.Sound;
        }
        public override string ToString()
        {
            return "DynamicUsual, loudness = " + vLoudness;
        }
    }
}
