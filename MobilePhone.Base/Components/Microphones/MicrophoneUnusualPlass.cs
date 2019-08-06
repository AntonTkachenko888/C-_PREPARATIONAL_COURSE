using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Microphones
{
    public class MicrophoneUnusualPlass:MicrophoneBase
    {
        private readonly int vMicrophoneSensitivity = 100;
        public override int MicrophoneSensitivity { get { return vMicrophoneSensitivity; } }

        public override string GetSound()
        {
            return "MicrophoneUnusualPlass sound ->  not bad sound";
        }
        public override string ToString()
        {
            return "MicrophoneUnusualPlass, microphone sensitivity = " + vMicrophoneSensitivity;
        }
    }
}
