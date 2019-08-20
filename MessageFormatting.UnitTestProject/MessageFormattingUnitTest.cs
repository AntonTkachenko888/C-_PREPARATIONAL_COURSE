using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void Format_WrongFormat_FormatinfList()
        {
            //arrange
            var del = FormatMethods.GetFormatMethod("Lowercase");
            var testMessage = new List<Message>();
            testMessage.Add(new Message() {Text = "Hi1", User = "Barny", ReceivingTime = new DateTime(1993, 03, 14)});
            testMessage.Add(new Message() { Text = "Hi2", User = "Barny", ReceivingTime = new DateTime(1993, 03, 14) });
            testMessage.Add(new Message() { Text = "Hi3", User = "Barny", ReceivingTime = new DateTime(1993, 03, 14) });
            var expectedValue = new List<Message>();
            expectedValue.Add(new Message() { Text = "hi1", User = "Barny", ReceivingTime = new DateTime(1993, 03, 14) });
            expectedValue.Add(new Message() { Text = "hi2", User = "Barny", ReceivingTime = new DateTime(1993, 03, 14) });
            expectedValue.Add(new Message() { Text = "hi3", User = "Barny", ReceivingTime = new DateTime(1993, 03, 14) });
            //act
            foreach (var item in testMessage)
            {
                item.Text = del(item).Text;
            }
            //assert
            Assert.AreEqual(testMessage[0].Text, expectedValue[0].Text);
            Assert.AreEqual(testMessage[1].Text, expectedValue[1].Text);
            Assert.AreEqual(testMessage[2].Text, expectedValue[2].Text);
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
