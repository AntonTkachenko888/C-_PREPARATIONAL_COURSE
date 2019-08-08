using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.GeneralInterfaces;

namespace MobilePhone.Base.Components.HeadSets
{
    public class SamsungHeadset :IPlayback
    {
        private IOutput Output;

        public SamsungHeadset(IOutput output)
        {
            Output = output;
        }

        public void Play(object data)
        {
            Output.WriteLine("SamsungHeadset playback selected");
            Output.WriteLine("Set playback to mobile...");
            Output.WriteLine("Play sound in mobile");
            Output.WriteLine($"{nameof(SamsungHeadset)} sound: " + (string)data);
        }
    }
}
