using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.Base.Components.Chargers;
using MobilePhone.Base.Components.HeadSets;
using MobilePhone.Base.MobilePhones;
using MobilePhone.UnitTestProject;

namespace MobilePhone.ThreadingTasksUnitTestProject
{
    [TestClass]
    public class ThreadingUnitTest
    {
        private readonly MobilePhoneBase vNokia1100 = new Nokia1100(777);
        private readonly FakeOutput vFakeOutput = new FakeOutput();
        
        #region ChargerTests
        [TestMethod]
        public void Charge_CanNotBeLessThanZero_True()
        {
            //arrange
            //act
            vNokia1100.Battery.BatteryCapacity = 1;
            vNokia1100.Battery.PhoneRun();
            Thread.Sleep(5*1000);
            //assert
            Assert.IsTrue(vNokia1100.Battery.BatteryCapacity>=0);
        }
        [TestMethod]
        public void Charge_CanNotBeMoreThanOneHundred_True()
        {
            //arrange
            vNokia1100.ChargerComponent = ChargeFactory.GetCharge(Charges.FastChargeThread, vNokia1100.Battery, vFakeOutput);
            //act
            vNokia1100.Battery.PhoneRun();
            vNokia1100.ChargerComponent.PutOnCharge();
            Thread.Sleep(5 * 1000);
            //assert
            Assert.IsTrue(vNokia1100.Battery.BatteryCapacity <= 100);
        }

        [TestMethod]
        public void ChargeThread_NotTurnedOn_Decreased()
        {
            //arrange
            vNokia1100.ChargerComponent = ChargeFactory.GetCharge(Charges.FastChargeThread, vNokia1100.Battery, vFakeOutput);
            //act
            vNokia1100.Battery.PhoneRun();
            Thread.Sleep(5 * 1000);
            //assert
            Assert.IsTrue(vNokia1100.Battery.BatteryCapacity <= 95);
        }
        [TestMethod]
        public void ChargeThread_TurnedOn_Increased()
        {
            //arrange
            vNokia1100.ChargerComponent = ChargeFactory.GetCharge(Charges.FastChargeThread, vNokia1100.Battery, vFakeOutput);
            //act
            vNokia1100.Battery.PhoneRun();
            vNokia1100.Battery.BatteryCapacity = 50;
            vNokia1100.ChargerComponent.PutOnCharge();
            Thread.Sleep(5 * 1000);
            //assert
            Assert.IsTrue(vNokia1100.Battery.BatteryCapacity >= 60);
        }

        [TestMethod]
        public void ChargeTask_NotTurnedOn_Decreased()
        {
            //arrange
            vNokia1100.ChargerComponent = ChargeFactory.GetCharge(Charges.FastChargeTask, vNokia1100.Battery, vFakeOutput);
            //act
            vNokia1100.Battery.PhoneRun();
            Thread.Sleep(5 * 1000);
            //assert
            Assert.IsTrue(vNokia1100.Battery.BatteryCapacity <= 95);
        }
        [TestMethod]
        public void ChargeTask_TurnedOn_Increased()
        {
            //arrange
            vNokia1100.ChargerComponent = ChargeFactory.GetCharge(Charges.FastChargeTask, vNokia1100.Battery, vFakeOutput);
            //act
            vNokia1100.Battery.PhoneRun();
            vNokia1100.Battery.BatteryCapacity = 50;
            vNokia1100.ChargerComponent.PutOnCharge();
            Thread.Sleep(5 * 1000);
            //assert
            Assert.IsTrue(vNokia1100.Battery.BatteryCapacity >= 60);
        }
        #endregion
    }
}
