using System;
using System.Linq;
using System.Runtime.ExceptionServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.Base.Components.SMS;

namespace MobilePhone.MessageFiltering.UnitTestProject
{
    [TestClass]
    public class MessageFiltering_UnitTest
    {
        #region MessageFiltering
        [TestMethod]
        public void Filtering_User_Homer()
        {
            //arrange
            SMSProvider smsProvider = new SMSProvider();
            Storage storage = new Storage(smsProvider);
            MessageFilteringParams messageFilteringParams = new MessageFilteringParams();
            messageFilteringParams.SelectedUser = "Homer";
            messageFilteringParams.UsersSortOptions = SortOptions.AND;
            messageFilteringParams.MessageText = "";
            messageFilteringParams.MessageTextSortOptions = SortOptions.AND;
            messageFilteringParams.FromDate = DateTime.MinValue;
            messageFilteringParams.BeforeDate= DateTime.MaxValue;
            messageFilteringParams.FormattingOptions = "None";

            var expected = new Message()
            {
                User = "Homer",
                Text = "D’Oh!",
                ReceivingTime = new DateTime(1994, 3, 14, 10, 14, 23)
            };

            //act
            var user = storage.GetMessages(messageFilteringParams).First();
            //assert
            Assert.IsTrue(expected.User == user.User);
            Assert.IsTrue(expected.Text == user.Text);
            Assert.IsTrue(expected.ReceivingTime == user.ReceivingTime);
        }
        [TestMethod]
        public void Filtering_Message_Boring()
        {
            //arrange
            SMSProvider smsProvider = new SMSProvider();
            Storage storage = new Storage(smsProvider);
            MessageFilteringParams messageFilteringParams = new MessageFilteringParams();
            messageFilteringParams.SelectedUser = "";
            messageFilteringParams.UsersSortOptions = SortOptions.AND;
            messageFilteringParams.MessageText = "Boring";
            messageFilteringParams.MessageTextSortOptions = SortOptions.AND;
            messageFilteringParams.FromDate = DateTime.MinValue;
            messageFilteringParams.BeforeDate = DateTime.MaxValue;
            messageFilteringParams.FormattingOptions = "None";

            var expected = new Message()
            {
                User = "Homer",
                Text = "Boring!",
                ReceivingTime = new DateTime(1996, 3, 14, 10, 14, 23)
            };

            //act
            var user = storage.GetMessages(messageFilteringParams).First();
            //assert
            Assert.IsTrue(expected.User == user.User);
            Assert.IsTrue(expected.Text == user.Text);
            Assert.IsTrue(expected.ReceivingTime == user.ReceivingTime);
        }
        [TestMethod]
        public void Filtering_DateTime_Marge()
        {
            //arrange
            SMSProvider smsProvider = new SMSProvider();
            Storage storage = new Storage(smsProvider);
            MessageFilteringParams messageFilteringParams = new MessageFilteringParams();
            messageFilteringParams.SelectedUser = "";
            messageFilteringParams.UsersSortOptions = SortOptions.AND;
            messageFilteringParams.MessageText = "";
            messageFilteringParams.MessageTextSortOptions = SortOptions.AND;
            messageFilteringParams.FromDate = new DateTime(1994, 3, 14, 10, 14, 23);
            messageFilteringParams.BeforeDate = new DateTime(1996, 3, 14, 10, 14, 23);
            messageFilteringParams.FormattingOptions = "None";

            var expected = new Message()
            {
                User = "Marge",
                Text = "You have no idea what it's like, being married to you.",
                ReceivingTime = new DateTime(1995, 3, 14, 10, 14, 23)
            };

            //act
            var user = storage.GetMessages(messageFilteringParams).First();
            //assert
            Assert.IsTrue(expected.User == user.User);
            Assert.IsTrue(expected.Text == user.Text);
            Assert.IsTrue(expected.ReceivingTime == user.ReceivingTime);
        }
        [TestMethod]
        public void Filtering_AND_HomerBoring()
        {
            //arrange
            SMSProvider smsProvider = new SMSProvider();
            Storage storage = new Storage(smsProvider);
            MessageFilteringParams messageFilteringParams = new MessageFilteringParams();
            messageFilteringParams.SelectedUser = "Homer";
            messageFilteringParams.UsersSortOptions = SortOptions.AND;
            messageFilteringParams.MessageText = "B";
            messageFilteringParams.MessageTextSortOptions = SortOptions.AND;
            messageFilteringParams.FromDate = new DateTime(1995, 3, 14, 10, 14, 23);
            messageFilteringParams.BeforeDate = new DateTime(1997, 3, 14, 10, 14, 23);
            messageFilteringParams.FormattingOptions = "None";

            var expected = new Message()
            {
                User = "Homer",
                Text = "Boring!",
                ReceivingTime = new DateTime(1996, 3, 14, 10, 14, 23)
            };

            //act
            var user = storage.GetMessages(messageFilteringParams).First();
            //assert
            Assert.IsTrue(expected.User == user.User);
            Assert.IsTrue(expected.Text == user.Text);
            Assert.IsTrue(expected.ReceivingTime == user.ReceivingTime);
        }
        [TestMethod]
        public void Filtering_OR_HomerBoring()
        {
            //arrange
            SMSProvider smsProvider = new SMSProvider();
            Storage storage = new Storage(smsProvider);
            MessageFilteringParams messageFilteringParams = new MessageFilteringParams();
            messageFilteringParams.SelectedUser = "Vasia";
            messageFilteringParams.UsersSortOptions = SortOptions.OR;
            messageFilteringParams.MessageText = "B";
            messageFilteringParams.MessageTextSortOptions = SortOptions.OR;
            messageFilteringParams.FromDate = new DateTime(1998, 3, 14, 10, 14, 23);
            messageFilteringParams.BeforeDate = new DateTime(1999, 3, 14, 10, 14, 23);
            messageFilteringParams.FormattingOptions = "None";

            var expected = new Message()
            {
                User = "Homer",
                Text = "Boring!",
                ReceivingTime = new DateTime(1996, 3, 14, 10, 14, 23)
            };

            //act
            var user = storage.GetMessages(messageFilteringParams).First();
            //assert
            Assert.IsTrue(expected.User == user.User);
            Assert.IsTrue(expected.Text == user.Text);
            Assert.IsTrue(expected.ReceivingTime == user.ReceivingTime);
        }
        [TestMethod]
        public void Filtering_ORAND_HomerBoring()
        {
            //arrange
            SMSProvider smsProvider = new SMSProvider();
            Storage storage = new Storage(smsProvider);
            MessageFilteringParams messageFilteringParams = new MessageFilteringParams();
            messageFilteringParams.SelectedUser = "Vasia";
            messageFilteringParams.UsersSortOptions = SortOptions.AND;
            messageFilteringParams.MessageText = "Boring";
            messageFilteringParams.MessageTextSortOptions = SortOptions.OR;
            messageFilteringParams.FromDate = new DateTime(1995, 3, 14, 10, 14, 23);
            messageFilteringParams.BeforeDate = new DateTime(1997, 3, 14, 10, 14, 23);
            messageFilteringParams.FormattingOptions = "None";

            var expected = new Message()
            {
                User = "Homer",
                Text = "Boring!",
                ReceivingTime = new DateTime(1996, 3, 14, 10, 14, 23)
            };

            //act
            var user = storage.GetMessages(messageFilteringParams).First();
            //assert
            Assert.IsTrue(expected.User == user.User);
            Assert.IsTrue(expected.Text == user.Text);
            Assert.IsTrue(expected.ReceivingTime == user.ReceivingTime);
        }
        #endregion

