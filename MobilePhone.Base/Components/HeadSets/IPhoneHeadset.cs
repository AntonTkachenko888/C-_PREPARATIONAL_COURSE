using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.GeneralInterfaces;

namespace MobilePhone.Base.Components.HeadSets
{
    public class iPhoneHeadset :IPlayback
    {
        private IOutput Output;

        public iPhoneHeadset(IOutput output)
        {
            Output = output;
        }

        public void Play(object data)
        {
            Output.WriteLine("iPhoneHeadset playback selected");
            Output.WriteLine("Set playback to mobile...");
            Output.WriteLine("Play sound in mobile");
            Output.WriteLine($"{nameof(iPhoneHeadset)} sound: " + (string)data);
        }
    }
}
