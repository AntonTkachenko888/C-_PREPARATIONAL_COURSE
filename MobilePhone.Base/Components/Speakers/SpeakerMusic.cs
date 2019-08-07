using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Speakers
{
    public class DynamicMusic:DynamicBase
    {
        private readonly int vLoudness = 10;
        public override int Loudness { get { return vLoudness; } }

        public override string MakeSound(ISound sound)
        {
            return "DynamicMusic sound -> " + sound.Sound;
        }
        public override string ToString()
        {
            return "DynamicMusic, loudness = "+ vLoudness;
        }
    }
}