        #region AddRemove
        [TestMethod]
        public void Filtering_Add_Added()
        {
            //arrange
            SMSProvider smsProvider = new SMSProvider();
            Storage storage = new Storage(smsProvider);
            MessageFilteringParams messageFilteringParams = new MessageFilteringParams();
            messageFilteringParams.SelectedUser = "Vasia";
            messageFilteringParams.UsersSortOptions = SortOptions.AND;
            messageFilteringParams.MessageText = "Hi";
            messageFilteringParams.MessageTextSortOptions = SortOptions.AND;
            messageFilteringParams.FromDate = DateTime.MinValue;
            messageFilteringParams.BeforeDate = DateTime.MaxValue;
            messageFilteringParams.FormattingOptions = "None";
            
            var expected = new Message()
            {
                User = "Vasia",
                Text = "Hi",
                ReceivingTime = new DateTime(2021, 3, 14, 10, 14, 23)
            };

            //act
            smsProvider.RaiseSMSReceivedEvent(expected);
            var user = storage.GetMessages(messageFilteringParams).First();
            //assert
            Assert.IsTrue(expected.User == user.User);
            Assert.IsTrue(expected.Text == user.Text);
            Assert.IsTrue(expected.ReceivingTime == user.ReceivingTime);
        }
        [TestMethod]
        public void Filtering_Remove_Removed()
        {
            //arrange
            SMSProvider smsProvider = new SMSProvider();
            Storage storage = new Storage(smsProvider);
            MessageFilteringParams messageFilteringParams = new MessageFilteringParams();
            messageFilteringParams.SelectedUser = "Marge";
            messageFilteringParams.UsersSortOptions = SortOptions.AND;
            messageFilteringParams.MessageText = "You have no idea what";
            messageFilteringParams.MessageTextSortOptions = SortOptions.AND;
            messageFilteringParams.FromDate = DateTime.MinValue;
            messageFilteringParams.BeforeDate = DateTime.MaxValue;
            messageFilteringParams.FormattingOptions = "None";

            var expected = new Message()
            {
                User = "Marge",
                Text = "You have no idea what it's like, being married to you.",
                ReceivingTime = new DateTime(1995, 3, 14, 10, 14, 23)
            };
            //act
            storage.Remove(expected);
            var user = storage.GetMessages(messageFilteringParams);
            //assert
            Assert.IsTrue(user.Count()==0);
        }
        #endregion
    }
}
