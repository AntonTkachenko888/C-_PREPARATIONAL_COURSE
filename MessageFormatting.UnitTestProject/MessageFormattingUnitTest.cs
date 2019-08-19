using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.Base.Components.SMS;
using MobilePhone.Base.MobilePhones;
using MobilePhone.UnitTestProject;

namespace MessageFormatting.UnitTestProject
{
    [TestClass]
    public class MessageFormattingUnitTest
    {
        
        #region FormatMethods
        [TestMethod]
        public void Format_None_WithOutFormatting()
        {
            //arrange
            var del = FormatMethods.GetFormatMethod("None");
            var testMessage = new Message() { Text = "Hi", User = "Barny", ReceivingTime = new DateTime(1993,03,14)};
            var expectedValue = "Hi";
            //act
            var result = del(testMessage);
            //assert
            Assert.AreEqual(expectedValue, result.Text);
        }
        [TestMethod]
        public void Format_StartWithDateTime()
        {
            //arrange
            var del = FormatMethods.GetFormatMethod("Start with date time");
            var testMessage = new Message() { Text = "Hi", User = "Barny", ReceivingTime = new DateTime(1993, 03, 14) };
            var expectedValue = $"[{testMessage.ReceivingTime}]"+" Hi";
            //act
            var result = del(testMessage);
            //assert
            Assert.AreEqual(expectedValue, result.Text);
        }
        [TestMethod]
        public void Format_EndWithDateTime()
        {
            //arrange
            var del = FormatMethods.GetFormatMethod("End with date time");
            var testMessage = new Message() { Text = "Hi", User = "Barny", ReceivingTime = new DateTime(1993, 03, 14) };
            var expectedValue = $"Hi [{testMessage.ReceivingTime}]";
            //act
            var result = del(testMessage);
            //assert
            Assert.AreEqual(expectedValue, result.Text);
        }
        [TestMethod]
        public void Format_Custom()
        {
            //arrange
            var del = FormatMethods.GetFormatMethod("Custom");
            var testMessage = new Message() { Text = "Hi", User = "Barny", ReceivingTime = new DateTime(1993, 03, 14) };
            var expectedValue = $"@@@Hi [{testMessage.ReceivingTime}]@@@";
            //act
            var result = del(testMessage);
            //assert
            Assert.AreEqual(expectedValue, result.Text);
        }
        [TestMethod]
        public void Format_Lowercase()
        {
            //arrange
            var del = FormatMethods.GetFormatMethod("Lowercase");
            var testMessage = new Message() { Text = "Hi", User = "Barny", ReceivingTime = new DateTime(1993, 03, 14) };
            var expectedValue = "hi";
            //act
            var result = del(testMessage);
            //assert
            Assert.AreEqual(expectedValue, result.Text);
        }
        [TestMethod]
        public void Format_Uppercase()
        {
            //arrange
            var del = FormatMethods.GetFormatMethod("Uppercase");
            var testMessage = new Message() { Text = "Hi", User = "Barny", ReceivingTime = new DateTime(1993, 03, 14) };
            var expectedValue = "HI";
            //act
            var result = del(testMessage);
            //assert
            Assert.AreEqual(expectedValue, result.Text);
        }
        [TestMethod]
        public void Format_WrongFormat_ResurtNoneWithOutFormatting()
        {
            //arrange
            var del = FormatMethods.GetFormatMethod("jmfuyhjkygthgyj");
            var testMessage = new Message() { Text = "Hi", User = "Barny", ReceivingTime = new DateTime(1993, 03, 14) };
            var expectedValue = "Hi";
            //act
            var result = del(testMessage);
            //assert
            Assert.AreEqual(expectedValue, result.Text);
        }
        #endregion

        #region SMSProvider
        private FakeOutput vFakeOutput = new FakeOutput();
        private void OnSMSReceived(IMessage message)
        {
            vFakeOutput.WriteLine(message.Text);
        }
        [TestMethod]
        public void SMSProvider_Event_Raised()
        {
            //arrange
            
            MobilePhoneBase Nokia1100 = new Nokia1100(777);
            Nokia1100.SMSProvider.SMSRecieved += OnSMSReceived;
            var testMessage = new Message() { Text = "Hi", User = "Barny", ReceivingTime = new DateTime(1993, 03, 14) };
            var expectedValue = "Hi";
            //act
            Nokia1100.SMSProvider.RaiseSMSReceivedEvent(testMessage);
            var result = vFakeOutput.Output.Trim();
            vFakeOutput.Clean();
            //assert
            Assert.AreEqual(expectedValue, result);
        }
        #endregion
    }
}
