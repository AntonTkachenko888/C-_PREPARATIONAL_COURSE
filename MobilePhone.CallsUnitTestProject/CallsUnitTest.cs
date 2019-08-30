using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhone.Base.Components.Calls;
using MobilePhone.Base.MobilePhones;

namespace MobilePhone.CallsUnitTestProject
{
    [TestClass]
    public class CallsUnitTest
    {
        #region Sorting
        [TestMethod]
        public void Callhistory_AddSorting()
        {
            //arrange
            MobilePhoneBase vNokia1100 = new Nokia1100(777);
            //act
            var calls = vNokia1100.CallsHistory.GetAllCalls();
            vNokia1100.CallsHistory.Add(new PhoneCall(99, CallDirection.incoming,
                                        new DateTime(2055, 3, 14, 10, 14, 23),
                                        new TimeSpan(0, 0, 11), vNokia1100.Contacts));
            var lastCall = vNokia1100.CallsHistory.GetAllCalls().First();
            //assert
            Assert.IsTrue(99 == lastCall.PhoneNamber);
        }
        [TestMethod]
        public void Callhistory_RemoveSorting()
        {
            //arrange
            MobilePhoneBase vNokia1100 = new Nokia1100(777);
            //act
            var lastCallControl = vNokia1100.CallsHistory.GetAllCalls().First();
            vNokia1100.CallsHistory.Remove(lastCallControl);
            var lastCall = vNokia1100.CallsHistory.GetAllCalls().First();
            //assert
            Assert.IsTrue(lastCallControl.StartTime != lastCall.StartTime);
        }
        #endregion
        #region Comparing calls
        [TestMethod]
        public void Callhistory_ComparingCalls_Match()
        {
            //arrange
            MobilePhoneBase vNokia1100 = new Nokia1100(777);
            var c1 = new PhoneCall(1, CallDirection.incoming,
                new DateTime(1997, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 1), vNokia1100.Contacts);
            var c2 = new PhoneCall(1, CallDirection.incoming,
                new DateTime(1997, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 1), vNokia1100.Contacts);
            //act
            var result = CallNumberStartTimeEqualityComparer.Instance.Equals(c1,c2);
            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Callhistory_ComparingCalls_NotMatch()
        {
            //arrange
            MobilePhoneBase vNokia1100 = new Nokia1100(777);
            var c1 = new PhoneCall(1, CallDirection.incoming,
                new DateTime(1997, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 1), vNokia1100.Contacts);
            var c2 = new PhoneCall(2, CallDirection.incoming,
                new DateTime(1998, 3, 14, 10, 14, 23), new TimeSpan(0, 0, 2), vNokia1100.Contacts);
            //act
            var result = CallNumberStartTimeEqualityComparer.Instance.Equals(c1,c2);
            //assert
            Assert.IsFalse(result);
        }
        #endregion
        #region Comparing contacts
        [TestMethod]
        public void Callhistory_ComparingContacts_Match()
        {
            //arrange
            var c1 = new Contact("Homer", "Simson", 1);
            var c2 = new Contact("Homer", "Simson", 1);
            //act
            var result = ContactNameLastNameEqualityComparer.Instance.Equals(c1, c2);
            //assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void Callhistory_ComparingContacts_NotMatch()
        {
            //arrange
            var c1 = new Contact("Homer", "Simson", 1);
            var c2 = new Contact("Mom", "Simson", 4);
            //act
            var result = ContactNameLastNameEqualityComparer.Instance.Equals(c1, c2);
            //assert
            Assert.IsFalse(result);
        }
        #endregion
    }
}
