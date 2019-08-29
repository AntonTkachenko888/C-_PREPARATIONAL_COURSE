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
using MobilePhone.Base.Components.Calls;
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

        private readonly Storage vStorage;
        public override Storage Storage { get { return vStorage; } }

        private readonly CallProvider vCallProvider = new CallProvider();
        public override CallProvider CallProvider { get { return vCallProvider; } }

        private readonly CallsHistory vCallsHistory;
        public override CallsHistory CallsHistory { get { return vCallsHistory; } }

        private readonly SimCardMicro vSimCard = new SimCardMicro();
        public override SimCardBase SimCard { get { return vSimCard; } }

        private readonly MonochromeScreen vScreen = new MonochromeScreen(100,100,100);
        public override ScreenBase Screen { get { return vScreen; } }

        private readonly BatteryLiPoly vBattery = new BatteryLiPoly(100,5);
        public override BatteryBase Battery { get { return vBattery; } }

        private readonly DynamicUsual vDynamic = new DynamicUsual();
        public override DynamicBase Dynamic { get { return vDynamic; } }

        private readonly MicrophoneUnusualPlass vMicrophone = new MicrophoneUnusualPlass();
        public override MicrophoneBase Microphone { get { return vMicrophone; } }

        private readonly UAKeyboard vKeyboard = new UAKeyboard();
        public override KeyboardBase Keyboard { get { return vKeyboard; } }

        private Nokia1100()
        {
            vStorage = new Storage(SMSProvider);
            vCallsHistory = new CallsHistory(CallProvider);
        }
        public Nokia1100(int serialNamber):this()
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
