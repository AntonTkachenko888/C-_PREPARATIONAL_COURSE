using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.Components.Microphones
{
    public abstract class MicrophoneBase
    {
        public abstract int MicrophoneSensitivity { get; }
        public abstract string GetSound();
    }
}
