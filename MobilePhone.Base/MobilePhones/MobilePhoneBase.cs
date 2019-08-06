﻿using MobilePhone.Base.Components.Batterys;
using MobilePhone.Base.Components.Dynamics;
using MobilePhone.Base.Components.Microphones;
using MobilePhone.Base.Components.Screens;
using MobilePhone.Base.Components.Sim_cards;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.Base.MobilePhones
{
    public abstract class MobilePhoneBase
    {
        public abstract int SerialNamber { get; }
        public abstract SimCardBase SimCard { get; }
        public abstract ScreenBase Screen { get; }
        public abstract BatteryBase Battery { get; }
        public abstract DynamicBase Dynamic { get; }
        public abstract MicrophoneBase Microphone { get; }

        public abstract void SimCardAdd(int namber);
        public string GetDescription()
        {
            var descriptionBuilder = new StringBuilder();
            descriptionBuilder.AppendLine(this.ToString());
            descriptionBuilder.AppendLine($"SerialNamber: {SerialNamber.ToString()}");
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