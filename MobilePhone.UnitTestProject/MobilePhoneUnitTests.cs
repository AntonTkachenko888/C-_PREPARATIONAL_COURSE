using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.Base.Components.Chargers;
using MobilePhone.Base.Components.HeadSets;
using MobilePhone.Base.MobilePhones;

namespace MobilePhone.UnitTestProject
{
    [TestClass]
    public class MobilePhoneUnitTests
    {
        private readonly MobilePhoneBase vNokia1100 = new Nokia1100(777);
        private readonly FakeOutput vFakeOutput = new FakeOutput();
        
        #region HeadsetTests
        [TestMethod]
        public void iPhoneHeadsetTestMethod()
        {
            //arrange
            vNokia1100.PlaybackComponent = HeadsetFactory.GetHeadset(Headsets.iPhoneHeadset, vFakeOutput);
            string controlValue = "\niPhoneHeadset playback selected"+
                                    "\nSet playback to mobile..." +
                                    "\nPlay sound in mobile" +
                                    "\niPhoneHeadset sound: Hi";
            //act
            vNokia1100.Play("Hi");
            //assert
            Assert.AreEqual(controlValue, vFakeOutput.Output);
        }
        [TestMethod]
        public void SamsungHeadsetTestMethod()
        {
            //arrange
            vNokia1100.PlaybackComponent = HeadsetFactory.GetHeadset(Headsets.SamsungHeadset, vFakeOutput);
            string controlValue = "\nSamsungHeadset playback selected" +
                                    "\nSet playback to mobile..." +
                                    "\nPlay sound in mobile" +
                                    "\nSamsungHeadset sound: Hi";
            //act
            vNokia1100.Play("Hi");
            //assert
            Assert.AreEqual(controlValue, vFakeOutput.Output);
        }
        [TestMethod]
        public void UnofficialiPhoneHeadsetTestMethod()
        {
            //arrange
            vNokia1100.PlaybackComponent = HeadsetFactory.GetHeadset(Headsets.UnofficialiPhoneHeadset, vFakeOutput);
            string controlValue = "\nUnofficialiPhoneHeadset playback selected" +
                                    "\nSet playback to mobile..." +
                                    "\nPlay sound in mobile" +
                                    "\nUnofficialiPhoneHeadset sound: Hi";
            //act
            vNokia1100.Play("Hi");
            //assert
            Assert.AreEqual(controlValue, vFakeOutput.Output);
        }
        [TestMethod]
        public void PhoneSpeakerTestMethod()
        {
            //arrange
            vNokia1100.PlaybackComponent = HeadsetFactory.GetHeadset(Headsets.PhoneSpeaker, vFakeOutput);
            string controlValue = "\nPhoneSpeaker playback selected" +
                                    "\nSet playback to mobile..." +
                                    "\nPlay sound in mobile" +
                                    "\nPhoneSpeaker sound: Hi";
            //act
            vNokia1100.Play("Hi");
            //assert
            Assert.AreEqual(controlValue, vFakeOutput.Output);
        }
        #endregion
        #region ChargerTests
        [TestMethod]
        public void FastChargeTestMethod()
        {
            //arrange
            vFakeOutput.Clean();
            vNokia1100.ChargerComponent = ChargeFactory.GetCharge(Charges.FastCharge, vFakeOutput);
            string controlValue = "\nFastCharge charging fast";
            //act
            vNokia1100.Charge();
            //assert
            Assert.AreEqual(controlValue, vFakeOutput.Output);
        }
        [TestMethod]
        public void UsualChargeTestMethod()
        {
            //arrange
            vFakeOutput.Clean();
            vNokia1100.ChargerComponent = ChargeFactory.GetCharge(Charges.UsualCharge, vFakeOutput);
            string controlValue = "\nUsualCharge charging slowly";
            //act
            vNokia1100.Charge();
            //assert
            Assert.AreEqual(controlValue, vFakeOutput.Output);
        }
        #endregion
    }
}
