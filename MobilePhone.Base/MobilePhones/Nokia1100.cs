using MobilePhone.Base.Components.Batteries;
using MobilePhone.Base.Components.Speakers;
using MobilePhone.Base.Components.Keyboards;
using MobilePhone.Base.Components.Microphones;
using MobilePhone.Base.Components.Screens;
using MobilePhone.Base.Components.Sim_cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilePhone.Base.Components.SMS;

namespace MobilePhone.Base.MobilePhones
{
    public class Nokia1100:UsualMobilePhoneBase
    {
        private readonly string vModel = "Nokia1100";
        public override string Model { get { return vModel; } }
        private readonly int vSerialNamber;
        public override int SerialNumber {get { return vSerialNamber; }}

        private readonly SMSProvider vSMSProvider = new SMSProvider();
        public override SMSProvider SMSProvider { get { return vSMSProvider; } }

        private readonly SimCardMicro vSimCard = new SimCardMicro();
        public override SimCardBase SimCard { get { return vSimCard; } }

        private readonly MonochromeScreen vScreen = new MonochromeScreen(100,100,100);
        public override ScreenBase Screen { get { return vScreen; } }

        private readonly BatteryLiPoly vBattery = new BatteryLiPoly(3000,5);
        public override BatteryBase Battery { get { return vBattery; } }

        private readonly DynamicUsual vDynamic = new DynamicUsual();
        public override DynamicBase Dynamic { get { return vDynamic; } }

        private readonly MicrophoneUnusualPlass vMicrophone = new MicrophoneUnusualPlass();
        public override MicrophoneBase Microphone { get { return vMicrophone; } }

        private readonly UAKeyboard vKeyboard = new UAKeyboard();
        public override KeyboardBase Keyboard { get { return vKeyboard; } }

        public Nokia1100(int serialNamber)
        {
            vSerialNamber = serialNamber;
        }

        public override void SimCardAdd(int number)
        {
            SimCard.Number = number;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public string GetDescription()
        {
            return base.ToString();
        }

    }
}
