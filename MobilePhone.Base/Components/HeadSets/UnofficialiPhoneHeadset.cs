using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.GeneralInterfaces;

namespace MobilePhone.Base.Components.HeadSets
{
    public class UnofficialiPhoneHeadset :IPlayback
    {
        private IOutput Output;

        public UnofficialiPhoneHeadset(IOutput output)
        {
            Output = output;
        }

        public void Play(object data)
        {
            Output.WriteLine("UnofficialiPhoneHeadset playback selected");
            Output.WriteLine("Set playback to mobile...");
            Output.WriteLine("Play sound in mobile");
            Output.WriteLine($"{nameof(UnofficialiPhoneHeadset)} sound: " + (string)data);
        }
    }
}
