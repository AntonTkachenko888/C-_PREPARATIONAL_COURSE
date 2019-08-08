using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.GeneralInterfaces;

namespace MobilePhone.Base.Components.HeadSets
{
    public class PhoneSpeaker:IPlayback
    {
        private IOutput Output;

        public PhoneSpeaker(IOutput output)
        {
            Output = output;
        }

        public void Play(object data)
        {
            Output.WriteLine("PhoneSpeaker playback selected");
            Output.WriteLine("Set playback to mobile...");
            Output.WriteLine("Play sound in mobile");
            Output.WriteLine($"{nameof(PhoneSpeaker)} sound: " + (string)data);
        }
    }
}
