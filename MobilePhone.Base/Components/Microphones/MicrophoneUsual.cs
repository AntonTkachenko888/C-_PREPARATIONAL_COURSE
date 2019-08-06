using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Microphones
{
    public class MicrophoneUsual:MicrophoneBase
    {
        private readonly int vMicrophoneSensitivity = 50;
        public override int MicrophoneSensitivity { get { return vMicrophoneSensitivity; } }

        public override string GetSound()
        {
            return "MicrophoneUsual sound ->  not bad sound";
        }
        public override string ToString()
        {
            return "MicrophoneUsual, microphone sensitivity = " + vMicrophoneSensitivity;
        }
    }
}
