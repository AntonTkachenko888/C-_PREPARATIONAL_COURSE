using MobilePhone.Base.MobilePhones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MobilePhone.Base.Components.Chargers;
using MobilePhone.Base.Components.HeadSets;

namespace MobilePhone.WindowsFormsApp
{
    public partial class MobilePhone : Form
    {
        private readonly MobilePhoneBase Nokia1100 = new Nokia1100(777);
        private Headsets currentHeadsets;
        private Charges currentCharges;
        private FormOutput formOutput;
        public MobilePhone()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            formOutput = new FormOutput(richTextBoxOutWindow);

            currentHeadsets = GetSelectedHeadset();
            currentCharges = GetSelectedCharge();

            labelCurentPhone.Text = labelCurentPhone.Text + " " + Nokia1100.Model;
            richTextBoxOutWindow.ReadOnly = true;
        }

        private void button_ApplyPlayback_Click(object sender, EventArgs e)
        {
            Nokia1100.PlaybackComponent = HeadsetFactory.GetHeadset(currentHeadsets, formOutput);
            Nokia1100.Play("Hi");
        }
        
        private void button_ApplyCharger_Click(object sender, EventArgs e)
        {
            Nokia1100.ChargerComponent = ChargeFactory.GetCharge(currentCharges, formOutput);
            Nokia1100.Charge();
        }
        
        #region radioButton_Headsets
        private void radioButton_iPhoneHeadset_CheckedChanged(object sender, EventArgs e)
        {
            currentHeadsets = GetSelectedHeadset();
        }

        private void radioButton_SamsungHeadset_CheckedChanged(object sender, EventArgs e)
        {
            currentHeadsets = GetSelectedHeadset();
        }

        private void radioButton_UnofficialiPhoneHeadset_CheckedChanged(object sender, EventArgs e)
        {
            currentHeadsets = GetSelectedHeadset();
        }

        private void radioButton_PhoneSpeaker_CheckedChanged(object sender, EventArgs e)
        {
            currentHeadsets = GetSelectedHeadset();
        }
        #endregion

        #region radioButton_Charges
        private void radioButton_FastCharge_CheckedChanged(object sender, EventArgs e)
        {
            currentCharges = GetSelectedCharge();
        }

        private void radioButton_UsualCharge_CheckedChanged(object sender, EventArgs e)
        {
            currentCharges = GetSelectedCharge();
        }
        #endregion

        private void button_Clean_Click(object sender, EventArgs e)
        {
            richTextBoxOutWindow.Clear();
        }

        #region AditionalMethods
        private Headsets GetSelectedHeadset()
        {
            if (radioButton_iPhoneHeadset.Checked)
            {
                return Headsets.iPhoneHeadset;
            }
            else if (radioButton_SamsungHeadset.Checked)
            {
                return Headsets.SamsungHeadset;
            }
            else if (radioButton_UnofficialiPhoneHeadset.Checked)
            {
                return Headsets.UnofficialiPhoneHeadset;
            }
            else if (radioButton_PhoneSpeaker.Checked)
            {
                return Headsets.PhoneSpeaker;
            }
            throw new ArgumentOutOfRangeException();
        }
        private Charges GetSelectedCharge()
        {
            if (radioButton_FastCharge.Checked)
            {
                return Charges.FastCharge;
            }
            else if (radioButton_UsualCharge.Checked)
            {
                return Charges.UsualCharge;
            }
            throw new ArgumentOutOfRangeException();
        }
        #endregion
        
    }
}
