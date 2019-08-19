using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhone.Base.Components.SMS;
using MobilePhone.Base.MobilePhones;
using SMSSender;

namespace MobilePhone.WindowsFormsApp
{
    public partial class L3_MessageFormatting : Form
    {
        private readonly MobilePhoneBase Nokia1100 = new Nokia1100(777);
        private SmsSender SmsSender;
        private FormOutput formOutput;
        public L3_MessageFormatting()
        {
            InitializeComponent();

            Nokia1100.SMSProvider.SMSRecieved += OnSMSReceived;
            SmsSender = new SmsSender(Nokia1100);
        }
        private void L3_MessageFormatting_Load(object sender, EventArgs e)
        {
            SmsSender.TimerTick(1);
            formOutput = new FormOutput(richTextBox_MessageOutBox);
        }

        private void OnSMSReceived(IMessage message)
        {
            if (InvokeRequired)
            {
                Invoke(new SMSProvider.SMSReceivedDelegate(OnSMSReceived), message);
                return;
            }
            formOutput.WriteLine(FormatedMessage(message).Text);
        }

        private IMessage FormatedMessage(IMessage message)
        {
            return FormatMethods.GetFormatMethod(comboBox_FormattingOptions.SelectedText).Invoke(message);
        }
    }
}
