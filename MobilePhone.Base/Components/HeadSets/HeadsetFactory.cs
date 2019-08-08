using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.GeneralInterfaces;

namespace MobilePhone.Base.Components.HeadSets
{
    public static class HeadsetFactory
    {
        public static IPlayback GetHeadset(Headsets headsets, IOutput output)
        {
            IPlayback playback = null;
            switch (headsets)
            {
                case Headsets.iPhoneHeadset:
                    playback = new iPhoneHeadset(output);
                    break;
                case Headsets.SamsungHeadset:
                    playback = new SamsungHeadset(output);
                    break;
                case Headsets.UnofficialiPhoneHeadset:
                    playback = new UnofficialiPhoneHeadset(output);
                    break;
                case Headsets.PhoneSpeaker:
                    playback = new PhoneSpeaker(output);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return playback;
        }
    }
}
