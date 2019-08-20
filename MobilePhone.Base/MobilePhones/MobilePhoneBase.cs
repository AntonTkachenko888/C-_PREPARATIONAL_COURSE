using MobilePhone.Base.Components.Batteries;
using MobilePhone.Base.Components.Speakers;
using MobilePhone.Base.Components.Microphones;
using MobilePhone.Base.Components.Screens;
using MobilePhone.Base.Components.Sim_cards;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.Components.Chargers;
using MobilePhone.Base.Components.HeadSets;
using MobilePhone.Base.Components.SMS;

namespace MobilePhone.Base.MobilePhones
{
    public abstract class MobilePhoneBase
    {
        public abstract Storage Storage { get; }
        public abstract SMSProvider SMSProvider { get; }
        public abstract string Model { get; }
        public abstract int SerialNumber { get; }
        public abstract SimCardBase SimCard { get; }
        public abstract ScreenBase Screen { get; }
        public abstract BatteryBase Battery { get; }
        public abstract DynamicBase Dynamic { get; }
        public abstract MicrophoneBase Microphone { get; }

        public IPlayback PlaybackComponent { get; set; }
        public ICharger ChargerComponent { get; set; }

        public void Play(object data)
        {
            PlaybackComponent.Play(data);
        }
        public void Charge()
        {
            ChargerComponent.Charge();
        }
        public abstract void SimCardAdd(int number);
        public override string ToString()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine($"Model: {Model.ToString()}");
            descriptionBuilder.AppendLine($"SerialNamber: {SerialNumber.ToString()}");
            descriptionBuilder.AppendLine($"SimCard Type: {SimCard.ToString()}");
            descriptionBuilder.AppendLine($"Screen Type: {Screen.ToString()}");
            descriptionBuilder.AppendLine($"Battery Type: {Battery.ToString()}");
            descriptionBuilder.AppendLine($"Dynamic Type: {Dynamic.ToString()}");
            descriptionBuilder.AppendLine($"Microphone Type: {Microphone.ToString()}");
            return descriptionBuilder.ToString();
        }

        public virtual string Call(int phoneNamber)
        {
            return "You are calling to "+ phoneNamber;
        }


    }
}
